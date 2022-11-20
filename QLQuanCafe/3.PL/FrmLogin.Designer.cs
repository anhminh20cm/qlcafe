namespace _3.PL
{
    partial class FrmLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_out = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txb_pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txb_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_out);
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 224);
            this.panel1.TabIndex = 0;
            // 
            // btn_out
            // 
            this.btn_out.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_out.Location = new System.Drawing.Point(376, 162);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(148, 49);
            this.btn_out.TabIndex = 3;
            this.btn_out.Text = "THOÁT";
            this.btn_out.UseVisualStyleBackColor = true;
            this.btn_out.Click += new System.EventHandler(this.btn_out_Click);
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_login.Location = new System.Drawing.Point(17, 162);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(148, 49);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "ĐĂNG NHẬP";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txb_pass);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(17, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(507, 47);
            this.panel3.TabIndex = 1;
            // 
            // txb_pass
            // 
            this.txb_pass.Location = new System.Drawing.Point(212, 10);
            this.txb_pass.Name = "txb_pass";
            this.txb_pass.Size = new System.Drawing.Size(281, 27);
            this.txb_pass.TabIndex = 1;
            this.txb_pass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "MẬT KHẨU:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txb_username);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(17, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(507, 47);
            this.panel2.TabIndex = 0;
            // 
            // txb_username
            // 
            this.txb_username.Location = new System.Drawing.Point(212, 10);
            this.txb_username.Name = "txb_username";
            this.txb_username.Size = new System.Drawing.Size(281, 27);
            this.txb_username.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÊN ĐĂNG NHẬP:";
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 250);
            this.Controls.Add(this.panel1);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txb_pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_username;
        private System.Windows.Forms.Button btn_out;
        private System.Windows.Forms.Button btn_login;
    }
}