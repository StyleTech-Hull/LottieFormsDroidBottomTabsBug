using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace LottieBottomNavigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainTabbedPage : Xamarin.Forms.TabbedPage
    {
        public MainTabbedPage()
        {
            InitializeComponent();

            //Sets Main tab bar to bottom of screen on android
            On<Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
            On<Android>().SetBarItemColor(Color.FromHex("#999999"));
            On<Android>().SetBarSelectedItemColor(Color.FromHex("#EB5D3F"));
            BarBackgroundColor = Color.FromHex("#F9F9F9");
        }
    }
}