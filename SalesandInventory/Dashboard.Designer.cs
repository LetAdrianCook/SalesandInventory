namespace SalesandInventory
{
    partial class Dashboard
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
            panel1 = new Panel();
            reportBtn = new Button();
            supplierBtn = new Button();
            createBtn = new Button();
            logoutBtn = new Button();
            inventoryBtn = new Button();
            dbBtn = new Button();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            lblUsertype = new TextBox();
            lblFullname = new TextBox();
            exitBtn = new Button();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            dashPanel = new Panel();
            panel1.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 31, 34);
            panel1.Controls.Add(reportBtn);
            panel1.Controls.Add(supplierBtn);
            panel1.Controls.Add(createBtn);
            panel1.Controls.Add(logoutBtn);
            panel1.Controls.Add(inventoryBtn);
            panel1.Controls.Add(dbBtn);
            panel1.Controls.Add(panelLogo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(216, 691);
            panel1.TabIndex = 0;
            // 
            // reportBtn
            // 
            reportBtn.Dock = DockStyle.Top;
            reportBtn.FlatAppearance.BorderSize = 0;
            reportBtn.FlatStyle = FlatStyle.Flat;
            reportBtn.Font = new Font("Arial", 12F, FontStyle.Bold);
            reportBtn.ForeColor = Color.White;
            reportBtn.Image = Properties.Resources.report;
            reportBtn.ImageAlign = ContentAlignment.MiddleLeft;
            reportBtn.Location = new Point(0, 454);
            reportBtn.Margin = new Padding(2);
            reportBtn.Name = "reportBtn";
            reportBtn.Padding = new Padding(14, 0, 0, 0);
            reportBtn.Size = new Size(216, 84);
            reportBtn.TabIndex = 7;
            reportBtn.Text = "          Report";
            reportBtn.TextAlign = ContentAlignment.MiddleLeft;
            reportBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            reportBtn.UseVisualStyleBackColor = true;
            reportBtn.Click += reportBtn_Click;
            // 
            // supplierBtn
            // 
            supplierBtn.Dock = DockStyle.Top;
            supplierBtn.FlatAppearance.BorderSize = 0;
            supplierBtn.FlatStyle = FlatStyle.Flat;
            supplierBtn.Font = new Font("Arial", 12F, FontStyle.Bold);
            supplierBtn.ForeColor = Color.White;
            supplierBtn.Image = Properties.Resources.supplier;
            supplierBtn.ImageAlign = ContentAlignment.MiddleLeft;
            supplierBtn.Location = new Point(0, 370);
            supplierBtn.Margin = new Padding(2);
            supplierBtn.Name = "supplierBtn";
            supplierBtn.Padding = new Padding(14, 0, 0, 0);
            supplierBtn.Size = new Size(216, 84);
            supplierBtn.TabIndex = 6;
            supplierBtn.Text = "         Supplier";
            supplierBtn.TextAlign = ContentAlignment.MiddleLeft;
            supplierBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            supplierBtn.UseVisualStyleBackColor = true;
            supplierBtn.Click += supplierBtn_Click;
            // 
            // createBtn
            // 
            createBtn.BackgroundImageLayout = ImageLayout.Zoom;
            createBtn.Dock = DockStyle.Top;
            createBtn.FlatAppearance.BorderSize = 0;
            createBtn.FlatStyle = FlatStyle.Flat;
            createBtn.Font = new Font("Arial", 12F, FontStyle.Bold);
            createBtn.ForeColor = Color.White;
            createBtn.Image = Properties.Resources.useradd;
            createBtn.ImageAlign = ContentAlignment.MiddleLeft;
            createBtn.Location = new Point(0, 286);
            createBtn.Margin = new Padding(2);
            createBtn.Name = "createBtn";
            createBtn.Padding = new Padding(14, 0, 0, 0);
            createBtn.Size = new Size(216, 84);
            createBtn.TabIndex = 5;
            createBtn.Text = "   User Management";
            createBtn.TextAlign = ContentAlignment.MiddleLeft;
            createBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            createBtn.UseVisualStyleBackColor = true;
            createBtn.Click += createBtn_Click_1;
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
            // inventoryBtn
            // 
            inventoryBtn.Dock = DockStyle.Top;
            inventoryBtn.FlatAppearance.BorderSize = 0;
            inventoryBtn.FlatStyle = FlatStyle.Flat;
            inventoryBtn.Font = new Font("Arial", 12F, FontStyle.Bold);
            inventoryBtn.ForeColor = Color.White;
            inventoryBtn.Image = Properties.Resources.inventory1;
            inventoryBtn.ImageAlign = ContentAlignment.MiddleLeft;
            inventoryBtn.Location = new Point(0, 202);
            inventoryBtn.Margin = new Padding(2);
            inventoryBtn.Name = "inventoryBtn";
            inventoryBtn.Padding = new Padding(14, 0, 0, 0);
            inventoryBtn.Size = new Size(216, 84);
            inventoryBtn.TabIndex = 2;
            inventoryBtn.Text = "       Inventory";
            inventoryBtn.TextAlign = ContentAlignment.MiddleLeft;
            inventoryBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            inventoryBtn.UseVisualStyleBackColor = true;
            inventoryBtn.Click += inventoryBtn_Click;
            // 
            // dbBtn
            // 
            dbBtn.Dock = DockStyle.Top;
            dbBtn.FlatAppearance.BorderSize = 0;
            dbBtn.FlatStyle = FlatStyle.Flat;
            dbBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dbBtn.ForeColor = Color.White;
            dbBtn.Image = Properties.Resources.dashboard;
            dbBtn.ImageAlign = ContentAlignment.MiddleLeft;
            dbBtn.Location = new Point(0, 118);
            dbBtn.Margin = new Padding(2);
            dbBtn.Name = "dbBtn";
            dbBtn.Padding = new Padding(14, 0, 0, 0);
            dbBtn.Size = new Size(216, 84);
            dbBtn.TabIndex = 1;
            dbBtn.Text = "       Dashboard";
            dbBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            dbBtn.UseVisualStyleBackColor = true;
            dbBtn.Click += dbBtn_Click;
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
            panelLogo.Size = new Size(216, 118);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(30, 31, 34);
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.invexlogo_removebg_preview;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(216, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
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
            panel3.TabIndex = 1;
            // 
            // lblUsertype
            // 
            lblUsertype.BackColor = Color.FromArgb(30, 31, 34);
            lblUsertype.BorderStyle = BorderStyle.None;
            lblUsertype.Enabled = false;
            lblUsertype.Font = new Font("Arial", 10F);
            lblUsertype.ForeColor = Color.White;
            lblUsertype.Location = new Point(679, 32);
            lblUsertype.Name = "lblUsertype";
            lblUsertype.Size = new Size(175, 16);
            lblUsertype.TabIndex = 4;
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
            lblFullname.Location = new Point(679, 12);
            lblFullname.Name = "lblFullname";
            lblFullname.Size = new Size(175, 19);
            lblFullname.TabIndex = 4;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(309, 0);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 2;
            // 
            // dashPanel
            // 
            dashPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            dashPanel.BackColor = SystemColors.Control;
            dashPanel.Dock = DockStyle.Fill;
            dashPanel.Location = new Point(216, 56);
            dashPanel.Margin = new Padding(2);
            dashPanel.Name = "dashPanel";
            dashPanel.Size = new Size(968, 635);
            dashPanel.TabIndex = 3;
            dashPanel.Paint += dashPanel_Paint;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1184, 691);
            Controls.Add(dashPanel);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button dbBtn;
        private Panel panelLogo;
        private Button logoutBtn;
        private Button inventoryBtn;
        private Panel panel3;
        private Label label2;
        private Panel dashPanel;
        private Button exitBtn;
        private Button createBtn;
        private Button reportBtn;
        private Button supplierBtn;
        private TextBox lblUsertype;
        private TextBox lblFullname;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}