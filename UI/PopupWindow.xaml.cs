using System;
using System.Windows;
using System.Windows.Input;

namespace MMS.UI
{
    /// <summary>
    ///     Interaction logic for PopupWindow.xaml
    /// </summary>
    public partial class PopupWindow 
    {
        public Boolean Result { get; set; }

        public PopupWindow(Window owner,String title,String content)
        {
            this.Owner = owner;
            this.InitializeComponent();
            this.Result = false;
            this.PopupTitle.Content = title;
            this.PopupContent.Text = content;
        }

        private void ConfirmButton_OnClick(object sender, RoutedEventArgs e)
        {
            this.Result = true;
            this.Close();
        }

        private void CancelButton_OnClick(object sender, RoutedEventArgs e)
        {
            this.Result = false;
            this.Close();
        }

        private void TitleBorder_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}