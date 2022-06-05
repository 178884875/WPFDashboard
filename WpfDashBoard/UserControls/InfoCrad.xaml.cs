using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfDashBoard.UserControls
{
    /// <summary>
    /// Interaction logic for InfoCrad.xaml
    /// </summary>
    public partial class InfoCrad : UserControl
    {
        public InfoCrad()
        {
            InitializeComponent();
        }


        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(InfoCrad));



        public string Number
        {
            get { return (string)GetValue(NumberProperty); }
            set { SetValue(NumberProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Number.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NumberProperty =
            DependencyProperty.Register("Number", typeof(string), typeof(InfoCrad));





        public bool IsActive
        {
            get { return (bool)GetValue(IsActiveProperty); }
            set { SetValue(IsActiveProperty, value); }
        }

        public static readonly DependencyProperty IsActiveProperty =
            DependencyProperty.Register("IsActive", typeof(bool), typeof(InfoCrad));




        public bool IsTechnical
        {
            get { return (bool)GetValue(IsTechnicalProperty); }
            set { SetValue(IsTechnicalProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsTechnical.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsTechnicalProperty =
            DependencyProperty.Register("IsTechnical", typeof(bool), typeof(InfoCrad));



    }
}
