namespace Emps.WindowsClient
{
	partial class Offer
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
			this.TenderItemGridview = new System.Windows.Forms.DataGridView();
			this.SendButton = new System.Windows.Forms.Button();
			this.KeyTextBox = new System.Windows.Forms.TextBox();
			this.KeyLabel = new System.Windows.Forms.Label();
			this.IvTextbox = new System.Windows.Forms.TextBox();
			this.IvLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.TenderItemGridview)).BeginInit();
			this.SuspendLayout();
			// 
			// TenderItemGridview
			// 
			this.TenderItemGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TenderItemGridview.Location = new System.Drawing.Point(81, 74);
			this.TenderItemGridview.Name = "TenderItemGridview";
			this.TenderItemGridview.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.TenderItemGridview.RowHeadersWidth = 51;
			this.TenderItemGridview.RowTemplate.Height = 24;
			this.TenderItemGridview.Size = new System.Drawing.Size(1169, 541);
			this.TenderItemGridview.TabIndex = 0;
			this.TenderItemGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TenderItemGridview_CellContentClick);
			// 
			// SendButton
			// 
			this.SendButton.Location = new System.Drawing.Point(1000, 658);
			this.SendButton.Name = "SendButton";
			this.SendButton.Size = new System.Drawing.Size(250, 30);
			this.SendButton.TabIndex = 1;
			this.SendButton.Text = "ارسال پیشنهاد ها و نمایش کلید ها";
			this.SendButton.UseVisualStyleBackColor = true;
			this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
			// 
			// KeyTextBox
			// 
			this.KeyTextBox.Location = new System.Drawing.Point(393, 669);
			this.KeyTextBox.Name = "KeyTextBox";
			this.KeyTextBox.Size = new System.Drawing.Size(444, 22);
			this.KeyTextBox.TabIndex = 2;
			this.KeyTextBox.Visible = false;
			// 
			// KeyLabel
			// 
			this.KeyLabel.AutoSize = true;
			this.KeyLabel.Location = new System.Drawing.Point(839, 672);
			this.KeyLabel.Name = "KeyLabel";
			this.KeyLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.KeyLabel.Size = new System.Drawing.Size(36, 16);
			this.KeyLabel.TabIndex = 3;
			this.KeyLabel.Text = "کلید : ";
			this.KeyLabel.Visible = false;
			// 
			// IvTextbox
			// 
			this.IvTextbox.Location = new System.Drawing.Point(81, 669);
			this.IvTextbox.Name = "IvTextbox";
			this.IvTextbox.Size = new System.Drawing.Size(232, 22);
			this.IvTextbox.TabIndex = 2;
			this.IvTextbox.Visible = false;
			// 
			// IvLabel
			// 
			this.IvLabel.AutoSize = true;
			this.IvLabel.Location = new System.Drawing.Point(335, 672);
			this.IvLabel.Name = "IvLabel";
			this.IvLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.IvLabel.Size = new System.Drawing.Size(28, 16);
			this.IvLabel.TabIndex = 3;
			this.IvLabel.Text = "IV : ";
			this.IvLabel.Visible = false;
			// 
			// Offer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1316, 734);
			this.Controls.Add(this.IvLabel);
			this.Controls.Add(this.IvTextbox);
			this.Controls.Add(this.KeyLabel);
			this.Controls.Add(this.KeyTextBox);
			this.Controls.Add(this.SendButton);
			this.Controls.Add(this.TenderItemGridview);
			this.Name = "Offer";
			this.Text = "Offer";
			this.Load += new System.EventHandler(this.Offer_Load);
			((System.ComponentModel.ISupportInitialize)(this.TenderItemGridview)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView TenderItemGridview;
		private System.Windows.Forms.Button SendButton;
		private System.Windows.Forms.TextBox KeyTextBox;
		private System.Windows.Forms.Label KeyLabel;
		private System.Windows.Forms.TextBox IvTextbox;
		private System.Windows.Forms.Label IvLabel;
	}
}