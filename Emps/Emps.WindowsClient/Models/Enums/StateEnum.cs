namespace Emps.WindowsClient.Models.Enums;

internal enum TenderStateEnum : byte
{
	PendingOffer = 0,
	WaitForKey = 1,
	PendingKey = 2,
	Expired = 3,
	NotStart = 4,
	CompanyAccessDenied = 5
}