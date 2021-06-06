using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ter
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            aboutList.ItemsSource = GetMenuList();
            var homePage = typeof(Views.Item1);
            Detail = new NavigationPage((Page)Activator.CreateInstance(homePage));
            IsPresented = false;
        }

        public List<MasterMenuItems> GetMenuList()
        {
            var list = new List<MasterMenuItems>();
            list.Add(new MasterMenuItems()
            {
                Text = "Основное",
                ImagePath = "dr.png",
                TargetPage = typeof(Views.Item1)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Броня",
                ImagePath = "ar.png",
                TargetPage = typeof(Views.Item2)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Оружие",
                ImagePath = "we.png",
                TargetPage = typeof(Views.Item3)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Крылья",
                ImagePath = "sunwin.png",
                TargetPage = typeof(Views.Item4)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Свой рецепт",
                ImagePath = "gid.png",
                TargetPage = typeof(MainPage2)
            });
            return list;
        }

        private void aboutList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedMenuItem = (MasterMenuItems)e.SelectedItem;
            Type selectedPage = selectedMenuItem.TargetPage;
            Detail = new NavigationPage((Page)Activator.CreateInstance(selectedPage));
            IsPresented = false;
        }
    }
}
