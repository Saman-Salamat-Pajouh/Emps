using Emps.WindowsClient.Models.Enums;

namespace Emps.WindowsClient.Models.ViewModels;

internal class TtacOperationResponseViewModel : TtacBaseResponseViewModel
{
	public ResponseResultEnum Result { get; set; }

	public string Message { get; set; }

	public dynamic Errors { get; set; }
}