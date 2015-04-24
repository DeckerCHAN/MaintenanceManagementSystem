using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace MMS.UI.Pages.SubPages
{
    class DevicePage:SubPagebase
    {
        public DevicePage()
        {
            this.Title = Properties.Resources.Device;
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
            this.StatisticsData.ItemsSource =
                this.Db.Device.OrderBy(p => p.DeviceId).Take((int)this.CurrentPage * 10).Skip(((int)this.CurrentPage - 1) * 10).Join(this.Db.Company, device => device.BelongTo, company => company.CompanyId,
                    (device, company) => new
                    {
                        DeviceId = device.DeviceId,
                        DeviceBelongToCompany = company.CompanyName

                    }).ToList();
        }
    }
}
