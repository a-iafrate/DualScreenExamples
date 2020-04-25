using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.DualScreen;

namespace DualScreenExamples.XF
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public List<Item> items = new List<Item>();
        DualScreenInfo currentWindows = DualScreenInfo.Current;

        public MainPage()
        {
            InitializeComponent();

            items.Add(new Item("Item 1", "Description 1"));
            items.Add(new Item("Item 2", "Description 2"));
            items.Add(new Item("Item 3", "Description 3"));
            items.Add(new Item("Item 4", "Description 4"));
            items.Add(new Item("Item 5", "Description 5"));
            items.Add(new Item("Item 6", "Description 6"));
            items.Add(new Item("Item 7", "Description 7"));

            listView.ItemsSource = items;
            currentWindows.PropertyChanged += CurrentWindows_PropertyChanged;
        }

        private void CurrentWindows_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Debug.WriteLine(String.Format($"SpanMode: {currentWindows.SpanMode}"));
            Debug.WriteLine(String.Format($"Panels count: {currentWindows.SpanningBounds.Length}"));
            if (currentWindows.SpanningBounds.Length > 0)
            {
                Debug.WriteLine(String.Format($"Panel2: {currentWindows.SpanningBounds[0].Width}"));
                Debug.WriteLine(String.Format($"Panel2: {currentWindows.HingeBounds.Width}"));
            }
            if (currentWindows.SpanningBounds.Length > 1)
            {
                Debug.WriteLine(String.Format($"Panel2: {currentWindows.SpanningBounds[1].Width}"));
            }
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Item item = (Item)e.SelectedItem;
            if (twoPaneView.Mode!=TwoPaneViewMode.SinglePane)
            {
                detailsPage.load(item);
            }
            else
            {
                Navigation.PushAsync(new DetailsPage(item));
            }
        }
    }
}
