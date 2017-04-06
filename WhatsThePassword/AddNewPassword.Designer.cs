namespace WhatsThePassword
{
    partial class AddNewPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewPassword));
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_Website = new System.Windows.Forms.Label();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.tb_Website = new System.Windows.Forms.TextBox();
            this.tb_UserName = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(362, 218);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(84, 34);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lbl_Website
            // 
            this.lbl_Website.AutoSize = true;
            this.lbl_Website.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Website.Location = new System.Drawing.Point(27, 46);
            this.lbl_Website.Name = "lbl_Website";
            this.lbl_Website.Size = new System.Drawing.Size(90, 25);
            this.lbl_Website.TabIndex = 9;
            this.lbl_Website.Text = "Website:";
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.Location = new System.Drawing.Point(27, 96);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(108, 25);
            this.lbl_UserName.TabIndex = 8;
            this.lbl_UserName.Text = "Username:";
            // 
            // tb_Website
            // 
            this.tb_Website.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Website.Location = new System.Drawing.Point(144, 43);
            this.tb_Website.Name = "tb_Website";
            this.tb_Website.Size = new System.Drawing.Size(284, 30);
            this.tb_Website.TabIndex = 0;
            // 
            // tb_UserName
            // 
            this.tb_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_UserName.Location = new System.Drawing.Point(144, 93);
            this.tb_UserName.Name = "tb_UserName";
            this.tb_UserName.Size = new System.Drawing.Size(284, 30);
            this.tb_UserName.TabIndex = 1;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(27, 147);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(104, 25);
            this.lbl_Password.TabIndex = 12;
            this.lbl_Password.Text = "Password:";
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(144, 144);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(284, 30);
            this.tb_Password.TabIndex = 2;
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(12, 218);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(90, 34);
            this.btn_Back.TabIndex = 4;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // AddNewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 264);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_Website);
            this.Controls.Add(this.lbl_UserName);
            this.Controls.Add(this.tb_Website);
            this.Controls.Add(this.tb_UserName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddNewPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "What\'s The Password - Add New Password";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddNewPassword_Close);
            this.Resize += new System.EventHandler(this.AddNewPassword_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lbl_Website;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.TextBox tb_Website;
        private System.Windows.Forms.TextBox tb_UserName;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Button btn_Back;
    }
}