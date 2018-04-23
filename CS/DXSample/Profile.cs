using DevExpress.Mvvm;
using System;

namespace DXSample {    
    public class Profile : BindableBase {
        public int ID {
            get { return GetProperty(() => ID); }
            set { SetProperty(() => ID, value); }
        }
        public string Login {
            get { return GetProperty(() => Login); }
            set { SetProperty(() => Login, value); }
        }
        public int AccessLevel {
            get { return GetProperty(() => AccessLevel); }
            set { SetProperty(() => AccessLevel, value); }
        }

        public DateTime RegistrationDate {
            get { return GetProperty(() => RegistrationDate); }
            set { SetProperty(() => RegistrationDate, value); }
        }        
    }
}
