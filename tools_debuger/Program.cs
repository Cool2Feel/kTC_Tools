using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LeafSoft
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                //加载日志配置文件，只需要在程序启动时加载一次
                string filePath = AppDomain.CurrentDomain.BaseDirectory + "app.config";
                LogHelper.SetConfig(filePath);
                //log4net.Config.XmlConfigurator.Configure();
                LogHelper.WriteLog("Multi-tool Start: Running...");
                Application.Run(new MainForm());

            }
            catch (Exception e)
            {
                ExceptionLog.getLog().WriteLogFile(e, "LogFile.txt");
            }
        }
    }
}
