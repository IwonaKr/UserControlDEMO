using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace UserControlDEMO
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            Deployment.Current.Dispatcher.BeginInvoke(() =>
            {
                UC hih = new UC();
                hih.tb1.Text="Śnieg";
                hih.tb2.Text="OMG";
                hih.tb3.Text="Coca-cola";
                Uri uri = new Uri("Icons/snow.png", UriKind.Relative);
                ImageSource imgSrc = new BitmapImage(uri);
                hih.img.Source=imgSrc;
                this.CP.Children.Add(hih);
                UC hih2 = new UC();
                hih2.tb3.Text="jdhfjdshjfs";
                hih2.tb2.Text="khhfhfhfhfh";
                hih2.tb3.Text="llllllllll";
                imgSrc = new BitmapImage(new Uri("Icons/sunny.png", UriKind.Relative));
                hih2.img.Source=imgSrc;
                this.CP.Children.Add(hih2);

            });
        }
    }
}