using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Store
{
    public partial class ProductDetail : ContentPage
    {
        public ProductDetail(Product product)
        {
            BindingContext = new ProductDetailViewModel(product);
            InitializeComponent();
        }
    }
}
