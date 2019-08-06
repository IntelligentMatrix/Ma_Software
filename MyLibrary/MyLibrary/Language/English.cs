using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLibrary.Language
{
    /// <summary>
    /// English Version Text
    /// </summary>
    public class English : DefaultLanguage
    {
        /***********************************************************************************
         * 
         *    Normal Info
         * 
         ************************************************************************************/

        public override string AuthorizationFailed => "System authorization failed, need to use activation code authorization, thank you for your support.";
        public override string ConnectedFailed => "Connected Failed: ";
        public override string ConnectedSuccess => "Connect Success !";
        public override string UnknownError => "Unknown Error";
        public override string ErrorCode => "Error Code: ";
        public override string TextDescription => "Description: ";
        public override string ExceptionMessage => "Exception Info: ";
        public override string ExceptionSourse => "Exception Sourse：";
        public override string ExceptionType => "Exception Type：";
        public override string ExceptionStackTrace => "Exception Stack: ";
        public override string ExceptopnTargetSite => "Exception Method: ";
        public override string ExceprionCustomer => "Error in user-defined method: ";
        public override string SuccessText => "Success";
        public override string TwoParametersLengthIsNotSame => "Two Parameter Length is not same";
        public override string NotSupportedDataType => "Unsupported DataType, input again";
        public override string NotSupportedFunction => "The current feature logic does not support";
        public override string DataLengthIsNotEnough => "Receive length is not enough，Should:{0},Actual:{1}";
        public override string ReceiveDataTimeout => "Receive timeout: ";
        public override string ReceiveDataLengthTooShort => "Receive length is too short: ";
        public override string MessageTip => "Message prompt:";
        public override string Close => "Close";
        public override string Time => "Time:";
        public override string SoftWare => "Software:";
        public override string BugSubmit => "Bug submit";
        public override string MailServerCenter => "Mail Center System";
        public override string MailSendTail => "Mail Service system issued automatically, do not reply";
        public override string IpAddresError => "IP address input exception, format is incorrect";
        public override string Send => "Send";
        public override string Receive => "Receive";

        /***********************************************************************************
         * 
         *    System about
         * 
         ************************************************************************************/

        public override string SystemInstallOperater => "Install new software: ip address is";
        public override string SystemUpdateOperater => "Update software: ip address is";


        /***********************************************************************************
         * 
         *    File related information
         * 
         ************************************************************************************/


        public override string FileDownloadSuccess => "File Download Successful";
        public override string FileDownloadFailed => "File Download exception";
        public override string FileUploadFailed => "File Upload exception";
        public override string FileUploadSuccess => "File Upload Successful";
        public override string FileDeleteFailed => "File Delete exception";
        public override string FileDeleteSuccess => "File deletion succeeded";
        public override string FileReceiveFailed => "Confirm File Receive exception";
        public override string FileNotExist => "File does not exist";
        public override string FileSaveFailed => "File Store failed";
        public override string FileLoadFailed => "File load failed";
        public override string FileSendClientFailed => "An exception occurred when the file was sent";
        public override string FileWriteToNetFailed => "File Write Network exception";
        public override string FileReadFromNetFailed => "Read file exceptions from the network";
        public override string FilePathCreateFailed => "Folder path creation failed: ";
        public override string FileRemoteNotExist => "The other file does not exist, cannot receive!";


        /***********************************************************************************
         * 
         *    Log related
         * 
         ************************************************************************************/
        public override string LogNetDebug => "Debug";
        public override string LogNetInfo => "Info";
        public override string LogNetWarn => "Warn";
        public override string LogNetError => "Error";
        public override string LogNetFatal => "Fatal";
        public override string LogNetAbandon => "Abandon";
        public override string LogNetAll => "All";

    }
}
