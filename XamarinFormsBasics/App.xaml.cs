using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsBasics.ListView;

namespace XamarinFormsBasics
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();


            //MainPage = new MainPage();
            //MainPage = new NavigationPage(new MainPage()); // to naviagate from main page 
            MainPage = new TabbedPage // to make tabbed pages
            {
                Children = {
                    new MainPage(),
                    new Page1(""),
                    new ListViewExample(),
                    new ListViewWithItemTemplate()

                }
            };
            //MainPage = new CarouselPage
            //{
            //    Children = {
            //        new MainPage(),
            //        new Page1("")
            //    }
            //};



        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
