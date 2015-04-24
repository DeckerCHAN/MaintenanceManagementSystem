using System;
using System.Windows;
using System.Windows.Navigation;

namespace MMS.UI
{
    /// <summary>
    ///     Interaction logic for UIControl.xaml
    /// </summary>
    public partial class UIControl : Application
    {
        public LoginWindow LoginWindow;

        public UIControl()
        {

            this.LoginWindow = new LoginWindow();
            this.MainWindow = new MainWindow();
            this.Startup += UIControl_Startup;
            ((MainWindow)this.MainWindow).ExitButton.Click += ExitButton_Click;
        }

        void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Shutdown();
        }

        void UIControl_Startup(object sender, StartupEventArgs e)
        {
            this.LoginWindow.ShowDialog();
            this.MainWindow.Show();
        }
    }
}