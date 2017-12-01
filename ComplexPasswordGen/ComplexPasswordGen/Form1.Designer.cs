namespace ComplexPasswordGen
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation8 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.PasswordLength = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lengthvalue = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.password = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.GenBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.CopyPassword = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuTrackbar1 = new Bunifu.Framework.UI.BunifuTrackbar();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation8.AnimateOnlyDifferences = true;
            animation8.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.BlindCoeff")));
            animation8.LeafCoeff = 0F;
            animation8.MaxTime = 1F;
            animation8.MinTime = 0F;
            animation8.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicCoeff")));
            animation8.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicShift")));
            animation8.MosaicSize = 0;
            animation8.Padding = new System.Windows.Forms.Padding(0);
            animation8.RotateCoeff = 0F;
            animation8.RotateLimit = 0F;
            animation8.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.ScaleCoeff")));
            animation8.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.SlideCoeff")));
            animation8.TimeCoeff = 0F;
            animation8.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 2);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(448, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 184);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Crimson;
            this.bunifuTransition1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 184);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Crimson;
            this.panel4.Controls.Add(this.bunifuCustomLabel2);
            this.panel4.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuTransition1.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(2, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(446, 20);
            this.panel4.TabIndex = 4;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseMove);
            this.panel4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseUp);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(428, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(21, 20);
            this.bunifuCustomLabel2.TabIndex = 5;
            this.bunifuCustomLabel2.Text = "X";
            this.bunifuCustomLabel2.Click += new System.EventHandler(this.bunifuCustomLabel2_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(3, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(182, 15);
            this.bunifuCustomLabel1.TabIndex = 5;
            this.bunifuCustomLabel1.Text = "P100 password gen By: Desmen#8355";
            // 
            // PasswordLength
            // 
            this.PasswordLength.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.PasswordLength, BunifuAnimatorNS.DecorationType.None);
            this.PasswordLength.Location = new System.Drawing.Point(9, 57);
            this.PasswordLength.Name = "PasswordLength";
            this.PasswordLength.Size = new System.Drawing.Size(85, 13);
            this.PasswordLength.TabIndex = 5;
            this.PasswordLength.Text = "Password length";
            // 
            // lengthvalue
            // 
            this.lengthvalue.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lengthvalue, BunifuAnimatorNS.DecorationType.None);
            this.lengthvalue.Location = new System.Drawing.Point(93, 58);
            this.lengthvalue.Name = "lengthvalue";
            this.lengthvalue.Size = new System.Drawing.Size(13, 13);
            this.lengthvalue.TabIndex = 7;
            this.lengthvalue.Text = "0";
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.SystemColors.Control;
            this.password.BorderColorFocused = System.Drawing.Color.Crimson;
            this.password.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.password.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.password.BorderThickness = 2;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.password, BunifuAnimatorNS.DecorationType.None);
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.password.ForeColor = System.Drawing.Color.Black;
            this.password.isPassword = false;
            this.password.Location = new System.Drawing.Point(14, 27);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(422, 24);
            this.password.TabIndex = 8;
            this.password.Text = "Generate a password";
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // GenBtn
            // 
            this.GenBtn.ActiveBorderThickness = 1;
            this.GenBtn.ActiveCornerRadius = 20;
            this.GenBtn.ActiveFillColor = System.Drawing.Color.Crimson;
            this.GenBtn.ActiveForecolor = System.Drawing.Color.White;
            this.GenBtn.ActiveLineColor = System.Drawing.Color.SeaShell;
            this.GenBtn.BackColor = System.Drawing.SystemColors.Control;
            this.GenBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GenBtn.BackgroundImage")));
            this.GenBtn.ButtonText = "Generate Password";
            this.GenBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.GenBtn, BunifuAnimatorNS.DecorationType.None);
            this.GenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenBtn.ForeColor = System.Drawing.Color.Black;
            this.GenBtn.IdleBorderThickness = 1;
            this.GenBtn.IdleCornerRadius = 20;
            this.GenBtn.IdleFillColor = System.Drawing.Color.White;
            this.GenBtn.IdleForecolor = System.Drawing.Color.Black;
            this.GenBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GenBtn.Location = new System.Drawing.Point(14, 126);
            this.GenBtn.Margin = new System.Windows.Forms.Padding(5);
            this.GenBtn.Name = "GenBtn";
            this.GenBtn.Size = new System.Drawing.Size(160, 43);
            this.GenBtn.TabIndex = 9;
            this.GenBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GenBtn.Click += new System.EventHandler(this.GenBtn_Click);
            // 
            // CopyPassword
            // 
            this.CopyPassword.ActiveBorderThickness = 1;
            this.CopyPassword.ActiveCornerRadius = 20;
            this.CopyPassword.ActiveFillColor = System.Drawing.Color.Crimson;
            this.CopyPassword.ActiveForecolor = System.Drawing.Color.White;
            this.CopyPassword.ActiveLineColor = System.Drawing.Color.SeaShell;
            this.CopyPassword.BackColor = System.Drawing.SystemColors.Control;
            this.CopyPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CopyPassword.BackgroundImage")));
            this.CopyPassword.ButtonText = "Copy To Clipboard";
            this.CopyPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.CopyPassword, BunifuAnimatorNS.DecorationType.None);
            this.CopyPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyPassword.ForeColor = System.Drawing.Color.Black;
            this.CopyPassword.IdleBorderThickness = 1;
            this.CopyPassword.IdleCornerRadius = 20;
            this.CopyPassword.IdleFillColor = System.Drawing.Color.White;
            this.CopyPassword.IdleForecolor = System.Drawing.Color.Black;
            this.CopyPassword.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CopyPassword.Location = new System.Drawing.Point(276, 126);
            this.CopyPassword.Margin = new System.Windows.Forms.Padding(5);
            this.CopyPassword.Name = "CopyPassword";
            this.CopyPassword.Size = new System.Drawing.Size(160, 43);
            this.CopyPassword.TabIndex = 10;
            this.CopyPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CopyPassword.Click += new System.EventHandler(this.CopyPassword_Click);
            // 
            // bunifuTrackbar1
            // 
            this.bunifuTrackbar1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTrackbar1.BackgroudColor = System.Drawing.Color.DarkGray;
            this.bunifuTrackbar1.BorderRadius = 0;
            this.bunifuTransition1.SetDecoration(this.bunifuTrackbar1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTrackbar1.IndicatorColor = System.Drawing.Color.Crimson;
            this.bunifuTrackbar1.Location = new System.Drawing.Point(14, 74);
            this.bunifuTrackbar1.MaximumValue = 50;
            this.bunifuTrackbar1.MinimumValue = 10;
            this.bunifuTrackbar1.Name = "bunifuTrackbar1";
            this.bunifuTrackbar1.Size = new System.Drawing.Size(422, 30);
            this.bunifuTrackbar1.SliderRadius = 0;
            this.bunifuTrackbar1.TabIndex = 11;
            this.bunifuTrackbar1.Value = 0;
            this.bunifuTrackbar1.ValueChanged += new System.EventHandler(this.bunifuTrackbar1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 186);
            this.Controls.Add(this.bunifuTrackbar1);
            this.Controls.Add(this.CopyPassword);
            this.Controls.Add(this.GenBtn);
            this.Controls.Add(this.password);
            this.Controls.Add(this.lengthvalue);
            this.Controls.Add(this.PasswordLength);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desmen\'s Complex Password Gen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel PasswordLength;
        private Bunifu.Framework.UI.BunifuCustomLabel lengthvalue;
        private Bunifu.Framework.UI.BunifuMetroTextbox password;
        private Bunifu.Framework.UI.BunifuThinButton2 GenBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 CopyPassword;
        private Bunifu.Framework.UI.BunifuTrackbar bunifuTrackbar1;
    }
}

