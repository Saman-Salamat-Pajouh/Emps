using System.Net;
using Emps.WindowsClient.Helpers;
using Emps.WindowsClient.Models.Entities;
using Emps.WindowsClient.Models.ViewModels;
using Newtonsoft.Json;
using RestSharp;

namespace Emps.WindowsClient;

public partial class Offer : Form
{
	private readonly string _tenderCode;

	private readonly string _accessCode;

	public static Tender? Tender = new();

	public static List<TenderItemOfferViewModel> Offers = new();

	public Offer(string accessCode, string tenderCode)
	{
		InitializeComponent();
		_tenderCode = tenderCode;
		_accessCode = accessCode;
	}

	private void Offer_Load(object sender, EventArgs e)
	{
		var tenderStatic = new Tender
		{
			Id = 1,
			Number = 2,
			TenderItems = new List<TenderItem>
			{
				new()
				{
					Id = 1,
					Count = 20000,
					GenericName = "Insulin",
					DateOfSupplyStuff = DateTime.Now.AddDays(10),
					Description = ""
				},
				new()
				{
					Id = 2,
					Count = 15000,
					GenericName = "Mahyar",
					DateOfSupplyStuff = DateTime.Now.AddDays(12),
					Description = ""
				}
			}
		};

		var client = new RestClient(Program.TtacBaseApi + "GetTenderByCode/" + _tenderCode)
		{
			Timeout = -1
		};
		var request = new RestRequest(Method.GET);
		request.AddHeader("X-SSP-Api-Key", _accessCode!);
		var response = client.Execute<TtacResponseViewModel>(request);

		switch (response.StatusCode)
		{
			case HttpStatusCode.Unauthorized:
				MessageBox.Show("شما به سامانه فراخوان دسترسی ندارید",
					"خطا",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				return;
			case HttpStatusCode.OK when response.Data.IsSuccess:
				var tender = response.Data.Data as Tender;
				Tender = tender;
				BindGrid(tender);
				return;
			default:
				MessageBox.Show("خطا");
				break;
		}
	}

	private void TenderItemGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		switch (e.ColumnIndex)
		{
			case 6:
				var tenderItemId = int.Parse(TenderItemGridview.Rows[e.RowIndex].Cells[0].Value.ToString());
				if (Offers.Any(x => x.TenderItemId == tenderItemId))
				{
					MessageBox.Show("شما قبلا برای این فرآورده پیشنهاد داده اید", "تکراری",
						MessageBoxButtons.OK,
						MessageBoxIcon.Information);
					return;
				}
				var tenderItemOfferPage = new TenderItemOffer(tenderItemId);
				tenderItemOfferPage.Show();
				Hide();
				break;
		}
	}

	private void BindGrid(Tender? tender)
	{
		TenderItemGridview.Columns.Add("Id", "کد");
		TenderItemGridview.Columns.Add("GenericName", "نام فرآورده");
		TenderItemGridview.Columns.Add("Count", "تعداد");
		TenderItemGridview.Columns.Add("DateOfSupplyStuff", "تاریخ تامین");
		TenderItemGridview.Columns.Add("Description", "توضیحات");
		TenderItemGridview.Columns.Add("State", "آیا پیشنهاد ارسال شده یا خیر ؟");

		var buttonOfferEdit = new DataGridViewButtonColumn();
		buttonOfferEdit.Name = "عملیات";
		buttonOfferEdit.Text = "ارسال پیشنهاد";
		buttonOfferEdit.UseColumnTextForButtonValue = true;

		TenderItemGridview.Columns.Add(buttonOfferEdit);

		foreach (var item in tender!.TenderItems)
			TenderItemGridview.Rows.Add(item.Id,
				item.GenericName,
				item.Count,
				item.DateOfSupplyStuff.ConvertToPersianDateWithSlash(),
				item.Description,
				Offers.Any(x => x.TenderItemId == item.Id)
					? "بله"
					: "خیر");
	}

	private void SendButton_Click(object sender, EventArgs e)
	{
		var encryptedOffers = Offers.EncryptNew();

		KeyTextBox.Text = encryptedOffers.Key;
		IvTextbox.Text = encryptedOffers.Iv;

		var client = new RestClient(Program.TtacBaseApi + "SendOffer/")
		{
			Timeout = -1
		};
		var request = new RestRequest(Method.POST);
		request.AddHeader("X-SSP-Api-Key", _accessCode!);
		request.AddHeader("Content-Type", "application/json");
		request.AddParameter("application/json", JsonConvert.SerializeObject(new
		{
			encryptedOffers.Data,
			TenderCode = "1234567891"
		}), ParameterType.RequestBody);
		var response = client.Execute<TtacOperationResponseViewModel>(request);

		switch (response.StatusCode)
		{
			case HttpStatusCode.OK when response.Data.IsSuccess:
				MessageBox.Show(response.Data.Message, "موفقیت", MessageBoxButtons.OK,
					MessageBoxIcon.Information);
				KeyLabel.Visible = KeyTextBox.Visible = IvLabel.Visible = IvTextbox.Visible = true;
				Application.Exit();
				return;
			case HttpStatusCode.BadRequest:
				MessageBox.Show("1 چیزی رو غلط زدی", "خطا", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				return;
			default:
				MessageBox.Show("خطای سیستمی", "خطا", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				return;
		}
	}
}