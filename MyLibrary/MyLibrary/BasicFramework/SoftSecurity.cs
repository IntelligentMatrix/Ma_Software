using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web.Security;
namespace MyLibrary.BasicFramework
{

    /**********************************************************************************
     * 
     *    Create Date:2017-05-03 16:52:48
     *    Author By Richard.Hu
     * 
     * 
     **********************************************************************************/


    /// <summary>
    /// 字符串加密解密相关的自定义类
    /// </summary>
    public static class SoftSecurity
    {
        #region MD5 对称加密
        /// <summary>
        /// 加密数据，采用对称加密的方式
        /// </summary>
        /// <param name="pToEncrypt">待加密的数据</param>
        /// <returns>加密后的数据</returns>
        internal static string MD5Encrypt(string pToEncrypt)
        {
            return MD5Encrypt(pToEncrypt, "zxcvBNMM");
        }
        /// <summary>
        /// 加密数据，采用对称加密的方式
        /// </summary>
        /// <param name="pToEncrypt">待加密的数据</param>
        /// <param name="Password">密钥，长度为8，英文或数字</param>
        /// <returns>加密后的数据</returns>
        public static string MD5Encrypt(string pToEncrypt, string Password)
        {
            string aisdhaisdhwdb = Password;
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] inputByteArray = Encoding.Default.GetBytes(pToEncrypt);
            des.Key = Encoding.ASCII.GetBytes(aisdhaisdhwdb);
            des.IV = Encoding.ASCII.GetBytes(aisdhaisdhwdb);
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            StringBuilder ret = new StringBuilder();
            foreach (byte b in ms.ToArray())
            {
                ret.AppendFormat("{0:X2}", b);
            }
            ret.ToString();
            return ret.ToString();
        }

        /// <summary>
        /// 解密过程，使用的是对称的加密
        /// </summary>
        /// <param name="pToDecrypt">等待解密的字符</param>
        /// <returns>返回原密码，如果解密失败，返回‘解密失败’</returns>
        internal static string MD5Decrypt(string pToDecrypt)
        {
            return MD5Decrypt(pToDecrypt, "zxcvBNMM");
        }

        /// <summary>
        /// 解密过程，使用的是对称的加密
        /// </summary>
        /// <param name="pToDecrypt">等待解密的字符</param>
        /// <param name="password">密钥，长度为8，英文或数字</param>
        /// <returns>返回原密码，如果解密失败，返回‘解密失败’</returns>
        public static string MD5Decrypt(string pToDecrypt, string password)
        {
            if (pToDecrypt == "") return pToDecrypt;
            string zxcawrafdgegasd = password;
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] inputByteArray = new byte[pToDecrypt.Length / 2];
            for (int x = 0; x < pToDecrypt.Length / 2; x++)
            {
                int i = (Convert.ToInt32(pToDecrypt.Substring(x * 2, 2), 16));
                inputByteArray[x] = (byte)i;
            }
            des.Key = Encoding.ASCII.GetBytes(zxcawrafdgegasd);
            des.IV = Encoding.ASCII.GetBytes(zxcawrafdgegasd);
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            cs.Dispose();
            return Encoding.Default.GetString(ms.ToArray());
        }
        #endregion

        #region 不可逆加密
        /// <summary>
        /// SHA1加密字符串
        /// </summary>
        /// <param name="source">源字符串</param>
        /// <returns>加密后的字符串</returns>
        public static string SHA1(string source)
        {
            return FormsAuthentication.HashPasswordForStoringInConfigFile(source, "SHA1");
        }
        /// <summary>
        /// MD5加密字符串
        /// </summary>
        /// <param name="source">源字符串</param>
        /// <returns>加密后的字符串</returns>
        public static string MD5(string source)
        {
            return FormsAuthentication.HashPasswordForStoringInConfigFile(source, "MD5"); ;
        }
        /// <summary>
        /// 32Bit MD5加密
        /// </summary>
        /// <param name="s"></param>
        /// <param name="_input_charset"></param>
        /// <returns></returns>
        public static string GetMD5_32(string s, string _input_charset = "utf8")
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] t = md5.ComputeHash(Encoding.GetEncoding(_input_charset).GetBytes(s));
            StringBuilder sb = new StringBuilder(32);
            for (int i = 0; i < t.Length; i++)
            {
                sb.Append(t[i].ToString("x").PadLeft(2, '0'));
            }
            return sb.ToString();
        }
        /// <summary>
        /// 16Bit MD5加密
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string GetMd5_16(string s)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            string t2 = BitConverter.ToString(md5.ComputeHash(UTF8Encoding.Default.GetBytes(s)), 4, 8);
            t2 = t2.Replace("-", "");
            return t2;
        }
        #endregion

        #region 对称加密
        /*
         对称加密算法是应用较早的加密算法，技术成熟。
         在对称加密算法中，数据发信方将明文（原始数据）和加密密钥一起经过特殊加密算法处理后，使其变成复杂的加密密文发送出去。
         收信方收到密文后，若想解读原文，则需要使用加密用过的密钥及相同算法的逆算法对密文进行解密，才能使其恢复成可读明文。
         在对称加密算法中，使用的密钥只有一个，发收信双方都使用这个密钥对数据进行加密和解密，这就要求解密方事先必须知道加密密钥。
         对称加密算法的特点是算法公开、计算量小、加密速度快、加密效率高。不足之处是，交易双方都使用同样钥匙，安全性得不到保证。
         此外，每对用户每次使用对称加密算法时，都需要使用其他人不知道的惟一钥匙，这会使得发收信双方所拥有的钥匙数量成几何级数增长，
         密钥管理成为用户的负担。对称加密算法在分布式网络系统上使用较为困难，主要是因为密钥管理困难，使用成本较高。在计算机专网系统中广泛使用的对称加密算法有DES、IDEA和AES。
         * */
        static private SymmetricAlgorithm mobjCryptoService;
        static private string Key;
        /// <summary>   
        /// 对称加密类的初始化函数   
        /// </summary>   
        public static void SymmetryEncryptIni()
        {
            mobjCryptoService = new RijndaelManaged();
            Key = "Guz(%&hj7x89H$yuBI0456FtmaT5&fvHUFCy76*h%(HilJ$lhj!y6&(*jkP87jH7";
        }
        /// <summary>   
        /// 获得密钥   
        /// </summary>   
        /// <returns>密钥</returns>   
        private static byte[] GetLegalKey()
        {
            string sTemp = Key;
            mobjCryptoService.GenerateKey();
            byte[] bytTemp = mobjCryptoService.Key;
            int KeyLength = bytTemp.Length;
            if (sTemp.Length > KeyLength)
                sTemp = sTemp.Substring(0, KeyLength);
            else if (sTemp.Length < KeyLength)
                sTemp = sTemp.PadRight(KeyLength, ' ');
            return ASCIIEncoding.ASCII.GetBytes(sTemp);
        }
        /// <summary>   
        /// 获得初始向量IV   
        /// </summary>   
        /// <returns>初试向量IV</returns>   
        private static byte[] GetLegalIV()
        {
            string sTemp = "E4ghj*Ghg7!rNIfb&95GUY86GfghUb#er57HBh(u%g6HJ($jhWk7&!hg4ui%$hjk";
            mobjCryptoService.GenerateIV();
            byte[] bytTemp = mobjCryptoService.IV;
            int IVLength = bytTemp.Length;
            if (sTemp.Length > IVLength)
                sTemp = sTemp.Substring(0, IVLength);
            else if (sTemp.Length < IVLength)
                sTemp = sTemp.PadRight(IVLength, ' ');
            return ASCIIEncoding.ASCII.GetBytes(sTemp);
        }
        /// <summary>   
        /// 加密方法   
        /// </summary>   
        /// <param name="Source">待加密的串</param>   
        /// <returns>经过加密的串</returns>   
        public static string Encrypto(string Source)
        {
            byte[] bytIn = UTF8Encoding.UTF8.GetBytes(Source);
            MemoryStream ms = new MemoryStream();
            mobjCryptoService.Key = GetLegalKey();
            mobjCryptoService.IV = GetLegalIV();
            ICryptoTransform encrypto = mobjCryptoService.CreateEncryptor();
            CryptoStream cs = new CryptoStream(ms, encrypto, CryptoStreamMode.Write);
            cs.Write(bytIn, 0, bytIn.Length);
            cs.FlushFinalBlock();
            ms.Close();
            byte[] bytOut = ms.ToArray();
            return Convert.ToBase64String(bytOut);
        }
        /// <summary>   
        /// 解密方法   
        /// </summary>   
        /// <param name="Source">待解密的串</param>   
        /// <returns>经过解密的串</returns>   
        public static string Decrypto(string Source)
        {
            byte[] bytIn = Convert.FromBase64String(Source);
            MemoryStream ms = new MemoryStream(bytIn, 0, bytIn.Length);
            mobjCryptoService.Key = GetLegalKey();
            mobjCryptoService.IV = GetLegalIV();
            ICryptoTransform encrypto = mobjCryptoService.CreateDecryptor();
            CryptoStream cs = new CryptoStream(ms, encrypto, CryptoStreamMode.Read);
            StreamReader sr = new StreamReader(cs);
            return sr.ReadToEnd();
        }
        #endregion

        #region DES
        //默认密钥向量
        private static byte[] Keys = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };
        /// <summary>
        /// DES加密字符串
        /// </summary>
        /// <param name="encryptString">待加密的字符串</param>
        /// <param name="encryptKey">加密密钥,要求为8位</param>
        /// <returns>加密成功返回加密后的字符串，失败返回源串</returns>
        public static string EncryptDES(string encryptString, string encryptKey)
        {
            try
            {
                byte[] rgbKey = Encoding.UTF8.GetBytes(encryptKey.Substring(0, 8));
                byte[] rgbIV = Keys;
                byte[] inputByteArray = Encoding.UTF8.GetBytes(encryptString);
                DESCryptoServiceProvider dCSP = new DESCryptoServiceProvider();
                MemoryStream mStream = new MemoryStream();
                CryptoStream cStream = new CryptoStream(mStream, dCSP.CreateEncryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
                cStream.Write(inputByteArray, 0, inputByteArray.Length);
                cStream.FlushFinalBlock();
                return Convert.ToBase64String(mStream.ToArray());
            }
            catch
            {
                return encryptString;
            }
        }

        /// <summary>
        /// DES解密字符串
        /// </summary>
        /// <param name="decryptString">待解密的字符串</param>
        /// <param name="decryptKey">解密密钥,要求为8位,和加密密钥相同</param>
        /// <returns>解密成功返回解密后的字符串，失败返源串</returns>
        public static string DecryptDES(string decryptString, string decryptKey)
        {
            try
            {
                byte[] rgbKey = Encoding.UTF8.GetBytes(decryptKey);
                byte[] rgbIV = Keys;
                byte[] inputByteArray = Convert.FromBase64String(decryptString);
                DESCryptoServiceProvider DCSP = new DESCryptoServiceProvider();
                MemoryStream mStream = new MemoryStream();
                CryptoStream cStream = new CryptoStream(mStream, DCSP.CreateDecryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
                cStream.Write(inputByteArray, 0, inputByteArray.Length);
                cStream.FlushFinalBlock();
                return Encoding.UTF8.GetString(mStream.ToArray());
            }
            catch
            {
                return decryptString;
            }
        }

        /// <summary>
        /// DES加密方法
        /// </summary>
        /// <param name="strPlain">明文</param>
        /// <param name="strDESKey">密钥</param>
        /// <param name="strDESIV">向量</param>
        /// <returns>密文</returns>
        public static string DESEncrypt(string strPlain, string strDESKey, string strDESIV)
        {
            //把密钥转换成字节数组
            byte[] bytesDESKey = ASCIIEncoding.ASCII.GetBytes(strDESKey);
            //把向量转换成字节数组
            byte[] bytesDESIV = ASCIIEncoding.ASCII.GetBytes(strDESIV);
            //声明1个新的DES对象
            DESCryptoServiceProvider desEncrypt = new DESCryptoServiceProvider();
            //开辟一块内存流
            MemoryStream msEncrypt = new MemoryStream();
            //把内存流对象包装成加密流对象
            CryptoStream csEncrypt = new CryptoStream(msEncrypt, desEncrypt.CreateEncryptor(bytesDESKey, bytesDESIV), CryptoStreamMode.Write);
            //把加密流对象包装成写入流对象
            StreamWriter swEncrypt = new StreamWriter(csEncrypt);
            //写入流对象写入明文
            swEncrypt.WriteLine(strPlain);
            //写入流关闭
            swEncrypt.Close();
            //加密流关闭
            csEncrypt.Close();
            //把内存流转换成字节数组，内存流现在已经是密文了
            byte[] bytesCipher = msEncrypt.ToArray();
            //内存流关闭
            msEncrypt.Close();
            //把密文字节数组转换为字符串，并返回
            return UnicodeEncoding.Unicode.GetString(bytesCipher);
        }

        /// <summary>
        /// DES解密方法
        /// </summary>
        /// <param name="strCipher">密文</param>
        /// <param name="strDESKey">密钥</param>
        /// <param name="strDESIV">向量</param>
        /// <returns>明文</returns>
        public static string DESDecrypt(string strCipher, string strDESKey, string strDESIV)
        {
            //把密钥转换成字节数组
            byte[] bytesDESKey = ASCIIEncoding.ASCII.GetBytes(strDESKey);
            //把向量转换成字节数组
            byte[] bytesDESIV = ASCIIEncoding.ASCII.GetBytes(strDESIV);
            //把密文转换成字节数组
            byte[] bytesCipher = UnicodeEncoding.Unicode.GetBytes(strCipher);
            //声明1个新的DES对象
            DESCryptoServiceProvider desDecrypt = new DESCryptoServiceProvider();
            //开辟一块内存流，并存放密文字节数组
            MemoryStream msDecrypt = new MemoryStream(bytesCipher);
            //把内存流对象包装成解密流对象
            CryptoStream csDecrypt = new CryptoStream(msDecrypt, desDecrypt.CreateDecryptor(bytesDESKey, bytesDESIV), CryptoStreamMode.Read);
            //把解密流对象包装成读出流对象
            StreamReader srDecrypt = new StreamReader(csDecrypt);
            //明文=读出流的读出内容
            string strPlainText = srDecrypt.ReadLine();
            //读出流关闭
            srDecrypt.Close();
            //解密流关闭
            csDecrypt.Close();
            //内存流关闭
            msDecrypt.Close();
            //返回明文
            return strPlainText;
        }
       
        /// <summary>
        /// 加密文件
        /// </summary>
        public static void EncryptData(String pathInput, String pathOutput, byte[] desKey, byte[] desIV)
        {
            //Create the file streams to handle the input and output files.
            FileStream fin = new FileStream(pathInput, FileMode.Open, FileAccess.Read);
            FileStream fout = new FileStream(pathOutput, FileMode.OpenOrCreate, FileAccess.Write);
            fout.SetLength(0);

            //Create variables to help with read and write.
            byte[] bin = new byte[100]; //This is intermediate storage for the encryption.
            long rdlen = 0;              //This is the total number of bytes written.
            long totlen = fin.Length;    //This is the total length of the input file.
            int len;                     //This is the number of bytes to be written at a time.

            DES des = new DESCryptoServiceProvider();
            CryptoStream encStream = new CryptoStream(fout, des.CreateEncryptor(desKey, desIV), CryptoStreamMode.Write);

            //Read from the input file, then encrypt and write to the output file.
            while (rdlen < totlen)
            {
                len = fin.Read(bin, 0, 100);
                encStream.Write(bin, 0, len);
                rdlen = rdlen + len;
            }

            encStream.Close();
            fout.Close();
            fin.Close();
        }

        /// <summary>
        /// 解密文件
        /// </summary>
        /// <param name="pathInput"></param>
        /// <param name="pathOutput"></param>
        /// <param name="desKey"></param>
        /// <param name="desIV"></param>
        public static void DecryptData(String pathInput, String pathOutput, byte[] desKey, byte[] desIV)
        {
            //Create the file streams to handle the input and output files.
            FileStream fin = new FileStream(pathInput, FileMode.Open, FileAccess.Read);
            FileStream fout = new FileStream(pathOutput, FileMode.OpenOrCreate, FileAccess.Write);
            fout.SetLength(0);

            //Create variables to help with read and write.
            byte[] bin = new byte[100]; //This is intermediate storage for the encryption.
            long rdlen = 0;              //This is the total number of bytes written.
            long totlen = fin.Length;    //This is the total length of the input file.
            int len;                     //This is the number of bytes to be written at a time.

            DES des = new DESCryptoServiceProvider();
            CryptoStream encStream = new CryptoStream(fout, des.CreateDecryptor(desKey, desIV), CryptoStreamMode.Write);

            //Read from the input file, then encrypt and write to the output file.
            while (rdlen < totlen)
            {
                len = fin.Read(bin, 0, 100);
                encStream.Write(bin, 0, len);
                rdlen = rdlen + len;
            }

            encStream.Close();
            fout.Close();
            fin.Close();
        }
        #endregion

        #region 非对称加密
        /// <summary>
        /// 创建密钥
        /// </summary>
        /// <param name="path"></param>
        public static void CreatKey(string path)
        {
            if(!Directory.Exists(path)) Directory.CreateDirectory(path);
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            using (StreamWriter writer = new StreamWriter(path + @"\PrivateKey.xml", false))  //这个文件要保密...
            {
                writer.WriteLine(rsa.ToXmlString(true));
            }
            using (StreamWriter writer = new StreamWriter(path + @"\PublicKey.xml", false))
            {
                writer.WriteLine(rsa.ToXmlString(false));

            }
        }
        static RSACryptoServiceProvider rsaProvider = new RSACryptoServiceProvider(1024);
        //公钥
        public static string PublicKey = @"<RSAKeyValue><Modulus>nwbjN1znmyL2KyOIrRy/PbWZpTi+oekJIoGNc6jHCl0JNZLFHNs70fyf7y44BH8L8MBkSm5sSwCZfLm5nAsDNOmuEV5Uab5DuWYSE4R2Z3NkKexJJ4bnmXEZYXPMzTbXIpyvU2y9YVrz1BjjRPeHsb6daVdrBgjs4+2b/ok9myM=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
        //密钥
        public static string PrivateKey = @"<RSAKeyValue><Modulus>nwbjN1znmyL2KyOIrRy/PbWZpTi+oekJIoGNc6jHCl0JNZLFHNs70fyf7y44BH8L8MBkSm5sSwCZfLm5nAsDNOmuEV5Uab5DuWYSE4R2Z3NkKexJJ4bnmXEZYXPMzTbXIpyvU2y9YVrz1BjjRPeHsb6daVdrBgjs4+2b/ok9myM=</Modulus><Exponent>AQAB</Exponent><P>2PfagXD2zKzUGLkAXpC+04u0xvESpO1PbTUOGA2m8auviEMNz8VempJ/reOlJjEO2q2nrUsbtqKd0m96Cxz0Fw==</P><Q>u6Kiit1XhIgRD9jQnQh36y28LOmku2Gqn9KownMSVGhWzkkHQPw77A2h1OirQiKe6aOIO/yxdwTI/9Ds4Kwc1Q==</Q><DP>GfwtPj1yQXcde8yEX88EG7/qqbzrl7cYQSMOihDwgpcmUbJ+L/kaaHbNNd1CxT0w4z3TDC0np4r4TeCuBDC2hw==</DP><DQ>hl8I0jOC2klrFpMpilunLUeaa/uCWiKuQzhkXKR1qvbxu1b3F+XKr9hvXX6mLn2GmkDfbj4fhOFrZC/lg1weZQ==</DQ><InverseQ>P1y+6el2+1LsdwL14hYCILvsTKGokGSKD35N7HakLmHNjXiU05hN1cnXMsGIZGg+pNHmz/yuPmgNLJoNZCQiCg==</InverseQ><D>D27DriO99jg2W4lfQi2AAaUV/Aq9tUjAMjEQYSEH7+GHe0N7DYnZDE/P1Y5OsWEC76I8GV0N9Vlhi9EaSiJndRvUgphTL2YuAjrVr59Il+lwh/LUBN46AX3cmQm3cFf1F1FXKj4S+QCx/qrCH4mmKpynuQsPL/1XiQSWpugI30E=</D></RSAKeyValue>";
        /// <summary>
        /// 加密数据
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static byte[] EncryptData(byte[] data)
        {

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(1024);

            //将公钥导入到RSA对象中，准备加密；
            rsa.FromXmlString(PublicKey);

            //对数据data进行加密，并返回加密结果；
            //第二个参数用来选择Padding的格式
            byte[] buffer = rsa.Encrypt(data, false);
            return buffer;
        }
        /// <summary>
        /// 解密数据
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static byte[] DecryptData(byte[] data)
        {

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(1024);

            //将私钥导入RSA中，准备解密；
            rsa.FromXmlString(PrivateKey);

            //对数据进行解密，并返回解密结果；
            return rsa.Decrypt(data, false);

        }
        #endregion

    }
}
