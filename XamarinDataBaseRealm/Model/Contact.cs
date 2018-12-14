using System;
using Realms;

namespace XamarinDataBaseRealm.Model
{
    public class Contact : RealmObject
    {
        [PrimaryKey]
        public int Id { set; get; }
        public string Name { set; get; }
        public string Number { set; get; }

        public Contact(string name, string number)
        {
            Name = name;
            Number = number;
        }

        public Contact(){}

        public String ToString()
        {
            return 
                "\nId: " + Id 
                + "\nName: " + Name 
                + "\nNumber: " + Number
                + "\n==============================";
        }
    }
}
