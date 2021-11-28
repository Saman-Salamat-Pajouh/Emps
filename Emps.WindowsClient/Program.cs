using Microsoft.Extensions.Configuration;

namespace Emps.WindowsClient;

internal static class Program
{
	public static string? TtacBaseApi;

	/// <summary>
	///  The main entry point for the application.
	/// </summary>
	[STAThread]
	private static void Main()
	{
		var config = new ConfigurationBuilder()
			.SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
			.AddJsonFile("appsettings.json").Build();

		TtacBaseApi = config["TTACApiAddress"];

		ApplicationConfiguration.Initialize();
		Application.Run(new Login());
	}
}