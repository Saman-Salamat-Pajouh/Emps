using Emps.WindowsClient.Models.ViewModels;

namespace Emps.WindowsClient;

public partial class TenderItemOffer : Form
{
	private readonly int _tenderItemId;

	public TenderItemOffer(int tenderItemId)
	{
		InitializeComponent();
		_tenderItemId = tenderItemId;
	}

	private void TenderItemOffer_Load(object sender, System.EventArgs e)
	{
		var tenderItem = Offer.Tender?.TenderItems.First(x => x.Id == _tenderItemId);
		GenericLabel.Text += tenderItem!.GenericName;
	}

	private void ConfirmButton_Click(object sender, System.EventArgs e)
	{
		var country = CountryTextbox.Text;
		var countIsNumber = uint.TryParse(CountTextbox.Text, out var count);
		var dateOfSupplyIsDate = DateTime.TryParse(DateOfSupplyDatePicker.Text, out var date);
		var priceIsDouble = double.TryParse(PriceTextbox.Text, out var price);

		if (string.IsNullOrWhiteSpace(country))
		{
			MessageBox.Show("نام کشور را وارد کنید", "خطا", MessageBoxButtons.OK,
				MessageBoxIcon.Error);
			return;
		}

		if (!priceIsDouble)
		{
			MessageBox.Show("قیمت باید عدد باشد", "خطا", MessageBoxButtons.OK,
				MessageBoxIcon.Error);
			return;
		}

		if (!countIsNumber)
		{
			MessageBox.Show("تعداد باید عدد باشد", "خطا", MessageBoxButtons.OK,
				MessageBoxIcon.Error);
			return;
		}

		if (!dateOfSupplyIsDate)
		{
			MessageBox.Show("تاریخ تامین باید تاریخ باشد", "خطا", MessageBoxButtons.OK,
				MessageBoxIcon.Error);
			return;
		}

		Offer.Offers.Add(new TenderItemOfferViewModel
		{
			Count = count,
			Country = country,
			DateOfSupply = date,
			Price = price,
			TenderItemId = _tenderItemId
		});

		MessageBox.Show("پیشنهاد با موفقیت اضافه شد", "موفقیت", MessageBoxButtons.OK,
			MessageBoxIcon.Information);

		var offer = new Offer("", "");
		Hide();
		offer.Show();
	}
}