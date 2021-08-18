﻿using Microsoft.OData.Edm;

namespace FunctionalTests_AutomationPracticeCom
{
    public class PersonalInfo
    {
        public string Title { get; }   // Mr. or Mrs.

        public string FirstName { get; }  // Test

        public string LastName { get; }   // Tiesto

        public int Email { get; }   // silvanio.tiesto@gmail.com

        public string Password { get; }  // 12345

        public Date dateOfBirth { get; }  //  Date(int year, int month, int day); 1981, 07 , 21
    }
}
