using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsBasics
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new NavigationPage(new MainPage());
            //MainPage = new TabbedPage
            //{
            //    Children = {
            //        new MainPage(),
            //        new Page1("")
            //    }
            //};
            MainPage = new CarouselPage
            {
                Children = {
                    new MainPage(),
                    new Page1("")
                }
            };
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
