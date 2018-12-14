using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinDataBaseRealm.View;

namespace XamarinDataBaseRealm
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async void NewContact(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewContactPage());
        }
        async void OpenListContacts(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListContactsPage());
        }
    }

    }
