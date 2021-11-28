namespace Emps.WindowsClient.Models.Entities;

public class Tender
{
	public int Id { get; set; }

	public virtual List<TenderItem> TenderItems { get; set; }

	public uint Number { get; set; }
}