using System;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using CommunityToolkit.Maui.Views;
using AndroidX.Lifecycle;

namespace gip.vbm.mobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
        private BarcodeScanModelBase _Model;
        public AboutPage()
        {
            BindingContext = _Model = new BarcodeScanModelBase();
            InitializeComponent();
        }


        private async void barcodeScanner_OnBarcodeEntityTapped(object sender, BarcodeScannerEventArgs e)
        {
            await Navigation.PushAsync(new AboutPage2());
        }

        private async void PopulateBtn_Clicked(object sender, EventArgs e)
        {
            await Task.Run(() =>_Model.Populate());
        }
    }
}