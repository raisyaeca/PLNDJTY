using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using LoginNavigation.Pages;

using DevExpress.Mobile.DataGrid;
using DevExpress.Mobile.DataGrid.Theme;
using DevExpress.Mobile.Core;

namespace LoginNavigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {

        string searchText;
        int count;

        public Page1()
        {
            InitializeComponent();

            TestEmployeesRepository model = new TestEmployeesRepository();
            BindingContext = model;
        }
        void OnCustomizeCell(CustomizeCellEventArgs e)
        {
            if (string.IsNullOrEmpty(searchText))
                return;
            string cellText = e.DisplayText.ToUpper();
            if (cellText.Contains(searchText.ToUpper()) && !e.IsSelected)
            {
                e.BackgroundColor = ThemeManager.Theme.CellCustomizer.HighlightColor;
                e.ForeColor = Color.Black;
                e.Handled = true;
            }
        }
        void OnSearchTextChanged(object sender, EventArgs args)
        {
            SearchBar searchBar = (SearchBar)sender;
            searchText = searchBar.Text;
            grid.Redraw(false);
        }

             void OnCalculateCustomSummary(object sender, CustomSummaryEventArgs e)
            {
                IRowData x = grid.GetRow(grid.SelectedRowHandle);;
                Employee selectedOrder = x.DataObject as Employee;
                string JP = selectedOrder.JP;

            if (e.FieldName == "JP")

            if (e.IsTotalSummary)
            {
             
                if (e.SummaryProcess == CustomSummaryProcess.Start)
                {
                    count = 0;
                }
                if (e.SummaryProcess == CustomSummaryProcess.Calculate)
                {
                        if (JP == "PB")
                        count++;
                        e.TotalValue = count;
                }
            }
       }

        void OnPopupMenuCustomization(object sender, PopupMenuEventArgs e)
        {
            if (e.MenuType == GridPopupMenuType.DataRow)
            {
                e.Menu.Items.Clear();
                PopupMenuItem itemDetail = new PopupMenuItem();
                itemDetail.Caption = "lihat profil";
                itemDetail.Click += ItemDetailClick;
                e.Menu.Items.Insert(0, itemDetail);

                PopupMenuItem itemDelete = new PopupMenuItem();
                itemDelete.Caption = "delete";
                itemDelete.Click += ItemDeleteClick;
                e.Menu.Items.Insert(1, itemDelete);
            }
        }
            async void ItemDetailClick(object sender, EventArgs e)
            {
                IRowData rowData = grid.GetRow(grid.SelectedRowHandle);
                Employee selectedOrder = rowData.DataObject as Employee;
                string Name = selectedOrder.Name;
            if (Name == "Setyo Novanto") 
            {
                await Navigation.PushAsync(new setyo());
            }
            else if (Name == "Budi")
            {
                await Navigation.PushAsync(new budi());
            }
            else if (Name == "Harris Asrofi")
            {
                await Navigation.PushAsync(new haris());
            }
            else if (Name == "Sutedja")
            {
                await Navigation.PushAsync(new sutedja());
            }
            else if (Name == "Joko Anwar")
            {
                await Navigation.PushAsync(new joko());
            }
            else if (Name == "Bambang")
            {
                await Navigation.PushAsync(new bambang());
            }
            else if (Name == "Robert King")
            {
                await Navigation.PushAsync(new robert());
            }
            else if (Name == "Laura Callahan")
            {
                await Navigation.PushAsync(new laura());
            }
            else
            {
                await Navigation.PushAsync(new anne());
            }

        }

            void ItemDeleteClick(object sender, EventArgs e)
            {
                IRowData rowData = grid.GetRow(grid.SelectedRowHandle);
                Employee selectedOrder = rowData.DataObject as Employee;
                string Name = selectedOrder.Name;

                grid.DeleteRow(grid.SelectedRowHandle);
            }
    }


}
