using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

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

            items.Add(new Item("Item 1", "bla bla bla bla bla"));
            items.Add(new Item("Item 2", "bla bla bla bla bla"));
            items.Add(new Item("Item 3", "bla bla bla bla bla"));
            items.Add(new Item("Item 4", "bla bla bla bla bla"));
            items.Add(new Item("Item 5", "bla bla bla bla bla"));
            items.Add(new Item("Item 6", "bla bla bla bla bla"));
            items.Add(new Item("Item 7", "bla bla bla bla bla"));

            listView.BindingContext = items;
        }
    }
}
