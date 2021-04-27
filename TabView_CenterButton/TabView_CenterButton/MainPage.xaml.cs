using Syncfusion.XForms.TabView;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TabView_CenterButton
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Message", "CenterButton Clicked", "Ok");
        }

        private void TabView_CenterButtonTapped(object sender, EventArgs e)
        {
            DisplayAlert("Message", "CenterButton Clicked", "Ok");
        }
    }

}
