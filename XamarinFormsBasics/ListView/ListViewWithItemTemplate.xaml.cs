using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsBasics.Models;

namespace XamarinFormsBasics.ListView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewWithItemTemplate : ContentPage
    {
        public ListViewWithItemTemplate()
        {
            InitializeComponent();
            var myDataList = new List<Person>()
            { 
            new Person(){ Name="Yusuf1",Age=25},
            new Person(){ Name="Yusuf2",Age=25},
            new Person(){ Name="Yusuf3",Age=25},
            new Person(){ Name="Yusuf4",Age=25},

            };
            myList.ItemsSource = myDataList;
        }
    }
}