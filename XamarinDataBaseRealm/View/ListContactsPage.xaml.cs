using System;
using System.Collections.Generic;
using Realms;
using Xamarin.Forms;
using XamarinDataBaseRealm.Model;

namespace XamarinDataBaseRealm.View
{
    public partial class ListContactsPage : ContentPage
    {
        public ListContactsPage()
        {
            InitializeComponent();
        }

        void GetContacts()
        {
            var realm = Realm.GetInstance();
            var list = realm.All<Contact>(); // read all contcts
            foreach (Contact c in list)
            {
                //logs(c.ToString());
                //configure your listview
            }

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            GetContacts();
        }
    }
}
