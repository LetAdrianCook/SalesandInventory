namespace SalesandInventory
{
    partial class PosDashboard
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
            dashPanel = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            lblUsertype = new TextBox();
            lblFullname = new TextBox();
            exitBtn = new Button();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            userBtn = new Button();
            logoutBtn = new Button();
            posBtn = new Button();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dashPanel
            // 
            dashPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            dashPanel.BackColor = Color.White;
            dashPanel.Dock = DockStyle.Fill;
            dashPanel.Location = new Point(216, 56);
            dashPanel.Margin = new Padding(2);
            dashPanel.Name = "dashPanel";
            dashPanel.Size = new Size(968, 635);
            dashPanel.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(309, 0);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(30, 31, 34);
            panel3.Controls.Add(lblUsertype);
            panel3.Controls.Add(lblFullname);
            panel3.Controls.Add(exitBtn);
            panel3.Controls.Add(pictureBox2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(216, 0);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(968, 56);
            panel3.TabIndex = 5;
            // 
            // lblUsertype
            // 
            lblUsertype.BackColor = Color.FromArgb(30, 31, 34);
            lblUsertype.BorderStyle = BorderStyle.None;
            lblUsertype.Enabled = false;
            lblUsertype.Font = new Font("Arial", 10F);
            lblUsertype.ForeColor = Color.White;
            lblUsertype.Location = new Point(679, 29);
            lblUsertype.Name = "lblUsertype";
            lblUsertype.Size = new Size(175, 16);
            lblUsertype.TabIndex = 5;
            lblUsertype.Text = "Jane";
            lblUsertype.TextAlign = HorizontalAlignment.Center;
            // 
            // lblFullname
            // 
            lblFullname.BackColor = Color.FromArgb(30, 31, 34);
            lblFullname.BorderStyle = BorderStyle.None;
            lblFullname.Enabled = false;
            lblFullname.Font = new Font("Arial", 12F);
            lblFullname.ForeColor = Color.White;
            lblFullname.Location = new Point(679, 9);
            lblFullname.Name = "lblFullname";
            lblFullname.Size = new Size(175, 19);
            lblFullname.TabIndex = 6;
            lblFullname.Text = "Jane";
            lblFullname.TextAlign = HorizontalAlignment.Center;
            // 
            // exitBtn
            // 
            exitBtn.FlatAppearance.BorderSize = 0;
            exitBtn.FlatStyle = FlatStyle.Flat;
            exitBtn.ForeColor = SystemColors.Control;
            exitBtn.Image = Properties.Resources.exit;
            exitBtn.Location = new Point(910, 9);
            exitBtn.Margin = new Padding(2);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(43, 38);
            exitBtn.TabIndex = 3;
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.profile2;
            pictureBox2.Location = new Point(859, 9);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 31, 34);
            panel1.Controls.Add(userBtn);
            panel1.Controls.Add(logoutBtn);
            panel1.Controls.Add(posBtn);
            panel1.Controls.Add(panelLogo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(216, 691);
            panel1.TabIndex = 4;
            // 
            // userBtn
            // 
            userBtn.Dock = DockStyle.Top;
            userBtn.FlatAppearance.BorderSize = 0;
            userBtn.FlatStyle = FlatStyle.Flat;
            userBtn.Font = new Font("Arial", 12F, FontStyle.Bold);
            userBtn.ForeColor = Color.White;
            userBtn.Image = Properties.Resources.edit;
            userBtn.ImageAlign = ContentAlignment.MiddleLeft;
            userBtn.Location = new Point(0, 204);
            userBtn.Margin = new Padding(2);
            userBtn.Name = "userBtn";
            userBtn.Padding = new Padding(14, 0, 0, 0);
            userBtn.Size = new Size(216, 84);
            userBtn.TabIndex = 5;
            userBtn.Text = "      User Profile";
            userBtn.TextAlign = ContentAlignment.MiddleLeft;
            userBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            userBtn.UseVisualStyleBackColor = true;
            userBtn.Click += userBtn_Click;
            // 
            // logoutBtn
            // 
            logoutBtn.Dock = DockStyle.Bottom;
            logoutBtn.FlatAppearance.BorderSize = 0;
            logoutBtn.FlatStyle = FlatStyle.Flat;
            logoutBtn.Font = new Font("Arial", 12F, FontStyle.Bold);
            logoutBtn.ForeColor = Color.White;
            logoutBtn.Image = Properties.Resources.logout;
            logoutBtn.ImageAlign = ContentAlignment.MiddleLeft;
            logoutBtn.Location = new Point(0, 641);
            logoutBtn.Margin = new Padding(2);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Padding = new Padding(14, 0, 0, 0);
            logoutBtn.Size = new Size(216, 50);
            logoutBtn.TabIndex = 4;
            logoutBtn.Text = "          Logout";
            logoutBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            logoutBtn.UseVisualStyleBackColor = true;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // posBtn
            // 
            posBtn.Dock = DockStyle.Top;
            posBtn.FlatAppearance.BorderSize = 0;
            posBtn.FlatStyle = FlatStyle.Flat;
            posBtn.Font = new Font("Arial", 12F, FontStyle.Bold);
            posBtn.ForeColor = Color.White;
            posBtn.Image = Properties.Resources.cashier1;
            posBtn.ImageAlign = ContentAlignment.MiddleLeft;
            posBtn.Location = new Point(0, 120);
            posBtn.Margin = new Padding(2);
            posBtn.Name = "posBtn";
            posBtn.Padding = new Padding(14, 0, 0, 0);
            posBtn.Size = new Size(216, 84);
            posBtn.TabIndex = 1;
            posBtn.Text = "       Invex POS";
            posBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            posBtn.UseVisualStyleBackColor = true;
            posBtn.Click += posBtn_Click;
            // 
            // panelLogo
            // 
            panelLogo.AutoSize = true;
            panelLogo.BackColor = Color.FromArgb(30, 31, 34);
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(2);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(216, 120);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(30, 31, 34);
            pictureBox1.Image = Properties.Resources.invexlogo_removebg_preview;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(216, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // PosDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 691);
            Controls.Add(dashPanel);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PosDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PosDashboard";
            Load += PosDashboard_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel dashPanel;
        private Label label2;
        private Panel panel3;
        private Button exitBtn;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Button userBtn;
        private Button logoutBtn;
        private Button posBtn;
        private Panel panelLogo;
        private PictureBox pictureBox1;
        private TextBox lblUsertype;
        private TextBox lblFullname;
    }
}