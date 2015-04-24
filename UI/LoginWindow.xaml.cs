using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using MMS.Persistence;

namespace MMS.UI
{
    /// <summary>
    ///     Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow
    {
        public LoginWindow()
        {
            this.InitializeComponent();
        }

        private void Header_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void LoginButton_OnClick(object sender, RoutedEventArgs e)
        {
            using (var db = DataEntityBuilder.BuildMmsEntities())
            {
                if (
                    db.Admin.Any(
                        admin =>
                            admin.AdminName.Equals(this.UserNameTextBox.Text) &&
                            admin.AdminPassword.Equals(this.PasswordTextBox.Password)))
                {
                    Logging.Logger.GetLogger().Info("Successful log in!");
                    this.Close();
                }
                else
                {
                    this.FaultReason.Content = "登录失败";
                    Logging.Logger.GetLogger().Info("Log in fault! No user or wrong password!");
                  
                }

            }
        }
    }
}