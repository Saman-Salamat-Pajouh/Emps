using System.Security.Cryptography;
using Emps.WindowsClient.Models.Entities;
using Emps.WindowsClient.Models.ViewModels;
using Newtonsoft.Json;

namespace Emps.WindowsClient.Helpers;

internal static class EncryptionHelper
{
	internal static EncryptionViewModel EncryptNew(this object input)
	{
		var serializeObject = JsonConvert.SerializeObject(input);
		using var aesManaged = Aes.Create();

		aesManaged.GenerateKey();
		aesManaged.GenerateIV();

		return new EncryptionViewModel(
			EncryptStringToBytes(serializeObject, aesManaged.Key, aesManaged.IV),
			Convert.ToBase64String(aesManaged.Key),
			Convert.ToBase64String(aesManaged.IV));
	}

	internal static Tender? Decrypt(this byte[] encrypted, string key, string iv) =>
		JsonConvert.DeserializeObject<Tender>(DecryptStringFromBytes(encrypted,
			Convert.FromBase64String(key),
			Convert.FromBase64String(iv)));

	private static byte[] EncryptStringToBytes(string plainText, byte[] key, byte[] iv)
	{
		if (plainText is not { Length: > 0 })
			throw new ArgumentNullException(nameof(plainText));
		if (key is not { Length: > 0 })
			throw new ArgumentNullException(nameof(key));
		if (iv is not { Length: > 0 })
			throw new ArgumentNullException(nameof(iv));

		using var aesManaged = Aes.Create();
		aesManaged.Key = key;
		aesManaged.IV = iv;

		var encryptEngine = aesManaged.CreateEncryptor(aesManaged.Key, aesManaged.IV);

		using var msEncrypt = new MemoryStream();
		using var csEncrypt = new CryptoStream(msEncrypt, encryptEngine, CryptoStreamMode.Write);
		using (var swEncrypt = new StreamWriter(csEncrypt))
			swEncrypt.Write(plainText);

		return msEncrypt.ToArray();
	}

	private static string DecryptStringFromBytes(byte[] cipherText, byte[] key, byte[] iv)
	{
		if (cipherText is not { Length: > 0 })
			throw new ArgumentNullException(nameof(cipherText));
		if (key is not { Length: > 0 })
			throw new ArgumentNullException(nameof(key));
		if (iv is not { Length: > 0 })
			throw new ArgumentNullException(nameof(iv));

		using var aesManaged = Aes.Create();
		aesManaged.Key = key;
		aesManaged.IV = iv;

		var decryptEngine = aesManaged.CreateDecryptor(aesManaged.Key, aesManaged.IV);

		using var msDecrypt = new MemoryStream(cipherText);
		using var csDecrypt = new CryptoStream(msDecrypt, decryptEngine, CryptoStreamMode.Read);
		using var srDecrypt = new StreamReader(csDecrypt);

		return srDecrypt.ReadToEnd();
	}
}
