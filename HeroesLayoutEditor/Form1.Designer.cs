namespace HeroesLayoutEditor
{
    partial class Form1
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
            this.ListBoxObjects = new System.Windows.Forms.ListBox();
            this.ButtonFindNextLink = new System.Windows.Forms.Button();
            this.ComboBoxList = new System.Windows.Forms.ComboBox();
            this.ComboBoxObjectPicker = new System.Windows.Forms.ComboBox();
            this.PropertyGridMisc = new System.Windows.Forms.PropertyGrid();
            this.RichTextBoxProperties = new System.Windows.Forms.RichTextBox();
            this.GroupBoxGameStuff = new System.Windows.Forms.GroupBox();
            this.ButtonTeleport = new System.Windows.Forms.Button();
            this.GroupBoxGetRot = new System.Windows.Forms.GroupBox();
            this.ButtonPowRot = new System.Windows.Forms.Button();
            this.ButtonFlyRot = new System.Windows.Forms.Button();
            this.ButtonSpeedRot = new System.Windows.Forms.Button();
            this.GroupBoxGetPos = new System.Windows.Forms.GroupBox();
            this.ButtonGetPow = new System.Windows.Forms.Button();
            this.ButtonGetFly = new System.Windows.Forms.Button();
            this.ButtonGetSpeed = new System.Windows.Forms.Button();
            this.LabelRend = new System.Windows.Forms.Label();
            this.NumericObjRend = new System.Windows.Forms.NumericUpDown();
            this.LabelLinkId = new System.Windows.Forms.Label();
            this.NumericObjLink = new System.Windows.Forms.NumericUpDown();
            this.LabelType = new System.Windows.Forms.Label();
            this.LabelList = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.NumericRotZ = new System.Windows.Forms.NumericUpDown();
            this.NumericRotY = new System.Windows.Forms.NumericUpDown();
            this.NumericRotX = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.NumericPosZ = new System.Windows.Forms.NumericUpDown();
            this.NumericPosY = new System.Windows.Forms.NumericUpDown();
            this.NumericPosX = new System.Windows.Forms.NumericUpDown();
            this.ButtonRemove = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LabelFileLoaded = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TextBoxNumOfObjects = new System.Windows.Forms.ToolStripStatusLabel();
            this.checkBoxMiscSettings = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupBoxGameStuff.SuspendLayout();
            this.GroupBoxGetRot.SuspendLayout();
            this.GroupBoxGetPos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericObjRend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericObjLink)).BeginInit();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericRotZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericRotY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericRotX)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericPosZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericPosY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericPosX)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxObjects
            // 
            this.ListBoxObjects.FormattingEnabled = true;
            this.ListBoxObjects.Location = new System.Drawing.Point(12, 27);
            this.ListBoxObjects.Name = "ListBoxObjects";
            this.ListBoxObjects.Size = new System.Drawing.Size(175, 329);
            this.ListBoxObjects.TabIndex = 3;
            this.ListBoxObjects.SelectedIndexChanged += new System.EventHandler(this.ListBoxObjects_SelectedIndexChanged);
            // 
            // ButtonFindNextLink
            // 
            this.ButtonFindNextLink.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonFindNextLink.Location = new System.Drawing.Point(249, 168);
            this.ButtonFindNextLink.Name = "ButtonFindNextLink";
            this.ButtonFindNextLink.Size = new System.Drawing.Size(42, 18);
            this.ButtonFindNextLink.TabIndex = 53;
            this.ButtonFindNextLink.Text = "Find";
            this.ButtonFindNextLink.UseVisualStyleBackColor = true;
            this.ButtonFindNextLink.Click += new System.EventHandler(this.ButtonFindNextLink_Click);
            // 
            // ComboBoxList
            // 
            this.ComboBoxList.FormattingEnabled = true;
            this.ComboBoxList.Location = new System.Drawing.Point(199, 41);
            this.ComboBoxList.Name = "ComboBoxList";
            this.ComboBoxList.Size = new System.Drawing.Size(119, 21);
            this.ComboBoxList.TabIndex = 44;
            this.ComboBoxList.SelectedIndexChanged += new System.EventHandler(this.ComboBoxList_SelectedIndexChanged);
            // 
            // ComboBoxObjectPicker
            // 
            this.ComboBoxObjectPicker.FormattingEnabled = true;
            this.ComboBoxObjectPicker.Location = new System.Drawing.Point(324, 42);
            this.ComboBoxObjectPicker.Name = "ComboBoxObjectPicker";
            this.ComboBoxObjectPicker.Size = new System.Drawing.Size(156, 21);
            this.ComboBoxObjectPicker.TabIndex = 45;
            this.ComboBoxObjectPicker.SelectedIndexChanged += new System.EventHandler(this.ComboBoxObjectPicker_SelectedIndexChanged);
            // 
            // PropertyGridMisc
            // 
            this.PropertyGridMisc.HelpVisible = false;
            this.PropertyGridMisc.LineColor = System.Drawing.SystemColors.ControlDark;
            this.PropertyGridMisc.Location = new System.Drawing.Point(403, 174);
            this.PropertyGridMisc.Name = "PropertyGridMisc";
            this.PropertyGridMisc.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            this.PropertyGridMisc.Size = new System.Drawing.Size(175, 144);
            this.PropertyGridMisc.TabIndex = 51;
            this.PropertyGridMisc.ToolbarVisible = false;
            // 
            // RichTextBoxProperties
            // 
            this.RichTextBoxProperties.BackColor = System.Drawing.SystemColors.Control;
            this.RichTextBoxProperties.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBoxProperties.Cursor = System.Windows.Forms.Cursors.Default;
            this.RichTextBoxProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichTextBoxProperties.Location = new System.Drawing.Point(404, 324);
            this.RichTextBoxProperties.Name = "RichTextBoxProperties";
            this.RichTextBoxProperties.ReadOnly = true;
            this.RichTextBoxProperties.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.RichTextBoxProperties.Size = new System.Drawing.Size(174, 63);
            this.RichTextBoxProperties.TabIndex = 50;
            this.RichTextBoxProperties.Text = "";
            // 
            // GroupBoxGameStuff
            // 
            this.GroupBoxGameStuff.Controls.Add(this.ButtonTeleport);
            this.GroupBoxGameStuff.Controls.Add(this.GroupBoxGetRot);
            this.GroupBoxGameStuff.Controls.Add(this.GroupBoxGetPos);
            this.GroupBoxGameStuff.Location = new System.Drawing.Point(196, 213);
            this.GroupBoxGameStuff.Name = "GroupBoxGameStuff";
            this.GroupBoxGameStuff.Size = new System.Drawing.Size(201, 169);
            this.GroupBoxGameStuff.TabIndex = 46;
            this.GroupBoxGameStuff.TabStop = false;
            this.GroupBoxGameStuff.Text = "Sonic Heroes Stuff";
            // 
            // ButtonTeleport
            // 
            this.ButtonTeleport.Enabled = false;
            this.ButtonTeleport.Location = new System.Drawing.Point(12, 137);
            this.ButtonTeleport.Name = "ButtonTeleport";
            this.ButtonTeleport.Size = new System.Drawing.Size(168, 23);
            this.ButtonTeleport.TabIndex = 3;
            this.ButtonTeleport.Text = "Teleport";
            this.ButtonTeleport.UseVisualStyleBackColor = true;
            this.ButtonTeleport.Click += new System.EventHandler(this.ButtonTeleport_Click);
            // 
            // GroupBoxGetRot
            // 
            this.GroupBoxGetRot.Controls.Add(this.ButtonPowRot);
            this.GroupBoxGetRot.Controls.Add(this.ButtonFlyRot);
            this.GroupBoxGetRot.Controls.Add(this.ButtonSpeedRot);
            this.GroupBoxGetRot.Enabled = false;
            this.GroupBoxGetRot.Location = new System.Drawing.Point(6, 78);
            this.GroupBoxGetRot.Name = "GroupBoxGetRot";
            this.GroupBoxGetRot.Size = new System.Drawing.Size(189, 53);
            this.GroupBoxGetRot.TabIndex = 5;
            this.GroupBoxGetRot.TabStop = false;
            this.GroupBoxGetRot.Text = "Get Rotation";
            // 
            // ButtonPowRot
            // 
            this.ButtonPowRot.Location = new System.Drawing.Point(122, 22);
            this.ButtonPowRot.Name = "ButtonPowRot";
            this.ButtonPowRot.Size = new System.Drawing.Size(52, 23);
            this.ButtonPowRot.TabIndex = 2;
            this.ButtonPowRot.Text = "Other2";
            this.ButtonPowRot.UseVisualStyleBackColor = true;
            this.ButtonPowRot.Click += new System.EventHandler(this.ButtonPowRot_Click);
            // 
            // ButtonFlyRot
            // 
            this.ButtonFlyRot.Location = new System.Drawing.Point(64, 22);
            this.ButtonFlyRot.Name = "ButtonFlyRot";
            this.ButtonFlyRot.Size = new System.Drawing.Size(52, 23);
            this.ButtonFlyRot.TabIndex = 1;
            this.ButtonFlyRot.Text = "Other";
            this.ButtonFlyRot.UseVisualStyleBackColor = true;
            this.ButtonFlyRot.Click += new System.EventHandler(this.ButtonFlyRot_Click);
            // 
            // ButtonSpeedRot
            // 
            this.ButtonSpeedRot.Location = new System.Drawing.Point(6, 22);
            this.ButtonSpeedRot.Name = "ButtonSpeedRot";
            this.ButtonSpeedRot.Size = new System.Drawing.Size(52, 23);
            this.ButtonSpeedRot.TabIndex = 0;
            this.ButtonSpeedRot.Text = "Leader";
            this.ButtonSpeedRot.UseVisualStyleBackColor = true;
            this.ButtonSpeedRot.Click += new System.EventHandler(this.ButtonSpeedRot_Click);
            // 
            // GroupBoxGetPos
            // 
            this.GroupBoxGetPos.Controls.Add(this.ButtonGetPow);
            this.GroupBoxGetPos.Controls.Add(this.ButtonGetFly);
            this.GroupBoxGetPos.Controls.Add(this.ButtonGetSpeed);
            this.GroupBoxGetPos.Enabled = false;
            this.GroupBoxGetPos.Location = new System.Drawing.Point(6, 19);
            this.GroupBoxGetPos.Name = "GroupBoxGetPos";
            this.GroupBoxGetPos.Size = new System.Drawing.Size(189, 53);
            this.GroupBoxGetPos.TabIndex = 4;
            this.GroupBoxGetPos.TabStop = false;
            this.GroupBoxGetPos.Text = "Get Position";
            // 
            // ButtonGetPow
            // 
            this.ButtonGetPow.Location = new System.Drawing.Point(122, 22);
            this.ButtonGetPow.Name = "ButtonGetPow";
            this.ButtonGetPow.Size = new System.Drawing.Size(52, 23);
            this.ButtonGetPow.TabIndex = 2;
            this.ButtonGetPow.Text = "Other2";
            this.ButtonGetPow.UseVisualStyleBackColor = true;
            this.ButtonGetPow.Click += new System.EventHandler(this.ButtonGetPow_Click);
            // 
            // ButtonGetFly
            // 
            this.ButtonGetFly.Location = new System.Drawing.Point(64, 22);
            this.ButtonGetFly.Name = "ButtonGetFly";
            this.ButtonGetFly.Size = new System.Drawing.Size(52, 23);
            this.ButtonGetFly.TabIndex = 1;
            this.ButtonGetFly.Text = "Other";
            this.ButtonGetFly.UseVisualStyleBackColor = true;
            this.ButtonGetFly.Click += new System.EventHandler(this.ButtonGetFly_Click);
            // 
            // ButtonGetSpeed
            // 
            this.ButtonGetSpeed.Location = new System.Drawing.Point(6, 22);
            this.ButtonGetSpeed.Name = "ButtonGetSpeed";
            this.ButtonGetSpeed.Size = new System.Drawing.Size(52, 23);
            this.ButtonGetSpeed.TabIndex = 0;
            this.ButtonGetSpeed.Text = "Leader";
            this.ButtonGetSpeed.UseVisualStyleBackColor = true;
            this.ButtonGetSpeed.Click += new System.EventHandler(this.ButtonGetSpeed_Click);
            // 
            // LabelRend
            // 
            this.LabelRend.AutoSize = true;
            this.LabelRend.Location = new System.Drawing.Point(297, 171);
            this.LabelRend.Name = "LabelRend";
            this.LabelRend.Size = new System.Drawing.Size(90, 13);
            this.LabelRend.TabIndex = 43;
            this.LabelRend.Text = "Render Distance:";
            // 
            // NumericObjRend
            // 
            this.NumericObjRend.Location = new System.Drawing.Point(297, 187);
            this.NumericObjRend.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumericObjRend.Name = "NumericObjRend";
            this.NumericObjRend.Size = new System.Drawing.Size(92, 20);
            this.NumericObjRend.TabIndex = 48;
            this.NumericObjRend.ValueChanged += new System.EventHandler(this.NumericObjRend_ValueChanged);
            // 
            // LabelLinkId
            // 
            this.LabelLinkId.AutoSize = true;
            this.LabelLinkId.Location = new System.Drawing.Point(199, 171);
            this.LabelLinkId.Name = "LabelLinkId";
            this.LabelLinkId.Size = new System.Drawing.Size(44, 13);
            this.LabelLinkId.TabIndex = 42;
            this.LabelLinkId.Text = "Link ID:";
            // 
            // NumericObjLink
            // 
            this.NumericObjLink.Location = new System.Drawing.Point(199, 187);
            this.NumericObjLink.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumericObjLink.Name = "NumericObjLink";
            this.NumericObjLink.Size = new System.Drawing.Size(92, 20);
            this.NumericObjLink.TabIndex = 47;
            this.NumericObjLink.ValueChanged += new System.EventHandler(this.NumericObjLink_ValueChanged);
            // 
            // LabelType
            // 
            this.LabelType.AutoSize = true;
            this.LabelType.Location = new System.Drawing.Point(321, 26);
            this.LabelType.Name = "LabelType";
            this.LabelType.Size = new System.Drawing.Size(68, 13);
            this.LabelType.TabIndex = 41;
            this.LabelType.Text = "Object Type:";
            // 
            // LabelList
            // 
            this.LabelList.AutoSize = true;
            this.LabelList.Location = new System.Drawing.Point(199, 26);
            this.LabelList.Name = "LabelList";
            this.LabelList.Size = new System.Drawing.Size(60, 13);
            this.LabelList.TabIndex = 40;
            this.LabelList.Text = "Object List:";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.NumericRotZ);
            this.GroupBox2.Controls.Add(this.NumericRotY);
            this.GroupBox2.Controls.Add(this.NumericRotX);
            this.GroupBox2.Location = new System.Drawing.Point(193, 121);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(385, 47);
            this.GroupBox2.TabIndex = 39;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Rotation (X, Y, Z)";
            // 
            // NumericRotZ
            // 
            this.NumericRotZ.DecimalPlaces = 4;
            this.NumericRotZ.Location = new System.Drawing.Point(256, 19);
            this.NumericRotZ.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.NumericRotZ.Minimum = new decimal(new int[] {
            65535,
            0,
            0,
            -2147483648});
            this.NumericRotZ.Name = "NumericRotZ";
            this.NumericRotZ.Size = new System.Drawing.Size(119, 20);
            this.NumericRotZ.TabIndex = 29;
            this.NumericRotZ.ValueChanged += new System.EventHandler(this.NumericRotZ_ValueChanged);
            // 
            // NumericRotY
            // 
            this.NumericRotY.DecimalPlaces = 4;
            this.NumericRotY.Location = new System.Drawing.Point(131, 19);
            this.NumericRotY.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.NumericRotY.Minimum = new decimal(new int[] {
            65535,
            0,
            0,
            -2147483648});
            this.NumericRotY.Name = "NumericRotY";
            this.NumericRotY.Size = new System.Drawing.Size(119, 20);
            this.NumericRotY.TabIndex = 28;
            this.NumericRotY.ValueChanged += new System.EventHandler(this.NumericRotY_ValueChanged);
            // 
            // NumericRotX
            // 
            this.NumericRotX.DecimalPlaces = 4;
            this.NumericRotX.Location = new System.Drawing.Point(6, 19);
            this.NumericRotX.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.NumericRotX.Minimum = new decimal(new int[] {
            65535,
            0,
            0,
            -2147483648});
            this.NumericRotX.Name = "NumericRotX";
            this.NumericRotX.Size = new System.Drawing.Size(119, 20);
            this.NumericRotX.TabIndex = 27;
            this.NumericRotX.ValueChanged += new System.EventHandler(this.NumericRotX_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.NumericPosZ);
            this.groupBox3.Controls.Add(this.NumericPosY);
            this.groupBox3.Controls.Add(this.NumericPosX);
            this.groupBox3.Location = new System.Drawing.Point(193, 68);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(385, 47);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Position (X, Y, Z)";
            // 
            // NumericPosZ
            // 
            this.NumericPosZ.DecimalPlaces = 4;
            this.NumericPosZ.Location = new System.Drawing.Point(256, 19);
            this.NumericPosZ.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NumericPosZ.Name = "NumericPosZ";
            this.NumericPosZ.Size = new System.Drawing.Size(119, 20);
            this.NumericPosZ.TabIndex = 26;
            this.NumericPosZ.ValueChanged += new System.EventHandler(this.NumericPosZ_ValueChanged);
            // 
            // NumericPosY
            // 
            this.NumericPosY.DecimalPlaces = 4;
            this.NumericPosY.Location = new System.Drawing.Point(131, 19);
            this.NumericPosY.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NumericPosY.Name = "NumericPosY";
            this.NumericPosY.Size = new System.Drawing.Size(119, 20);
            this.NumericPosY.TabIndex = 25;
            this.NumericPosY.ValueChanged += new System.EventHandler(this.NumericPosY_ValueChanged);
            // 
            // NumericPosX
            // 
            this.NumericPosX.DecimalPlaces = 4;
            this.NumericPosX.Location = new System.Drawing.Point(6, 19);
            this.NumericPosX.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NumericPosX.Name = "NumericPosX";
            this.NumericPosX.Size = new System.Drawing.Size(119, 20);
            this.NumericPosX.TabIndex = 24;
            this.NumericPosX.ValueChanged += new System.EventHandler(this.NumericPosX_ValueChanged);
            // 
            // ButtonRemove
            // 
            this.ButtonRemove.Location = new System.Drawing.Point(104, 362);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.Size = new System.Drawing.Size(83, 23);
            this.ButtonRemove.TabIndex = 55;
            this.ButtonRemove.Text = "Remove";
            this.ButtonRemove.UseVisualStyleBackColor = true;
            this.ButtonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(15, 362);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(83, 23);
            this.ButtonAdd.TabIndex = 54;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LabelFileLoaded,
            this.toolStripStatusLabel1,
            this.TextBoxNumOfObjects});
            this.statusStrip1.Location = new System.Drawing.Point(0, 390);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(583, 22);
            this.statusStrip1.TabIndex = 56;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LabelFileLoaded
            // 
            this.LabelFileLoaded.Name = "LabelFileLoaded";
            this.LabelFileLoaded.Size = new System.Drawing.Size(81, 17);
            this.LabelFileLoaded.Text = "No file loaded";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // TextBoxNumOfObjects
            // 
            this.TextBoxNumOfObjects.Name = "TextBoxNumOfObjects";
            this.TextBoxNumOfObjects.Size = new System.Drawing.Size(54, 17);
            this.TextBoxNumOfObjects.Text = "0 objects";
            // 
            // checkBoxMiscSettings
            // 
            this.checkBoxMiscSettings.AutoSize = true;
            this.checkBoxMiscSettings.Enabled = false;
            this.checkBoxMiscSettings.Location = new System.Drawing.Point(486, 45);
            this.checkBoxMiscSettings.Name = "checkBoxMiscSettings";
            this.checkBoxMiscSettings.Size = new System.Drawing.Size(92, 17);
            this.checkBoxMiscSettings.TabIndex = 58;
            this.checkBoxMiscSettings.Text = "Misc. Settings";
            this.checkBoxMiscSettings.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(583, 24);
            this.menuStrip1.TabIndex = 59;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 412);
            this.Controls.Add(this.checkBoxMiscSettings);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ButtonRemove);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.ButtonFindNextLink);
            this.Controls.Add(this.ComboBoxList);
            this.Controls.Add(this.ComboBoxObjectPicker);
            this.Controls.Add(this.PropertyGridMisc);
            this.Controls.Add(this.RichTextBoxProperties);
            this.Controls.Add(this.GroupBoxGameStuff);
            this.Controls.Add(this.LabelRend);
            this.Controls.Add(this.NumericObjRend);
            this.Controls.Add(this.LabelLinkId);
            this.Controls.Add(this.NumericObjLink);
            this.Controls.Add(this.LabelType);
            this.Controls.Add(this.LabelList);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ListBoxObjects);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Heroes Layout Editor";
            this.GroupBoxGameStuff.ResumeLayout(false);
            this.GroupBoxGetRot.ResumeLayout(false);
            this.GroupBoxGetPos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumericObjRend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericObjLink)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumericRotZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericRotY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericRotX)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumericPosZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericPosY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericPosX)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.ListBox ListBoxObjects;
        internal System.Windows.Forms.Button ButtonFindNextLink;
        internal System.Windows.Forms.ComboBox ComboBoxList;
        internal System.Windows.Forms.ComboBox ComboBoxObjectPicker;
        internal System.Windows.Forms.PropertyGrid PropertyGridMisc;
        internal System.Windows.Forms.RichTextBox RichTextBoxProperties;
        internal System.Windows.Forms.GroupBox GroupBoxGameStuff;
        internal System.Windows.Forms.Button ButtonTeleport;
        internal System.Windows.Forms.GroupBox GroupBoxGetRot;
        internal System.Windows.Forms.Button ButtonPowRot;
        internal System.Windows.Forms.Button ButtonFlyRot;
        internal System.Windows.Forms.Button ButtonSpeedRot;
        internal System.Windows.Forms.GroupBox GroupBoxGetPos;
        internal System.Windows.Forms.Button ButtonGetPow;
        internal System.Windows.Forms.Button ButtonGetFly;
        internal System.Windows.Forms.Button ButtonGetSpeed;
        internal System.Windows.Forms.Label LabelRend;
        internal System.Windows.Forms.NumericUpDown NumericObjRend;
        internal System.Windows.Forms.Label LabelLinkId;
        internal System.Windows.Forms.NumericUpDown NumericObjLink;
        internal System.Windows.Forms.Label LabelType;
        internal System.Windows.Forms.Label LabelList;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.NumericUpDown NumericRotZ;
        internal System.Windows.Forms.NumericUpDown NumericRotY;
        internal System.Windows.Forms.NumericUpDown NumericRotX;
        internal System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.NumericUpDown NumericPosZ;
        internal System.Windows.Forms.NumericUpDown NumericPosY;
        internal System.Windows.Forms.NumericUpDown NumericPosX;
        internal System.Windows.Forms.Button ButtonRemove;
        internal System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LabelFileLoaded;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel TextBoxNumOfObjects;
        private System.Windows.Forms.CheckBox checkBoxMiscSettings;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}