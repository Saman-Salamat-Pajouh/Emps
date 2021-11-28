namespace Emps.WindowsClient
{
	partial class SendKey
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
			this.SendKeyButton = new System.Windows.Forms.Button();
			this.KeyLabel = new System.Windows.Forms.Label();
			this.IvLabel = new System.Windows.Forms.Label();
			this.KeyTextbox = new System.Windows.Forms.TextBox();
			this.IvTextbox = new System.Windows.Forms.TextBox();
			this.OfferTraceCodeLabel = new System.Windows.Forms.Label();
			this.OfferTraceCodeTextbox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// SendKeyButton
			// 
			this.SendKeyButton.Location = new System.Drawing.Point(226, 211);
			this.SendKeyButton.Name = "SendKeyButton";
			this.SendKeyButton.Size = new System.Drawing.Size(75, 23);
			this.SendKeyButton.TabIndex = 0;
			this.SendKeyButton.Text = "ارسال";
			this.SendKeyButton.UseVisualStyleBackColor = true;
			this.SendKeyButton.Click += new System.EventHandler(this.SendKeyButton_Click);
			// 
			// KeyLabel
			// 
			this.KeyLabel.AutoSize = true;
			this.KeyLabel.Location = new System.Drawing.Point(330, 48);
			this.KeyLabel.Name = "KeyLabel";
			this.KeyLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.KeyLabel.Size = new System.Drawing.Size(33, 16);
			this.KeyLabel.TabIndex = 1;
			this.KeyLabel.Text = "کلید :";
			// 
			// IvLabel
			// 
			this.IvLabel.AutoSize = true;
			this.IvLabel.Location = new System.Drawing.Point(338, 101);
			this.IvLabel.Name = "IvLabel";
			this.IvLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.IvLabel.Size = new System.Drawing.Size(25, 16);
			this.IvLabel.TabIndex = 1;
			this.IvLabel.Text = "IV :";
			// 
			// KeyTextbox
			// 
			this.KeyTextbox.Location = new System.Drawing.Point(33, 45);
			this.KeyTextbox.Name = "KeyTextbox";
			this.KeyTextbox.Size = new System.Drawing.Size(228, 22);
			this.KeyTextbox.TabIndex = 2;
			// 
			// IvTextbox
			// 
			this.IvTextbox.Location = new System.Drawing.Point(33, 98);
			this.IvTextbox.Name = "IvTextbox";
			this.IvTextbox.Size = new System.Drawing.Size(228, 22);
			this.IvTextbox.TabIndex = 2;
			// 
			// OfferTraceCodeLabel
			// 
			this.OfferTraceCodeLabel.AutoSize = true;
			this.OfferTraceCodeLabel.Location = new System.Drawing.Point(338, 150);
			this.OfferTraceCodeLabel.Name = "OfferTraceCodeLabel";
			this.OfferTraceCodeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.OfferTraceCodeLabel.Size = new System.Drawing.Size(105, 16);
			this.OfferTraceCodeLabel.TabIndex = 1;
			this.OfferTraceCodeLabel.Text = "کد پیگیری پیشنهاد :";
			// 
			// OfferTraceCodeTextbox
			// 
			this.OfferTraceCodeTextbox.Location = new System.Drawing.Point(33, 147);
			this.OfferTraceCodeTextbox.Name = "OfferTraceCodeTextbox";
			this.OfferTraceCodeTextbox.Size = new System.Drawing.Size(228, 22);
			this.OfferTraceCodeTextbox.TabIndex = 2;
			// 
			// SendKey
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(524, 281);
			this.Controls.Add(this.OfferTraceCodeTextbox);
			this.Controls.Add(this.IvTextbox);
			this.Controls.Add(this.OfferTraceCodeLabel);
			this.Controls.Add(this.KeyTextbox);
			this.Controls.Add(this.IvLabel);
			this.Controls.Add(this.KeyLabel);
			this.Controls.Add(this.SendKeyButton);
			this.Name = "SendKey";
			this.Text = "ارسال کلید";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button SendKeyButton;
		private System.Windows.Forms.Label KeyLabel;
		private System.Windows.Forms.Label IvLabel;
		private System.Windows.Forms.TextBox KeyTextbox;
		private System.Windows.Forms.TextBox IvTextbox;
		private System.Windows.Forms.Label OfferTraceCodeLabel;
		private System.Windows.Forms.TextBox OfferTraceCodeTextbox;
	}
}