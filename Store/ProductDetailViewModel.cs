using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace Store
{
    public class ProductDetailViewModel : INotifyPropertyChanged
    {
        public ProductDetailViewModel(Product product)
        {
            ArrowGoBackCommand = new Command(GoBack);

            Title = product.ProductName;
            Background = product.Background;
            PictureName = product.PictureName;
            ProductPrice = $"US { product.ProductPrice}";
            ProductDescription = product.ProductDescription;
            Caracteristics = product.Caracteristics;
            ButtonPurchase = product.ButtonPurchase;

        }

        public ICommand ArrowGoBackCommand { get; set; }
        public string Title { get; set; } 
        public string Background { get; set; }
        public string PictureName { get; set; }
        public string ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public string Caracteristics { get; set; }
        public string ButtonPurchase { get; set; }

        public void GoBack()
        {
            Xamarin.Forms.Application.Current.MainPage.Navigation.PopAsync();
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
