namespace Emps.WindowsClient.Models.ViewModels
{
	public class TenderItemOfferViewModel
	{
		public int TenderItemId { get; set; }

		public uint Count { get; set; }

		public string Country { get; set; }

		public double Price { get; set; }

		public DateTime DateOfSupply { get; set; }
	}
}
