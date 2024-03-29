﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using LoginNavigation.Pages;
using DevExpress.Mobile.DataGrid;
using DevExpress.Mobile.DataGrid.Theme;
using DevExpress.Mobile.Core;

namespace LoginNavigation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page2 : ContentPage
	{
        string searchText;
        int count;

        public Page2()
        {
            InitializeComponent();

            Page2Repository model = new Page2Repository();
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
            IRowData x = grid.GetRow(grid.SelectedRowHandle); ;
            Page2Class selectedOrder = x.DataObject as Page2Class;
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
                        if (JP == "TD")
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
            Page2Class selectedOrder = rowData.DataObject as Page2Class;
            string Name = selectedOrder.Name;
            if (Name == "Dilan Mulyana")
            {
                await Navigation.PushAsync(new dilan());
            }
            else if (Name == "Milea Kuna")
            {
                await Navigation.PushAsync(new milea());
            }
            else if (Name == "Lucky Djalu")
            {
                await Navigation.PushAsync(new lucky());
            }
            else if (Name == "Siti")
            {
                await Navigation.PushAsync(new siti());
            }
            else
            {
                await Navigation.PushAsync(new fara());
            }
            

        }


        void ItemDeleteClick(object sender, EventArgs e)
        {
            IRowData rowData = grid.GetRow(grid.SelectedRowHandle);
            Page2Class selectedOrder = rowData.DataObject as Page2Class;
            string Name = selectedOrder.Name;

            grid.DeleteRow(grid.SelectedRowHandle);
        }
    }
}