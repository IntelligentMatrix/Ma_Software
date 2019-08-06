using MyLibrary.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Pic_Integrate
{
    static class Program
    {
        
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //初始化相关变量
            ProgramData.IniLogComponent();
            ProgramData.InitialSysPara();
            ProgramData.RefreshTemplateFileList();//刷新模板文件List            
            ProgramData.RefreshTemplateTable();//读取Template数据
            ProgramData.IniSheetTemplate();//初始化Sheet模板数据

            //主程序入口
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //注册软件
            if (!Authorization.Authorize("Please contact the GETECH for registration code!")) return;
            Application.Run(new MainForm());
        }
    }
}
