namespace _3.PL
{
    partial class FrmAdmin
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
            this.tc_admin = new System.Windows.Forms.TabControl();
            this.tp_bill = new System.Windows.Forms.TabPage();
            this.btn_viewBill = new System.Windows.Forms.Button();
            this.dtpk_month = new System.Windows.Forms.DateTimePicker();
            this.dgrid_bill = new System.Windows.Forms.DataGridView();
            this.dtpk_date = new System.Windows.Forms.DateTimePicker();
            this.tp_food = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nm_foodPrice = new System.Windows.Forms.NumericUpDown();
            this.cmb_category = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_foodName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_foodId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_seachFoodName = new System.Windows.Forms.TextBox();
            this.btn_seachFood = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.dgrid_food = new System.Windows.Forms.DataGridView();
            this.tp_foodCategory = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_category = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_categoryid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_updateCategory = new System.Windows.Forms.Button();
            this.btn_deleteCategory = new System.Windows.Forms.Button();
            this.btn_showCategory = new System.Windows.Forms.Button();
            this.btn_category = new System.Windows.Forms.Button();
            this.dgrid_category = new System.Windows.Forms.DataGridView();
            this.tp_account = new System.Windows.Forms.TabPage();
            this.tp_table = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmb_tableStatus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_tableName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_tableID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_seachTable = new System.Windows.Forms.TextBox();
            this.btn_seachTable = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_updateTable = new System.Windows.Forms.Button();
            this.btn_deleteTable = new System.Windows.Forms.Button();
            this.btn_showTable = new System.Windows.Forms.Button();
            this.btn_addTable = new System.Windows.Forms.Button();
            this.dgrid_table = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cmb_accountType = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_displayName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_seachAcount = new System.Windows.Forms.TextBox();
            this.btn_seachAcount = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_updateAcount = new System.Windows.Forms.Button();
            this.btn_deleteAcount = new System.Windows.Forms.Button();
            this.btn_showAcount = new System.Windows.Forms.Button();
            this.btn_addAcount = new System.Windows.Forms.Button();
            this.dgrid_account = new System.Windows.Forms.DataGridView();
            this.btn_reset = new System.Windows.Forms.Button();
            this.tc_admin.SuspendLayout();
            this.tp_bill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_bill)).BeginInit();
            this.tp_food.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_foodPrice)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_food)).BeginInit();
            this.tp_foodCategory.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_category)).BeginInit();
            this.tp_account.SuspendLayout();
            this.tp_table.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_table)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_account)).BeginInit();
            this.SuspendLayout();
            // 
            // tc_admin
            // 
            this.tc_admin.Controls.Add(this.tp_bill);
            this.tc_admin.Controls.Add(this.tp_food);
            this.tc_admin.Controls.Add(this.tp_foodCategory);
            this.tc_admin.Controls.Add(this.tp_table);
            this.tc_admin.Controls.Add(this.tp_account);
            this.tc_admin.Location = new System.Drawing.Point(12, 12);
            this.tc_admin.Name = "tc_admin";
            this.tc_admin.SelectedIndex = 0;
            this.tc_admin.Size = new System.Drawing.Size(787, 472);
            this.tc_admin.TabIndex = 0;
            // 
            // tp_bill
            // 
            this.tp_bill.Controls.Add(this.btn_viewBill);
            this.tp_bill.Controls.Add(this.dtpk_month);
            this.tp_bill.Controls.Add(this.dgrid_bill);
            this.tp_bill.Controls.Add(this.dtpk_date);
            this.tp_bill.Location = new System.Drawing.Point(4, 29);
            this.tp_bill.Name = "tp_bill";
            this.tp_bill.Padding = new System.Windows.Forms.Padding(3);
            this.tp_bill.Size = new System.Drawing.Size(779, 439);
            this.tp_bill.TabIndex = 0;
            this.tp_bill.Text = "doanh thu";
            this.tp_bill.UseVisualStyleBackColor = true;
            // 
            // btn_viewBill
            // 
            this.btn_viewBill.Location = new System.Drawing.Point(303, 6);
            this.btn_viewBill.Name = "btn_viewBill";
            this.btn_viewBill.Size = new System.Drawing.Size(142, 29);
            this.btn_viewBill.TabIndex = 3;
            this.btn_viewBill.Text = "thống kê";
            this.btn_viewBill.UseVisualStyleBackColor = true;
            // 
            // dtpk_month
            // 
            this.dtpk_month.Location = new System.Drawing.Point(502, 6);
            this.dtpk_month.Name = "dtpk_month";
            this.dtpk_month.Size = new System.Drawing.Size(250, 27);
            this.dtpk_month.TabIndex = 2;
            // 
            // dgrid_bill
            // 
            this.dgrid_bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_bill.Location = new System.Drawing.Point(6, 56);
            this.dgrid_bill.Name = "dgrid_bill";
            this.dgrid_bill.RowHeadersWidth = 51;
            this.dgrid_bill.RowTemplate.Height = 29;
            this.dgrid_bill.Size = new System.Drawing.Size(746, 353);
            this.dgrid_bill.TabIndex = 1;
            // 
            // dtpk_date
            // 
            this.dtpk_date.Location = new System.Drawing.Point(6, 6);
            this.dtpk_date.Name = "dtpk_date";
            this.dtpk_date.Size = new System.Drawing.Size(250, 27);
            this.dtpk_date.TabIndex = 0;
            // 
            // tp_food
            // 
            this.tp_food.Controls.Add(this.panel2);
            this.tp_food.Controls.Add(this.panel1);
            this.tp_food.Location = new System.Drawing.Point(4, 29);
            this.tp_food.Name = "tp_food";
            this.tp_food.Padding = new System.Windows.Forms.Padding(3);
            this.tp_food.Size = new System.Drawing.Size(779, 439);
            this.tp_food.TabIndex = 1;
            this.tp_food.Text = "thức ăn";
            this.tp_food.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nm_foodPrice);
            this.panel2.Controls.Add(this.cmb_category);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_foodName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_foodId);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_seachFoodName);
            this.panel2.Controls.Add(this.btn_seachFood);
            this.panel2.Location = new System.Drawing.Point(411, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(362, 423);
            this.panel2.TabIndex = 1;
            // 
            // nm_foodPrice
            // 
            this.nm_foodPrice.Location = new System.Drawing.Point(156, 293);
            this.nm_foodPrice.Name = "nm_foodPrice";
            this.nm_foodPrice.Size = new System.Drawing.Size(203, 27);
            this.nm_foodPrice.TabIndex = 15;
            // 
            // cmb_category
            // 
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Location = new System.Drawing.Point(156, 228);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(203, 28);
            this.cmb_category.TabIndex = 14;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(156, 352);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(203, 27);
            this.textBox5.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "GIÁ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "DANH MỤC";
            // 
            // txt_foodName
            // 
            this.txt_foodName.Location = new System.Drawing.Point(156, 167);
            this.txt_foodName.Name = "txt_foodName";
            this.txt_foodName.Size = new System.Drawing.Size(203, 27);
            this.txt_foodName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "TÊN MÓN";
            // 
            // txt_foodId
            // 
            this.txt_foodId.Location = new System.Drawing.Point(156, 109);
            this.txt_foodId.Name = "txt_foodId";
            this.txt_foodId.ReadOnly = true;
            this.txt_foodId.Size = new System.Drawing.Size(203, 27);
            this.txt_foodId.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // txt_seachFoodName
            // 
            this.txt_seachFoodName.Location = new System.Drawing.Point(3, 46);
            this.txt_seachFoodName.Name = "txt_seachFoodName";
            this.txt_seachFoodName.Size = new System.Drawing.Size(256, 27);
            this.txt_seachFoodName.TabIndex = 3;
            // 
            // btn_seachFood
            // 
            this.btn_seachFood.Location = new System.Drawing.Point(265, 19);
            this.btn_seachFood.Name = "btn_seachFood";
            this.btn_seachFood.Size = new System.Drawing.Size(94, 69);
            this.btn_seachFood.TabIndex = 2;
            this.btn_seachFood.Text = "tìm";
            this.btn_seachFood.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_sua);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_show);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.dgrid_food);
            this.panel1.Location = new System.Drawing.Point(6, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 422);
            this.panel1.TabIndex = 0;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(103, 18);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(94, 69);
            this.btn_sua.TabIndex = 4;
            this.btn_sua.Text = "sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(203, 18);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(94, 69);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(302, 18);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(94, 69);
            this.btn_show.TabIndex = 2;
            this.btn_show.Text = "xem";
            this.btn_show.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(3, 18);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(94, 69);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // dgrid_food
            // 
            this.dgrid_food.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_food.Location = new System.Drawing.Point(3, 110);
            this.dgrid_food.Name = "dgrid_food";
            this.dgrid_food.RowHeadersWidth = 51;
            this.dgrid_food.RowTemplate.Height = 29;
            this.dgrid_food.Size = new System.Drawing.Size(393, 300);
            this.dgrid_food.TabIndex = 0;
            // 
            // tp_foodCategory
            // 
            this.tp_foodCategory.Controls.Add(this.panel3);
            this.tp_foodCategory.Controls.Add(this.panel4);
            this.tp_foodCategory.Location = new System.Drawing.Point(4, 29);
            this.tp_foodCategory.Name = "tp_foodCategory";
            this.tp_foodCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tp_foodCategory.Size = new System.Drawing.Size(779, 439);
            this.tp_foodCategory.TabIndex = 2;
            this.tp_foodCategory.Text = "danh mục";
            this.tp_foodCategory.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_category);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txt_categoryid);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(411, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(362, 423);
            this.panel3.TabIndex = 3;
            // 
            // txt_category
            // 
            this.txt_category.Location = new System.Drawing.Point(156, 167);
            this.txt_category.Name = "txt_category";
            this.txt_category.Size = new System.Drawing.Size(203, 27);
            this.txt_category.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(3, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 25);
            this.label9.TabIndex = 6;
            this.label9.Text = "TÊN DANH MỤC";
            // 
            // txt_categoryid
            // 
            this.txt_categoryid.Location = new System.Drawing.Point(156, 109);
            this.txt_categoryid.Name = "txt_categoryid";
            this.txt_categoryid.ReadOnly = true;
            this.txt_categoryid.Size = new System.Drawing.Size(203, 27);
            this.txt_categoryid.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(3, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 25);
            this.label10.TabIndex = 4;
            this.label10.Text = "ID";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_updateCategory);
            this.panel4.Controls.Add(this.btn_deleteCategory);
            this.panel4.Controls.Add(this.btn_showCategory);
            this.panel4.Controls.Add(this.btn_category);
            this.panel4.Controls.Add(this.dgrid_category);
            this.panel4.Location = new System.Drawing.Point(6, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(399, 422);
            this.panel4.TabIndex = 2;
            // 
            // btn_updateCategory
            // 
            this.btn_updateCategory.Location = new System.Drawing.Point(103, 18);
            this.btn_updateCategory.Name = "btn_updateCategory";
            this.btn_updateCategory.Size = new System.Drawing.Size(94, 69);
            this.btn_updateCategory.TabIndex = 4;
            this.btn_updateCategory.Text = "sửa";
            this.btn_updateCategory.UseVisualStyleBackColor = true;
            // 
            // btn_deleteCategory
            // 
            this.btn_deleteCategory.Location = new System.Drawing.Point(203, 18);
            this.btn_deleteCategory.Name = "btn_deleteCategory";
            this.btn_deleteCategory.Size = new System.Drawing.Size(94, 69);
            this.btn_deleteCategory.TabIndex = 3;
            this.btn_deleteCategory.Text = "xóa";
            this.btn_deleteCategory.UseVisualStyleBackColor = true;
            // 
            // btn_showCategory
            // 
            this.btn_showCategory.Location = new System.Drawing.Point(302, 18);
            this.btn_showCategory.Name = "btn_showCategory";
            this.btn_showCategory.Size = new System.Drawing.Size(94, 69);
            this.btn_showCategory.TabIndex = 2;
            this.btn_showCategory.Text = "xem";
            this.btn_showCategory.UseVisualStyleBackColor = true;
            // 
            // btn_category
            // 
            this.btn_category.Location = new System.Drawing.Point(3, 18);
            this.btn_category.Name = "btn_category";
            this.btn_category.Size = new System.Drawing.Size(94, 69);
            this.btn_category.TabIndex = 1;
            this.btn_category.Text = "thêm";
            this.btn_category.UseVisualStyleBackColor = true;
            // 
            // dgrid_category
            // 
            this.dgrid_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_category.Location = new System.Drawing.Point(3, 110);
            this.dgrid_category.Name = "dgrid_category";
            this.dgrid_category.RowHeadersWidth = 51;
            this.dgrid_category.RowTemplate.Height = 29;
            this.dgrid_category.Size = new System.Drawing.Size(393, 300);
            this.dgrid_category.TabIndex = 0;
            // 
            // tp_account
            // 
            this.tp_account.Controls.Add(this.panel7);
            this.tp_account.Controls.Add(this.panel8);
            this.tp_account.Location = new System.Drawing.Point(4, 29);
            this.tp_account.Name = "tp_account";
            this.tp_account.Padding = new System.Windows.Forms.Padding(3);
            this.tp_account.Size = new System.Drawing.Size(779, 439);
            this.tp_account.TabIndex = 4;
            this.tp_account.Text = "tài khoản";
            this.tp_account.UseVisualStyleBackColor = true;
            // 
            // tp_table
            // 
            this.tp_table.Controls.Add(this.panel5);
            this.tp_table.Controls.Add(this.panel6);
            this.tp_table.Location = new System.Drawing.Point(4, 29);
            this.tp_table.Name = "tp_table";
            this.tp_table.Padding = new System.Windows.Forms.Padding(3);
            this.tp_table.Size = new System.Drawing.Size(779, 439);
            this.tp_table.TabIndex = 3;
            this.tp_table.Text = "bàn ăn";
            this.tp_table.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cmb_tableStatus);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.txt_tableName);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.txt_tableID);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.txt_seachTable);
            this.panel5.Controls.Add(this.btn_seachTable);
            this.panel5.Location = new System.Drawing.Point(411, 8);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(362, 423);
            this.panel5.TabIndex = 3;
            // 
            // cmb_tableStatus
            // 
            this.cmb_tableStatus.FormattingEnabled = true;
            this.cmb_tableStatus.Location = new System.Drawing.Point(156, 228);
            this.cmb_tableStatus.Name = "cmb_tableStatus";
            this.cmb_tableStatus.Size = new System.Drawing.Size(203, 28);
            this.cmb_tableStatus.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(3, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "TRẠNG THÁI";
            // 
            // txt_tableName
            // 
            this.txt_tableName.Location = new System.Drawing.Point(156, 167);
            this.txt_tableName.Name = "txt_tableName";
            this.txt_tableName.Size = new System.Drawing.Size(203, 27);
            this.txt_tableName.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(3, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 25);
            this.label11.TabIndex = 6;
            this.label11.Text = "TÊN BÀN";
            // 
            // txt_tableID
            // 
            this.txt_tableID.Location = new System.Drawing.Point(156, 109);
            this.txt_tableID.Name = "txt_tableID";
            this.txt_tableID.ReadOnly = true;
            this.txt_tableID.Size = new System.Drawing.Size(203, 27);
            this.txt_tableID.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(3, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 25);
            this.label12.TabIndex = 4;
            this.label12.Text = "ID";
            // 
            // txt_seachTable
            // 
            this.txt_seachTable.Location = new System.Drawing.Point(3, 46);
            this.txt_seachTable.Name = "txt_seachTable";
            this.txt_seachTable.Size = new System.Drawing.Size(256, 27);
            this.txt_seachTable.TabIndex = 3;
            // 
            // btn_seachTable
            // 
            this.btn_seachTable.Location = new System.Drawing.Point(265, 19);
            this.btn_seachTable.Name = "btn_seachTable";
            this.btn_seachTable.Size = new System.Drawing.Size(94, 69);
            this.btn_seachTable.TabIndex = 2;
            this.btn_seachTable.Text = "tìm";
            this.btn_seachTable.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btn_updateTable);
            this.panel6.Controls.Add(this.btn_deleteTable);
            this.panel6.Controls.Add(this.btn_showTable);
            this.panel6.Controls.Add(this.btn_addTable);
            this.panel6.Controls.Add(this.dgrid_table);
            this.panel6.Location = new System.Drawing.Point(6, 9);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(399, 422);
            this.panel6.TabIndex = 2;
            // 
            // btn_updateTable
            // 
            this.btn_updateTable.Location = new System.Drawing.Point(103, 18);
            this.btn_updateTable.Name = "btn_updateTable";
            this.btn_updateTable.Size = new System.Drawing.Size(94, 69);
            this.btn_updateTable.TabIndex = 4;
            this.btn_updateTable.Text = "sửa";
            this.btn_updateTable.UseVisualStyleBackColor = true;
            // 
            // btn_deleteTable
            // 
            this.btn_deleteTable.Location = new System.Drawing.Point(203, 18);
            this.btn_deleteTable.Name = "btn_deleteTable";
            this.btn_deleteTable.Size = new System.Drawing.Size(94, 69);
            this.btn_deleteTable.TabIndex = 3;
            this.btn_deleteTable.Text = "xóa";
            this.btn_deleteTable.UseVisualStyleBackColor = true;
            // 
            // btn_showTable
            // 
            this.btn_showTable.Location = new System.Drawing.Point(302, 18);
            this.btn_showTable.Name = "btn_showTable";
            this.btn_showTable.Size = new System.Drawing.Size(94, 69);
            this.btn_showTable.TabIndex = 2;
            this.btn_showTable.Text = "xem";
            this.btn_showTable.UseVisualStyleBackColor = true;
            // 
            // btn_addTable
            // 
            this.btn_addTable.Location = new System.Drawing.Point(3, 18);
            this.btn_addTable.Name = "btn_addTable";
            this.btn_addTable.Size = new System.Drawing.Size(94, 69);
            this.btn_addTable.TabIndex = 1;
            this.btn_addTable.Text = "thêm";
            this.btn_addTable.UseVisualStyleBackColor = true;
            // 
            // dgrid_table
            // 
            this.dgrid_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_table.Location = new System.Drawing.Point(3, 110);
            this.dgrid_table.Name = "dgrid_table";
            this.dgrid_table.RowHeadersWidth = 51;
            this.dgrid_table.RowTemplate.Height = 29;
            this.dgrid_table.Size = new System.Drawing.Size(393, 300);
            this.dgrid_table.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btn_reset);
            this.panel7.Controls.Add(this.cmb_accountType);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.txt_displayName);
            this.panel7.Controls.Add(this.label14);
            this.panel7.Controls.Add(this.txt_userName);
            this.panel7.Controls.Add(this.label15);
            this.panel7.Controls.Add(this.txt_seachAcount);
            this.panel7.Controls.Add(this.btn_seachAcount);
            this.panel7.Location = new System.Drawing.Point(411, 8);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(362, 423);
            this.panel7.TabIndex = 3;
            // 
            // cmb_accountType
            // 
            this.cmb_accountType.FormattingEnabled = true;
            this.cmb_accountType.Location = new System.Drawing.Point(156, 228);
            this.cmb_accountType.Name = "cmb_accountType";
            this.cmb_accountType.Size = new System.Drawing.Size(203, 28);
            this.cmb_accountType.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(3, 230);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(160, 25);
            this.label13.TabIndex = 8;
            this.label13.Text = "LOẠI TÀI KHOẢN";
            // 
            // txt_displayName
            // 
            this.txt_displayName.Location = new System.Drawing.Point(156, 167);
            this.txt_displayName.Name = "txt_displayName";
            this.txt_displayName.Size = new System.Drawing.Size(203, 27);
            this.txt_displayName.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(3, 169);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 25);
            this.label14.TabIndex = 6;
            this.label14.Text = "TÊN HIỂN THỊ";
            // 
            // txt_userName
            // 
            this.txt_userName.Location = new System.Drawing.Point(156, 109);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.ReadOnly = true;
            this.txt_userName.Size = new System.Drawing.Size(203, 27);
            this.txt_userName.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(3, 111);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(153, 25);
            this.label15.TabIndex = 4;
            this.label15.Text = "TÊN TÀI KHOẢN";
            // 
            // txt_seachAcount
            // 
            this.txt_seachAcount.Location = new System.Drawing.Point(3, 46);
            this.txt_seachAcount.Name = "txt_seachAcount";
            this.txt_seachAcount.Size = new System.Drawing.Size(256, 27);
            this.txt_seachAcount.TabIndex = 3;
            // 
            // btn_seachAcount
            // 
            this.btn_seachAcount.Location = new System.Drawing.Point(265, 19);
            this.btn_seachAcount.Name = "btn_seachAcount";
            this.btn_seachAcount.Size = new System.Drawing.Size(94, 69);
            this.btn_seachAcount.TabIndex = 2;
            this.btn_seachAcount.Text = "tìm";
            this.btn_seachAcount.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btn_updateAcount);
            this.panel8.Controls.Add(this.btn_deleteAcount);
            this.panel8.Controls.Add(this.btn_showAcount);
            this.panel8.Controls.Add(this.btn_addAcount);
            this.panel8.Controls.Add(this.dgrid_account);
            this.panel8.Location = new System.Drawing.Point(6, 9);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(399, 422);
            this.panel8.TabIndex = 2;
            // 
            // btn_updateAcount
            // 
            this.btn_updateAcount.Location = new System.Drawing.Point(103, 18);
            this.btn_updateAcount.Name = "btn_updateAcount";
            this.btn_updateAcount.Size = new System.Drawing.Size(94, 69);
            this.btn_updateAcount.TabIndex = 4;
            this.btn_updateAcount.Text = "sửa";
            this.btn_updateAcount.UseVisualStyleBackColor = true;
            // 
            // btn_deleteAcount
            // 
            this.btn_deleteAcount.Location = new System.Drawing.Point(203, 18);
            this.btn_deleteAcount.Name = "btn_deleteAcount";
            this.btn_deleteAcount.Size = new System.Drawing.Size(94, 69);
            this.btn_deleteAcount.TabIndex = 3;
            this.btn_deleteAcount.Text = "xóa";
            this.btn_deleteAcount.UseVisualStyleBackColor = true;
            // 
            // btn_showAcount
            // 
            this.btn_showAcount.Location = new System.Drawing.Point(302, 18);
            this.btn_showAcount.Name = "btn_showAcount";
            this.btn_showAcount.Size = new System.Drawing.Size(94, 69);
            this.btn_showAcount.TabIndex = 2;
            this.btn_showAcount.Text = "xem";
            this.btn_showAcount.UseVisualStyleBackColor = true;
            // 
            // btn_addAcount
            // 
            this.btn_addAcount.Location = new System.Drawing.Point(3, 18);
            this.btn_addAcount.Name = "btn_addAcount";
            this.btn_addAcount.Size = new System.Drawing.Size(94, 69);
            this.btn_addAcount.TabIndex = 1;
            this.btn_addAcount.Text = "thêm";
            this.btn_addAcount.UseVisualStyleBackColor = true;
            // 
            // dgrid_account
            // 
            this.dgrid_account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_account.Location = new System.Drawing.Point(3, 110);
            this.dgrid_account.Name = "dgrid_account";
            this.dgrid_account.RowHeadersWidth = 51;
            this.dgrid_account.RowTemplate.Height = 29;
            this.dgrid_account.Size = new System.Drawing.Size(393, 300);
            this.dgrid_account.TabIndex = 0;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(265, 279);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(94, 69);
            this.btn_reset.TabIndex = 5;
            this.btn_reset.Text = "ĐẶT LẠI";
            this.btn_reset.UseVisualStyleBackColor = true;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 495);
            this.Controls.Add(this.tc_admin);
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdmin";
            this.tc_admin.ResumeLayout(false);
            this.tp_bill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_bill)).EndInit();
            this.tp_food.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_foodPrice)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_food)).EndInit();
            this.tp_foodCategory.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_category)).EndInit();
            this.tp_account.ResumeLayout(false);
            this.tp_table.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_table)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_account)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_admin;
        private System.Windows.Forms.TabPage tp_bill;
        private System.Windows.Forms.TabPage tp_food;
        private System.Windows.Forms.TabPage tp_foodCategory;
        private System.Windows.Forms.TabPage tp_account;
        private System.Windows.Forms.Button btn_viewBill;
        private System.Windows.Forms.DateTimePicker dtpk_month;
        private System.Windows.Forms.DataGridView dgrid_bill;
        private System.Windows.Forms.DateTimePicker dtpk_date;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_seachFoodName;
        private System.Windows.Forms.Button btn_seachFood;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dgrid_food;
        private System.Windows.Forms.NumericUpDown nm_foodPrice;
        private System.Windows.Forms.ComboBox cmb_category;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_foodName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_foodId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_category;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_categoryid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_updateCategory;
        private System.Windows.Forms.Button btn_deleteCategory;
        private System.Windows.Forms.Button btn_showCategory;
        private System.Windows.Forms.Button btn_category;
        private System.Windows.Forms.DataGridView dgrid_category;
        private System.Windows.Forms.TabPage tp_table;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cmb_tableStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_tableName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_tableID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_seachTable;
        private System.Windows.Forms.Button btn_seachTable;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_updateTable;
        private System.Windows.Forms.Button btn_deleteTable;
        private System.Windows.Forms.Button btn_showTable;
        private System.Windows.Forms.Button btn_addTable;
        private System.Windows.Forms.DataGridView dgrid_table;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.ComboBox cmb_accountType;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_displayName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_seachAcount;
        private System.Windows.Forms.Button btn_seachAcount;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btn_updateAcount;
        private System.Windows.Forms.Button btn_deleteAcount;
        private System.Windows.Forms.Button btn_showAcount;
        private System.Windows.Forms.Button btn_addAcount;
        private System.Windows.Forms.DataGridView dgrid_account;
    }
}