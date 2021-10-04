using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Store.Resource;
using Xamarin.Forms;

namespace Store
{
    public class HomePageViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Product> Product { get; set; }

        public string Title { get; set; }
        public string MostPopularSubtitle { get; set; }
        public string TodaysDealsSubtitle { get; set; }
        public string LatestTechnologySubtitle { get; set; }
        public string LowerTitle { get; set; }

        public ObservableCollection<Product> PreferenceButton { get; set; }

        public ObservableCollection<Product> LowerImage { get; set; }

        public HomePageViewModel()
        {
            Title = AppResources.Store;
            MostPopularSubtitle = AppResources.MostPopular;
            TodaysDealsSubtitle = AppResources.TodaysDeals;
            LatestTechnologySubtitle = AppResources.LatestTechnology;
            LowerTitle = AppResources.PreOwned;

            ProductDetailNav = new Command<Product>(OnSelect);


            Product = new ObservableCollection<Product>();

            Product.Add(new Product
            {
                ProductName = "iPhone",
                ProductPrice = $"${1300}",
                ProductColor = "RED",
                ProductImage = "rediphone",
                ProductDetailNavTap = ProductDetailNav,
                Background = "#000",
                PictureName = "rediphone1",
                ProductDescription = "This phone is unlocked and compatible with any carrier of choice on GSM.Tested for battery health and guaranteed to have a minimum battery capacity of 80%.",
                Caracteristics = "USA Quartz Movement",
                ButtonPurchase = "ADD TO CART"
            });

            Product.Add(new Product
            {
                ProductName = "Camera",
                ProductPrice = $"${2500}",
                ProductColor = "RED",
                ProductImage = "redcamera",
                ProductDetailNavTap = ProductDetailNav,
                Background = "#000",
                PictureName = "redcamera1",
                ProductDescription = "The PowerShot SX410 IS camera is packed with advanced Canon technologies that make it easy to capture your best images ever. ",
                Caracteristics = "USA Quartz Movement",
                ButtonPurchase = "ADD TO CART"
            });

            Product.Add(new Product
            {
                ProductName = "Laptop",
                ProductPrice = $"${3000}",
                ProductColor = "RED",
                ProductImage = "redlaptop",
                ProductDetailNavTap = ProductDetailNav,
                Background = "#000",
                PictureName = "redlaptop1",
                ProductDescription = "Get your hands on a versatile 15 inch laptop packed with features for an enjoyable multimedia experience.",
                Caracteristics = "USA Quartz Movement",
                ButtonPurchase = "ADD TO CART"
            });

            PreferenceButton = new ObservableCollection<Product>();

            PreferenceButton.Add(new Product { PreferenceButtonName = "Relevance" });
            PreferenceButton.Add(new Product { PreferenceButtonName = "Filters" });

            LowerImage = new ObservableCollection<Product>();

            LowerImage.Add(new Product { LowerProductImage = "redheadphones" });
            LowerImage.Add(new Product { LowerProductImage = "redpc" });
        }

        public ICommand ProductDetailNav { get; set; }
        

        public void OnSelect(Product product)
        {
            
            Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new ProductDetail(product));
        }
        

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
