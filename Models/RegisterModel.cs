

namespace ClassManager.Models{
    public class RegisterModel{
        public RegisterModel(string firstName, string lastName, int idNumber, string password, string email)
        {
         FirstName=firstName;
         LastName=lastName;
         IdNumber=idNumber;
         Password=password;
         Email=email;   
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int IdNumber { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}