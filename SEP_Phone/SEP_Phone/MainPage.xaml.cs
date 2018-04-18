using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SEP_Phone
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            Geolocator geolocator = new Geolocator();
            geolocator.DesiredAccuracyInMeters = 5;
            double latitude = -1.0;
            double longitude = -1.0;
            double altitude = -1.0;
            try
            {
                Geoposition geoposition = await geolocator.GetGeopositionAsync(TimeSpan.FromMinutes(5), TimeSpan.FromSeconds(10));
                latitude = geoposition.Coordinate.Point.Position.Latitude;
                longitude = geoposition.Coordinate.Point.Position.Longitude;
                altitude = geoposition.Coordinate.Point.Position.Altitude;
                Coordonnee cgps = new Coordonnee(latitude, longitude, altitude);
                CoordConversion coordConversion = new CoordConversion(cgps,altitude);
                ErrorPrint.Text = latitude.ToString()+"|"+longitude.ToString()+"|"+altitude.ToString();

            }
            catch (UnauthorizedAccessException)
            {
                ErrorPrint.Text = "Location service is not activated";
            }
        }
    }
}
