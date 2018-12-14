using System;
using System.Collections.Generic;
using Realms;
using Xamarin.Forms;
using XamarinDataBaseRealm.Model;

namespace XamarinDataBaseRealm.View
{
    public partial class NewContactPage : ContentPage
    {
        public NewContactPage()
        {
            InitializeComponent();

        }

       

        void Save(object sender, EventArgs e)
        {

            try
            {
                var realm = Realm.GetInstance();
                int _id = realm.All<Contact>().AsRealmCollection<Contact>().Count + 1;
                var contact = new Contact(NameEdit.Text.ToString(), NumberEdit.Text.ToString());
                realm.Write(() =>
                {
                    contact.Id = _id;
                    contact = realm.Add(contact);
                });
            }
            catch (Exception ex)
            {
                logs("NewContactPage:Save-Exception => "+ex.Message);
            }

        }


        public static void logs(String log)
        {
            System.Diagnostics.Debug.WriteLine(log);
        }

        protected override void  OnAppearing()
        {
            base.OnAppearing();
             
        }
    }
}
