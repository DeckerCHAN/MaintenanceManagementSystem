using System.Linq;
using System.Windows;

namespace MMS.UI.Pages.SubPages
{
    public class CompanyPage : SubPagebase
    {
        public CompanyPage()
        {
            this.Title = Properties.Resources.Company;
        }

        protected override void AddItemButton_OnClick(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        protected override void DeleteItemButton_OnClick(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        protected override void AlterItemButton_OnClick(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }



        protected override void RefreshData()
        {
            this.StatisticsData.ItemsSource = Db.Company.OrderBy(p => p.CompanyId).Take((int)this.CurrentPage * 10).Skip(((int)this.CurrentPage - 1) * 10).ToList();
        }

    }
}