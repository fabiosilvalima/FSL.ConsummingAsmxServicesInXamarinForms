using FSL.XF2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FSL.XF2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            lvCustomers.BeginRefresh();
            
            var customers = await App.CustomerSoapService.GetAllCustomers();

            lvCustomers.ItemsSource = customers;
            lvCustomers.EndRefresh();
        }

        private async void lvCustomers_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var customer = e.Item as ICustomer;

            var allCustomers = lvCustomers.ItemsSource as List<ICustomer>;
        }
    }
}
