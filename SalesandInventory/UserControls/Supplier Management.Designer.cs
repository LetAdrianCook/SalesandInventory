using SalesandInventory.RJControls;

namespace SalesandInventory.UserControls
{
    partial class Supplier_Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supplier_Management));
            supplierGridView = new DataGridView();
            pictureBox13 = new PictureBox();
            searchBarTxt = new TextBox();
            panel2 = new Panel();
            createSupplier = new RJButton();
            creEmail = new TextBox();
            creSupplierName = new TextBox();
            creContact = new TextBox();
            label10 = new Label();
            label1 = new Label();
            label18 = new Label();
            label11 = new Label();
            label12 = new Label();
            panel1 = new Panel();
            removeBtn = new RJButton();
            updateBtn = new RJButton();
            updateEmail = new TextBox();
            updateSupplierName = new TextBox();
            updateContact = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            columnFilterCbx = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)supplierGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // supplierGridView
            // 
            supplierGridView.AllowUserToAddRows = false;
            supplierGridView.AllowUserToDeleteRows = false;
            supplierGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            supplierGridView.BackgroundColor = Color.White;
            supplierGridView.BorderStyle = BorderStyle.Fixed3D;
            supplierGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            supplierGridView.Location = new Point(35, 52);
            supplierGridView.Margin = new Padding(2);
            supplierGridView.Name = "supplierGridView";
            supplierGridView.ReadOnly = true;
            supplierGridView.RowHeadersWidth = 62;
            supplierGridView.Size = new Size(906, 363);
            supplierGridView.TabIndex = 2;
            supplierGridView.CellClick += supplierGridView_CellClick;
            // 
            // pictureBox13
            // 
            pictureBox13.BackColor = Color.Transparent;
            pictureBox13.Image = (Image)resources.GetObject("pictureBox13.Image");
            pictureBox13.Location = new Point(35, 19);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(28, 24);
            pictureBox13.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox13.TabIndex = 38;
            pictureBox13.TabStop = false;
            // 
            // searchBarTxt
            // 
            searchBarTxt.BackColor = Color.White;
            searchBarTxt.BorderStyle = BorderStyle.FixedSingle;
            searchBarTxt.Font = new Font("Arial", 13F);
            searchBarTxt.ForeColor = Color.Black;
            searchBarTxt.Location = new Point(86, 23);
            searchBarTxt.Multiline = true;
            searchBarTxt.Name = "searchBarTxt";
            searchBarTxt.Size = new Size(319, 20);
            searchBarTxt.TabIndex = 39;
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(createSupplier);
            panel2.Controls.Add(creEmail);
            panel2.Controls.Add(creSupplierName);
            panel2.Controls.Add(creContact);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label12);
            panel2.Location = new Point(35, 421);
            panel2.Name = "panel2";
            panel2.Size = new Size(449, 205);
            panel2.TabIndex = 42;
            // 
            // createSupplier
            // 
            createSupplier.BackColor = Color.FromArgb(35, 165, 90);
            createSupplier.BackgroundColor = Color.FromArgb(35, 165, 90);
            createSupplier.BorderColor = Color.PaleVioletRed;
            createSupplier.BorderRadius = 5;
            createSupplier.BorderSize = 0;
            createSupplier.FlatAppearance.BorderSize = 0;
            createSupplier.FlatStyle = FlatStyle.Flat;
            createSupplier.Font = new Font("Arial", 10F);
            createSupplier.ForeColor = Color.White;
            createSupplier.Location = new Point(20, 165);
            createSupplier.Name = "createSupplier";
            createSupplier.Size = new Size(407, 25);
            createSupplier.TabIndex = 38;
            createSupplier.Text = "Add";
            createSupplier.TextColor = Color.White;
            createSupplier.UseVisualStyleBackColor = false;
            createSupplier.Click += createSupplier_Click;
            // 
            // creEmail
            // 
            creEmail.BackColor = Color.White;
            creEmail.BorderStyle = BorderStyle.FixedSingle;
            creEmail.Font = new Font("Arial", 10F);
            creEmail.ForeColor = Color.Black;
            creEmail.Location = new Point(216, 120);
            creEmail.Multiline = true;
            creEmail.Name = "creEmail";
            creEmail.Size = new Size(134, 25);
            creEmail.TabIndex = 29;
            // 
            // creSupplierName
            // 
            creSupplierName.BackColor = Color.White;
            creSupplierName.BorderStyle = BorderStyle.FixedSingle;
            creSupplierName.Font = new Font("Arial", 10F);
            creSupplierName.ForeColor = Color.Black;
            creSupplierName.Location = new Point(216, 40);
            creSupplierName.Multiline = true;
            creSupplierName.Name = "creSupplierName";
            creSupplierName.Size = new Size(134, 25);
            creSupplierName.TabIndex = 27;
            // 
            // creContact
            // 
            creContact.BackColor = Color.White;
            creContact.BorderStyle = BorderStyle.FixedSingle;
            creContact.Font = new Font("Arial", 10F);
            creContact.ForeColor = Color.Black;
            creContact.Location = new Point(216, 82);
            creContact.Multiline = true;
            creContact.Name = "creContact";
            creContact.Size = new Size(134, 25);
            creContact.TabIndex = 27;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 10F);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(103, 129);
            label10.Name = "label10";
            label10.Size = new Size(49, 16);
            label10.TabIndex = 1;
            label10.Text = "Email :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(103, 87);
            label1.Name = "label1";
            label1.Size = new Size(76, 16);
            label1.TabIndex = 1;
            label1.Text = "Contact # :";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial", 10F);
            label18.ForeColor = Color.Black;
            label18.Location = new Point(103, 45);
            label18.Name = "label18";
            label18.Size = new Size(107, 16);
            label18.TabIndex = 1;
            label18.Text = "Supplier Name :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 10F);
            label11.Location = new Point(20, 93);
            label11.Name = "label11";
            label11.Size = new Size(0, 16);
            label11.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(169, 11);
            label12.Name = "label12";
            label12.Size = new Size(131, 19);
            label12.TabIndex = 0;
            label12.Text = "ADD SUPPLIER";
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(removeBtn);
            panel1.Controls.Add(updateBtn);
            panel1.Controls.Add(updateEmail);
            panel1.Controls.Add(updateSupplierName);
            panel1.Controls.Add(updateContact);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(490, 421);
            panel1.Name = "panel1";
            panel1.Size = new Size(449, 205);
            panel1.TabIndex = 43;
            // 
            // removeBtn
            // 
            removeBtn.BackColor = Color.FromArgb(218, 55, 60);
            removeBtn.BackgroundColor = Color.FromArgb(218, 55, 60);
            removeBtn.BorderColor = Color.PaleVioletRed;
            removeBtn.BorderRadius = 5;
            removeBtn.BorderSize = 0;
            removeBtn.FlatAppearance.BorderSize = 0;
            removeBtn.FlatStyle = FlatStyle.Flat;
            removeBtn.Font = new Font("Arial", 10F);
            removeBtn.ForeColor = Color.White;
            removeBtn.Location = new Point(238, 165);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(199, 25);
            removeBtn.TabIndex = 39;
            removeBtn.Text = "Remove";
            removeBtn.TextColor = Color.White;
            removeBtn.UseVisualStyleBackColor = false;
            removeBtn.Click += removeBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.FromArgb(88, 101, 242);
            updateBtn.BackgroundColor = Color.FromArgb(88, 101, 242);
            updateBtn.BorderColor = Color.PaleVioletRed;
            updateBtn.BorderRadius = 5;
            updateBtn.BorderSize = 0;
            updateBtn.FlatAppearance.BorderSize = 0;
            updateBtn.FlatStyle = FlatStyle.Flat;
            updateBtn.Font = new Font("Arial", 10F);
            updateBtn.ForeColor = Color.White;
            updateBtn.Location = new Point(21, 165);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(199, 25);
            updateBtn.TabIndex = 38;
            updateBtn.Text = "Update";
            updateBtn.TextColor = Color.White;
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // updateEmail
            // 
            updateEmail.BackColor = Color.White;
            updateEmail.BorderStyle = BorderStyle.FixedSingle;
            updateEmail.Font = new Font("Arial", 10F);
            updateEmail.ForeColor = Color.Black;
            updateEmail.Location = new Point(216, 118);
            updateEmail.Multiline = true;
            updateEmail.Name = "updateEmail";
            updateEmail.Size = new Size(134, 25);
            updateEmail.TabIndex = 29;
            // 
            // updateSupplierName
            // 
            updateSupplierName.BackColor = Color.White;
            updateSupplierName.BorderStyle = BorderStyle.FixedSingle;
            updateSupplierName.Font = new Font("Arial", 10F);
            updateSupplierName.ForeColor = Color.Black;
            updateSupplierName.Location = new Point(216, 38);
            updateSupplierName.Multiline = true;
            updateSupplierName.Name = "updateSupplierName";
            updateSupplierName.Size = new Size(134, 25);
            updateSupplierName.TabIndex = 27;
            // 
            // updateContact
            // 
            updateContact.BackColor = Color.White;
            updateContact.BorderStyle = BorderStyle.FixedSingle;
            updateContact.Font = new Font("Arial", 10F);
            updateContact.ForeColor = Color.Black;
            updateContact.Location = new Point(216, 80);
            updateContact.Multiline = true;
            updateContact.Name = "updateContact";
            updateContact.Size = new Size(134, 25);
            updateContact.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(103, 127);
            label2.Name = "label2";
            label2.Size = new Size(49, 16);
            label2.TabIndex = 1;
            label2.Text = "Email :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(103, 85);
            label3.Name = "label3";
            label3.Size = new Size(76, 16);
            label3.TabIndex = 1;
            label3.Text = "Contact # :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(103, 43);
            label4.Name = "label4";
            label4.Size = new Size(107, 16);
            label4.TabIndex = 1;
            label4.Text = "Supplier Name :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(167, 11);
            label6.Name = "label6";
            label6.Size = new Size(135, 19);
            label6.TabIndex = 0;
            label6.Text = "SUPPLIER INFO";
            // 
            // columnFilterCbx
            // 
            columnFilterCbx.BackColor = Color.White;
            columnFilterCbx.DropDownStyle = ComboBoxStyle.DropDownList;
            columnFilterCbx.Font = new Font("Arial", 10F);
            columnFilterCbx.ForeColor = Color.Black;
            columnFilterCbx.FormattingEnabled = true;
            columnFilterCbx.Items.AddRange(new object[] { "supplierID", "supplierName", "contactNo", "email", "dateCreated" });
            columnFilterCbx.Location = new Point(420, 19);
            columnFilterCbx.Name = "columnFilterCbx";
            columnFilterCbx.Size = new Size(153, 24);
            columnFilterCbx.TabIndex = 44;
            // 
            // Supplier_Management
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(columnFilterCbx);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(searchBarTxt);
            Controls.Add(pictureBox13);
            Controls.Add(supplierGridView);
            Name = "Supplier_Management";
            Size = new Size(968, 635);
            Load += Supplier_Management_Load;
            ((System.ComponentModel.ISupportInitialize)supplierGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView supplierGridView;
        private PictureBox pictureBox13;
        private TextBox searchBarTxt;
        private RJControls.RJButton rjButton3;
        private Panel panel2;
        private RJButton createSupplier;
        private RJControls.RJButton rjButton4;
        private TextBox textBox7;
        private TextBox textBox13;
        private TextBox textBox9;
        private Label label10;
        private Label label18;
        private Label label11;
        private Label label12;
        private Label label1;
        private Panel panel1;
        private RJControls.RJButton updateBtn;
        private TextBox updateEmail;
        private TextBox updateSupplierName;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox updateContact;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private RJControls.RJButton removeBtn;
        private ComboBox columnFilterCbx;
        private DataGridView supplierItemGridView;
        private TextBox creEmail;
        private TextBox creSupplierName;
        private TextBox creContact;
    }
}
