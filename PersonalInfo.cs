using Microsoft.OData.Edm;

namespace FunctionalTests_AutomationPracticeCom
{
    public class PersonalInfo
    {
        private readonly string validEmail = "silvanio.tiesto@gmail.com";

        private readonly string validPassword = "12345";

        public string Title { get; set; }   // Mr. or Mrs.

        public string FirstName { get; set; }  // Test

        public string LastName { get; set; }   // Tiesto

        public string Email { get; }   // silvanio.tiesto@gmail.com

        public string Password { get; set; }  // 12345

        public Date DateOfBirth { get; set; }  //  Date(int year, int month, int day); 1981, 07 , 21

        public string ValidEmail => validEmail;

        public string ValidPassword => validPassword;
    }
}
