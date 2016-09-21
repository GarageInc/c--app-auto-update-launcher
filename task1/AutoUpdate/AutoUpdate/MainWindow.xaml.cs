using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using System.Deployment.Application;
using System.Reflection;
using System.Diagnostics;
using System.Threading;

namespace AutoUpdate
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            lVersion.Content = GetCurrentVersion();
        }

        string appFileName = System.AppDomain.CurrentDomain.FriendlyName;
        string currentDirectoryPath = Directory.GetCurrentDirectory();
        string updateLauncher = "UpdateLauncher.exe";

        protected void bUpdate_Click(object sender, RoutedEventArgs e)
        {
            var remoteVersion = GetUpdateFileVersion();

            var currentVersion = GetCurrentVersion();

            bool hasNewVersion = String.Compare(remoteVersion, currentVersion) > 0;

            if (hasNewVersion && File.Exists(updateLauncher))
            {
                Application.Current.Shutdown();

                Process.Start(updateLauncher, getCurrentAppFilePath() + " " + getUpdateFilePath());
            } else
            {
                trace("You can't update!");
            }
        }
        
        protected void bVersion_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var version = GetCurrentVersion();
                
                trace( String.Format("Текущая версия: {0}", version));
            }
            catch (ConfigurationErrorsException)
            {
                trace("Error reading version");
            }
            
        }

        string GetCurrentVersion()
        {

            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(getCurrentAppFilePath());            

            return fvi.FileVersion;
        }

        string getCurrentAppFilePath()
        {
            return String.Format("{0}\\{1}", currentDirectoryPath, appFileName);
        }
        string getUpdateFilePath()
        {
            return String.Format("{0}\\test\\{1}", currentDirectoryPath, appFileName);
        }

        string GetUpdateFileVersion()
        {
            var updateFilePath = getUpdateFilePath();

            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(updateFilePath);

            return fvi.FileVersion;
        }

        string ReadSetting(string key)
        {
            var appSettings = ConfigurationManager.AppSettings;

            string result = appSettings[key] ?? "Not Found";
         
            return result;
        }

        void trace(string text)
        {

            MessageBox.Show(text);
            Application.Current.Shutdown();
        }

    }
}
