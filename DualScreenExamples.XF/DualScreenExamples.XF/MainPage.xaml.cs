using System;
using System.Collections.Generic;
using System.ComponentModel;
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
