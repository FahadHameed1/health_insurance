namespace OOAD_Final_Project
{
    partial class addnewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addnewUser));
            this.nametxtbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.emailtxtbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.phonetxtbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.usernametxtbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.passtxtbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.addUserBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cancelBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.chooseImageBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureView = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureView)).BeginInit();
            this.SuspendLayout();
            // 
            // nametxtbox
            // 
            this.nametxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nametxtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.nametxtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nametxtbox.HintForeColor = System.Drawing.Color.Empty;
            this.nametxtbox.HintText = "Full Name";
            this.nametxtbox.isPassword = false;
            this.nametxtbox.LineFocusedColor = System.Drawing.Color.Blue;
            this.nametxtbox.LineIdleColor = System.Drawing.Color.Gray;
            this.nametxtbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.nametxtbox.LineThickness = 3;
            this.nametxtbox.Location = new System.Drawing.Point(17, 60);
            this.nametxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.nametxtbox.Name = "nametxtbox";
            this.nametxtbox.Size = new System.Drawing.Size(264, 33);
            this.nametxtbox.TabIndex = 0;
            this.nametxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add New User";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-3, 40);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(589, 26);
            this.bunifuSeparator1.TabIndex = 2;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // emailtxtbox
            // 
            this.emailtxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailtxtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.emailtxtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailtxtbox.HintForeColor = System.Drawing.Color.Empty;
            this.emailtxtbox.HintText = "Email";
            this.emailtxtbox.isPassword = false;
            this.emailtxtbox.LineFocusedColor = System.Drawing.Color.Blue;
            this.emailtxtbox.LineIdleColor = System.Drawing.Color.Gray;
            this.emailtxtbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.emailtxtbox.LineThickness = 3;
            this.emailtxtbox.Location = new System.Drawing.Point(17, 106);
            this.emailtxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.emailtxtbox.Name = "emailtxtbox";
            this.emailtxtbox.Size = new System.Drawing.Size(264, 33);
            this.emailtxtbox.TabIndex = 3;
            this.emailtxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // phonetxtbox
            // 
            this.phonetxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phonetxtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.phonetxtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.phonetxtbox.HintForeColor = System.Drawing.Color.Empty;
            this.phonetxtbox.HintText = "Phone Number";
            this.phonetxtbox.isPassword = false;
            this.phonetxtbox.LineFocusedColor = System.Drawing.Color.Blue;
            this.phonetxtbox.LineIdleColor = System.Drawing.Color.Gray;
            this.phonetxtbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.phonetxtbox.LineThickness = 3;
            this.phonetxtbox.Location = new System.Drawing.Point(17, 155);
            this.phonetxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.phonetxtbox.Name = "phonetxtbox";
            this.phonetxtbox.Size = new System.Drawing.Size(264, 33);
            this.phonetxtbox.TabIndex = 0;
            this.phonetxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // usernametxtbox
            // 
            this.usernametxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernametxtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.usernametxtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usernametxtbox.HintForeColor = System.Drawing.Color.Empty;
            this.usernametxtbox.HintText = "Username";
            this.usernametxtbox.isPassword = false;
            this.usernametxtbox.LineFocusedColor = System.Drawing.Color.Blue;
            this.usernametxtbox.LineIdleColor = System.Drawing.Color.Gray;
            this.usernametxtbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.usernametxtbox.LineThickness = 3;
            this.usernametxtbox.Location = new System.Drawing.Point(17, 207);
            this.usernametxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.usernametxtbox.Name = "usernametxtbox";
            this.usernametxtbox.Size = new System.Drawing.Size(264, 33);
            this.usernametxtbox.TabIndex = 3;
            this.usernametxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // passtxtbox
            // 
            this.passtxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passtxtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passtxtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passtxtbox.HintForeColor = System.Drawing.Color.Empty;
            this.passtxtbox.HintText = "Password";
            this.passtxtbox.isPassword = false;
            this.passtxtbox.LineFocusedColor = System.Drawing.Color.Blue;
            this.passtxtbox.LineIdleColor = System.Drawing.Color.Gray;
            this.passtxtbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.passtxtbox.LineThickness = 3;
            this.passtxtbox.Location = new System.Drawing.Point(17, 259);
            this.passtxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.passtxtbox.Name = "passtxtbox";
            this.passtxtbox.Size = new System.Drawing.Size(264, 33);
            this.passtxtbox.TabIndex = 3;
            this.passtxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // addUserBtn
            // 
            this.addUserBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.addUserBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.addUserBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addUserBtn.BorderRadius = 5;
            this.addUserBtn.ButtonText = "Add User";
            this.addUserBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addUserBtn.DisabledColor = System.Drawing.Color.Gray;
            this.addUserBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(182)))), ((int)(((byte)(184)))));
            this.addUserBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.addUserBtn.Iconimage = null;
            this.addUserBtn.Iconimage_right = null;
            this.addUserBtn.Iconimage_right_Selected = null;
            this.addUserBtn.Iconimage_Selected = null;
            this.addUserBtn.IconMarginLeft = 0;
            this.addUserBtn.IconMarginRight = 0;
            this.addUserBtn.IconRightVisible = true;
            this.addUserBtn.IconRightZoom = 0D;
            this.addUserBtn.IconVisible = true;
            this.addUserBtn.IconZoom = 40D;
            this.addUserBtn.IsTab = true;
            this.addUserBtn.Location = new System.Drawing.Point(155, 402);
            this.addUserBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.addUserBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.addUserBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.addUserBtn.selected = false;
            this.addUserBtn.Size = new System.Drawing.Size(122, 30);
            this.addUserBtn.TabIndex = 5;
            this.addUserBtn.Text = "Add User";
            this.addUserBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addUserBtn.Textcolor = System.Drawing.Color.White;
            this.addUserBtn.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserBtn.Click += new System.EventHandler(this.loginMenuButton_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(104)))), ((int)(((byte)(89)))));
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(104)))), ((int)(((byte)(89)))));
            this.cancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelBtn.BorderRadius = 5;
            this.cancelBtn.ButtonText = "Cancel";
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.DisabledColor = System.Drawing.Color.Gray;
            this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(182)))), ((int)(((byte)(184)))));
            this.cancelBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.cancelBtn.Iconimage = null;
            this.cancelBtn.Iconimage_right = null;
            this.cancelBtn.Iconimage_right_Selected = null;
            this.cancelBtn.Iconimage_Selected = null;
            this.cancelBtn.IconMarginLeft = 0;
            this.cancelBtn.IconMarginRight = 0;
            this.cancelBtn.IconRightVisible = true;
            this.cancelBtn.IconRightZoom = 0D;
            this.cancelBtn.IconVisible = true;
            this.cancelBtn.IconZoom = 40D;
            this.cancelBtn.IsTab = true;
            this.cancelBtn.Location = new System.Drawing.Point(12, 402);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(104)))), ((int)(((byte)(89)))));
            this.cancelBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.cancelBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.cancelBtn.selected = false;
            this.cancelBtn.Size = new System.Drawing.Size(122, 30);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancelBtn.Textcolor = System.Drawing.Color.White;
            this.cancelBtn.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(-3, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 10);
            this.panel1.TabIndex = 7;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // chooseImageBtn
            // 
            this.chooseImageBtn.Activecolor = System.Drawing.Color.Silver;
            this.chooseImageBtn.BackColor = System.Drawing.Color.Silver;
            this.chooseImageBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chooseImageBtn.BorderRadius = 5;
            this.chooseImageBtn.ButtonText = "Choose Image";
            this.chooseImageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chooseImageBtn.DisabledColor = System.Drawing.Color.Gray;
            this.chooseImageBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(182)))), ((int)(((byte)(184)))));
            this.chooseImageBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.chooseImageBtn.Iconimage = null;
            this.chooseImageBtn.Iconimage_right = null;
            this.chooseImageBtn.Iconimage_right_Selected = null;
            this.chooseImageBtn.Iconimage_Selected = null;
            this.chooseImageBtn.IconMarginLeft = 0;
            this.chooseImageBtn.IconMarginRight = 0;
            this.chooseImageBtn.IconRightVisible = true;
            this.chooseImageBtn.IconRightZoom = 0D;
            this.chooseImageBtn.IconVisible = true;
            this.chooseImageBtn.IconZoom = 40D;
            this.chooseImageBtn.IsTab = true;
            this.chooseImageBtn.Location = new System.Drawing.Point(91, 341);
            this.chooseImageBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chooseImageBtn.Name = "chooseImageBtn";
            this.chooseImageBtn.Normalcolor = System.Drawing.Color.Silver;
            this.chooseImageBtn.OnHovercolor = System.Drawing.Color.DarkGray;
            this.chooseImageBtn.OnHoverTextColor = System.Drawing.Color.DarkGray;
            this.chooseImageBtn.selected = false;
            this.chooseImageBtn.Size = new System.Drawing.Size(140, 30);
            this.chooseImageBtn.TabIndex = 9;
            this.chooseImageBtn.Text = "Choose Image";
            this.chooseImageBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chooseImageBtn.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.chooseImageBtn.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseImageBtn.Click += new System.EventHandler(this.chooseImageBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label2.Location = new System.Drawing.Point(90, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Choose Profile Image";
            // 
            // pictureView
            // 
            this.pictureView.Image = ((System.Drawing.Image)(resources.GetObject("pictureView.Image")));
            this.pictureView.Location = new System.Drawing.Point(17, 314);
            this.pictureView.Name = "pictureView";
            this.pictureView.Size = new System.Drawing.Size(68, 67);
            this.pictureView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureView.TabIndex = 8;
            this.pictureView.TabStop = false;
            // 
            // addnewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(568, 442);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chooseImageBtn);
            this.Controls.Add(this.pictureView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addUserBtn);
            this.Controls.Add(this.passtxtbox);
            this.Controls.Add(this.usernametxtbox);
            this.Controls.Add(this.emailtxtbox);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phonetxtbox);
            this.Controls.Add(this.nametxtbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addnewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addnewUser";
            this.Load += new System.EventHandler(this.addnewUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox nametxtbox;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox emailtxtbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox phonetxtbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox usernametxtbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passtxtbox;
        private Bunifu.Framework.UI.BunifuFlatButton addUserBtn;
        private Bunifu.Framework.UI.BunifuFlatButton cancelBtn;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox pictureView;
        private Bunifu.Framework.UI.BunifuFlatButton chooseImageBtn;
        private System.Windows.Forms.Label label2;
    }
}