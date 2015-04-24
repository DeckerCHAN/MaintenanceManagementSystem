using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using MMS.Persistence;
using UI.Annotations;

namespace MMS.UI.Pages.SubPages
{
    public abstract partial class SubPagebase : Page, INotifyPropertyChanged
    {


        public SubPagebase()
        {
            this.InitializeComponent();
            this.Db = DataEntityBuilder.BuildMmsEntities();
            this.CurrentPage = 1;
        }

        public MMSEntities Db;
        public DataTable DataTable;

        public UInt32 CurrentPageValue;
        public UInt32 CurrentPage
        {
            get { return this.CurrentPageValue; }
            set
            {
                this.CurrentPageValue = value;
                this.OnPropertyChanged("CurrentPage");
            }
        }

        private void PreviousPageButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (this.CurrentPage > 1)
            {
                this.CurrentPage--;
                this.RefreshData();
            }
        }

        private void NextPageButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (this.CurrentPage < UInt32.MaxValue)
            {
                this.CurrentPage++;
                this.RefreshData();
            }
        }
        protected abstract void AddItemButton_OnClick(object sender, RoutedEventArgs e);

        protected abstract void DeleteItemButton_OnClick(object sender, RoutedEventArgs e);

        protected abstract void AlterItemButton_OnClick(object sender, RoutedEventArgs e);

        protected void RefreshItemButton_OnClick(object sender, RoutedEventArgs e)
        {
            this.RefreshData();
        }

        protected abstract void RefreshData();

        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(string propertyName)
        {
            var handler = this.PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        protected void Page_OnLoaded(object sender, RoutedEventArgs e)
        {
            this.RefreshData();
        }
    }
}