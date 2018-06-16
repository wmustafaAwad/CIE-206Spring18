namespace Database_Forms
{
    partial class SignupForm
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
            this.Privilege_ComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CreateUserButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ConfirmPassword_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Password_TextBox = new System.Windows.Forms.TextBox();
            this.Username_TextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // Privilege_ComboBox
            // 
            this.Privilege_ComboBox.FormattingEnabled = true;
            this.Privilege_ComboBox.Items.AddRange(new object[] {
            "Manager",
            "Cashier Person",
            "Chef",
            "Supervisor"});
            this.Privilege_ComboBox.Location = new System.Drawing.Point(201, 106);
            this.Privilege_ComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Privilege_ComboBox.Name = "Privilege_ComboBox";
            this.Privilege_ComboBox.Size = new System.Drawing.Size(146, 24);
            this.Privilege_ComboBox.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label4.Location = new System.Drawing.Point(40, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Privilege:";
            // 
            // CreateUserButton
            // 
            this.CreateUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateUserButton.Location = new System.Drawing.Point(179, 264);
            this.CreateUserButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateUserButton.Name = "CreateUserButton";
            this.CreateUserButton.Size = new System.Drawing.Size(113, 34);
            this.CreateUserButton.TabIndex = 21;
            this.CreateUserButton.Text = "Create User";
            this.CreateUserButton.UseVisualStyleBackColor = true;
            this.CreateUserButton.Click += new System.EventHandler(this.CreateUserButton_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label3.Location = new System.Drawing.Point(40, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Confirm password:";
            // 
            // ConfirmPassword_TextBox
            // 
            this.ConfirmPassword_TextBox.Location = new System.Drawing.Point(201, 202);
            this.ConfirmPassword_TextBox.Name = "ConfirmPassword_TextBox";
            this.ConfirmPassword_TextBox.PasswordChar = '*';
            this.ConfirmPassword_TextBox.Size = new System.Drawing.Size(224, 22);
            this.ConfirmPassword_TextBox.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label2.Location = new System.Drawing.Point(40, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.Location = new System.Drawing.Point(40, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Username:";
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.Location = new System.Drawing.Point(201, 152);
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.PasswordChar = '*';
            this.Password_TextBox.Size = new System.Drawing.Size(224, 22);
            this.Password_TextBox.TabIndex = 16;
            // 
            // Username_TextBox
            // 
            this.Username_TextBox.Location = new System.Drawing.Point(201, 53);
            this.Username_TextBox.Name = "Username_TextBox";
            this.Username_TextBox.Size = new System.Drawing.Size(224, 22);
            this.Username_TextBox.TabIndex = 15;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(493, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 359);
            this.Controls.Add(this.Privilege_ComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CreateUserButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ConfirmPassword_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password_TextBox);
            this.Controls.Add(this.Username_TextBox);
            this.Controls.Add(this.menuStrip1);
            this.Name = "SignupForm";
            this.Text = "Sign_up_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Privilege_ComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CreateUserButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ConfirmPassword_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Password_TextBox;
        private System.Windows.Forms.TextBox Username_TextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}