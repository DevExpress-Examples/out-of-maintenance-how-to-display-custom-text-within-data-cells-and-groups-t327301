using System;
using System.Windows;

namespace DXSample {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            DataContext = DataHelper.GetData();
        }

        private void GridControl_CustomColumnDisplayText(object sender, DevExpress.Xpf.Grid.CustomColumnDisplayTextEventArgs e) {
            if (e.Column.FieldName == "AccessLevel") {
                switch ((int)e.Value) {
                    case 0:
                        e.DisplayText = "User";
                        break;
                    case 1:
                        e.DisplayText = "Moderator";
                        break;
                    case 2:
                        e.DisplayText = "Administrator";
                        break;
                    default:
                        break;
                }
            }
        }

        private void GridControl_CustomGroupDisplayText(object sender, DevExpress.Xpf.Grid.CustomGroupDisplayTextEventArgs e) {
            if (e.Column.FieldName == "RegistrationDate") {
                DateTime val = (DateTime)e.Value;
                e.DisplayText = val.ToString("dd-MMM-yyyy");
            }
        }
    }  
}
