using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DualScreenExamples.XF
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailsView : ContentView
    {
        public DetailsView()
        {
            InitializeComponent();
           
        }

        public void load(Item item)
        {
            labelDescription.Text = item.Description;
        }
    }
}