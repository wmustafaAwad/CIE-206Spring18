namespace Database_Forms
{
    partial class ChangePasswordForm
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
            this.components = new System.ComponentModel.Container();
            this.ChangePassword_Button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ConfirmPassword_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NewPassword_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CurrentPassword_TextBox = new System.Windows.Forms.TextBox();
            this.Username_TextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // ChangePassword_Button
            // 
            this.ChangePassword_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePassword_Button.Location = new System.Drawing.Point(148, 239);
            this.ChangePassword_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChangePassword_Button.Name = "ChangePassword_Button";
            this.ChangePassword_Button.Size = new System.Drawing.Size(145, 42);
            this.ChangePassword_Button.TabIndex = 24;
            this.ChangePassword_Button.Text = "Change Password";
            this.ChangePassword_Button.UseVisualStyleBackColor = true;
            this.ChangePassword_Button.Click += new System.EventHandler(this.ChangePassword_Button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label4.Location = new System.Drawing.Point(40, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Confirm password:";
            // 
            // ConfirmPassword_TextBox
            // 
            this.ConfirmPassword_TextBox.Location = new System.Drawing.Point(202, 190);
            this.ConfirmPassword_TextBox.Name = "ConfirmPassword_TextBox";
            this.ConfirmPassword_TextBox.PasswordChar = '*';
            this.ConfirmPassword_TextBox.Size = new System.Drawing.Size(184, 22);
            this.ConfirmPassword_TextBox.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label3.Location = new System.Drawing.Point(40, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "New password:";
            // 
            // NewPassword_TextBox
            // 
            this.NewPassword_TextBox.Location = new System.Drawing.Point(202, 143);
            this.NewPassword_TextBox.Name = "NewPassword_TextBox";
            this.NewPassword_TextBox.PasswordChar = '*';
            this.NewPassword_TextBox.Size = new System.Drawing.Size(184, 22);
            this.NewPassword_TextBox.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label2.Location = new System.Drawing.Point(40, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Current password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.Location = new System.Drawing.Point(40, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Username:";
            // 
            // CurrentPassword_TextBox
            // 
            this.CurrentPassword_TextBox.Location = new System.Drawing.Point(202, 94);
            this.CurrentPassword_TextBox.Name = "CurrentPassword_TextBox";
            this.CurrentPassword_TextBox.PasswordChar = '*';
            this.CurrentPassword_TextBox.Size = new System.Drawing.Size(184, 22);
            this.CurrentPassword_TextBox.TabIndex = 17;
            // 
            // Username_TextBox
            // 
            this.Username_TextBox.Location = new System.Drawing.Point(202, 49);
            this.Username_TextBox.Name = "Username_TextBox";
            this.Username_TextBox.Size = new System.Drawing.Size(184, 22);
            this.Username_TextBox.TabIndex = 16;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 377);
            this.Controls.Add(this.ChangePassword_Button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ConfirmPassword_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NewPassword_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CurrentPassword_TextBox);
            this.Controls.Add(this.Username_TextBox);
            this.Name = "ChangePasswordForm";
            this.Text = "Change_Password_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChangePassword_Button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ConfirmPassword_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NewPassword_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CurrentPassword_TextBox;
        private System.Windows.Forms.TextBox Username_TextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}