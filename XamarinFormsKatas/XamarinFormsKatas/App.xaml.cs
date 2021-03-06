﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsKatas.Katas_UI.Kata_c;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamarinFormsKatas
{
    public partial class App : Application
    {
        public static KataC MasterDetail { get; internal set; }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Katas_UI.Kata_a.KataA());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
