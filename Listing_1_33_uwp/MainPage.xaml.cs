using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
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

namespace Listing_1_33_uwp
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

        private static async Task<string> FetchWebPage(string url)
        {
            HttpClient httpClient = new HttpClient();
            return await httpClient.GetStringAsync(url);
        }
        // Listing 1-34
        static async Task<IEnumerable<string>> FetchWebPages(string[] urls)
        {
            var tasks = new List<Task<String>>();
            foreach (string url in urls)
            {
                tasks.Add(FetchWebPage(url));
            }
            return await Task.WhenAll(tasks);
        }

        // Listing 1-33
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            // if/else added for Listing 1-34
            if (URLTextBox.Text.Contains(','))
            {
                LoadMultipleUrls();
            }
            else
            {
                // Listing 1-33
                try
                {
                    ResultTextBlock.Text = await FetchWebPage(URLTextBox.Text);
                    StatusTextBlock.Text = "Page Loaded";
                }
                catch (Exception ex)
                {
                    StatusTextBlock.Text = ex.Message;
                }
            }
        }

        // Code to make Listing 1-34 work
        private async void LoadMultipleUrls()
        {
            string[] urls = URLTextBox.Text.Split(',');
            List<string> pageTexts = new List<string>();
            try
            {
                pageTexts = (await FetchWebPages(urls)).ToList();
            }
            catch (Exception ex)
            {
                StatusTextBlock.Text = ex.Message;
            }
            foreach (string pageText in pageTexts)
            {
                ContentDialog htmlTextResultPage = new ContentDialog()
                {
                    Title = "HTML ResultPage",
                    Content = pageText,
                    CloseButtonText = "Ok"
                };
                await htmlTextResultPage.ShowAsync();
            }
        }
    }
}
