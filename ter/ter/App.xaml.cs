using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ter
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "recipe.db";
        public static RecipeRepository database;
        public static RecipeRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new RecipeRepository(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

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
