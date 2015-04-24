using System;
using System.Linq;
using System.Windows;
using MMS.Persistence;

namespace MMS.UI.Pages.SubPages
{
    public class ClientPage : SubPagebase
    {
        public ClientPage()
        {
            this.Title = Properties.Resources.Client;

        }

        protected override void AddItemButton_OnClick(object sender, RoutedEventArgs e)
        {

        }

        protected override void DeleteItemButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (this.StatisticsData.SelectedItems.Count > 0)
            {           
                var popup = new PopupWindow(Window.GetWindow(this), Properties.Resources.ConfirmDelete,
                    String.Format(Properties.Resources.ConfirmDeleteFormat, this.StatisticsData.SelectedItems.Count));
                popup.ShowDialog();
                if (popup.Result)
                {
                    foreach (Client selectedItem in this.StatisticsData.SelectedItems)
                    {
                        this.Db.Client.Remove(selectedItem);
                    }
                    this.Db.SaveChanges();
                    this.RefreshData();
                }
                else
                {
                    return;
                }

            }

        }

        protected override void AlterItemButton_OnClick(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }



        protected override void RefreshData()
        {
            this.StatisticsData.ItemsSource = Db.Client.OrderBy(p => p.ClientId).Take((int)this.CurrentPage * 10).Skip(((int)this.CurrentPage - 1) * 10).ToList();

        }

    }
}