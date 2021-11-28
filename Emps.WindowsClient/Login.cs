using System.Net;
using Emps.WindowsClient.Models.Enums;
using Emps.WindowsClient.Models.ViewModels;
using RestSharp;

namespace Emps.WindowsClient;

public partial class Login : Form
{
	public Login() =>
		InitializeComponent();

	private void LoginButton_Click(object sender, EventArgs e)
	{
		var accessKey = AccessKeyTextbox.Text;
		if (string.IsNullOrWhiteSpace(accessKey))
		{
			MessageBox.Show("کد دسترسی به درستی وارد نشده است", "خطا", MessageBoxButtons.OK,
				MessageBoxIcon.Error);
			return;
		}

		var tenderCode = TenderNumberTextbox.Text;
		if (string.IsNullOrWhiteSpace(tenderCode))
		{
			MessageBox.Show("شماره فراخوان به درستی وارد نشده است", "خطا", MessageBoxButtons.OK,
				MessageBoxIcon.Error);
			return;
		}

		var client = new RestClient(Program.TtacBaseApi + "GetTenderStatus/" + tenderCode)
		{
			Timeout = -1
		};
		var request = new RestRequest(Method.GET);
		request.AddHeader("X-SSP-Api-Key", accessKey!);
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
				switch ((TenderStateEnum)response.Data.Data)
				{
					case TenderStateEnum.PendingOffer:
						var offerForm = new Offer(accessKey, tenderCode);
						offerForm.Show();
						Hide();
						return;
					case TenderStateEnum.WaitForKey:
						MessageBox.Show("زمان ارسال کلید فرا نرسیده است");
						return;
					case TenderStateEnum.PendingKey:
						var sendKeyForm = new SendKey(accessKey);
						sendKeyForm.Show();
						Hide();
						return;
					case TenderStateEnum.Expired:
						MessageBox.Show("فراخوان تمام شده است");
						return;
					case TenderStateEnum.NotStart:
						MessageBox.Show("فراخوان شروع نشده است");
						return;
					case TenderStateEnum.CompanyAccessDenied:
						MessageBox.Show("شما به این فراخوان دسترسی ندارید");
						return;
					default:
						MessageBox.Show("خطای سیستمی");
						return;
				}

			default:
				MessageBox.Show("خطا");
				break;
		}
	}
}