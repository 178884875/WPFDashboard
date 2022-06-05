using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfDashBoard.UserControls
{
    /// <summary>
    /// Country.xaml 的交互逻辑
    /// </summary>
    public partial class Country : UserControl
    {
        public Country()
        {
            InitializeComponent();
        }


        public string CountryName
        {
            get { return (string)GetValue(CountryNameProperty); }
            set { SetValue(CountryNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CountryName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CountryNameProperty =
            DependencyProperty.Register("CountryName", typeof(string), typeof(Country));


        public string Price
        {
            get { return (string)GetValue(PriceProperty); }
            set { SetValue(PriceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Price.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PriceProperty =
            DependencyProperty.Register("Price", typeof(string), typeof(Country));


        public bool IsLevelUp
        {
            get { return (bool)GetValue(IsLevelUpProperty); }
            set { SetValue(IsLevelUpProperty, value); }
        }

        public static readonly DependencyProperty IsLevelUpProperty =
            DependencyProperty.Register("IsLevelUp", typeof(bool), typeof(Country));

        public ImageSource Flag
        {
            get { return (ImageSource)GetValue(FlagProperty); }
            set { SetValue(FlagProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Flag.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FlagProperty =
            DependencyProperty.Register("Flag", typeof(ImageSource), typeof(Country));




    }
}
