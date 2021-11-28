using System.Globalization;

namespace Emps.WindowsClient.Helpers
{
	internal static class PersianDateHelper
	{
		internal static string ConvertToPersianDateWithSlash(this DateTime dateTime)
		{
			var pc = new PersianCalendar();
			var month = pc.GetMonth(dateTime).ToString();
			var convertedMonth = month.Length == 1 ? "0" + month : month;
			var day = pc.GetDayOfMonth(dateTime).ToString();
			var convertedDay = day.Length == 1 ? "0" + day : day;
			return $"{pc.GetYear(dateTime)}/{convertedMonth}/{convertedDay}";
		}
	}
}
