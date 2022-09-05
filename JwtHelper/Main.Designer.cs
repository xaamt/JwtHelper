namespace JwtHelper
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.imageListAction = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tslblPoweredBy = new System.Windows.Forms.ToolStripStatusLabel();
            this.Base64Token = new System.Windows.Forms.GroupBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.btnPaste = new System.Windows.Forms.Button();
            this.cbDefaultKey = new System.Windows.Forms.CheckBox();
            this.lblContentLength = new System.Windows.Forms.Label();
            this.btnInspect = new System.Windows.Forms.Button();
            this.lblJwt = new System.Windows.Forms.Label();
            this.txtJwt = new System.Windows.Forms.TextBox();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtExpireUntil = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtExpiredAt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNotBefore = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIssuedAt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtIsValid = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtIsAuthenticated = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIssuerInfo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBranchName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBranchId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lvApplications = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblApplicationList = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lvRoles = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lblJsonContentLength = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.lblJsonContent = new System.Windows.Forms.Label();
            this.txtJsonContent = new System.Windows.Forms.TextBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            this.Base64Token.SuspendLayout();
            this.tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageListAction
            // 
            this.imageListAction.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListAction.ImageStream")));
            this.imageListAction.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListAction.Images.SetKeyName(0, "cancel.png");
            this.imageListAction.Images.SetKeyName(1, "search.png");
            this.imageListAction.Images.SetKeyName(2, "reset.png");
            this.imageListAction.Images.SetKeyName(3, "auto.png");
            this.imageListAction.Images.SetKeyName(4, "067.png");
            this.imageListAction.Images.SetKeyName(5, "068.png");
            this.imageListAction.Images.SetKeyName(6, "090.png");
            this.imageListAction.Images.SetKeyName(7, "030.png");
            this.imageListAction.Images.SetKeyName(8, "050.png");
            this.imageListAction.Images.SetKeyName(9, "066.png");
            this.imageListAction.Images.SetKeyName(10, "067.png");
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblPoweredBy});
            this.statusStrip.Location = new System.Drawing.Point(0, 1220);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 26, 0);
            this.statusStrip.Size = new System.Drawing.Size(1175, 39);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 15;
            this.statusStrip.Text = "statusStrip";
            // 
            // tslblPoweredBy
            // 
            this.tslblPoweredBy.Image = global::JwtHelper.Properties.Resources.about;
            this.tslblPoweredBy.IsLink = true;
            this.tslblPoweredBy.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.tslblPoweredBy.LinkColor = System.Drawing.SystemColors.WindowText;
            this.tslblPoweredBy.Name = "tslblPoweredBy";
            this.tslblPoweredBy.Size = new System.Drawing.Size(246, 30);
            this.tslblPoweredBy.Text = "Powered by XAMT.Pro";
            this.tslblPoweredBy.ToolTipText = "Powered by XAMT.Pro";
            this.tslblPoweredBy.Click += new System.EventHandler(this.tslblPoweredBy_Click);
            // 
            // Base64Token
            // 
            this.Base64Token.Controls.Add(this.txtKey);
            this.Base64Token.Controls.Add(this.lblKey);
            this.Base64Token.Controls.Add(this.btnPaste);
            this.Base64Token.Controls.Add(this.cbDefaultKey);
            this.Base64Token.Controls.Add(this.lblContentLength);
            this.Base64Token.Controls.Add(this.btnInspect);
            this.Base64Token.Controls.Add(this.lblJwt);
            this.Base64Token.Controls.Add(this.txtJwt);
            this.Base64Token.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Base64Token.Location = new System.Drawing.Point(18, 18);
            this.Base64Token.Margin = new System.Windows.Forms.Padding(9);
            this.Base64Token.Name = "Base64Token";
            this.Base64Token.Padding = new System.Windows.Forms.Padding(6);
            this.Base64Token.Size = new System.Drawing.Size(1138, 473);
            this.Base64Token.TabIndex = 16;
            this.Base64Token.TabStop = false;
            this.Base64Token.Text = "Base64 Token";
            // 
            // txtKey
            // 
            this.txtKey.BackColor = System.Drawing.SystemColors.Info;
            this.txtKey.Enabled = false;
            this.txtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtKey.Location = new System.Drawing.Point(15, 327);
            this.txtKey.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtKey.MaxLength = 500;
            this.txtKey.Name = "txtKey";
            this.txtKey.PasswordChar = '*';
            this.txtKey.Size = new System.Drawing.Size(866, 29);
            this.txtKey.TabIndex = 60;
            // 
            // lblKey
            // 
            this.lblKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKey.AutoSize = true;
            this.lblKey.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblKey.Location = new System.Drawing.Point(15, 294);
            this.lblKey.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(58, 25);
            this.lblKey.TabIndex = 59;
            this.lblKey.Text = "Key :";
            this.lblKey.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPaste
            // 
            this.btnPaste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPaste.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPaste.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnPaste.ImageKey = "068.png";
            this.btnPaste.ImageList = this.imageListAction;
            this.btnPaste.Location = new System.Drawing.Point(1076, 26);
            this.btnPaste.Margin = new System.Windows.Forms.Padding(6);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(48, 42);
            this.btnPaste.TabIndex = 2;
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // cbDefaultKey
            // 
            this.cbDefaultKey.AutoSize = true;
            this.cbDefaultKey.Location = new System.Drawing.Point(904, 329);
            this.cbDefaultKey.Margin = new System.Windows.Forms.Padding(6);
            this.cbDefaultKey.Name = "cbDefaultKey";
            this.cbDefaultKey.Size = new System.Drawing.Size(220, 29);
            this.cbDefaultKey.TabIndex = 3;
            this.cbDefaultKey.Text = "Default encoded Key";
            this.cbDefaultKey.UseVisualStyleBackColor = true;
            this.cbDefaultKey.CheckedChanged += new System.EventHandler(this.cbDefaultKey_CheckedChanged);
            // 
            // lblContentLength
            // 
            this.lblContentLength.ForeColor = System.Drawing.Color.Sienna;
            this.lblContentLength.Location = new System.Drawing.Point(974, 281);
            this.lblContentLength.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblContentLength.Name = "lblContentLength";
            this.lblContentLength.Size = new System.Drawing.Size(150, 26);
            this.lblContentLength.TabIndex = 49;
            this.lblContentLength.Text = "Length: 0";
            this.lblContentLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnInspect
            // 
            this.btnInspect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInspect.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnInspect.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnInspect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInspect.ImageIndex = 1;
            this.btnInspect.ImageList = this.imageListAction;
            this.btnInspect.Location = new System.Drawing.Point(906, 382);
            this.btnInspect.Margin = new System.Windows.Forms.Padding(6);
            this.btnInspect.Name = "btnInspect";
            this.btnInspect.Size = new System.Drawing.Size(218, 68);
            this.btnInspect.TabIndex = 4;
            this.btnInspect.Text = "Inspect";
            this.btnInspect.UseVisualStyleBackColor = true;
            this.btnInspect.Click += new System.EventHandler(this.btnInspect_Click);
            // 
            // lblJwt
            // 
            this.lblJwt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblJwt.AutoSize = true;
            this.lblJwt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblJwt.Location = new System.Drawing.Point(15, 42);
            this.lblJwt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblJwt.Name = "lblJwt";
            this.lblJwt.Size = new System.Drawing.Size(230, 25);
            this.lblJwt.TabIndex = 43;
            this.lblJwt.Text = "Base64 three part token :";
            this.lblJwt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtJwt
            // 
            this.txtJwt.BackColor = System.Drawing.SystemColors.Info;
            this.txtJwt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJwt.Location = new System.Drawing.Point(15, 76);
            this.txtJwt.Margin = new System.Windows.Forms.Padding(7);
            this.txtJwt.MaxLength = 0;
            this.txtJwt.Multiline = true;
            this.txtJwt.Name = "txtJwt";
            this.txtJwt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtJwt.Size = new System.Drawing.Size(1110, 198);
            this.txtJwt.TabIndex = 1;
            this.txtJwt.TextChanged += new System.EventHandler(this.txtJwt_TextChanged);
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabPage1);
            this.tabs.Controls.Add(this.tabPage2);
            this.tabs.Controls.Add(this.tabPage3);
            this.tabs.Controls.Add(this.tabPage4);
            this.tabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tabs.ImageList = this.imageListAction;
            this.tabs.ItemSize = new System.Drawing.Size(150, 30);
            this.tabs.Location = new System.Drawing.Point(18, 513);
            this.tabs.Margin = new System.Windows.Forms.Padding(4);
            this.tabs.Multiline = true;
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1138, 596);
            this.tabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabs.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tabPage1.ImageIndex = 7;
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1130, 558);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Basic Info";
            this.tabPage1.ToolTipText = "Base Info About Token";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtExpireUntil);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtExpiredAt);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtNotBefore);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtIssuedAt);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtIsValid);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtIsAuthenticated);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Location = new System.Drawing.Point(565, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(548, 495);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Date - Time";
            // 
            // txtExpireUntil
            // 
            this.txtExpireUntil.BackColor = System.Drawing.SystemColors.Control;
            this.txtExpireUntil.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExpireUntil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtExpireUntil.Location = new System.Drawing.Point(176, 366);
            this.txtExpireUntil.Margin = new System.Windows.Forms.Padding(4);
            this.txtExpireUntil.Multiline = true;
            this.txtExpireUntil.Name = "txtExpireUntil";
            this.txtExpireUntil.ReadOnly = true;
            this.txtExpireUntil.ShortcutsEnabled = false;
            this.txtExpireUntil.Size = new System.Drawing.Size(345, 100);
            this.txtExpireUntil.TabIndex = 25;
            this.txtExpireUntil.TabStop = false;
            this.txtExpireUntil.Text = "---";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 366);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 25);
            this.label10.TabIndex = 24;
            this.label10.Text = "Expire Until:";
            // 
            // txtExpiredAt
            // 
            this.txtExpiredAt.BackColor = System.Drawing.SystemColors.Control;
            this.txtExpiredAt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExpiredAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtExpiredAt.Location = new System.Drawing.Point(176, 306);
            this.txtExpiredAt.Margin = new System.Windows.Forms.Padding(4);
            this.txtExpiredAt.Multiline = true;
            this.txtExpiredAt.Name = "txtExpiredAt";
            this.txtExpiredAt.ReadOnly = true;
            this.txtExpiredAt.ShortcutsEnabled = false;
            this.txtExpiredAt.Size = new System.Drawing.Size(345, 26);
            this.txtExpiredAt.TabIndex = 23;
            this.txtExpiredAt.TabStop = false;
            this.txtExpiredAt.Text = "---";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 188);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 25);
            this.label11.TabIndex = 22;
            this.label11.Text = "Issued At:";
            // 
            // txtNotBefore
            // 
            this.txtNotBefore.BackColor = System.Drawing.SystemColors.Control;
            this.txtNotBefore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNotBefore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtNotBefore.Location = new System.Drawing.Point(176, 247);
            this.txtNotBefore.Margin = new System.Windows.Forms.Padding(4);
            this.txtNotBefore.Multiline = true;
            this.txtNotBefore.Name = "txtNotBefore";
            this.txtNotBefore.ReadOnly = true;
            this.txtNotBefore.ShortcutsEnabled = false;
            this.txtNotBefore.Size = new System.Drawing.Size(345, 26);
            this.txtNotBefore.TabIndex = 21;
            this.txtNotBefore.TabStop = false;
            this.txtNotBefore.Text = "---";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 306);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 25);
            this.label12.TabIndex = 20;
            this.label12.Text = "Expired At:";
            // 
            // txtIssuedAt
            // 
            this.txtIssuedAt.BackColor = System.Drawing.SystemColors.Control;
            this.txtIssuedAt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIssuedAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtIssuedAt.Location = new System.Drawing.Point(176, 188);
            this.txtIssuedAt.Margin = new System.Windows.Forms.Padding(4);
            this.txtIssuedAt.Multiline = true;
            this.txtIssuedAt.Name = "txtIssuedAt";
            this.txtIssuedAt.ReadOnly = true;
            this.txtIssuedAt.ShortcutsEnabled = false;
            this.txtIssuedAt.Size = new System.Drawing.Size(345, 26);
            this.txtIssuedAt.TabIndex = 19;
            this.txtIssuedAt.TabStop = false;
            this.txtIssuedAt.Text = "---";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 247);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 25);
            this.label13.TabIndex = 18;
            this.label13.Text = "Not Before: ";
            // 
            // txtIsValid
            // 
            this.txtIsValid.BackColor = System.Drawing.SystemColors.Control;
            this.txtIsValid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIsValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtIsValid.Location = new System.Drawing.Point(176, 129);
            this.txtIsValid.Margin = new System.Windows.Forms.Padding(4);
            this.txtIsValid.Multiline = true;
            this.txtIsValid.Name = "txtIsValid";
            this.txtIsValid.ReadOnly = true;
            this.txtIsValid.ShortcutsEnabled = false;
            this.txtIsValid.Size = new System.Drawing.Size(345, 26);
            this.txtIsValid.TabIndex = 17;
            this.txtIsValid.TabStop = false;
            this.txtIsValid.Text = "---";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(31, 129);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(138, 25);
            this.label14.TabIndex = 16;
            this.label14.Text = "Authenticated:";
            // 
            // txtIsAuthenticated
            // 
            this.txtIsAuthenticated.BackColor = System.Drawing.SystemColors.Control;
            this.txtIsAuthenticated.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIsAuthenticated.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtIsAuthenticated.Location = new System.Drawing.Point(176, 70);
            this.txtIsAuthenticated.Margin = new System.Windows.Forms.Padding(4);
            this.txtIsAuthenticated.Multiline = true;
            this.txtIsAuthenticated.Name = "txtIsAuthenticated";
            this.txtIsAuthenticated.ReadOnly = true;
            this.txtIsAuthenticated.ShortcutsEnabled = false;
            this.txtIsAuthenticated.Size = new System.Drawing.Size(345, 26);
            this.txtIsAuthenticated.TabIndex = 15;
            this.txtIsAuthenticated.TabStop = false;
            this.txtIsAuthenticated.Text = "---";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(31, 70);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(145, 25);
            this.label15.TabIndex = 14;
            this.label15.Text = "Well Formated:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIssuerInfo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtPosition);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtBranchName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtBranchId);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtFullName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtUserId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(526, 495);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main";
            // 
            // txtIssuerInfo
            // 
            this.txtIssuerInfo.BackColor = System.Drawing.SystemColors.Control;
            this.txtIssuerInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIssuerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtIssuerInfo.Location = new System.Drawing.Point(145, 425);
            this.txtIssuerInfo.Margin = new System.Windows.Forms.Padding(4);
            this.txtIssuerInfo.Multiline = true;
            this.txtIssuerInfo.Name = "txtIssuerInfo";
            this.txtIssuerInfo.ReadOnly = true;
            this.txtIssuerInfo.ShortcutsEnabled = false;
            this.txtIssuerInfo.Size = new System.Drawing.Size(330, 30);
            this.txtIssuerInfo.TabIndex = 27;
            this.txtIssuerInfo.TabStop = false;
            this.txtIssuerInfo.Text = "---";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(31, 425);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 30);
            this.label8.TabIndex = 26;
            this.label8.Text = "Issuer:";
            // 
            // txtPosition
            // 
            this.txtPosition.BackColor = System.Drawing.SystemColors.Control;
            this.txtPosition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPosition.Location = new System.Drawing.Point(145, 366);
            this.txtPosition.Margin = new System.Windows.Forms.Padding(4);
            this.txtPosition.Multiline = true;
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.ReadOnly = true;
            this.txtPosition.ShortcutsEnabled = false;
            this.txtPosition.Size = new System.Drawing.Size(330, 30);
            this.txtPosition.TabIndex = 25;
            this.txtPosition.TabStop = false;
            this.txtPosition.Text = "---";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(31, 366);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 30);
            this.label7.TabIndex = 24;
            this.label7.Text = "Position:";
            // 
            // txtBranchName
            // 
            this.txtBranchName.BackColor = System.Drawing.SystemColors.Control;
            this.txtBranchName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBranchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtBranchName.Location = new System.Drawing.Point(145, 306);
            this.txtBranchName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBranchName.Multiline = true;
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.ReadOnly = true;
            this.txtBranchName.ShortcutsEnabled = false;
            this.txtBranchName.Size = new System.Drawing.Size(330, 30);
            this.txtBranchName.TabIndex = 23;
            this.txtBranchName.TabStop = false;
            this.txtBranchName.Text = "---";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(31, 188);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 30);
            this.label6.TabIndex = 22;
            this.label6.Text = "Full Name:";
            // 
            // txtBranchId
            // 
            this.txtBranchId.BackColor = System.Drawing.SystemColors.Control;
            this.txtBranchId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBranchId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtBranchId.Location = new System.Drawing.Point(145, 247);
            this.txtBranchId.Margin = new System.Windows.Forms.Padding(4);
            this.txtBranchId.Multiline = true;
            this.txtBranchId.Name = "txtBranchId";
            this.txtBranchId.ReadOnly = true;
            this.txtBranchId.ShortcutsEnabled = false;
            this.txtBranchId.Size = new System.Drawing.Size(330, 30);
            this.txtBranchId.TabIndex = 21;
            this.txtBranchId.TabStop = false;
            this.txtBranchId.Text = "---";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(31, 306);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 30);
            this.label5.TabIndex = 20;
            this.label5.Text = "Branch Name:";
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.SystemColors.Control;
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtFullName.Location = new System.Drawing.Point(145, 188);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFullName.Multiline = true;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.ShortcutsEnabled = false;
            this.txtFullName.Size = new System.Drawing.Size(330, 30);
            this.txtFullName.TabIndex = 19;
            this.txtFullName.TabStop = false;
            this.txtFullName.Text = "---";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(31, 247);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 30);
            this.label4.TabIndex = 18;
            this.label4.Text = "Branch Id:";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.Control;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtUsername.Location = new System.Drawing.Point(145, 129);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.ShortcutsEnabled = false;
            this.txtUsername.Size = new System.Drawing.Size(330, 30);
            this.txtUsername.TabIndex = 17;
            this.txtUsername.TabStop = false;
            this.txtUsername.Text = "---";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(31, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 30);
            this.label3.TabIndex = 16;
            this.label3.Text = "Username:";
            // 
            // txtUserId
            // 
            this.txtUserId.BackColor = System.Drawing.SystemColors.Control;
            this.txtUserId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtUserId.Location = new System.Drawing.Point(145, 70);
            this.txtUserId.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserId.Multiline = true;
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.ReadOnly = true;
            this.txtUserId.ShortcutsEnabled = false;
            this.txtUserId.Size = new System.Drawing.Size(330, 30);
            this.txtUserId.TabIndex = 15;
            this.txtUserId.TabStop = false;
            this.txtUserId.Text = "---";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(31, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 30);
            this.label2.TabIndex = 14;
            this.label2.Text = "User Id:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lvApplications);
            this.tabPage2.Controls.Add(this.lblApplicationList);
            this.tabPage2.ImageIndex = 9;
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1130, 558);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Applications";
            this.tabPage2.ToolTipText = "Application Info";
            // 
            // lvApplications
            // 
            this.lvApplications.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvApplications.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lvApplications.FullRowSelect = true;
            this.lvApplications.GridLines = true;
            this.lvApplications.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvApplications.HideSelection = false;
            this.lvApplications.Location = new System.Drawing.Point(20, 65);
            this.lvApplications.Margin = new System.Windows.Forms.Padding(4);
            this.lvApplications.MultiSelect = false;
            this.lvApplications.Name = "lvApplications";
            this.lvApplications.ShowGroups = false;
            this.lvApplications.Size = new System.Drawing.Size(1086, 445);
            this.lvApplications.TabIndex = 48;
            this.lvApplications.UseCompatibleStateImageBehavior = false;
            this.lvApplications.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "#";
            this.columnHeader9.Width = 30;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Alias";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Title";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Is Admin";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Role Count";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 80;
            // 
            // lblApplicationList
            // 
            this.lblApplicationList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApplicationList.AutoSize = true;
            this.lblApplicationList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblApplicationList.Location = new System.Drawing.Point(15, 20);
            this.lblApplicationList.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblApplicationList.Name = "lblApplicationList";
            this.lblApplicationList.Size = new System.Drawing.Size(267, 25);
            this.lblApplicationList.TabIndex = 47;
            this.lblApplicationList.Text = "Applications (Audiences) :";
            this.lblApplicationList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lvRoles);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.ImageIndex = 10;
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1130, 558);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Roles";
            this.tabPage3.ToolTipText = "Role Info";
            // 
            // lvRoles
            // 
            this.lvRoles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lvRoles.GridLines = true;
            this.lvRoles.HideSelection = false;
            this.lvRoles.Location = new System.Drawing.Point(20, 65);
            this.lvRoles.Margin = new System.Windows.Forms.Padding(4);
            this.lvRoles.MultiSelect = false;
            this.lvRoles.Name = "lvRoles";
            this.lvRoles.ShowGroups = false;
            this.lvRoles.Size = new System.Drawing.Size(1086, 445);
            this.lvRoles.TabIndex = 50;
            this.lvRoles.UseCompatibleStateImageBehavior = false;
            this.lvRoles.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "#";
            this.columnHeader10.Width = 30;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Role";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 170;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Application";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Is Valid";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Admin Overrided";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 100;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 49;
            this.label1.Text = "Roles :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lblJsonContentLength);
            this.tabPage4.Controls.Add(this.btnCopy);
            this.tabPage4.Controls.Add(this.lblJsonContent);
            this.tabPage4.Controls.Add(this.txtJsonContent);
            this.tabPage4.ImageIndex = 8;
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1130, 558);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Json";
            this.tabPage4.ToolTipText = "Deserialized Token Payload";
            // 
            // lblJsonContentLength
            // 
            this.lblJsonContentLength.ForeColor = System.Drawing.Color.Sienna;
            this.lblJsonContentLength.Location = new System.Drawing.Point(895, 20);
            this.lblJsonContentLength.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblJsonContentLength.Name = "lblJsonContentLength";
            this.lblJsonContentLength.Size = new System.Drawing.Size(150, 26);
            this.lblJsonContentLength.TabIndex = 61;
            this.lblJsonContentLength.Text = "Length: 0";
            this.lblJsonContentLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCopy
            // 
            this.btnCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCopy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCopy.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCopy.ImageKey = "067.png";
            this.btnCopy.ImageList = this.imageListAction;
            this.btnCopy.Location = new System.Drawing.Point(1058, 9);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(6);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(48, 42);
            this.btnCopy.TabIndex = 47;
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // lblJsonContent
            // 
            this.lblJsonContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblJsonContent.AutoSize = true;
            this.lblJsonContent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblJsonContent.Location = new System.Drawing.Point(15, 20);
            this.lblJsonContent.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblJsonContent.Name = "lblJsonContent";
            this.lblJsonContent.Size = new System.Drawing.Size(156, 25);
            this.lblJsonContent.TabIndex = 46;
            this.lblJsonContent.Text = "Payload Json :";
            this.lblJsonContent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtJsonContent
            // 
            this.txtJsonContent.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtJsonContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtJsonContent.Location = new System.Drawing.Point(20, 65);
            this.txtJsonContent.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtJsonContent.MaxLength = 0;
            this.txtJsonContent.Multiline = true;
            this.txtJsonContent.Name = "txtJsonContent";
            this.txtJsonContent.ReadOnly = true;
            this.txtJsonContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtJsonContent.Size = new System.Drawing.Size(1086, 445);
            this.txtJsonContent.TabIndex = 45;
            this.txtJsonContent.TextChanged += new System.EventHandler(this.txtJsonContent_TextChanged);
            // 
            // btnReload
            // 
            this.btnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReload.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReload.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnReload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReload.ImageKey = "reset.png";
            this.btnReload.ImageList = this.imageListAction;
            this.btnReload.Location = new System.Drawing.Point(763, 1121);
            this.btnReload.Margin = new System.Windows.Forms.Padding(6);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(183, 68);
            this.btnReload.TabIndex = 19;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.ImageKey = "cancel.png";
            this.btnCancel.ImageList = this.imageListAction;
            this.btnCancel.Location = new System.Drawing.Point(972, 1121);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(183, 68);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Exit";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Main
            // 
            this.AcceptButton = this.btnInspect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 1259);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.Base64Token);
            this.Controls.Add(this.statusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "JWT Helper";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.Base64Token.ResumeLayout(false);
            this.Base64Token.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageListAction;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tslblPoweredBy;
        private System.Windows.Forms.GroupBox Base64Token;
        private System.Windows.Forms.CheckBox cbDefaultKey;
        private System.Windows.Forms.Label lblContentLength;
        private System.Windows.Forms.Button btnInspect;
        private System.Windows.Forms.Label lblJwt;
        private System.Windows.Forms.TextBox txtJwt;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblJsonContentLength;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label lblJsonContent;
        private System.Windows.Forms.TextBox txtJsonContent;
        private System.Windows.Forms.Label lblApplicationList;
        private System.Windows.Forms.ListView lvApplications;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView lvRoles;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBranchName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBranchId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.TextBox txtIssuerInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtExpireUntil;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtExpiredAt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNotBefore;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtIssuedAt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtIsValid;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtIsAuthenticated;
        private System.Windows.Forms.Label label15;
    }
}

