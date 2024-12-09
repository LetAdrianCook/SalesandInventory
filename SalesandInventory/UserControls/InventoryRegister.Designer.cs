namespace Sales_Inv
{
    partial class InventoryRegister
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryRegister));
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            supplierCbx = new ComboBox();
            addProductBtn = new SalesandInventory.RJControls.RJButton();
            sellingPriceTxt = new TextBox();
            unitCostTxt = new TextBox();
            quantityTxt = new TextBox();
            modelTxt = new TextBox();
            productNameTxt = new TextBox();
            brandTxt = new TextBox();
            productTypeCbx = new ComboBox();
            label9 = new Label();
            label16 = new Label();
            label19 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            inventoryGridView = new DataGridView();
            pictureBox13 = new PictureBox();
            searchBarTxt = new TextBox();
            panel2 = new Panel();
            resetBtn = new SalesandInventory.RJControls.RJButton();
            functionalBtn = new SalesandInventory.RJControls.RJButton();
            defectiveBtn = new SalesandInventory.RJControls.RJButton();
            updateBtn = new SalesandInventory.RJControls.RJButton();
            label12 = new Label();
            maxQuantityTxt = new TextBox();
            productIDtxt = new TextBox();
            label4 = new Label();
            label1 = new Label();
            columnFilterCbx = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)inventoryGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(37, 147);
            label2.Name = "label2";
            label2.Size = new Size(99, 16);
            label2.TabIndex = 1;
            label2.Text = "Product Type :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(37, 226);
            label3.Name = "label3";
            label3.Size = new Size(53, 16);
            label3.TabIndex = 1;
            label3.Text = "Model :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(37, 187);
            label5.Name = "label5";
            label5.Size = new Size(53, 16);
            label5.TabIndex = 1;
            label5.Text = "Brand :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(362, 69);
            label6.Name = "label6";
            label6.Size = new Size(68, 16);
            label6.TabIndex = 1;
            label6.Text = "Quantity :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(362, 109);
            label7.Name = "label7";
            label7.Size = new Size(72, 16);
            label7.TabIndex = 1;
            label7.Text = "Unit Cost :";
            // 
            // supplierCbx
            // 
            supplierCbx.BackColor = Color.White;
            supplierCbx.DropDownStyle = ComboBoxStyle.DropDownList;
            supplierCbx.Font = new Font("Arial", 10F);
            supplierCbx.ForeColor = Color.Black;
            supplierCbx.FormattingEnabled = true;
            supplierCbx.Location = new Point(479, 179);
            supplierCbx.Name = "supplierCbx";
            supplierCbx.Size = new Size(161, 24);
            supplierCbx.TabIndex = 9;
            // 
            // addProductBtn
            // 
            addProductBtn.BackColor = Color.FromArgb(35, 165, 90);
            addProductBtn.BackgroundColor = Color.FromArgb(35, 165, 90);
            addProductBtn.BorderColor = Color.PaleVioletRed;
            addProductBtn.BorderRadius = 5;
            addProductBtn.BorderSize = 0;
            addProductBtn.FlatAppearance.BorderSize = 0;
            addProductBtn.FlatStyle = FlatStyle.Flat;
            addProductBtn.Font = new Font("Arial", 10F);
            addProductBtn.ForeColor = Color.White;
            addProductBtn.Location = new Point(658, 74);
            addProductBtn.Name = "addProductBtn";
            addProductBtn.Size = new Size(230, 25);
            addProductBtn.TabIndex = 32;
            addProductBtn.Text = "Add";
            addProductBtn.TextColor = Color.White;
            addProductBtn.UseVisualStyleBackColor = false;
            addProductBtn.Click += addProductBtn_Click;
            // 
            // sellingPriceTxt
            // 
            sellingPriceTxt.BackColor = Color.White;
            sellingPriceTxt.BorderStyle = BorderStyle.FixedSingle;
            sellingPriceTxt.Font = new Font("Arial", 10F);
            sellingPriceTxt.ForeColor = Color.Black;
            sellingPriceTxt.Location = new Point(479, 145);
            sellingPriceTxt.Name = "sellingPriceTxt";
            sellingPriceTxt.Size = new Size(161, 23);
            sellingPriceTxt.TabIndex = 30;
            // 
            // unitCostTxt
            // 
            unitCostTxt.BackColor = Color.White;
            unitCostTxt.BorderStyle = BorderStyle.FixedSingle;
            unitCostTxt.Font = new Font("Arial", 10F);
            unitCostTxt.ForeColor = Color.Black;
            unitCostTxt.Location = new Point(479, 102);
            unitCostTxt.Name = "unitCostTxt";
            unitCostTxt.Size = new Size(161, 23);
            unitCostTxt.TabIndex = 30;
            // 
            // quantityTxt
            // 
            quantityTxt.BackColor = Color.White;
            quantityTxt.BorderStyle = BorderStyle.FixedSingle;
            quantityTxt.Font = new Font("Arial", 10F);
            quantityTxt.ForeColor = Color.Black;
            quantityTxt.Location = new Point(479, 62);
            quantityTxt.Name = "quantityTxt";
            quantityTxt.Size = new Size(161, 23);
            quantityTxt.TabIndex = 30;
            // 
            // modelTxt
            // 
            modelTxt.BackColor = Color.White;
            modelTxt.BorderStyle = BorderStyle.FixedSingle;
            modelTxt.Font = new Font("Arial", 10F);
            modelTxt.ForeColor = Color.Black;
            modelTxt.Location = new Point(154, 219);
            modelTxt.Name = "modelTxt";
            modelTxt.Size = new Size(161, 23);
            modelTxt.TabIndex = 29;
            // 
            // productNameTxt
            // 
            productNameTxt.BackColor = Color.White;
            productNameTxt.BorderStyle = BorderStyle.FixedSingle;
            productNameTxt.Font = new Font("Arial", 10F);
            productNameTxt.ForeColor = Color.Black;
            productNameTxt.Location = new Point(154, 102);
            productNameTxt.Name = "productNameTxt";
            productNameTxt.Size = new Size(161, 23);
            productNameTxt.TabIndex = 28;
            // 
            // brandTxt
            // 
            brandTxt.BackColor = Color.White;
            brandTxt.BorderStyle = BorderStyle.FixedSingle;
            brandTxt.Font = new Font("Arial", 10F);
            brandTxt.ForeColor = Color.Black;
            brandTxt.Location = new Point(154, 180);
            brandTxt.Name = "brandTxt";
            brandTxt.Size = new Size(161, 23);
            brandTxt.TabIndex = 28;
            // 
            // productTypeCbx
            // 
            productTypeCbx.AutoCompleteCustomSource.AddRange(new string[] { "Cpu Case", "Cpu Coolers", "External Hard Drives", "External SSD", "Fans", "Flash Drives", "Gaming Chairs", "Gaming Keyboards ", "Gaming Mouse ", "Graphics Cards", "Hard Drives", "Laptops", "Memory Module", "Micro SD", "Monitors", "Motherboards", "Network Attached Storage (NAS)", "Power Supplies", "Printers", "Processors", "Routers", "Solid State Drives (SSD)", "Speakers", "UPS", "Webcams" });
            productTypeCbx.BackColor = Color.White;
            productTypeCbx.DropDownStyle = ComboBoxStyle.DropDownList;
            productTypeCbx.Font = new Font("Arial", 10F);
            productTypeCbx.ForeColor = Color.Black;
            productTypeCbx.FormattingEnabled = true;
            productTypeCbx.Items.AddRange(new object[] { "Cpu Case", "Cpu Coolers", "External Hard Drives", "External SSD", "Fans", "Flash Drives", "Gaming Chairs", "Gaming Keyboards ", "Gaming Mouse ", "Graphics Cards", "Hard Drives", "Laptops", "Memory Module", "Micro SD", "Monitors", "Motherboards", "Network Attached Storage (NAS)", "Power Supplies", "Printers", "Processors", "Routers", "Solid State Drives (SSD)", "Speakers", "UPS", "Webcams" });
            productTypeCbx.Location = new Point(154, 139);
            productTypeCbx.Name = "productTypeCbx";
            productTypeCbx.Size = new Size(161, 24);
            productTypeCbx.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 10F);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(363, 187);
            label9.Name = "label9";
            label9.Size = new Size(67, 16);
            label9.TabIndex = 1;
            label9.Text = "Supplier :";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial", 10F);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(362, 147);
            label16.Name = "label16";
            label16.Size = new Size(93, 16);
            label16.TabIndex = 1;
            label16.Text = "Selling Price :";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Arial", 10F);
            label19.ForeColor = Color.Black;
            label19.Location = new Point(37, 109);
            label19.Name = "label19";
            label19.Size = new Size(104, 16);
            label19.TabIndex = 1;
            label19.Text = "Product Name :";
            // 
            // inventoryGridView
            // 
            inventoryGridView.AllowUserToAddRows = false;
            inventoryGridView.AllowUserToDeleteRows = false;
            inventoryGridView.BackgroundColor = Color.White;
            inventoryGridView.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(37, 42, 64);
            dataGridViewCellStyle1.Font = new Font("Arial", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Silver;
            dataGridViewCellStyle1.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            inventoryGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            inventoryGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inventoryGridView.Location = new Point(34, 60);
            inventoryGridView.Margin = new Padding(2);
            inventoryGridView.Name = "inventoryGridView";
            inventoryGridView.ReadOnly = true;
            inventoryGridView.RowHeadersWidth = 62;
            inventoryGridView.Size = new Size(907, 284);
            inventoryGridView.TabIndex = 1;
            inventoryGridView.CellClick += inventoryGridView_CellContentClick_1;
            inventoryGridView.CellContentClick += inventoryGridView_CellContentClick_2;
            // 
            // pictureBox13
            // 
            pictureBox13.BackColor = Color.Transparent;
            pictureBox13.Image = (Image)resources.GetObject("pictureBox13.Image");
            pictureBox13.Location = new Point(34, 21);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(28, 24);
            pictureBox13.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox13.TabIndex = 37;
            pictureBox13.TabStop = false;
            // 
            // searchBarTxt
            // 
            searchBarTxt.BackColor = Color.White;
            searchBarTxt.BorderStyle = BorderStyle.FixedSingle;
            searchBarTxt.Font = new Font("Arial", 13F);
            searchBarTxt.ForeColor = Color.Black;
            searchBarTxt.Location = new Point(72, 25);
            searchBarTxt.Multiline = true;
            searchBarTxt.Name = "searchBarTxt";
            searchBarTxt.Size = new Size(190, 20);
            searchBarTxt.TabIndex = 38;
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(addProductBtn);
            panel2.Controls.Add(resetBtn);
            panel2.Controls.Add(functionalBtn);
            panel2.Controls.Add(defectiveBtn);
            panel2.Controls.Add(sellingPriceTxt);
            panel2.Controls.Add(updateBtn);
            panel2.Controls.Add(unitCostTxt);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(maxQuantityTxt);
            panel2.Controls.Add(quantityTxt);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(supplierCbx);
            panel2.Controls.Add(modelTxt);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(productIDtxt);
            panel2.Controls.Add(productNameTxt);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(brandTxt);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label19);
            panel2.Controls.Add(productTypeCbx);
            panel2.Location = new Point(34, 349);
            panel2.Name = "panel2";
            panel2.Size = new Size(907, 275);
            panel2.TabIndex = 33;
            // 
            // resetBtn
            // 
            resetBtn.BackColor = Color.Gray;
            resetBtn.BackgroundColor = Color.Gray;
            resetBtn.BorderColor = Color.PaleVioletRed;
            resetBtn.BorderRadius = 5;
            resetBtn.BorderSize = 0;
            resetBtn.FlatAppearance.BorderSize = 0;
            resetBtn.FlatStyle = FlatStyle.Flat;
            resetBtn.Font = new Font("Arial", 10F);
            resetBtn.ForeColor = Color.White;
            resetBtn.Location = new Point(658, 209);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(230, 25);
            resetBtn.TabIndex = 38;
            resetBtn.Text = "Clear";
            resetBtn.TextColor = Color.White;
            resetBtn.UseVisualStyleBackColor = false;
            resetBtn.Click += resetBtn_Click;
            // 
            // functionalBtn
            // 
            functionalBtn.BackColor = Color.FromArgb(35, 165, 90);
            functionalBtn.BackgroundColor = Color.FromArgb(35, 165, 90);
            functionalBtn.BorderColor = Color.PaleVioletRed;
            functionalBtn.BorderRadius = 5;
            functionalBtn.BorderSize = 0;
            functionalBtn.FlatAppearance.BorderSize = 0;
            functionalBtn.FlatStyle = FlatStyle.Flat;
            functionalBtn.Font = new Font("Arial", 10F);
            functionalBtn.ForeColor = Color.White;
            functionalBtn.Location = new Point(776, 165);
            functionalBtn.Name = "functionalBtn";
            functionalBtn.Size = new Size(112, 25);
            functionalBtn.TabIndex = 38;
            functionalBtn.Text = "Functional";
            functionalBtn.TextColor = Color.White;
            functionalBtn.UseVisualStyleBackColor = false;
            functionalBtn.Click += functionalBtn_Click;
            // 
            // defectiveBtn
            // 
            defectiveBtn.BackColor = Color.FromArgb(218, 55, 60);
            defectiveBtn.BackgroundColor = Color.FromArgb(218, 55, 60);
            defectiveBtn.BorderColor = Color.PaleVioletRed;
            defectiveBtn.BorderRadius = 5;
            defectiveBtn.BorderSize = 0;
            defectiveBtn.FlatAppearance.BorderSize = 0;
            defectiveBtn.FlatStyle = FlatStyle.Flat;
            defectiveBtn.Font = new Font("Arial", 10F);
            defectiveBtn.ForeColor = Color.White;
            defectiveBtn.Location = new Point(658, 165);
            defectiveBtn.Name = "defectiveBtn";
            defectiveBtn.Size = new Size(112, 25);
            defectiveBtn.TabIndex = 38;
            defectiveBtn.Text = "Defective";
            defectiveBtn.TextColor = Color.White;
            defectiveBtn.UseVisualStyleBackColor = false;
            defectiveBtn.Click += defectiveBtn_Click;
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
            updateBtn.Location = new Point(658, 121);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(230, 25);
            updateBtn.TabIndex = 32;
            updateBtn.Text = "Update ";
            updateBtn.TextColor = Color.White;
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(37, 17);
            label12.Name = "label12";
            label12.Size = new Size(209, 19);
            label12.TabIndex = 0;
            label12.Text = "PRODUCT INFORMATION";
            // 
            // maxQuantityTxt
            // 
            maxQuantityTxt.BackColor = Color.White;
            maxQuantityTxt.BorderStyle = BorderStyle.FixedSingle;
            maxQuantityTxt.Font = new Font("Arial", 10F);
            maxQuantityTxt.ForeColor = Color.Black;
            maxQuantityTxt.Location = new Point(483, 219);
            maxQuantityTxt.Name = "maxQuantityTxt";
            maxQuantityTxt.Size = new Size(161, 23);
            maxQuantityTxt.TabIndex = 30;
            // 
            // productIDtxt
            // 
            productIDtxt.BackColor = Color.White;
            productIDtxt.BorderStyle = BorderStyle.FixedSingle;
            productIDtxt.Enabled = false;
            productIDtxt.Font = new Font("Arial", 10F);
            productIDtxt.ForeColor = Color.Black;
            productIDtxt.Location = new Point(154, 62);
            productIDtxt.Name = "productIDtxt";
            productIDtxt.Size = new Size(161, 23);
            productIDtxt.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(366, 226);
            label4.Name = "label4";
            label4.Size = new Size(97, 16);
            label4.TabIndex = 1;
            label4.Text = "Max Quantity :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(37, 69);
            label1.Name = "label1";
            label1.Size = new Size(81, 16);
            label1.TabIndex = 1;
            label1.Text = "Product ID :";
            // 
            // columnFilterCbx
            // 
            columnFilterCbx.BackColor = Color.White;
            columnFilterCbx.DropDownStyle = ComboBoxStyle.DropDownList;
            columnFilterCbx.Font = new Font("Arial", 10F);
            columnFilterCbx.ForeColor = Color.Black;
            columnFilterCbx.FormattingEnabled = true;
            columnFilterCbx.Items.AddRange(new object[] { "productID", "productName", "supplierName", "productType", "brand", "model", "status" });
            columnFilterCbx.Location = new Point(293, 22);
            columnFilterCbx.Name = "columnFilterCbx";
            columnFilterCbx.Size = new Size(149, 24);
            columnFilterCbx.TabIndex = 40;
            // 
            // InventoryRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(columnFilterCbx);
            Controls.Add(panel2);
            Controls.Add(searchBarTxt);
            Controls.Add(pictureBox13);
            Controls.Add(inventoryGridView);
            ForeColor = Color.Black;
            Name = "InventoryRegister";
            Size = new Size(968, 635);
            Load += InventoryRegister_Load;
            ((System.ComponentModel.ISupportInitialize)inventoryGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox supplierCbx;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView inventoryGridView;
        private PictureBox pictureBox13;
        private TextBox searchBarTxt;
        private TextBox quantityTxt;
        private TextBox modelTxt;
        private TextBox brandTxt;
        private SalesandInventory.RJControls.RJButton rjButton2;
        private Panel panel2;
        private SalesandInventory.RJControls.RJButton updateBtn;
        private Label label12;
        private TextBox unitCostTxt;
        private Label label9;
        private SalesandInventory.RJControls.RJButton defectiveBtn;
        private TextBox sellingPriceTxt;
        private ComboBox productTypeCbx;
        private Label label16;
        private ComboBox columnFilterCbx;
        private TextBox productNameTxt;
        private Label label19;
        private SalesandInventory.RJControls.RJButton addProductBtn;
        private TextBox productIDtxt;
        private Label label1;
        private TextBox maxQuantityTxt;
        private Label label4;
        private SalesandInventory.RJControls.RJButton resetBtn;
        private SalesandInventory.RJControls.RJButton functionalBtn;
    }
}
