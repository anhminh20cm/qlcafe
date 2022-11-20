namespace _3.PL
{
    partial class FrmTableManger
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmb_food = new System.Windows.Forms.ComboBox();
            this.cmb_category = new System.Windows.Forms.ComboBox();
            this.cmb_switchTable = new System.Windows.Forms.ComboBox();
            this.nm_discount = new System.Windows.Forms.NumericUpDown();
            this.btn_switchTable = new System.Windows.Forms.Button();
            this.btn_discount = new System.Windows.Forms.Button();
            this.btn_checkout = new System.Windows.Forms.Button();
            this.nmfoodCount = new System.Windows.Forms.NumericUpDown();
            this.lsv_bill = new System.Windows.Forms.ListView();
            this.btn_addFood = new System.Windows.Forms.Button();
            this.flp_table = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_discount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmfoodCount)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.adminToolStripMenuItem.Text = "admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.thôngTinCáNhânToolStripMenuItem.Text = "thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.đăngXuấtToolStripMenuItem.Text = "đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmb_food);
            this.panel2.Controls.Add(this.cmb_category);
            this.panel2.Controls.Add(this.cmb_switchTable);
            this.panel2.Controls.Add(this.nm_discount);
            this.panel2.Controls.Add(this.btn_switchTable);
            this.panel2.Controls.Add(this.btn_discount);
            this.panel2.Controls.Add(this.btn_checkout);
            this.panel2.Controls.Add(this.nmfoodCount);
            this.panel2.Controls.Add(this.lsv_bill);
            this.panel2.Controls.Add(this.btn_addFood);
            this.panel2.Location = new System.Drawing.Point(393, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 392);
            this.panel2.TabIndex = 2;
            // 
            // cmb_food
            // 
            this.cmb_food.FormattingEnabled = true;
            this.cmb_food.Location = new System.Drawing.Point(3, 37);
            this.cmb_food.Name = "cmb_food";
            this.cmb_food.Size = new System.Drawing.Size(208, 28);
            this.cmb_food.TabIndex = 11;
            // 
            // cmb_category
            // 
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Location = new System.Drawing.Point(3, 3);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(208, 28);
            this.cmb_category.TabIndex = 10;
            // 
            // cmb_switchTable
            // 
            this.cmb_switchTable.FormattingEnabled = true;
            this.cmb_switchTable.Location = new System.Drawing.Point(3, 351);
            this.cmb_switchTable.Name = "cmb_switchTable";
            this.cmb_switchTable.Size = new System.Drawing.Size(94, 28);
            this.cmb_switchTable.TabIndex = 9;
            // 
            // nm_discount
            // 
            this.nm_discount.Location = new System.Drawing.Point(174, 352);
            this.nm_discount.Name = "nm_discount";
            this.nm_discount.Size = new System.Drawing.Size(94, 27);
            this.nm_discount.TabIndex = 8;
            // 
            // btn_switchTable
            // 
            this.btn_switchTable.Location = new System.Drawing.Point(3, 314);
            this.btn_switchTable.Name = "btn_switchTable";
            this.btn_switchTable.Size = new System.Drawing.Size(94, 32);
            this.btn_switchTable.TabIndex = 7;
            this.btn_switchTable.Text = "chuyển bàn";
            this.btn_switchTable.UseVisualStyleBackColor = true;
            // 
            // btn_discount
            // 
            this.btn_discount.Location = new System.Drawing.Point(174, 314);
            this.btn_discount.Name = "btn_discount";
            this.btn_discount.Size = new System.Drawing.Size(94, 32);
            this.btn_discount.TabIndex = 6;
            this.btn_discount.Text = "giảm giá";
            this.btn_discount.UseVisualStyleBackColor = true;
            // 
            // btn_checkout
            // 
            this.btn_checkout.Location = new System.Drawing.Point(298, 314);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(94, 60);
            this.btn_checkout.TabIndex = 5;
            this.btn_checkout.Text = "thanh toán";
            this.btn_checkout.UseVisualStyleBackColor = true;
            // 
            // nmfoodCount
            // 
            this.nmfoodCount.Location = new System.Drawing.Point(319, 21);
            this.nmfoodCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmfoodCount.Name = "nmfoodCount";
            this.nmfoodCount.Size = new System.Drawing.Size(73, 27);
            this.nmfoodCount.TabIndex = 4;
            // 
            // lsv_bill
            // 
            this.lsv_bill.HideSelection = false;
            this.lsv_bill.Location = new System.Drawing.Point(3, 81);
            this.lsv_bill.Name = "lsv_bill";
            this.lsv_bill.Size = new System.Drawing.Size(389, 227);
            this.lsv_bill.TabIndex = 3;
            this.lsv_bill.UseCompatibleStateImageBehavior = false;
            // 
            // btn_addFood
            // 
            this.btn_addFood.Location = new System.Drawing.Point(217, 3);
            this.btn_addFood.Name = "btn_addFood";
            this.btn_addFood.Size = new System.Drawing.Size(94, 60);
            this.btn_addFood.TabIndex = 2;
            this.btn_addFood.Text = "thêm món";
            this.btn_addFood.UseVisualStyleBackColor = true;
            // 
            // flp_table
            // 
            this.flp_table.Location = new System.Drawing.Point(12, 31);
            this.flp_table.Name = "flp_table";
            this.flp_table.Size = new System.Drawing.Size(375, 392);
            this.flp_table.TabIndex = 3;
            // 
            // FrmTableManger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flp_table);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmTableManger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "phần mềm quản lý quán cà phê";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nm_discount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmfoodCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmb_food;
        private System.Windows.Forms.ComboBox cmb_category;
        private System.Windows.Forms.ComboBox cmb_switchTable;
        private System.Windows.Forms.NumericUpDown nm_discount;
        private System.Windows.Forms.Button btn_switchTable;
        private System.Windows.Forms.Button btn_discount;
        private System.Windows.Forms.Button btn_checkout;
        private System.Windows.Forms.NumericUpDown nmfoodCount;
        private System.Windows.Forms.ListView lsv_bill;
        private System.Windows.Forms.Button btn_addFood;
        private System.Windows.Forms.FlowLayoutPanel flp_table;
    }
}