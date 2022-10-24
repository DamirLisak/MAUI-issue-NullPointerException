using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace gip.vbm.mobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        public void RefreshIcons()
        {
            //BuildNavList();
        }
    }
}