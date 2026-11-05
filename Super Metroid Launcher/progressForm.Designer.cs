using System.Net;
using System.Text;

using LibGit2Sharp;
using System.Net.NetworkInformation;
using XSystem.Security.Cryptography;
using System.IO.Compression;

namespace Super_Metroid_Launcher
{
    partial class progressForm : Form
    {
        private volatile int progress = 0;
        private volatile int max = 999999;

        public progressForm(string title, string message)
        {
            InitializeComponent();

            this.Text = title;
            this.updateLabel.Text = message;

            switch (title)
            {
                case "Repository Download":
                    this.Shown += new System.EventHandler(this.cloneRepo);
                    break;
                case "Copying ROM File":
                    this.Shown += new System.EventHandler(this.copyROM);
                    break;
                case "Downloading TCC":
                    this.Shown += new System.EventHandler(this.downloadTCC);
                    break;
                case "Downloading SDL2":
                    this.Shown += new System.EventHandler(this.downloadSDL2);
                    break;
                /*case "Downloading Python":
                    this.Shown += new System.EventHandler(this.downloadPython);
                    break;*/
                case "Downloading pip":
                    this.Shown += new System.EventHandler(this.downloadPip);
                    break;
            }
        }

        private void copyROM(object sender, EventArgs e)
        {
            this.Refresh();

            if (File.Exists(Path.Combine(Program.repoDir, "sm.smc")))
            {
                this.Close();
                return;
            }

            if (File.Exists(Path.Combine(Program.currentDirectory, "sm.smc")))
            {
                File.Move(Path.Combine(Program.currentDirectory, "sm.smc"), Path.Combine(Program.repoDir, "sm.smc"));
                this.Close();
                return;
            }

            Boolean exit = false;
            var result = new OpenFileDialog();
            result.Filter = "Super Metroid ROM(*.smc;*.sfc)|*.smc;*.sfc";
            while (!exit)
            {
                if (result.ShowDialog() == DialogResult.OK)
                {
                    if (checkHash(result.FileName))
                    {
                        File.Copy(result.FileName, Path.Combine(Program.repoDir, "sm.smc"));
                        exit = true;
                    }
                    else
                    {
                        var answer = MessageBox.Show("ROM hash is not valid.\n\nWould you like to select another?", "Invalid ROM Hash", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        if (answer == DialogResult.No) exit = true;
                    }
                }
                else exit = true;
            }

            this.Close();
        }

        private void cloneRepo(object sender, EventArgs e)
        {
            this.Refresh();

            if (!IsConnectedToInternet())
            {
                MessageBox.Show("Unable to connect to the internet.\n\nPlease ensure you have a stable internet connection before updating your repository.", "No Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
                return;
            }

            var repoDir = Path.Combine(Program.currentDirectory, "sm");

            try
            {
                using (var repo = new Repository(repoDir))
                {
                    var trackedBranch = repo.Head.TrackedBranch;

                    Commit originHeadCommit = repo.ObjectDatabase.FindMergeBase(repo.Branches[trackedBranch.FriendlyName].Tip, repo.Head.Tip);
                    repo.Reset(ResetMode.Hard, originHeadCommit,
                        new CheckoutOptions
                        {
                            OnCheckoutProgress = (clonePath, completed, total) => CheckoutProgress(clonePath, completed, total)
                        });
                }
            }
            catch
            {
                Task.Run(() =>
                {
                    // 改为中文版仓库：汉化工程 sm-zh-cn（snesrev/sm 的汉化 fork）
                    Repository.Clone("https://github.com/Ghost-J-R/sm-zh-cn.git", repoDir,
                        new CloneOptions
                        {
                            OnCheckoutProgress = (clonePath, completed, total) => CheckoutProgress(clonePath, completed, total)
                        });
                });
            }

            while (!Directory.Exists(repoDir))
            {
                Application.DoEvents();
            }

            do
            {
                progBar.Value = progress;
                progBar.Maximum = max;
            } while (progress < max);

            this.Close();
        }

        public void CheckoutProgress(string path, int completed, int total)
        {
            max = total;
            progress = completed;
        }

        private async void downloadTCC(object sender, EventArgs e)
        {
            this.Refresh();

            IProgress<int> progressReporter = new Progress<int>(percentage =>
            {
                progBar.Value = Math.Clamp(percentage, 0, 100);
            });

            var directory = Path.Combine(
                Program.third_partyDir,
                "tcc");

            var filePath = Path.Combine(
                directory,
                "TCC.zip");

            try
            {
                await DownloadFileAsync(
                    new Uri("https://github.com/FitzRoyX/tinycc/releases/download/tcc_20221020/tcc_20221020.zip"),
                    filePath,
                    progressReporter
                );

                updateLabel.Text = $"Unzipping...";

                try
                {
                    await Task.Run(() =>
                    {
                        Directory.CreateDirectory(directory);

                        ZipFile.ExtractToDirectory(
                            filePath,
                            Program.third_partyDir,
                            overwriteFiles: true);
                    });
                }
                finally
                {
                    if (File.Exists(filePath))
                    {
                        File.Delete(filePath);
                    }
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"The download failed:\n\n{ex.Message}",
                    "Download Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                this.Close();
            }
        }

        private async void downloadSDL2(object sender, EventArgs e)
        {
            this.Refresh();

            IProgress<int> progressReporter = new Progress<int>(percentage =>
            {
                progBar.Value = Math.Clamp(percentage, 0, 100);
            });

            var directory = Path.Combine(
                Program.third_partyDir,
                "SDL2-2.24.1");

            var filePath = Path.Combine(
                directory,
                "SDL2.zip");

            try
            {
                await DownloadFileAsync(
                    new Uri("https://github.com/libsdl-org/SDL/releases/download/release-2.24.1/SDL2-devel-2.24.1-VC.zip"),
                    filePath,
                    progressReporter
                );

                updateLabel.Text = $"Unzipping...";

                try
                {
                    await Task.Run(() =>
                    {
                        Directory.CreateDirectory(directory);

                        ZipFile.ExtractToDirectory(
                            filePath,
                            Program.third_partyDir,
                            overwriteFiles: true);
                    });
                }
                finally
                {
                    if (File.Exists(filePath))
                    {
                        File.Delete(filePath);
                    }
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"The download failed:\n\n{ex.Message}",
                    "Download Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                this.Close();
            }
        }

        private async void downloadPython(object sender, EventArgs e)
        {
            this.Refresh();

            IProgress<int> progressReporter = new Progress<int>(percentage =>
            {
                progBar.Value = Math.Clamp(percentage, 0, 100);
            });

            var directory = Path.Combine(
                Program.repoDir,
                "assets");

            var filePath = Path.Combine(
                directory,
                "Python.zip");

            try
            {
                await DownloadFileAsync(
                    new Uri("https://www.python.org/ftp/python/3.11.1/python-3.11.1-embed-amd64.zip"),
                    filePath,
                    progressReporter
                );

                updateLabel.Text = $"Unzipping...";

                try
                {
                    await Task.Run(() =>
                    {
                        Directory.CreateDirectory(directory);

                        ZipFile.ExtractToDirectory(
                            filePath,
                            directory,
                            overwriteFiles: true);
                    });
                }
                finally
                {
                    if (File.Exists(filePath))
                    {
                        File.Delete(filePath);
                    }
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"The download failed:\n\n{ex.Message}",
                    "Download Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                this.Close();
            }
        }

        private static readonly HttpClient httpClient = new()
        {
            Timeout = TimeSpan.FromMinutes(10)
        };

        private async Task DownloadFileAsync(
            Uri uri,
            string destination,
            IProgress<int> progressReporter = null)
        {
            var directory = Path.GetDirectoryName(destination);

            if (!string.IsNullOrEmpty(directory))
            {
                Directory.CreateDirectory(directory);
            }

            var temporaryDestination = destination + ".download";

            try
            {
                using HttpResponseMessage response = await httpClient.GetAsync(
                    uri,
                    HttpCompletionOption.ResponseHeadersRead);

                response.EnsureSuccessStatusCode();

                var contentLength = response.Content.Headers.ContentLength;

                await using Stream source = await response.Content.ReadAsStreamAsync();

                await using FileStream target = new(
                    temporaryDestination,
                    FileMode.Create,
                    FileAccess.Write,
                    FileShare.None,
                    bufferSize: 81920,
                    useAsync: true);

                var buffer = new byte[81920];
                long totalBytesRead = 0;
                int bytesRead;

                while ((bytesRead = await source.ReadAsync(buffer)) > 0)
                {
                    await target.WriteAsync(buffer.AsMemory(0, bytesRead));

                    totalBytesRead += bytesRead;

                    if (contentLength is > 0)
                    {
                        int percentage = (int)(totalBytesRead * 100 / contentLength.Value);
                        progressReporter?.Report(percentage);
                    }
                }

                progressReporter?.Report(100);
            }
            catch
            {
                if (File.Exists(temporaryDestination))
                {
                    File.Delete(temporaryDestination);
                }

                throw;
            }

            if (File.Exists(destination))
            {
                File.Delete(destination);
            }

            File.Move(temporaryDestination, destination);
        }

        private async void downloadPip(object sender, EventArgs e)
        {
            this.Refresh();

            var filename = "get-pip.py";
            Uri uri = new Uri("https://bootstrap.pypa.io/get-pip.py");

            var directory = Path.Combine(Program.repoDir, "assets");
            var destination = Path.Combine(Program.repoDir, "assets", filename);

            if (File.Exists(destination)) File.Delete(destination);

            progBar.Minimum = 0;
            progBar.Maximum = 100;
            progBar.Value = 0;

            IProgress<int> progressReporter = new Progress<int>(percentage =>
            {
                progBar.Value = Math.Clamp(percentage, 0, 100);
            });

            try
            {
                await DownloadFileAsync(uri, destination, progressReporter);
                this.Close();
            }
            catch (HttpRequestException)
            {
                MessageBox.Show(
                    "Unable to download the file. Please ensure you have a stable internet connection.",
                    "Download Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"The download failed:\n\n{ex.Message}",
                    "Download Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                this.Close();
            }
        }

        public static bool IsConnectedToInternet()
        {
            Ping p = new Ping();
            try
            {
                PingReply reply = p.Send("github.com", 10000);
                if (reply.Status == IPStatus.Success)
                    return true;
            }
            catch { }
            try
            {
                PingReply reply = p.Send("python.org", 10000);
                if (reply.Status == IPStatus.Success)
                    return true;
            }
            catch { }
            try
            {
                PingReply reply = p.Send("google.com", 10000);
                if (reply.Status == IPStatus.Success)
                    return true;
            }
            catch { }

            return false;
        }

        private Boolean checkHash(string file)
        {
            using (SHA256Managed sha256Hasher = new SHA256Managed())
            using (FileStream stream = new FileStream(file, FileMode.Open))
            using (BufferedStream buffer = new BufferedStream(stream))
            {
                byte[] hash = sha256Hasher.ComputeHash(buffer);
                StringBuilder hashString = new StringBuilder(2 * hash.Length);
                foreach (byte b in hash)
                {
                    hashString.AppendFormat("{0:x2}", b);
                }

                // 简体中文汉化版 ROM v1.00（4 MB）的 SHA-256；原版 ROM 为 12B77C4B...CA72
                if (hashString.ToString().ToUpper() == "7B29DAB77D9856C5218B46299E6AC60C896B381107B995EEC06AC7C2AAD3CEFD") return true;
            }
            return false;
        }

        private ProgressBar progBar;
        private Label updateLabel;
    }
}