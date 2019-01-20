using System;

namespace UnitTesting_EmailCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            string mailaddress = "ich@providercom";
            testen(mailaddress);
        }
        public static bool IsEmailAddress(string emailAddress)
        {
            int iAt = emailAddress.IndexOf('@');
            int iDot = emailAddress.LastIndexOf('.');
            return (iAt > 0 && iDot > iAt); 
        }
        public static void testen(string emailAddress)
        {
            if (IsEmailAddress(emailAddress))
            {
                Console.WriteLine("TEST PASSED: " + emailAddress + " korrekt als Email-Adresse erkannt");
            }
            
            else
            {
                Console.WriteLine("TEST FAILED: " + emailAddress + " nicht als Email-Adresse erkannt, obwohl korrekt.");
            }
        }
    }
}
