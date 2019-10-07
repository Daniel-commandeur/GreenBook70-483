using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Listing_1_29_uwp
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
        private double computeAverages(long noOfValues)
        {
            double total = 0;
            Random rand = new Random();
            for (long values = 0; values < noOfValues; values++)
            {
                total = total + rand.NextDouble();
            }
            return total / noOfValues;
        }
        // Listing 1-32
        private Task<double> asyncComputeAverages(long noOfValues)
        {
            return Task<double>.Run(() => { return computeAverages(noOfValues); });
        }

        private void Listing_1_29_Button_Click(object sender, RoutedEventArgs e)
        {
            long noOfValues = long.Parse(NumberOfValuesTextBox.Text);
            ResultTextBlock.Text = "Result: " + computeAverages(noOfValues);
        }
        private void Listing_1_30_Button_Click(object sender, RoutedEventArgs e)
        {
            long noOfValues = long.Parse(NumberOfValuesTextBox.Text);
            Task.Run(() =>
            {
                ResultTextBlock.Text = "Result: " + computeAverages(noOfValues);
            });
        }
        private void Listing_1_31_Button_Click(object sender, RoutedEventArgs e)
        {
            long noOfValues = long.Parse(NumberOfValuesTextBox.Text);
            Task.Run(() =>
            {
                double result = computeAverages(noOfValues);
#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
                ResultTextBlock.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                    {
                        ResultTextBlock.Text = "Result: " + result.ToString();
                    });
#pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
            });
        }
        private async void Listing_1_32_Button_Click(object sender, RoutedEventArgs e)
        {
            long noOfValues = long.Parse(NumberOfValuesTextBox.Text);
            ResultTextBlock.Text = "Calculating";
            double result = await (asyncComputeAverages(noOfValues));
            ResultTextBlock.Text = "Result: " + result.ToString();
        }
    }
}
