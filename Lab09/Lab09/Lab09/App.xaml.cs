using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Lab09;

namespace Lab09
{
    public partial class App : Application
    {
        public static float ScreenHeight { get; set; }
        public static float ScreenWidth { get; set; }
        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new SwipeDemo();
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

    internal class MockDataStore
    {
    }
}
