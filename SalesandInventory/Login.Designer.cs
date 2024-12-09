namespace SalesandInventory
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            pictureBox1 = new PictureBox();
            userInput = new TextBox();
            passInput = new TextBox();
            label4 = new Label();
            label5 = new Label();
            exitApp = new LinkLabel();
            loginBtn = new RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 113);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.invexlogo_removebg_preview;
            pictureBox1.Location = new Point(114, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 149);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // userInput
            // 
            userInput.BackColor = Color.FromArgb(30, 31, 34);
            userInput.BorderStyle = BorderStyle.FixedSingle;
            userInput.Font = new Font("Arial", 12F);
            userInput.ForeColor = Color.White;
            userInput.Location = new Point(65, 203);
            userInput.Margin = new Padding(2);
            userInput.Name = "userInput";
            userInput.Size = new Size(277, 26);
            userInput.TabIndex = 5;
            // 
            // passInput
            // 
            passInput.BackColor = Color.FromArgb(30, 31, 34);
            passInput.BorderStyle = BorderStyle.FixedSingle;
            passInput.Font = new Font("Arial", 12F);
            passInput.ForeColor = Color.White;
            passInput.Location = new Point(65, 282);
            passInput.Margin = new Padding(2);
            passInput.Name = "passInput";
            passInput.Size = new Size(277, 26);
            passInput.TabIndex = 6;
            passInput.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(65, 173);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(133, 18);
            label4.TabIndex = 1;
            label4.Text = "Enter a username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(65, 252);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(77, 18);
            label5.TabIndex = 1;
            label5.Text = "Password";
            // 
            // exitApp
            // 
            exitApp.ActiveLinkColor = Color.CornflowerBlue;
            exitApp.AutoSize = true;
            exitApp.Font = new Font("Arial", 10F);
            exitApp.LinkColor = Color.FromArgb(2, 165, 244);
            exitApp.Location = new Point(154, 398);
            exitApp.Margin = new Padding(2, 0, 2, 0);
            exitApp.Name = "exitApp";
            exitApp.Size = new Size(101, 16);
            exitApp.TabIndex = 8;
            exitApp.TabStop = true;
            exitApp.Text = "Exit Application";
            exitApp.LinkClicked += exitApp_LinkClicked;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.FromArgb(88, 101, 242);
            loginBtn.BackgroundColor = Color.FromArgb(88, 101, 242);
            loginBtn.BorderColor = Color.PaleVioletRed;
            loginBtn.BorderRadius = 5;
            loginBtn.BorderSize = 0;
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(65, 331);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(277, 41);
            loginBtn.TabIndex = 9;
            loginBtn.Text = "Log In";
            loginBtn.TextColor = Color.White;
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 51, 56);
            ClientSize = new Size(403, 484);
            Controls.Add(loginBtn);
            Controls.Add(exitApp);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(userInput);
            Controls.Add(passInput);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox userInput;
        private TextBox passInput;
        private Label label4;
        private Label label5;
        private LinkLabel exitApp;
        private RJControls.RJButton loginBtn;
    }
}
