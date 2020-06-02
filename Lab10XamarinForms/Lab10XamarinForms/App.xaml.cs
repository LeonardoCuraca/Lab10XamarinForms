﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Lab10XamarinForms.Services;
using Lab10XamarinForms.Views;

namespace Lab10XamarinForms
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
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
