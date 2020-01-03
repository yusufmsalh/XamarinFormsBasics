using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsBasics.ListView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewExample : ContentPage
    {
        public ListViewExample()
        {
            InitializeComponent();
            myList.ItemsSource = new List<string>() {

            "Yusuf",
            "1",
            "2",
            "3"
            };
        }
    }
}