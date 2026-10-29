namespace Super_Metroid_Launcher
{
    partial class keymapper
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(keymapper));
            this.pictureController = new System.Windows.Forms.PictureBox();
            this.textBoxDpadLeft = new System.Windows.Forms.TextBox();
            this.textBoxDpadRight = new System.Windows.Forms.TextBox();
            this.textBoxDpadUp = new System.Windows.Forms.TextBox();
            this.textBoxDpadDown = new System.Windows.Forms.TextBox();
            this.textBoxSelect = new System.Windows.Forms.TextBox();
            this.textBoxStart = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxL = new System.Windows.Forms.TextBox();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.groupBoxController = new System.Windows.Forms.GroupBox();
            this.buttonAssignAll = new System.Windows.Forms.Button();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.radioButtonController = new System.Windows.Forms.RadioButton();
            this.radioButtonKeyboard = new System.Windows.Forms.RadioButton();
            this.groupBoxCheats = new System.Windows.Forms.GroupBox();
            this.textBoxJump = new System.Windows.Forms.TextBox();
            this.textBoxTurbo = new System.Windows.Forms.TextBox();
            this.textBoxLife = new System.Windows.Forms.TextBox();
            this.labelJump = new System.Windows.Forms.Label();
            this.labelTurbo = new System.Windows.Forms.Label();
            this.labelLife = new System.Windows.Forms.Label();
            this.groupBoxGame = new System.Windows.Forms.GroupBox();
            this.labelVolumeDown = new System.Windows.Forms.Label();
            this.labelVolumeUp = new System.Windows.Forms.Label();
            this.labelDecreaseWindowSize = new System.Windows.Forms.Label();
            this.labelIncreaseWindowSize = new System.Windows.Forms.Label();
            this.checkBoxDim = new System.Windows.Forms.CheckBox();
            this.textBoxPause = new System.Windows.Forms.TextBox();
            this.labelPause = new System.Windows.Forms.Label();
            this.textBoxVolumeDown = new System.Windows.Forms.TextBox();
            this.textBoxVolumeUp = new System.Windows.Forms.TextBox();
            this.textBoxDecreaseWindowSize = new System.Windows.Forms.TextBox();
            this.textBoxIncreaseWindowSize = new System.Windows.Forms.TextBox();
            this.labelReset = new System.Windows.Forms.Label();
            this.textBoxReset = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labelReplayToggle = new System.Windows.Forms.Label();
            this.labelStopReplay = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxToggleReplay = new System.Windows.Forms.TextBox();
            this.textBoxStopReplay = new System.Windows.Forms.TextBox();
            this.groupBoxReplays = new System.Windows.Forms.GroupBox();
            this.labelReplaysNote = new System.Windows.Forms.Label();
            this.groupBoxReplayControls = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxPerformance = new System.Windows.Forms.GroupBox();
            this.labelToggleRenderer = new System.Windows.Forms.Label();
            this.labelToggleFPS = new System.Windows.Forms.Label();
            this.textBoxRenderer = new System.Windows.Forms.TextBox();
            this.textBoxFPS = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureController)).BeginInit();
            this.groupBoxController.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxCheats.SuspendLayout();
            this.groupBoxGame.SuspendLayout();
            this.groupBoxReplays.SuspendLayout();
            this.groupBoxReplayControls.SuspendLayout();
            this.groupBoxPerformance.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureController
            // 
            this.pictureController.Image = ((System.Drawing.Image)(resources.GetObject("pictureController.Image")));
            this.pictureController.Location = new System.Drawing.Point(6, 22);
            this.pictureController.Name = "pictureController";
            this.pictureController.Size = new System.Drawing.Size(686, 307);
            // 用 Zoom 而不是 AutoSize：AutoSize 会把本控件尺寸钉死为图片原始像素（686×307），
            // 与 AutoScaleMode.Font 下被缩放的输入框坐标不同步，高 DPI（150%/200%）时
            // 手柄图与 12 个按键输入框会错位。Zoom 让图片等比缩放到控件尺寸（控件随 DPI 缩放），
            // 两者同倍放大即保持对齐；图片与控件宽高比一致（686:307），不会裁切或留黑边。
            this.pictureController.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureController.TabIndex = 0;
            this.pictureController.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureController, resources.GetString("pictureController.ToolTip"));
            // 
            // textBoxDpadLeft
            // 
            this.textBoxDpadLeft.Location = new System.Drawing.Point(18, 173);
            this.textBoxDpadLeft.Name = "textBoxDpadLeft";
            this.textBoxDpadLeft.ReadOnly = true;
            this.textBoxDpadLeft.Size = new System.Drawing.Size(50, 23);
            this.textBoxDpadLeft.TabIndex = 2;
            // 
            // textBoxDpadRight
            // 
            this.textBoxDpadRight.Location = new System.Drawing.Point(210, 173);
            this.textBoxDpadRight.Name = "textBoxDpadRight";
            this.textBoxDpadRight.ReadOnly = true;
            this.textBoxDpadRight.Size = new System.Drawing.Size(50, 23);
            this.textBoxDpadRight.TabIndex = 3;
            // 
            // textBoxDpadUp
            // 
            this.textBoxDpadUp.Location = new System.Drawing.Point(114, 88);
            this.textBoxDpadUp.Name = "textBoxDpadUp";
            this.textBoxDpadUp.ReadOnly = true;
            this.textBoxDpadUp.Size = new System.Drawing.Size(50, 23);
            this.textBoxDpadUp.TabIndex = 0;
            // 
            // textBoxDpadDown
            // 
            this.textBoxDpadDown.Location = new System.Drawing.Point(114, 256);
            this.textBoxDpadDown.Name = "textBoxDpadDown";
            this.textBoxDpadDown.ReadOnly = true;
            this.textBoxDpadDown.Size = new System.Drawing.Size(50, 23);
            this.textBoxDpadDown.TabIndex = 1;
            // 
            // textBoxSelect
            // 
            this.textBoxSelect.Location = new System.Drawing.Point(289, 208);
            this.textBoxSelect.Name = "textBoxSelect";
            this.textBoxSelect.ReadOnly = true;
            this.textBoxSelect.Size = new System.Drawing.Size(50, 23);
            this.textBoxSelect.TabIndex = 4;
            // 
            // textBoxStart
            // 
            this.textBoxStart.Location = new System.Drawing.Point(358, 208);
            this.textBoxStart.Name = "textBoxStart";
            this.textBoxStart.ReadOnly = true;
            this.textBoxStart.Size = new System.Drawing.Size(50, 23);
            this.textBoxStart.TabIndex = 5;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(465, 173);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.ReadOnly = true;
            this.textBoxY.Size = new System.Drawing.Size(40, 23);
            this.textBoxY.TabIndex = 9;
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(597, 173);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.ReadOnly = true;
            this.textBoxA.Size = new System.Drawing.Size(40, 23);
            this.textBoxA.TabIndex = 6;
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(531, 107);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.ReadOnly = true;
            this.textBoxX.Size = new System.Drawing.Size(40, 23);
            this.textBoxX.TabIndex = 8;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(531, 240);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.ReadOnly = true;
            this.textBoxB.Size = new System.Drawing.Size(40, 23);
            this.textBoxB.TabIndex = 7;
            // 
            // textBoxL
            // 
            this.textBoxL.Location = new System.Drawing.Point(182, 37);
            this.textBoxL.Name = "textBoxL";
            this.textBoxL.ReadOnly = true;
            this.textBoxL.Size = new System.Drawing.Size(50, 23);
            this.textBoxL.TabIndex = 10;
            // 
            // textBoxR
            // 
            this.textBoxR.Location = new System.Drawing.Point(466, 37);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.ReadOnly = true;
            this.textBoxR.Size = new System.Drawing.Size(50, 23);
            this.textBoxR.TabIndex = 11;
            // 
            // groupBoxController
            // 
            this.groupBoxController.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxController.Controls.Add(this.buttonAssignAll);
            this.groupBoxController.Controls.Add(this.groupBoxInput);
            this.groupBoxController.Controls.Add(this.textBoxDpadDown);
            this.groupBoxController.Controls.Add(this.textBoxDpadLeft);
            this.groupBoxController.Controls.Add(this.textBoxDpadUp);
            this.groupBoxController.Controls.Add(this.textBoxDpadRight);
            this.groupBoxController.Controls.Add(this.textBoxA);
            this.groupBoxController.Controls.Add(this.textBoxSelect);
            this.groupBoxController.Controls.Add(this.textBoxB);
            this.groupBoxController.Controls.Add(this.textBoxStart);
            this.groupBoxController.Controls.Add(this.textBoxR);
            this.groupBoxController.Controls.Add(this.textBoxY);
            this.groupBoxController.Controls.Add(this.textBoxL);
            this.groupBoxController.Controls.Add(this.textBoxX);
            this.groupBoxController.Controls.Add(this.pictureController);
            this.groupBoxController.Location = new System.Drawing.Point(12, 12);
            this.groupBoxController.Name = "groupBoxController";
            this.groupBoxController.Size = new System.Drawing.Size(698, 337);
            this.groupBoxController.TabIndex = 3;
            this.groupBoxController.TabStop = false;
            this.groupBoxController.Text = "控制器/手柄 按键映射";
            this.toolTip1.SetToolTip(this.groupBoxController, resources.GetString("groupBoxController.ToolTip"));
            // 
            // buttonAssignAll
            // 
            this.buttonAssignAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAssignAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAssignAll.Location = new System.Drawing.Point(282, 99);
            this.buttonAssignAll.Name = "buttonAssignAll";
            this.buttonAssignAll.Size = new System.Drawing.Size(134, 25);
            this.buttonAssignAll.TabIndex = 9;
            this.buttonAssignAll.Text = "依次分配全部按键";
            this.toolTip1.SetToolTip(this.buttonAssignAll, "依次设置每一项（按 ESC 跳到下一项）");
            this.buttonAssignAll.UseVisualStyleBackColor = true;
            this.buttonAssignAll.Click += new System.EventHandler(this.ButtonAssignAll_Click);
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.radioButtonController);
            this.groupBoxInput.Controls.Add(this.radioButtonKeyboard);
            this.groupBoxInput.Location = new System.Drawing.Point(306, 130);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(87, 72);
            this.groupBoxInput.TabIndex = 12;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "输入类型";
            this.toolTip1.SetToolTip(this.groupBoxInput, "选择游戏使用的输入设备类型，即用键盘或手柄控制游戏");
            // 
            // radioButtonController
            // 
            this.radioButtonController.AutoSize = true;
            this.radioButtonController.Enabled = false;
            this.radioButtonController.Location = new System.Drawing.Point(6, 47);
            this.radioButtonController.Name = "radioButtonController";
            this.radioButtonController.Size = new System.Drawing.Size(78, 19);
            this.radioButtonController.TabIndex = 1;
            this.radioButtonController.Text = "控制器/手柄";
            this.radioButtonController.UseVisualStyleBackColor = true;
            // 
            // radioButtonKeyboard
            // 
            this.radioButtonKeyboard.AutoSize = true;
            this.radioButtonKeyboard.Checked = true;
            this.radioButtonKeyboard.Location = new System.Drawing.Point(6, 22);
            this.radioButtonKeyboard.Name = "radioButtonKeyboard";
            this.radioButtonKeyboard.Size = new System.Drawing.Size(75, 19);
            this.radioButtonKeyboard.TabIndex = 0;
            this.radioButtonKeyboard.TabStop = true;
            this.radioButtonKeyboard.Text = "键盘";
            this.radioButtonKeyboard.UseVisualStyleBackColor = true;
            this.radioButtonKeyboard.CheckedChanged += new System.EventHandler(this.InputType_CheckedChanged);
            // 
            // groupBoxCheats
            // 
            this.groupBoxCheats.Controls.Add(this.textBoxJump);
            this.groupBoxCheats.Controls.Add(this.textBoxTurbo);
            this.groupBoxCheats.Controls.Add(this.textBoxLife);
            this.groupBoxCheats.Controls.Add(this.labelJump);
            this.groupBoxCheats.Controls.Add(this.labelTurbo);
            this.groupBoxCheats.Controls.Add(this.labelLife);
            this.groupBoxCheats.Location = new System.Drawing.Point(716, 252);
            this.groupBoxCheats.Name = "groupBoxCheats";
            this.groupBoxCheats.Size = new System.Drawing.Size(210, 111);
            this.groupBoxCheats.TabIndex = 6;
            this.groupBoxCheats.TabStop = false;
            this.groupBoxCheats.Text = "作弊";
            // 
            // textBoxJump
            // 
            this.textBoxJump.Location = new System.Drawing.Point(139, 51);
            this.textBoxJump.Name = "textBoxJump";
            this.textBoxJump.ReadOnly = true;
            this.textBoxJump.Size = new System.Drawing.Size(63, 23);
            this.textBoxJump.TabIndex = 1;
            this.textBoxJump.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTurbo
            // 
            this.textBoxTurbo.Location = new System.Drawing.Point(139, 80);
            this.textBoxTurbo.Name = "textBoxTurbo";
            this.textBoxTurbo.ReadOnly = true;
            this.textBoxTurbo.Size = new System.Drawing.Size(63, 23);
            this.textBoxTurbo.TabIndex = 3;
            this.textBoxTurbo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxLife
            // 
            this.textBoxLife.Location = new System.Drawing.Point(139, 22);
            this.textBoxLife.Name = "textBoxLife";
            this.textBoxLife.ReadOnly = true;
            this.textBoxLife.Size = new System.Drawing.Size(63, 23);
            this.textBoxLife.TabIndex = 0;
            this.textBoxLife.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelJump
            // 
            this.labelJump.AutoSize = false;
            this.labelJump.Location = new System.Drawing.Point(92, 54);
            this.labelJump.Name = "labelJump";
            this.labelJump.Size = new System.Drawing.Size(39, 15);
            this.labelJump.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelJump.TabIndex = 5;
            this.labelJump.Text = "跳跃:";
            this.toolTip1.SetToolTip(this.labelJump, "If you have no keys, give yourself a single key.");
            // 
            // labelTurbo
            // 
            this.labelTurbo.AutoSize = false;
            this.labelTurbo.Location = new System.Drawing.Point(92, 83);
            this.labelTurbo.Name = "labelTurbo";
            this.labelTurbo.Size = new System.Drawing.Size(39, 15);
            this.labelTurbo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelTurbo.TabIndex = 5;
            this.labelTurbo.Text = "加速游戏:";
            this.toolTip1.SetToolTip(this.labelTurbo, "游戏以极快的速度运行。");
            // 
            // labelLife
            // 
            this.labelLife.AutoSize = false;
            this.labelLife.Location = new System.Drawing.Point(46, 25);
            this.labelLife.Name = "labelLife";
            this.labelLife.Size = new System.Drawing.Size(85, 15);
            this.labelLife.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelLife.TabIndex = 5;
            this.labelLife.Text = "回满血:";
            this.toolTip1.SetToolTip(this.labelLife, "恢复全部血量。按住 Shift 再按该键会同时补满其他资源。");
            // 
            // groupBoxGame
            // 
            this.groupBoxGame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxGame.Controls.Add(this.labelVolumeDown);
            this.groupBoxGame.Controls.Add(this.labelVolumeUp);
            this.groupBoxGame.Controls.Add(this.labelDecreaseWindowSize);
            this.groupBoxGame.Controls.Add(this.labelIncreaseWindowSize);
            this.groupBoxGame.Controls.Add(this.checkBoxDim);
            this.groupBoxGame.Controls.Add(this.textBoxPause);
            this.groupBoxGame.Controls.Add(this.labelPause);
            this.groupBoxGame.Controls.Add(this.textBoxVolumeDown);
            this.groupBoxGame.Controls.Add(this.textBoxVolumeUp);
            this.groupBoxGame.Controls.Add(this.textBoxDecreaseWindowSize);
            this.groupBoxGame.Controls.Add(this.textBoxIncreaseWindowSize);
            this.groupBoxGame.Controls.Add(this.labelReset);
            this.groupBoxGame.Controls.Add(this.textBoxReset);
            this.groupBoxGame.Location = new System.Drawing.Point(716, 20);
            this.groupBoxGame.Name = "groupBoxGame";
            this.groupBoxGame.Size = new System.Drawing.Size(210, 223);
            this.groupBoxGame.TabIndex = 4;
            this.groupBoxGame.TabStop = false;
            this.groupBoxGame.Text = "游戏功能";
            // 
            // labelVolumeDown
            // 
            this.labelVolumeDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVolumeDown.AutoSize = false;
            this.labelVolumeDown.Location = new System.Drawing.Point(47, 193);
            this.labelVolumeDown.Name = "labelVolumeDown";
            this.labelVolumeDown.Size = new System.Drawing.Size(82, 15);
            this.labelVolumeDown.TabIndex = 7;
            this.labelVolumeDown.Text = "减小游戏音量:";
            this.labelVolumeDown.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.labelVolumeDown, "降低游戏音量");
            // 
            // labelVolumeUp
            // 
            this.labelVolumeUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVolumeUp.AutoSize = false;
            this.labelVolumeUp.Location = new System.Drawing.Point(63, 164);
            this.labelVolumeUp.Name = "labelVolumeUp";
            this.labelVolumeUp.Size = new System.Drawing.Size(66, 15);
            this.labelVolumeUp.TabIndex = 7;
            this.labelVolumeUp.Text = "增大游戏音量:";
            this.labelVolumeUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.labelVolumeUp, "提高游戏音量");
            // 
            // labelDecreaseWindowSize
            // 
            this.labelDecreaseWindowSize.AutoSize = false;
            this.labelDecreaseWindowSize.Location = new System.Drawing.Point(4, 135);
            this.labelDecreaseWindowSize.Name = "labelDecreaseWindowSize";
            this.labelDecreaseWindowSize.Size = new System.Drawing.Size(125, 15);
            this.labelDecreaseWindowSize.TabIndex = 7;
            this.labelDecreaseWindowSize.Text = "缩小游戏窗口:";
            this.labelDecreaseWindowSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.labelDecreaseWindowSize, "窗口缩放倍数减 1");
            // 
            // labelIncreaseWindowSize
            // 
            this.labelIncreaseWindowSize.AutoSize = false;
            this.labelIncreaseWindowSize.Location = new System.Drawing.Point(8, 106);
            this.labelIncreaseWindowSize.Name = "labelIncreaseWindowSize";
            this.labelIncreaseWindowSize.Size = new System.Drawing.Size(121, 15);
            this.labelIncreaseWindowSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelIncreaseWindowSize.TabIndex = 7;
            this.labelIncreaseWindowSize.Text = "放大游戏窗口:";
            this.toolTip1.SetToolTip(this.labelIncreaseWindowSize, "窗口缩放倍数加 1");
            // 
            // checkBoxDim
            // 
            this.checkBoxDim.AutoSize = true;
            this.checkBoxDim.Location = new System.Drawing.Point(79, 78);
            this.checkBoxDim.Name = "checkBoxDim";
            this.checkBoxDim.Size = new System.Drawing.Size(123, 19);
            this.checkBoxDim.TabIndex = 6;
            this.checkBoxDim.Text = "暂停时画面变暗";
            this.toolTip1.SetToolTip(this.checkBoxDim, "启用后，用专用暂停键暂停时画面会变暗");
            this.checkBoxDim.UseVisualStyleBackColor = true;
            // 
            // textBoxPause
            // 
            this.textBoxPause.Location = new System.Drawing.Point(137, 49);
            this.textBoxPause.Name = "textBoxPause";
            this.textBoxPause.ReadOnly = true;
            this.textBoxPause.Size = new System.Drawing.Size(65, 23);
            this.textBoxPause.TabIndex = 1;
            this.textBoxPause.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelPause
            // 
            this.labelPause.AutoSize = false;
            this.labelPause.Location = new System.Drawing.Point(90, 52);
            this.labelPause.Name = "labelPause";
            this.labelPause.Size = new System.Drawing.Size(39, 15);
            this.labelPause.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelPause.TabIndex = 5;
            this.labelPause.Text = "暂停游戏:";
            this.toolTip1.SetToolTip(this.labelPause, "暂停游戏但不打开地图/道具菜单");
            // 
            // textBoxVolumeDown
            // 
            this.textBoxVolumeDown.Location = new System.Drawing.Point(137, 190);
            this.textBoxVolumeDown.Name = "textBoxVolumeDown";
            this.textBoxVolumeDown.ReadOnly = true;
            this.textBoxVolumeDown.Size = new System.Drawing.Size(65, 23);
            this.textBoxVolumeDown.TabIndex = 5;
            this.textBoxVolumeDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxVolumeUp
            // 
            this.textBoxVolumeUp.Location = new System.Drawing.Point(137, 161);
            this.textBoxVolumeUp.Name = "textBoxVolumeUp";
            this.textBoxVolumeUp.ReadOnly = true;
            this.textBoxVolumeUp.Size = new System.Drawing.Size(65, 23);
            this.textBoxVolumeUp.TabIndex = 4;
            this.textBoxVolumeUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxDecreaseWindowSize
            // 
            this.textBoxDecreaseWindowSize.Location = new System.Drawing.Point(137, 132);
            this.textBoxDecreaseWindowSize.Name = "textBoxDecreaseWindowSize";
            this.textBoxDecreaseWindowSize.ReadOnly = true;
            this.textBoxDecreaseWindowSize.Size = new System.Drawing.Size(65, 23);
            this.textBoxDecreaseWindowSize.TabIndex = 3;
            this.textBoxDecreaseWindowSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxIncreaseWindowSize
            // 
            this.textBoxIncreaseWindowSize.Location = new System.Drawing.Point(137, 103);
            this.textBoxIncreaseWindowSize.Name = "textBoxIncreaseWindowSize";
            this.textBoxIncreaseWindowSize.ReadOnly = true;
            this.textBoxIncreaseWindowSize.Size = new System.Drawing.Size(65, 23);
            this.textBoxIncreaseWindowSize.TabIndex = 2;
            this.textBoxIncreaseWindowSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelReset
            // 
            this.labelReset.AutoSize = false;
            this.labelReset.Location = new System.Drawing.Point(93, 23);
            this.labelReset.Name = "labelReset";
            this.labelReset.Size = new System.Drawing.Size(36, 15);
            this.labelReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelReset.TabIndex = 7;
            this.labelReset.Text = "重置游戏:";
            this.toolTip1.SetToolTip(this.labelReset, "重置游戏");
            // 
            // textBoxReset
            // 
            this.textBoxReset.Location = new System.Drawing.Point(137, 20);
            this.textBoxReset.Name = "textBoxReset";
            this.textBoxReset.ReadOnly = true;
            this.textBoxReset.Size = new System.Drawing.Size(65, 23);
            this.textBoxReset.TabIndex = 0;
            this.textBoxReset.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelReplayToggle
            // 
            this.labelReplayToggle.AutoSize = false;
            this.labelReplayToggle.Location = new System.Drawing.Point(15, 26);
            this.labelReplayToggle.Name = "labelReplayToggle";
            this.labelReplayToggle.Size = new System.Drawing.Size(116, 15);
            this.labelReplayToggle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelReplayToggle.TabIndex = 5;
            this.labelReplayToggle.Text = "切换回放速度:";
            this.toolTip1.SetToolTip(this.labelReplayToggle, "在回放的高速与正常速度之间切换。");
            // 
            // labelStopReplay
            // 
            this.labelStopReplay.AutoSize = false;
            this.labelStopReplay.Location = new System.Drawing.Point(61, 55);
            this.labelStopReplay.Name = "labelStopReplay";
            this.labelStopReplay.Size = new System.Drawing.Size(70, 15);
            this.labelStopReplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelStopReplay.TabIndex = 5;
            this.labelStopReplay.Text = "停止回放:";
            this.toolTip1.SetToolTip(this.labelStopReplay, "停止当前正在进行的回放。");
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 394);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(175, 32);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "保存";
            this.toolTip1.SetToolTip(this.buttonSave, "保存全部按键设置并关闭菜单");
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(12, 356);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(175, 32);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "重置";
            this.toolTip1.SetToolTip(this.buttonReset, "重置全部按键相关设置");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(12, 432);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(175, 32);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "取消";
            this.toolTip1.SetToolTip(this.buttonCancel, "不保存任何改动，直接关闭按键绑定工具");
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // textBoxToggleReplay
            // 
            this.textBoxToggleReplay.Location = new System.Drawing.Point(139, 22);
            this.textBoxToggleReplay.Name = "textBoxToggleReplay";
            this.textBoxToggleReplay.ReadOnly = true;
            this.textBoxToggleReplay.Size = new System.Drawing.Size(63, 23);
            this.textBoxToggleReplay.TabIndex = 0;
            this.textBoxToggleReplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxStopReplay
            // 
            this.textBoxStopReplay.Location = new System.Drawing.Point(139, 51);
            this.textBoxStopReplay.Name = "textBoxStopReplay";
            this.textBoxStopReplay.ReadOnly = true;
            this.textBoxStopReplay.Size = new System.Drawing.Size(63, 23);
            this.textBoxStopReplay.TabIndex = 1;
            this.textBoxStopReplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBoxReplays
            // 
            this.groupBoxReplays.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxReplays.Controls.Add(this.textBoxToggleReplay);
            this.groupBoxReplays.Controls.Add(this.labelReplayToggle);
            this.groupBoxReplays.Controls.Add(this.textBoxStopReplay);
            this.groupBoxReplays.Controls.Add(this.labelStopReplay);
            this.groupBoxReplays.Location = new System.Drawing.Point(716, 373);
            this.groupBoxReplays.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.groupBoxReplays.Name = "groupBoxReplays";
            this.groupBoxReplays.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.groupBoxReplays.Size = new System.Drawing.Size(210, 91);
            this.groupBoxReplays.TabIndex = 5;
            this.groupBoxReplays.TabStop = false;
            this.groupBoxReplays.Text = "回放";
            // 
            // labelReplaysNote
            // 
            this.labelReplaysNote.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelReplaysNote.Location = new System.Drawing.Point(6, 34);
            this.labelReplaysNote.Name = "labelReplaysNote";
            this.labelReplaysNote.Size = new System.Drawing.Size(498, 68);
            this.labelReplaysNote.TabIndex = 7;
            this.labelReplaysNote.Text = resources.GetString("labelReplaysNote.Text");
            // 
            // groupBoxReplayControls
            // 
            this.groupBoxReplayControls.Controls.Add(this.labelReplaysNote);
            this.groupBoxReplayControls.Controls.Add(this.label1);
            this.groupBoxReplayControls.Location = new System.Drawing.Point(194, 355);
            this.groupBoxReplayControls.Name = "groupBoxReplayControls";
            this.groupBoxReplayControls.Size = new System.Drawing.Size(510, 109);
            this.groupBoxReplayControls.TabIndex = 7;
            this.groupBoxReplayControls.TabStop = false;
            this.groupBoxReplayControls.Text = "回放控制";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "游戏内置了回放 / 即时存档系统，操作如下：";
            // 
            // groupBoxPerformance
            // 
            this.groupBoxPerformance.Controls.Add(this.labelToggleRenderer);
            this.groupBoxPerformance.Controls.Add(this.labelToggleFPS);
            this.groupBoxPerformance.Controls.Add(this.textBoxRenderer);
            this.groupBoxPerformance.Controls.Add(this.textBoxFPS);
            this.groupBoxPerformance.Location = new System.Drawing.Point(1010, 811);
            this.groupBoxPerformance.Name = "groupBoxPerformance";
            this.groupBoxPerformance.Size = new System.Drawing.Size(332, 49);
            this.groupBoxPerformance.TabIndex = 8;
            this.groupBoxPerformance.TabStop = false;
            this.groupBoxPerformance.Text = "Performance";
            this.groupBoxPerformance.Visible = false;
            // 
            // labelToggleRenderer
            // 
            this.labelToggleRenderer.AutoSize = true;
            this.labelToggleRenderer.Location = new System.Drawing.Point(11, 21);
            this.labelToggleRenderer.Name = "labelToggleRenderer";
            this.labelToggleRenderer.Size = new System.Drawing.Size(95, 15);
            this.labelToggleRenderer.TabIndex = 9;
            this.labelToggleRenderer.Text = "Toggle Renderer:";
            // 
            // labelToggleFPS
            // 
            this.labelToggleFPS.AutoSize = true;
            this.labelToggleFPS.Location = new System.Drawing.Point(183, 21);
            this.labelToggleFPS.Name = "labelToggleFPS";
            this.labelToggleFPS.Size = new System.Drawing.Size(64, 15);
            this.labelToggleFPS.TabIndex = 10;
            this.labelToggleFPS.Text = "ToggleFPS:";
            // 
            // textBoxRenderer
            // 
            this.textBoxRenderer.Location = new System.Drawing.Point(112, 17);
            this.textBoxRenderer.Name = "textBoxRenderer";
            this.textBoxRenderer.ReadOnly = true;
            this.textBoxRenderer.Size = new System.Drawing.Size(65, 23);
            this.textBoxRenderer.TabIndex = 0;
            this.textBoxRenderer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxFPS
            // 
            this.textBoxFPS.Location = new System.Drawing.Point(253, 17);
            this.textBoxFPS.Name = "textBoxFPS";
            this.textBoxFPS.ReadOnly = true;
            this.textBoxFPS.Size = new System.Drawing.Size(65, 23);
            this.textBoxFPS.TabIndex = 0;
            this.textBoxFPS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // keymapper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1403, 908);
            this.Controls.Add(this.groupBoxPerformance);
            this.Controls.Add(this.groupBoxReplayControls);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxReplays);
            this.Controls.Add(this.groupBoxGame);
            this.Controls.Add(this.groupBoxCheats);
            this.Controls.Add(this.groupBoxController);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "keymapper";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "按键绑定工具";
            ((System.ComponentModel.ISupportInitialize)(this.pictureController)).EndInit();
            this.groupBoxController.ResumeLayout(false);
            this.groupBoxController.PerformLayout();
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBoxCheats.ResumeLayout(false);
            this.groupBoxCheats.PerformLayout();
            this.groupBoxGame.ResumeLayout(false);
            this.groupBoxGame.PerformLayout();
            this.groupBoxReplays.ResumeLayout(false);
            this.groupBoxReplays.PerformLayout();
            this.groupBoxReplayControls.ResumeLayout(false);
            this.groupBoxReplayControls.PerformLayout();
            this.groupBoxPerformance.ResumeLayout(false);
            this.groupBoxPerformance.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureController;
        private TextBox textBoxDpadLeft;
        private TextBox textBoxDpadRight;
        private TextBox textBoxDpadUp;
        private TextBox textBoxDpadDown;
        private TextBox textBoxSelect;
        private TextBox textBoxStart;
        private TextBox textBoxY;
        private TextBox textBoxA;
        private TextBox textBoxX;
        private TextBox textBoxB;
        private TextBox textBoxL;
        private TextBox textBoxR;
        private GroupBox groupBoxController;
        private GroupBox groupBoxCheats;
        private TextBox textBoxJump;
        private ToolTip toolTip1;
        private TextBox textBoxTurbo;
        private TextBox textBoxLife;
        private Label labelJump;
        private Label labelTurbo;
        private Label labelLife;
        private GroupBox groupBoxMisc;
        private TextBox textBoxPause;
        private Label labelPause;
        private TextBox textBoxReset;
        private TextBox textBoxToggleReplay;
        private Label labelReset;
        private Label labelReplayToggle;
        private GroupBox groupBoxGame;
        private Label labelStopReplay;
        private TextBox textBoxStopReplay;
        private GroupBox groupBoxReplays;
        private Label labelVolumeDown;
        private Label labelVolumeUp;
        private Label labelDecreaseWindowSize;
        private Label labelIncreaseWindowSize;
        private CheckBox checkBoxDim;
        private TextBox textBoxVolumeDown;
        private TextBox textBoxVolumeUp;
        private TextBox textBoxDecreaseWindowSize;
        private TextBox textBoxIncreaseWindowSize;
        private Label labelReplaysNote;
        private Button buttonSave;
        private Button buttonReset;
        private Button buttonCancel;
        private GroupBox groupBoxReplayControls;
        private Label label1;
        private GroupBox groupBoxInput;
        private RadioButton radioButtonController;
        private RadioButton radioButtonKeyboard;
        private GroupBox groupBoxPerformance;
        private Label labelToggleRenderer;
        private Label labelToggleFPS;
        private TextBox textBoxRenderer;
        private TextBox textBoxFPS;
        private ContextMenuStrip contextMenuStrip1;
        private Button buttonAssignAll;
    }
}