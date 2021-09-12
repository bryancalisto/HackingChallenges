using System.IO;
using System.Security.Cryptography;

public static class Cypher
{
  public const int int_dontKnow = 0;

  public static byte[] decrypt(byte[] _param0)
  {
    using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
    {
      rijndaelManaged.BlockSize = 128;
      rijndaelManaged.Mode = CipherMode.CBC;
      rijndaelManaged.GenerateKey();
      rijndaelManaged.GenerateIV();
      using (MemoryStream memoryStream = new MemoryStream(_param0))
      {
        byte[] numArray1 = new byte[rijndaelManaged.Key.Length];
        byte[] numArray2 = new byte[rijndaelManaged.IV.Length];
        memoryStream.Read(numArray1, 0, numArray1.Length);
        memoryStream.Read(numArray2, 0, numArray2.Length);
        using (ICryptoTransform decryptor = rijndaelManaged.CreateDecryptor(numArray1, numArray2))
        {
          using (CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream, decryptor, CryptoStreamMode.Read))
          {
            byte[] buffer = new byte[memoryStream.Length - memoryStream.Position];
            cryptoStream.Read(buffer, 0, buffer.Length);
            return buffer;
          }
        }
      }
    }
  }

  public static byte[] returnDecrypted(Stream _param0)
  {
    byte[] buffer = new byte[_param0.Length];
    _param0.Read(buffer, 0, buffer.Length);
    return decrypt(buffer);
  }
}
