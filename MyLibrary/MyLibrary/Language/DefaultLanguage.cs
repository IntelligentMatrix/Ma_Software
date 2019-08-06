using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLibrary.Language
{
    /// <summary>
    /// 系统的语言基类，默认也即是中文版本
    /// </summary>
    public class DefaultLanguage
    {
        /***********************************************************************************
         * 
         *    一般的错误信息
         * 
         ************************************************************************************/

        public virtual string AuthorizationFailed => "系统授权失败，需要使用激活码授权，谢谢支持。";
        public virtual string ConnectedFailed => "连接失败：";
        public virtual string ConnectedSuccess => "连接成功！";
        public virtual string UnknownError => "未知错误";
        public virtual string ErrorCode => "错误代号";
        public virtual string TextDescription => "文本描述";
        public virtual string ExceptionMessage => "错误信息：";
        public virtual string ExceptionSourse => "错误源：";
        public virtual string ExceptionType => "错误类型：";
        public virtual string ExceptionStackTrace => "错误堆栈：";
        public virtual string ExceptopnTargetSite => "错误方法：";
        public virtual string ExceprionCustomer => "用户自定义方法出错：";
        public virtual string SuccessText => "成功";
        public virtual string TwoParametersLengthIsNotSame => "两个参数的个数不一致";
        public virtual string NotSupportedDataType => "输入的类型不支持，请重新输入";
        public virtual string NotSupportedFunction => "当前的功能逻辑不支持";
        public virtual string DataLengthIsNotEnough => "接收的数据长度不足，应该值:{0},实际值:{1}";
        public virtual string ReceiveDataTimeout => "接收数据超时：";
        public virtual string ReceiveDataLengthTooShort => "接收的数据长度太短：";
        public virtual string MessageTip => "消息提示：";
        public virtual string Close => "关闭";
        public virtual string Time => "时间：";
        public virtual string SoftWare => "软件：";
        public virtual string BugSubmit => "Bug提交";
        public virtual string MailServerCenter => "邮件发送系统";
        public virtual string MailSendTail => "邮件服务系统自动发出，请勿回复！";
        public virtual string IpAddresError => "Ip地址输入异常，格式不正确";
        public virtual string Send => "发送";
        public virtual string Receive => "接收";

        /***********************************************************************************
         * 
         *    系统相关的错误信息
         * 
         ************************************************************************************/

        public virtual string SystemInstallOperater => "安装新系统：IP为";
        public virtual string SystemUpdateOperater => "更新新系统：IP为";
        /***********************************************************************************
         * 
         *    文件相关的信息
         * 
         ************************************************************************************/


        public virtual string FileDownloadSuccess => "文件下载成功";
        public virtual string FileDownloadFailed => "文件下载异常";
        public virtual string FileUploadFailed => "文件上传异常";
        public virtual string FileUploadSuccess => "文件上传成功";
        public virtual string FileDeleteFailed => "文件删除异常";
        public virtual string FileDeleteSuccess => "文件删除成功";
        public virtual string FileReceiveFailed => "确认文件接收异常";
        public virtual string FileNotExist => "文件不存在";
        public virtual string FileSaveFailed => "文件存储失败";
        public virtual string FileLoadFailed => "文件加载失败";
        public virtual string FileSendClientFailed => "文件发送的时候发生了异常";
        public virtual string FileWriteToNetFailed => "文件写入网络异常";
        public virtual string FileReadFromNetFailed => "从网络读取文件异常";
        public virtual string FilePathCreateFailed => "文件夹路径创建失败：";
        public virtual string FileRemoteNotExist => "对方文件不存在，无法接收！";

        /***********************************************************************************
         * 
         *    日志 相关
         * 
         ************************************************************************************/
        public virtual string LogNetDebug => "调试";
        public virtual string LogNetInfo => "信息";
        public virtual string LogNetWarn => "警告";
        public virtual string LogNetError => "错误";
        public virtual string LogNetFatal => "致命";
        public virtual string LogNetAbandon => "放弃";
        public virtual string LogNetAll => "全部";
    }
}
