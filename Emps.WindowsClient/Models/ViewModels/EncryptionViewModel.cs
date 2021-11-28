namespace Emps.WindowsClient.Models.ViewModels
{
	internal class EncryptionViewModel
	{
		public EncryptionViewModel(byte[] data, string key, string iv)
		{
			Data = data;
			Key = key;
			Iv = iv;
		}

		public EncryptionViewModel() { }

		public byte[] Data { get; set; }

		public string Key { get; set; }

		public string Iv { get; set; }
	}
}
