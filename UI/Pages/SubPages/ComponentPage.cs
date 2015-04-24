using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace MMS.UI.Pages.SubPages
{
    class ComponentPage : SubPagebase
    {
        public ComponentPage()
        {
            this.Title = Properties.Resources.Component;
        }
        protected override void AddItemButton_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        protected override void DeleteItemButton_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        protected override void AlterItemButton_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        protected override void RefreshData()
        {
            this.StatisticsData.ItemsSource = Db.Component.OrderBy(p => p.ComponentId).Take((int)this.CurrentPage * 10).Skip(((int)this.CurrentPage - 1) * 10).Join(this.Db.Company, component => component.Provider, company => company.CompanyId, (component, company) => new
            {
                ComponentId = component.ComponentId,
                ComponentName = component.ComponentName,
                ComponentType = component.ComponentModel,
                ComponentProvideBy = company.CompanyName
            }).ToList();
        }
    }
}
