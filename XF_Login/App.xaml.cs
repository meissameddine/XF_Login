﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_Login
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new XF_Login.Pages.LoginPage();
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
