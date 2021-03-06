﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLiteAndCloud.Data;
using SQLiteAndCloud.Views;
using SQLiteAndCloud.Models;


[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SQLiteAndCloud
{
    public partial class App : Application
    {
        static TodoItemDatabase database;

        public App()
        {
            InitializeComponent();

            var nav = new NavigationPage(new TodoListPage());
            nav.BarBackgroundColor = (Color)App.Current.Resources["primaryGreen"];
            nav.BarTextColor = Color.White;

            MainPage = nav;
        }

        public static TodoItemDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new TodoItemDatabase();
                }
                return database;
            }
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