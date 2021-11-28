namespace Emps.WindowsClient.Models.Entities;

public class TenderItem
{
	public int Id { get; set; }

	public string GenericName { get; set; }

	public uint Count { get; set; }

	public DateTime DateOfSupplyStuff { get; set; }

	public string Description { get; set; }
}