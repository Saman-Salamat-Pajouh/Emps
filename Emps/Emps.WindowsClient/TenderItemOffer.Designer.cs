namespace Emps.WindowsClient
{
	partial class TenderItemOffer
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
			this.GenericLabel = new System.Windows.Forms.Label();
			this.PriceLabel = new System.Windows.Forms.Label();
			this.PriceTextbox = new System.Windows.Forms.TextBox();
			this.DateOfSupplyLabel = new System.Windows.Forms.Label();
			this.DateOfSupplyDatePicker = new System.Windows.Forms.DateTimePicker();
			this.CountLable = new System.Windows.Forms.Label();
			this.CountTextbox = new System.Windows.Forms.TextBox();
			this.CountryLabel = new System.Windows.Forms.Label();
			this.CountryTextbox = new System.Windows.Forms.TextBox();
			this.ConfirmButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// GenericLabel
			// 
			this.GenericLabel.AutoSize = true;
			this.GenericLabel.Location = new System.Drawing.Point(318, 29);
			this.GenericLabel.Name = "GenericLabel";
			this.GenericLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.GenericLabel.Size = new System.Drawing.Size(149, 16);
			this.GenericLabel.TabIndex = 0;
			this.GenericLabel.Text = "ارسال پیشنهاد برای فرآورده ";
			// 
			// PriceLabel
			// 
			this.PriceLabel.AutoSize = true;
			this.PriceLabel.Location = new System.Drawing.Point(645, 108);
			this.PriceLabel.Name = "PriceLabel";
			this.PriceLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.PriceLabel.Size = new System.Drawing.Size(88, 16);
			this.PriceLabel.TabIndex = 1;
			this.PriceLabel.Text = "قیمت پیشنهادی :";
			// 
			// PriceTextbox
			// 
			this.PriceTextbox.Location = new System.Drawing.Point(453, 105);
			this.PriceTextbox.Name = "PriceTextbox";
			this.PriceTextbox.Size = new System.Drawing.Size(144, 22);
			this.PriceTextbox.TabIndex = 2;
			// 
			// DateOfSupplyLabel
			// 
			this.DateOfSupplyLabel.AutoSize = true;
			this.DateOfSupplyLabel.Location = new System.Drawing.Point(663, 177);
			this.DateOfSupplyLabel.Name = "DateOfSupplyLabel";
			this.DateOfSupplyLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.DateOfSupplyLabel.Size = new System.Drawing.Size(70, 16);
			this.DateOfSupplyLabel.TabIndex = 1;
			this.DateOfSupplyLabel.Text = "تاریخ تامین :";
			// 
			// DateOfSupplyDatePicker
			// 
			this.DateOfSupplyDatePicker.Location = new System.Drawing.Point(432, 177);
			this.DateOfSupplyDatePicker.Name = "DateOfSupplyDatePicker";
			this.DateOfSupplyDatePicker.Size = new System.Drawing.Size(200, 22);
			this.DateOfSupplyDatePicker.TabIndex = 3;
			// 
			// CountLable
			// 
			this.CountLable.AutoSize = true;
			this.CountLable.Location = new System.Drawing.Point(263, 108);
			this.CountLable.Name = "CountLable";
			this.CountLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.CountLable.Size = new System.Drawing.Size(86, 16);
			this.CountLable.TabIndex = 1;
			this.CountLable.Text = "تعداد پیشنهادی :";
			// 
			// CountTextbox
			// 
			this.CountTextbox.Location = new System.Drawing.Point(71, 105);
			this.CountTextbox.Name = "CountTextbox";
			this.CountTextbox.Size = new System.Drawing.Size(144, 22);
			this.CountTextbox.TabIndex = 2;
			// 
			// CountryLabel
			// 
			this.CountryLabel.AutoSize = true;
			this.CountryLabel.Location = new System.Drawing.Point(289, 177);
			this.CountryLabel.Name = "CountryLabel";
			this.CountryLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.CountryLabel.Size = new System.Drawing.Size(42, 16);
			this.CountryLabel.TabIndex = 1;
			this.CountryLabel.Text = "کشور :";
			// 
			// CountryTextbox
			// 
			this.CountryTextbox.Location = new System.Drawing.Point(71, 174);
			this.CountryTextbox.Name = "CountryTextbox";
			this.CountryTextbox.Size = new System.Drawing.Size(144, 22);
			this.CountryTextbox.TabIndex = 2;
			// 
			// ConfirmButton
			// 
			this.ConfirmButton.Location = new System.Drawing.Point(356, 239);
			this.ConfirmButton.Name = "ConfirmButton";
			this.ConfirmButton.Size = new System.Drawing.Size(75, 30);
			this.ConfirmButton.TabIndex = 4;
			this.ConfirmButton.Text = "تایید";
			this.ConfirmButton.UseVisualStyleBackColor = true;
			this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
			// 
			// TenderItemOffer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 302);
			this.Controls.Add(this.ConfirmButton);
			this.Controls.Add(this.DateOfSupplyDatePicker);
			this.Controls.Add(this.CountryTextbox);
			this.Controls.Add(this.CountTextbox);
			this.Controls.Add(this.PriceTextbox);
			this.Controls.Add(this.DateOfSupplyLabel);
			this.Controls.Add(this.CountryLabel);
			this.Controls.Add(this.CountLable);
			this.Controls.Add(this.PriceLabel);
			this.Controls.Add(this.GenericLabel);
			this.Name = "TenderItemOffer";
			this.Text = "TenderItemOffer";
			this.Load += new System.EventHandler(this.TenderItemOffer_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label GenericLabel;
		private System.Windows.Forms.Label PriceLabel;
		private System.Windows.Forms.TextBox PriceTextbox;
		private System.Windows.Forms.Label DateOfSupplyLabel;
		private System.Windows.Forms.DateTimePicker DateOfSupplyDatePicker;
		private System.Windows.Forms.Label CountLable;
		private System.Windows.Forms.TextBox CountTextbox;
		private System.Windows.Forms.Label CountryLabel;
		private System.Windows.Forms.TextBox CountryTextbox;
		private System.Windows.Forms.Button ConfirmButton;
	}
}