using System.Windows.Input;

namespace Store
{
    public class Product
    {
        public string ProductImage { get; set; }
        public string ProductName { get; set; }
        public string ProductPrice { get; set; }
        public string ProductColor { get; set; }
        public string PreferenceButtonName { get; set; }
        public string LowerProductImage { get; set; }

        public ICommand ProductDetailNavTap { get; set; }
        public string PictureName { get; set; }
        public string ProductDescription { get; set; }
        public string Caracteristics { get; set; }
        public string ButtonPurchase { get; set; }
        public string Background { get; set; }

    }
}