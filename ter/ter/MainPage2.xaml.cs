using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ter
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage2 : ContentPage
    {
        public MainPage2()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            recipeList.ItemsSource = App.Database.GetItems();
            base.OnAppearing();
        }

        private async void recipeList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Recipe selectedRecipe = (Recipe)e.SelectedItem;
            RecipePage recipePage = new RecipePage();
            recipePage.BindingContext = selectedRecipe;
            await Navigation.PushAsync(recipePage);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Recipe reciipe = new Recipe();
            RecipePage recipePage = new RecipePage();
            recipePage.BindingContext = reciipe;
            await Navigation.PushAsync(recipePage);
        }
    }
}