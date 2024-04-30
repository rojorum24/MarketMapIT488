using MarketMap.ViewModels;
using MarketMap.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MarketMap
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
