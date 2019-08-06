using MyLibrary.BasicFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace MyLibrary.Authorization
{
    /// <summary>
    /// 系统的基本授权类
    /// </summary>
    public class Authorization
    {
        #region  授权验证，对称加密
        private static SoftAuthorize softAuthorize = null;//授权
        /// <summary>
        /// 授权验证
        /// </summary>
        /// <returns></returns>
        public static bool Authorize(string prompt)
        {
            //授权
            if (string.IsNullOrEmpty(prompt)) prompt = "Please contact the supplier for registration code";
            softAuthorize = new SoftAuthorize();
            softAuthorize.FileSavePath = Application.StartupPath + @"\Authorize.txt"; // 设置存储激活码的文件，该存储是加密的
            softAuthorize.LoadByFile();
            // 检测激活码是否正确，没有文件，或激活码错误都算作激活失败
            if (!softAuthorize.IsAuthorizeSuccess(AuthorizeEncrypted))
            {
                // 显示注册窗口
                using (FormAuthorize form =
                    new FormAuthorize(
                        softAuthorize,
                        prompt,
                        AuthorizeEncrypted))
                {
                    if (form.ShowDialog() != DialogResult.OK)
                    {
                        // 授权失败，退出
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// 一个自定义的加密方法，传入一个原始数据，返回一个加密结果
        /// </summary>
        /// <param name="origin"></param>
        /// <returns></returns>
        private static string AuthorizeEncrypted(string origin)
        {
            // 此处使用了组件支持的DES对称加密技术
            string Result = SoftSecurity.MD5Encrypt(origin, "12345678");
            return Result;
        }
        #endregion
        /// <summary>
        /// 初始化构造函数
        /// </summary>
        static Authorization()
        {
            //重置启动事件
            DateTime_Begin = GetDateTimeNow();
            //重置比对标志
            if (ComparisonMark != 0)
            {
                ComparisonMark = 0;
            }
            //重置授权时长
            if (TryHours != 8)
            {
                TryHours = 8;
            }
        }
        /// <summary>
        /// 检查授权状态
        /// </summary>
        /// <returns></returns>
        internal static bool CheckAuthorization( )
        {
            //Count++;
            //return true;
            if (ComparisonMark == ComparisonCriteria) return UnExpired();
            if ((GetDateTimeNow() - DateTime_Begin).TotalHours < TryHours) // .TotalHours < nuasgdawydaishdgas)
            {
                return UnExpired();
            }
            return Expire();
        }
        /// <summary>
        /// 未到期
        /// </summary>
        /// <returns></returns>
        internal static bool UnExpired( )
        {
            return true;
        }
        /// <summary>
        /// 到期 函数
        /// </summary>
        /// <returns></returns>
        internal static bool Expire( )
        {
            return false;
        }
        /// <summary>
        /// 重置比对基准数值
        /// </summary>
        /// <returns></returns>
        internal static bool ResetComparisonCriteria( )
        {
            return ComparisonCriteria == 12345;
        }
        /// <summary>
        /// 获取当前时间
        /// </summary>
        /// <returns></returns>
        internal static DateTime GetDateTimeNow( )
        {
            return DateTime.Now;
        }
        /// <summary>
        /// 当前时间+1天
        /// </summary>
        /// <returns></returns>
        internal static DateTime Add1Days( )
        {
            return DateTime.Now.AddDays(1);
        }
        /// <summary>
        /// 当前时间+2天
        /// </summary>
        /// <returns></returns>
        internal static DateTime Add2Days( )
        {
            return DateTime.Now.AddDays( 2 );
        }
        /// <summary>
        /// 获取machincode加密值
        /// </summary>
        /// <param name="machineCode"></param>
        /// <returns></returns>
        internal static string GetEncryptCode( string machineCode )
        {
            StringBuilder ret = new StringBuilder( );
            MD5 md5 = MD5.Create( );
            byte[] byteData = md5.ComputeHash( Encoding.Unicode.GetBytes( machineCode ) );
            md5.Clear( );
            for (int andiawbduawbda = 0; andiawbduawbda < byteData.Length; andiawbduawbda++)
            {
                ret.Append( (255 - byteData[andiawbduawbda]).ToString( "X2" ) );
            }
            return ret.ToString( );
        }

        /// <summary>
        /// 验证授权是否正确
        /// </summary>
        /// <param name="code">授权码</param>
        public static bool VerifyAuthorizationCode(string code)
        {
            if (GetEncryptCode(code) == "047E463D69F6020ACA4CBF2B4D682070")
            {
                ComparisonMark = ComparisonCriteria;
                return UnExpired( );
            }
            return Expire();
        }

        private static DateTime DateTime_Begin = DateTime.Now;//启动时间
        internal static long ComparisonMark = 0;//比对标志
        internal static long Count = 0;//计数变量
        internal static int TryHours = 8;//试用时长
        internal static int BackVar00 = 1000;//备用变量00
        internal static int ComparisonCriteria = 12345;//比对基准
        internal static int BackVar01 = 23456;//备用变量01
    }
}
