using System;
using System.Collections.ObjectModel;

namespace DXSample {

    public class DataHelper {
        public static ObservableCollection<Profile> GetData() {
            ObservableCollection<Profile> collection = new ObservableCollection<Profile>();
            collection.Add(new Profile() { ID = 0, Login = "USERNAME1", AccessLevel = 2, RegistrationDate = new DateTime(2015, 12, 19) });
            collection.Add(new Profile() { ID = 1, Login = "USERNAME2", AccessLevel = 0, RegistrationDate = new DateTime(2015, 12, 27) });            
            collection.Add(new Profile() { ID = 2, Login = "USERNAME3", AccessLevel = 0, RegistrationDate = new DateTime(2015, 12, 27) });
            collection.Add(new Profile() { ID = 3, Login = "USERNAME4", AccessLevel = 0, RegistrationDate = new DateTime(2015, 12, 27) });
            collection.Add(new Profile() { ID = 4, Login = "USERNAME5", AccessLevel = 1, RegistrationDate = new DateTime(2015, 12, 22) });
            collection.Add(new Profile() { ID = 5, Login = "USERNAME6", AccessLevel = 0, RegistrationDate = new DateTime(2015, 12, 27) });
            collection.Add(new Profile() { ID = 6, Login = "USERNAME7", AccessLevel = 0, RegistrationDate = new DateTime(2015, 12, 27) });
            collection.Add(new Profile() { ID = 8, Login = "USERNAME9", AccessLevel = 0, RegistrationDate = new DateTime(2015, 12, 27) });
            collection.Add(new Profile() { ID = 7, Login = "USERNAME8", AccessLevel = 1, RegistrationDate = new DateTime(2015, 12, 22) });            
            return collection;
        }
    }
}
