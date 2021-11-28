using System.Net;
using System.Text;
using Emps.WindowsClient.Models.Enums;
using Emps.WindowsClient.Models.ViewModels;
using Newtonsoft.Json;
using RestSharp;

namespace Emps.WindowsClient;

public partial class SendKey : Form
{
	private readonly string _accessKey;

	public SendKey(string accessKey)
	{
		InitializeComponent();
		_accessKey = accessKey;
	}

	private void SendKeyButton_Click(object sender, System.EventArgs e)
	{
		var key = KeyTextbox.Text;
		var iv = IvTextbox.Text;
		var offerTraceCode = OfferTraceCodeTextbox.Text;

		if (string.IsNullOrWhiteSpace(key))
		{
			MessageBox.Show("کلید را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return;
		}

		if (string.IsNullOrWhiteSpace(iv))
		{
			MessageBox.Show("کلید IV را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return;
		}

		if (string.IsNullOrWhiteSpace(offerTraceCode))
		{
			MessageBox.Show("کد پیگیری پیشنهاد خود را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return;
		}

		var client = new RestClient(Program.TtacBaseApi + "SendKey/")
		{
			Timeout = -1
		};
		var request = new RestRequest(Method.POST);
		request.AddHeader("X-SSP-Api-Key", _accessKey!);
		request.AddHeader("Content-Type", "application/json");
		request.AddParameter("application/json", JsonConvert.SerializeObject(new
		{
			Key = key,
			IV = iv,
			OfferTraceCode = offerTraceCode,
		}), ParameterType.RequestBody);
		var response = client.Execute<TtacOperationResponseViewModel>(request);

		switch (response.StatusCode)
		{
			case HttpStatusCode.OK when response.Data.IsSuccess:
				switch (response.Data.Result)
				{
					case ResponseResultEnum.Successful:
						MessageBox.Show(response.Data.Message, "با موفقیت",
							MessageBoxButtons.OK, MessageBoxIcon.Information);
						Application.Exit();
						return;
					default:
						MessageBox.Show("خطای سیستمی");
						return;
				}
			case HttpStatusCode.BadRequest:
				var errorMessages = new StringBuilder();
				foreach (var dataError in response.Data.Errors)
				{
					// ToDo : Grab Error Message From JsonArray
					var value = (JsonArray)dataError.Value;
					errorMessages.Append(Environment.NewLine +
							     dataError.Key + " : " + Environment.NewLine +
							     value.Select(x => x.ToString()));
				}

				MessageBox.Show(errorMessages.ToString());
				return;
			default:
				MessageBox.Show("خطا");
				break;
		}
	}
}