using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using MMS.Persistence;

namespace MMS.UI.Pages.SubPages
{
    class MaintenanceRecordPage:SubPagebase
    {
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
                Db.MaintenanceRecord.OrderBy(p => p.MaintenanceTime)
                    .Take((int) this.CurrentPage*10)
                    .Skip(((int) this.CurrentPage - 1)*10)
                    .Join(this.Db.Client, maint => maint.ClientId, client => client.ClientId,(maint,client)=>new {MaintenanceRecord = maint,Client = client})
                    .Join(this.Db.Employee, maint => maint.MaintenanceRecord.MaintenanceManId, employee => employee.EmployeeId, (maint, employee) => new { Employee = employee, MaintenanceRecordWithClient =maint})
                    .Select(record=>new
                    {
                        RecordId = record.MaintenanceRecordWithClient.MaintenanceRecord.MaintenanceRecordId,
                        Maintanecer = record.Employee.EmployeeName,
                        ClientName = record.MaintenanceRecordWithClient.Client.ClientName,
                        DeviceId = record.MaintenanceRecordWithClient.MaintenanceRecord.DeviceId,
                        MaintanceTime = record.MaintenanceRecordWithClient.MaintenanceRecord.MaintenanceTime
                    }).ToList();

        }
    }
}
