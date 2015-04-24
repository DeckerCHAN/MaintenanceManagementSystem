using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using MMS.UI.Pages;
using UI.Annotations;

namespace MMS.UI
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public sealed partial class MainWindow : INotifyPropertyChanged
    {
        public MainPage MainPage;
        public MainWindow()
        {
            this.InitializeComponent();
            this.MainPage = new MainPage();
            this.DataStatistics.IsChecked = true;
            this.ContentFrame.Content = this.MainPage;
        }

        private void AboutUsRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void DataStatisticsRadioButton_Click(object sender, RoutedEventArgs e)
        {
            this.ContentFrame.Content = this.MainPage;
        }

        private void UIElement_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        private void OnPropertyChanged(string propertyName)
        {
            var handler = this.PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}