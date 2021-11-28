namespace Emps.WindowsClient.Models.ViewModels;

internal class TtacResponseViewModel : TtacBaseResponseViewModel
{
	public dynamic Data { get; set; }

	public long RecordsTotal { get; set; }

	public long RecordsFiltered { get; set; }
}