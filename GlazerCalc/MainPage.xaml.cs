using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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

namespace GlazerCalc
{
    public sealed partial class MainPage : Page
    {
        const double MAX_WIDTH = 96;
        const double MIN_WIDTH = 0;
        const double MAX_HEIGHT = 96;
        const double MIN_HEIGHT = 0;
        public int MyValue { get; set; }
        double height, width, area, perimeter;

        public MainPage()
        {
            

            this.InitializeComponent();
            DataContext = this;
        }

        private void calcBtn_Click(object sender, RoutedEventArgs e)
        {           
            string tintColor;
            if (heightBox != null && widthBox != null)
            {
                height = Double.Parse(heightBox.Text.ToString());
                width = Double.Parse(widthBox.Text.ToString());
                area = height * width;
                perimeter = 2 * (height + width);
                areaBox.Text = "" + area;
                perimeterBox.Text = "" + perimeter; 
                if (black.IsChecked == true)
                {
                    tintColor = "Black";
                }else if (blue.IsChecked == true)
                {
                    tintColor = "Blue";
                }else if (brown.IsChecked==true)
                {
                    tintColor = "Brown";
                }
                else
                {
                    tintColor = "No Tint Selected";
                }
                colorBox.Text = tintColor;
            }
        }

        void checkInput(object sender, KeyRoutedEventArgs e)
        {
            var height = .0;
            var width = .0;
            var heightText = heightBox.Text;
            if(Double.TryParse(heightText.ToString() , out height))
            {
                if(height < MIN_HEIGHT || height > MAX_HEIGHT)
                {
                    heightBox.Text = "";
                    height = 0;
                }
            }
            else
            {
                heightBox.Text = "";
            }
            if(Double.TryParse(heightText.ToString(), out width))
            {
                if (width < MIN_WIDTH || width > MAX_WIDTH)
                {
                    widthBox.Text = "";
                    width = 0;
                }
            }
            else
            {
                widthBox.Text = "";
            }
        }
    }
}
