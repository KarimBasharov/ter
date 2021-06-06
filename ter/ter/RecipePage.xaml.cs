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
    public partial class RecipePage : ContentPage
    {
        public RecipePage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var recipee = (Recipe)BindingContext;
            if (!String.IsNullOrEmpty(recipee.Name))
            {
                App.Database.SaveItem(recipee);
            }
            this.Navigation.PopAsync();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            var recipee = (Recipe)BindingContext;
            App.Database.DeleteItem(recipee.Id);
            this.Navigation.PopAsync();
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }
    }
}