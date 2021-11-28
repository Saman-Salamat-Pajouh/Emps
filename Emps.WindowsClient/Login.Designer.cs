namespace Emps.WindowsClient
{
	partial class Login
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
			this.LoginButton = new System.Windows.Forms.Button();
			this.AccessKeyTextbox = new System.Windows.Forms.TextBox();
			this.AccessKeyLabel = new System.Windows.Forms.Label();
			this.TenderNumberTextbox = new System.Windows.Forms.TextBox();
			this.TenderNumberLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// LoginButton
			// 
			this.LoginButton.Location = new System.Drawing.Point(175, 165);
			this.LoginButton.Name = "LoginButton";
			this.LoginButton.Size = new System.Drawing.Size(169, 42);
			this.LoginButton.TabIndex = 0;
			this.LoginButton.Text = "ورود";
			this.LoginButton.UseVisualStyleBackColor = true;
			this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
			// 
			// AccessKeyTextbox
			// 
			this.AccessKeyTextbox.Location = new System.Drawing.Point(49, 59);
			this.AccessKeyTextbox.Name = "AccessKeyTextbox";
			this.AccessKeyTextbox.Size = new System.Drawing.Size(307, 22);
			this.AccessKeyTextbox.TabIndex = 1;
			// 
			// AccessKeyLabel
			// 
			this.AccessKeyLabel.AutoSize = true;
			this.AccessKeyLabel.Location = new System.Drawing.Point(384, 62);
			this.AccessKeyLabel.Name = "AccessKeyLabel";
			this.AccessKeyLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.AccessKeyLabel.Size = new System.Drawing.Size(121, 16);
			this.AccessKeyLabel.TabIndex = 2;
			this.AccessKeyLabel.Text = "کد دسترسی به سامانه :";
			// 
			// TenderNumberTextbox
			// 
			this.TenderNumberTextbox.Location = new System.Drawing.Point(49, 103);
			this.TenderNumberTextbox.Name = "TenderNumberTextbox";
			this.TenderNumberTextbox.Size = new System.Drawing.Size(307, 22);
			this.TenderNumberTextbox.TabIndex = 1;
			// 
			// TenderNumberLabel
			// 
			this.TenderNumberLabel.AutoSize = true;
			this.TenderNumberLabel.Location = new System.Drawing.Point(400, 106);
			this.TenderNumberLabel.Name = "TenderNumberLabel";
			this.TenderNumberLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.TenderNumberLabel.Size = new System.Drawing.Size(105, 16);
			this.TenderNumberLabel.TabIndex = 2;
			this.TenderNumberLabel.Text = "کد شما در فراخوان :";
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(601, 237);
			this.Controls.Add(this.TenderNumberLabel);
			this.Controls.Add(this.AccessKeyLabel);
			this.Controls.Add(this.TenderNumberTextbox);
			this.Controls.Add(this.AccessKeyTextbox);
			this.Controls.Add(this.LoginButton);
			this.Name = "Login";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Text = "ورود";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button LoginButton;
		private System.Windows.Forms.TextBox AccessKeyTextbox;
		private System.Windows.Forms.Label AccessKeyLabel;
		private System.Windows.Forms.TextBox TenderNumberTextbox;
		private System.Windows.Forms.Label TenderNumberLabel;
	}
}

