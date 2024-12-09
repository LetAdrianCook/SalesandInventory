namespace SalesandInventory.UserControls
{
    partial class CreateUserWindow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateUserWindow));
            groupBox4 = new GroupBox();
            createUser = new RJControls.RJButton();
            groupBox8 = new GroupBox();
            crePassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            creUsername = new TextBox();
            groupBox3 = new GroupBox();
            creLastName = new TextBox();
            creMiddleName = new TextBox();
            label9 = new Label();
            label3 = new Label();
            label8 = new Label();
            creFirstname = new TextBox();
            groupBox1 = new GroupBox();
            invType = new RadioButton();
            salesType = new RadioButton();
            userGridView = new DataGridView();
            groupBox5 = new GroupBox();
            activateBtn = new RJControls.RJButton();
            updateBtn = new RJControls.RJButton();
            groupBox2 = new GroupBox();
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            updateLastNameTxt = new TextBox();
            updateMiddleNameTxt = new TextBox();
            updateFirstNameTxt = new TextBox();
            pictureBox7 = new PictureBox();
            textBox4 = new TextBox();
            columnFilterCbx = new ComboBox();
            searchBarTxt = new TextBox();
            pictureBox13 = new PictureBox();
            groupBox4.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userGridView).BeginInit();
            groupBox5.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            SuspendLayout();
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.White;
            groupBox4.Controls.Add(createUser);
            groupBox4.Controls.Add(groupBox8);
            groupBox4.Controls.Add(groupBox3);
            groupBox4.Controls.Add(groupBox1);
            groupBox4.Location = new Point(12, 13);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(502, 394);
            groupBox4.TabIndex = 13;
            groupBox4.TabStop = false;
            // 
            // createUser
            // 
            createUser.BackColor = Color.MediumSpringGreen;
            createUser.BackgroundColor = Color.MediumSpringGreen;
            createUser.BorderColor = Color.PaleVioletRed;
            createUser.BorderRadius = 10;
            createUser.BorderSize = 0;
            createUser.FlatAppearance.BorderSize = 0;
            createUser.FlatStyle = FlatStyle.Flat;
            createUser.Font = new Font("Arial", 10F);
            createUser.ForeColor = Color.Black;
            createUser.Location = new Point(22, 345);
            createUser.Name = "createUser";
            createUser.Size = new Size(461, 30);
            createUser.TabIndex = 37;
            createUser.Text = "Add";
            createUser.TextColor = Color.Black;
            createUser.UseVisualStyleBackColor = false;
            createUser.Click += createUser_Click;
            // 
            // groupBox8
            // 
            groupBox8.BackColor = Color.White;
            groupBox8.Controls.Add(crePassword);
            groupBox8.Controls.Add(label1);
            groupBox8.Controls.Add(label2);
            groupBox8.Controls.Add(creUsername);
            groupBox8.Font = new Font("Arial", 12.75F, FontStyle.Bold);
            groupBox8.Location = new Point(22, 14);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(287, 135);
            groupBox8.TabIndex = 12;
            groupBox8.TabStop = false;
            groupBox8.Text = "Account Information";
            // 
            // crePassword
            // 
            crePassword.BorderStyle = BorderStyle.FixedSingle;
            crePassword.Font = new Font("Arial", 10F);
            crePassword.Location = new Point(103, 84);
            crePassword.Name = "crePassword";
            crePassword.Size = new Size(178, 23);
            crePassword.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10F);
            label1.Location = new Point(22, 50);
            label1.Name = "label1";
            label1.Size = new Size(75, 16);
            label1.TabIndex = 2;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10F);
            label2.Location = new Point(22, 91);
            label2.Name = "label2";
            label2.Size = new Size(72, 16);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // creUsername
            // 
            creUsername.BorderStyle = BorderStyle.FixedSingle;
            creUsername.Font = new Font("Arial", 10F);
            creUsername.Location = new Point(103, 40);
            creUsername.Name = "creUsername";
            creUsername.Size = new Size(178, 23);
            creUsername.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(creLastName);
            groupBox3.Controls.Add(creMiddleName);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(creFirstname);
            groupBox3.Font = new Font("Arial", 12.75F, FontStyle.Bold);
            groupBox3.Location = new Point(22, 170);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(461, 162);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Personal Information";
            // 
            // creLastName
            // 
            creLastName.BorderStyle = BorderStyle.FixedSingle;
            creLastName.Font = new Font("Arial", 10F);
            creLastName.Location = new Point(149, 110);
            creLastName.Name = "creLastName";
            creLastName.Size = new Size(184, 23);
            creLastName.TabIndex = 36;
            // 
            // creMiddleName
            // 
            creMiddleName.BorderStyle = BorderStyle.FixedSingle;
            creMiddleName.Font = new Font("Arial", 10F);
            creMiddleName.Location = new Point(149, 69);
            creMiddleName.Name = "creMiddleName";
            creMiddleName.Size = new Size(184, 23);
            creMiddleName.TabIndex = 35;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 10F);
            label9.Location = new Point(20, 41);
            label9.Name = "label9";
            label9.Size = new Size(79, 16);
            label9.TabIndex = 2;
            label9.Text = "First Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10F);
            label3.Location = new Point(20, 118);
            label3.Name = "label3";
            label3.Size = new Size(78, 16);
            label3.TabIndex = 2;
            label3.Text = "Last Name:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 10F);
            label8.Location = new Point(20, 82);
            label8.Name = "label8";
            label8.Size = new Size(92, 16);
            label8.TabIndex = 2;
            label8.Text = "Middle Name:";
            // 
            // creFirstname
            // 
            creFirstname.BorderStyle = BorderStyle.FixedSingle;
            creFirstname.Font = new Font("Arial", 10F);
            creFirstname.Location = new Point(149, 28);
            creFirstname.Name = "creFirstname";
            creFirstname.Size = new Size(184, 23);
            creFirstname.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(invType);
            groupBox1.Controls.Add(salesType);
            groupBox1.Font = new Font("Arial", 12.75F, FontStyle.Bold);
            groupBox1.Location = new Point(324, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 3);
            groupBox1.Size = new Size(159, 135);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "User Type";
            // 
            // invType
            // 
            invType.AutoSize = true;
            invType.Font = new Font("Arial", 10F);
            invType.Location = new Point(20, 77);
            invType.Name = "invType";
            invType.Size = new Size(83, 20);
            invType.TabIndex = 5;
            invType.TabStop = true;
            invType.Text = "Inventory";
            invType.UseVisualStyleBackColor = true;
            // 
            // salesType
            // 
            salesType.AutoSize = true;
            salesType.Font = new Font("Arial", 10F);
            salesType.Location = new Point(20, 37);
            salesType.Name = "salesType";
            salesType.Size = new Size(60, 20);
            salesType.TabIndex = 5;
            salesType.TabStop = true;
            salesType.Text = "Sales";
            salesType.UseVisualStyleBackColor = true;
            // 
            // userGridView
            // 
            userGridView.AllowUserToAddRows = false;
            userGridView.AllowUserToDeleteRows = false;
            userGridView.BackgroundColor = Color.White;
            userGridView.BorderStyle = BorderStyle.Fixed3D;
            userGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userGridView.Location = new Point(520, 43);
            userGridView.Name = "userGridView";
            userGridView.ReadOnly = true;
            userGridView.RowHeadersWidth = 62;
            userGridView.RowTemplate.DefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userGridView.Size = new Size(435, 583);
            userGridView.TabIndex = 14;
            userGridView.CellClick += userGridView_CellClick;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.White;
            groupBox5.Controls.Add(activateBtn);
            groupBox5.Controls.Add(updateBtn);
            groupBox5.Controls.Add(groupBox2);
            groupBox5.Controls.Add(pictureBox7);
            groupBox5.Controls.Add(textBox4);
            groupBox5.Location = new Point(12, 413);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(502, 213);
            groupBox5.TabIndex = 14;
            groupBox5.TabStop = false;
            // 
            // activateBtn
            // 
            activateBtn.BackColor = Color.MediumSpringGreen;
            activateBtn.BackgroundColor = Color.MediumSpringGreen;
            activateBtn.BorderColor = Color.PaleVioletRed;
            activateBtn.BorderRadius = 10;
            activateBtn.BorderSize = 0;
            activateBtn.FlatAppearance.BorderSize = 0;
            activateBtn.FlatStyle = FlatStyle.Flat;
            activateBtn.Font = new Font("Arial", 10F);
            activateBtn.ForeColor = Color.White;
            activateBtn.Location = new Point(250, 173);
            activateBtn.Name = "activateBtn";
            activateBtn.Size = new Size(233, 30);
            activateBtn.TabIndex = 35;
            activateBtn.Text = "Activate";
            activateBtn.TextColor = Color.White;
            activateBtn.UseVisualStyleBackColor = false;
            activateBtn.Click += activateBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.RoyalBlue;
            updateBtn.BackgroundColor = Color.RoyalBlue;
            updateBtn.BorderColor = Color.PaleVioletRed;
            updateBtn.BorderRadius = 10;
            updateBtn.BorderSize = 0;
            updateBtn.FlatAppearance.BorderSize = 0;
            updateBtn.FlatStyle = FlatStyle.Flat;
            updateBtn.Font = new Font("Arial", 10F);
            updateBtn.ForeColor = Color.White;
            updateBtn.Location = new Point(22, 173);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(222, 30);
            updateBtn.TabIndex = 35;
            updateBtn.Text = "Update";
            updateBtn.TextColor = Color.White;
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(updateLastNameTxt);
            groupBox2.Controls.Add(updateMiddleNameTxt);
            groupBox2.Controls.Add(updateFirstNameTxt);
            groupBox2.Font = new Font("Arial", 12.75F, FontStyle.Bold);
            groupBox2.Location = new Point(22, 20);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(461, 147);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Update Information";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10F);
            label7.Location = new Point(20, 118);
            label7.Name = "label7";
            label7.Size = new Size(78, 16);
            label7.TabIndex = 3;
            label7.Text = "Last Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10F);
            label5.Location = new Point(20, 77);
            label5.Name = "label5";
            label5.Size = new Size(92, 16);
            label5.TabIndex = 2;
            label5.Text = "Middle Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10F);
            label6.Location = new Point(20, 36);
            label6.Name = "label6";
            label6.Size = new Size(79, 16);
            label6.TabIndex = 2;
            label6.Text = "First Name:";
            // 
            // updateLastNameTxt
            // 
            updateLastNameTxt.BorderStyle = BorderStyle.FixedSingle;
            updateLastNameTxt.Font = new Font("Arial", 13F);
            updateLastNameTxt.Location = new Point(149, 110);
            updateLastNameTxt.Multiline = true;
            updateLastNameTxt.Name = "updateLastNameTxt";
            updateLastNameTxt.Size = new Size(184, 26);
            updateLastNameTxt.TabIndex = 1;
            // 
            // updateMiddleNameTxt
            // 
            updateMiddleNameTxt.BorderStyle = BorderStyle.FixedSingle;
            updateMiddleNameTxt.Font = new Font("Arial", 13F);
            updateMiddleNameTxt.Location = new Point(149, 69);
            updateMiddleNameTxt.Multiline = true;
            updateMiddleNameTxt.Name = "updateMiddleNameTxt";
            updateMiddleNameTxt.Size = new Size(184, 26);
            updateMiddleNameTxt.TabIndex = 1;
            // 
            // updateFirstNameTxt
            // 
            updateFirstNameTxt.BorderStyle = BorderStyle.FixedSingle;
            updateFirstNameTxt.Font = new Font("Arial", 13F);
            updateFirstNameTxt.Location = new Point(149, 28);
            updateFirstNameTxt.Multiline = true;
            updateFirstNameTxt.Name = "updateFirstNameTxt";
            updateFirstNameTxt.Size = new Size(184, 26);
            updateFirstNameTxt.TabIndex = 1;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.icons8_user_30;
            pictureBox7.Location = new Point(38, 316);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(42, 27);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 16;
            pictureBox7.TabStop = false;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Arial", 11F);
            textBox4.Location = new Point(80, 311);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "ID Number";
            textBox4.Size = new Size(179, 17);
            textBox4.TabIndex = 15;
            // 
            // columnFilterCbx
            // 
            columnFilterCbx.DropDownStyle = ComboBoxStyle.DropDownList;
            columnFilterCbx.Font = new Font("Arial", 10F);
            columnFilterCbx.FormattingEnabled = true;
            columnFilterCbx.Items.AddRange(new object[] { "userID", "userName", "userType", "firstName", "middleName", "lastName", "status" });
            columnFilterCbx.Location = new Point(813, 9);
            columnFilterCbx.Name = "columnFilterCbx";
            columnFilterCbx.Size = new Size(142, 24);
            columnFilterCbx.TabIndex = 44;
            // 
            // searchBarTxt
            // 
            searchBarTxt.BorderStyle = BorderStyle.FixedSingle;
            searchBarTxt.Font = new Font("Arial", 13F);
            searchBarTxt.Location = new Point(564, 13);
            searchBarTxt.Multiline = true;
            searchBarTxt.Name = "searchBarTxt";
            searchBarTxt.Size = new Size(233, 20);
            searchBarTxt.TabIndex = 42;
            // 
            // pictureBox13
            // 
            pictureBox13.BackColor = Color.Transparent;
            pictureBox13.Image = (Image)resources.GetObject("pictureBox13.Image");
            pictureBox13.Location = new Point(520, 13);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(28, 24);
            pictureBox13.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox13.TabIndex = 41;
            pictureBox13.TabStop = false;
            // 
            // CreateUserWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(columnFilterCbx);
            Controls.Add(groupBox5);
            Controls.Add(userGridView);
            Controls.Add(groupBox4);
            Controls.Add(pictureBox13);
            Controls.Add(searchBarTxt);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "CreateUserWindow";
            Size = new Size(968, 635);
            Load += CreateUserWindow_Load;
            groupBox4.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userGridView).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox4;
        private Button createUserbtn;
        private GroupBox groupBox3;
        private TextBox creFirstname;
        private GroupBox groupBox1;
        private RadioButton invType;
        private RadioButton salesType;
        private TextBox crePassword;
        private DataGridView userGridView;
        private GroupBox groupBox5;
        private GroupBox groupBox8;
        private PictureBox pictureBox7;
        private TextBox textBox4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox creLastName;
        private TextBox creMiddleName;
        private TextBox creUsername;
       // private RJControls.RJButton createUserbtn;
        private RJControls.RJButton updateBtn;
        private TextBox updateLastNameTxt;
        private TextBox updateMiddleNameTxt;
        private TextBox updateFirstNameTxt;
        private RJControls.RJButton createUser;
        private Label label9;
        private Label label8;
        private ComboBox columnFilterCbx;
        private TextBox searchBarTxt;
        private PictureBox pictureBox13;
        private RJControls.RJButton activateBtn;
    }
}
