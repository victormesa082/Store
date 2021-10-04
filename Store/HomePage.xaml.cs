using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace Store
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            BindingContext = new HomePageViewModel();
            
            InitializeComponent();

        }

        void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
        }
    }
}
