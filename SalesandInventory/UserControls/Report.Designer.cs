namespace SalesandInventory.UserControls
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            salesGridView = new DataGridView();
            panel3 = new Panel();
            lblTotalSales = new Label();
            label9 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            lblTotalprofit = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            lblTotalorders = new Label();
            labelord = new Label();
            pictureBox3 = new PictureBox();
            panel4 = new Panel();
            lblTotalinventoryitem = new Label();
            label12 = new Label();
            pictureBox4 = new PictureBox();
            startDate = new DateTimePicker();
            label13 = new Label();
            endDate = new DateTimePicker();
            orderItemsGridView = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            columnFilterCbx = new ComboBox();
            searchBarTxt = new TextBox();
            osearchBarTxt = new TextBox();
            ocolumnFilterCbx = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)salesGridView).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderItemsGridView).BeginInit();
            SuspendLayout();
            // 
            // salesGridView
            // 
            salesGridView.BackgroundColor = Color.White;
            salesGridView.BorderStyle = BorderStyle.Fixed3D;
            salesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            salesGridView.Location = new Point(37, 77);
            salesGridView.Margin = new Padding(2);
            salesGridView.Name = "salesGridView";
            salesGridView.RowHeadersWidth = 62;
            salesGridView.Size = new Size(401, 308);
            salesGridView.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lblTotalSales);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(37, 401);
            panel3.Name = "panel3";
            panel3.Size = new Size(212, 205);
            panel3.TabIndex = 42;
            // 
            // lblTotalSales
            // 
            lblTotalSales.AutoSize = true;
            lblTotalSales.Font = new Font("Arial Black", 15F, FontStyle.Bold);
            lblTotalSales.ForeColor = Color.FromArgb(88, 101, 242);
            lblTotalSales.Location = new Point(25, 159);
            lblTotalSales.Margin = new Padding(2, 0, 2, 0);
            lblTotalSales.Name = "lblTotalSales";
            lblTotalSales.Size = new Size(118, 28);
            lblTotalSales.TabIndex = 2;
            lblTotalSales.Text = "P 100,000";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 15F);
            label9.Location = new Point(46, 7);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(107, 23);
            label9.TabIndex = 2;
            label9.Text = "Total Sales";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(33, 45);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(133, 92);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblTotalprofit);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(269, 401);
            panel1.Name = "panel1";
            panel1.Size = new Size(212, 205);
            panel1.TabIndex = 45;
            // 
            // lblTotalprofit
            // 
            lblTotalprofit.AutoSize = true;
            lblTotalprofit.Font = new Font("Arial Black", 15F, FontStyle.Bold);
            lblTotalprofit.ForeColor = Color.FromArgb(88, 101, 242);
            lblTotalprofit.Location = new Point(40, 159);
            lblTotalprofit.Margin = new Padding(2, 0, 2, 0);
            lblTotalprofit.Name = "lblTotalprofit";
            lblTotalprofit.Size = new Size(118, 28);
            lblTotalprofit.TabIndex = 2;
            lblTotalprofit.Text = "P 100,000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 15F);
            label3.Location = new Point(75, 7);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 23);
            label3.TabIndex = 2;
            label3.Text = "Profit";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(37, 45);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblTotalorders);
            panel2.Controls.Add(labelord);
            panel2.Controls.Add(pictureBox3);
            panel2.Location = new Point(730, 401);
            panel2.Name = "panel2";
            panel2.Size = new Size(212, 205);
            panel2.TabIndex = 46;
            // 
            // lblTotalorders
            // 
            lblTotalorders.AutoSize = true;
            lblTotalorders.Font = new Font("Arial Black", 15F, FontStyle.Bold);
            lblTotalorders.ForeColor = Color.FromArgb(88, 101, 242);
            lblTotalorders.Location = new Point(81, 159);
            lblTotalorders.Margin = new Padding(2, 0, 2, 0);
            lblTotalorders.Name = "lblTotalorders";
            lblTotalorders.Size = new Size(51, 28);
            lblTotalorders.TabIndex = 2;
            lblTotalorders.Text = "234";
            // 
            // labelord
            // 
            labelord.AutoSize = true;
            labelord.Font = new Font("Arial", 15F);
            labelord.Location = new Point(48, 7);
            labelord.Margin = new Padding(2, 0, 2, 0);
            labelord.Name = "labelord";
            labelord.Size = new Size(120, 23);
            labelord.TabIndex = 2;
            labelord.Text = "Total Orders";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(37, 45);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(133, 92);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(lblTotalinventoryitem);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(pictureBox4);
            panel4.Location = new Point(500, 401);
            panel4.Name = "panel4";
            panel4.Size = new Size(212, 205);
            panel4.TabIndex = 45;
            // 
            // lblTotalinventoryitem
            // 
            lblTotalinventoryitem.AutoSize = true;
            lblTotalinventoryitem.Font = new Font("Arial Black", 15F, FontStyle.Bold);
            lblTotalinventoryitem.ForeColor = Color.FromArgb(88, 101, 242);
            lblTotalinventoryitem.Location = new Point(66, 159);
            lblTotalinventoryitem.Margin = new Padding(2, 0, 2, 0);
            lblTotalinventoryitem.Name = "lblTotalinventoryitem";
            lblTotalinventoryitem.Size = new Size(38, 28);
            lblTotalinventoryitem.TabIndex = 2;
            lblTotalinventoryitem.Text = "56";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 15F);
            label12.Location = new Point(41, 7);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(138, 23);
            label12.TabIndex = 2;
            label12.Text = "Total Inventory";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(37, 45);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(133, 92);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // startDate
            // 
            startDate.CalendarFont = new Font("Arial", 8F);
            startDate.Font = new Font("Arial", 10F);
            startDate.Location = new Point(445, 20);
            startDate.Name = "startDate";
            startDate.Size = new Size(237, 23);
            startDate.TabIndex = 48;
            startDate.ValueChanged += startDate_ValueChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(689, 20);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(16, 18);
            label13.TabIndex = 49;
            label13.Text = "- ";
            // 
            // endDate
            // 
            endDate.CalendarFont = new Font("Arial", 8F);
            endDate.Font = new Font("Arial", 10F);
            endDate.Location = new Point(705, 20);
            endDate.Name = "endDate";
            endDate.Size = new Size(237, 23);
            endDate.TabIndex = 48;
            endDate.ValueChanged += endDate_ValueChanged;
            // 
            // orderItemsGridView
            // 
            orderItemsGridView.BackgroundColor = Color.White;
            orderItemsGridView.BorderStyle = BorderStyle.Fixed3D;
            orderItemsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderItemsGridView.Location = new Point(448, 77);
            orderItemsGridView.Margin = new Padding(2);
            orderItemsGridView.Name = "orderItemsGridView";
            orderItemsGridView.RowHeadersWidth = 62;
            orderItemsGridView.Size = new Size(494, 308);
            orderItemsGridView.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            label1.Location = new Point(37, 52);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(93, 18);
            label1.TabIndex = 2;
            label1.Text = "Order Table";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            label2.Location = new Point(448, 52);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 18);
            label2.TabIndex = 2;
            label2.Text = "Product Sold";
            // 
            // columnFilterCbx
            // 
            columnFilterCbx.DropDownStyle = ComboBoxStyle.DropDownList;
            columnFilterCbx.Font = new Font("Arial", 10F);
            columnFilterCbx.FormattingEnabled = true;
            columnFilterCbx.Items.AddRange(new object[] { "OrderID", "UserID" });
            columnFilterCbx.Location = new Point(298, 48);
            columnFilterCbx.Name = "columnFilterCbx";
            columnFilterCbx.Size = new Size(140, 24);
            columnFilterCbx.TabIndex = 52;
            // 
            // searchBarTxt
            // 
            searchBarTxt.BorderStyle = BorderStyle.FixedSingle;
            searchBarTxt.Font = new Font("Arial", 13F);
            searchBarTxt.Location = new Point(135, 49);
            searchBarTxt.Multiline = true;
            searchBarTxt.Name = "searchBarTxt";
            searchBarTxt.Size = new Size(157, 20);
            searchBarTxt.TabIndex = 51;
            // 
            // osearchBarTxt
            // 
            osearchBarTxt.BorderStyle = BorderStyle.FixedSingle;
            osearchBarTxt.Font = new Font("Arial", 13F);
            osearchBarTxt.Location = new Point(639, 49);
            osearchBarTxt.Multiline = true;
            osearchBarTxt.Name = "osearchBarTxt";
            osearchBarTxt.Size = new Size(157, 20);
            osearchBarTxt.TabIndex = 51;
            // 
            // ocolumnFilterCbx
            // 
            ocolumnFilterCbx.DropDownStyle = ComboBoxStyle.DropDownList;
            ocolumnFilterCbx.Font = new Font("Arial", 10F);
            ocolumnFilterCbx.FormattingEnabled = true;
            ocolumnFilterCbx.Items.AddRange(new object[] { "OrderItemID", "OrderID", "ProductID" });
            ocolumnFilterCbx.Location = new Point(802, 48);
            ocolumnFilterCbx.Name = "ocolumnFilterCbx";
            ocolumnFilterCbx.Size = new Size(140, 24);
            ocolumnFilterCbx.TabIndex = 52;
            // 
            // Report
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ocolumnFilterCbx);
            Controls.Add(osearchBarTxt);
            Controls.Add(columnFilterCbx);
            Controls.Add(searchBarTxt);
            Controls.Add(label13);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(endDate);
            Controls.Add(startDate);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(orderItemsGridView);
            Controls.Add(salesGridView);
            Name = "Report";
            Size = new Size(968, 635);
            Load += Report_Load;
            ((System.ComponentModel.ISupportInitialize)salesGridView).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderItemsGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView salesGridView;
        private Panel panel3;
        private Label lblTotalSales;
        private Label label9;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label lblTotalprofit;
        private Label label3;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label lblTotalorders;
        private Label labelord;
        private PictureBox pictureBox3;
        private Panel panel4;
        private Label lblTotalinventoryitem;
        private Label label12;
        private PictureBox pictureBox4;
        private DateTimePicker startDate;
        private Label label13;
        private DateTimePicker endDate;
        private DataGridView orderItemsGridView;
        private Label label1;
        private Label label2;
        private ComboBox columnFilterCbx;
        private TextBox searchBarTxt;
        private TextBox osearchBarTxt;
        private ComboBox ocolumnFilterCbx;
    }
}
