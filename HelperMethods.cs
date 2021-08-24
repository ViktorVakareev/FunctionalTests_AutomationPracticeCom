using System;

namespace FunctionalTests_AutomationPracticeCom
{
    public class HelperMethods
    {
        public static string GenerateNewRandomEmailOrPassword()
        {
            var rnd = new Random();
            return $"vic{rnd.Next(555,55555)}@gmail.com";
        }
    }
}
