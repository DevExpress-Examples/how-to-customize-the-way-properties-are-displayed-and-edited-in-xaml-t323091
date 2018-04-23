using System.Windows;

namespace DXSample {
    public partial class MainWindow : Window {
        public MainWindow() {
            DataContext = new Contact {
                FirstName = "Carolyn",
                LastName = "Baker",
                Email = "carolyn.baker@example.com",
                Phone = "(555)349-3010",
                Address = "1198 Theresa Cir",
                City = "Whitinsville",
                State = "MA",
                Zip = "01582",
            };
            InitializeComponent();
        }
    }
    public class Contact {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CreditCardNumber { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public byte[] Photo { get; set; }
    }
}