using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OtherFunctions
{
    public class InputValidate
    {
        public InputValidate() { }

        static void Main(string[] args)
        {
            Console.Write("Nhap ngay sinh: ");
            string birthday = Console.ReadLine();
            Console.WriteLine(BirthdayValidate(birthday));
        }

        public static bool PhoneNumberValidate(string phoneNumber)
        {
            string pattern = @"^(0\d{9}|84\d{9}|\+84\d{9})$";

            return (Regex.IsMatch(phoneNumber, pattern));
        }

        public static bool EmailValidate(string email)
        {
            return MailAddress.TryCreate(email, out var resultEmail);
        }

        public static bool BirthdayValidate(string birthday)
        {
            string[] dateFormats = new string[]
        {
            "dd/MM/yyyy",
            "dd/M/yyyy",
            "d/MM/yyyy",
            "d/M/yyyy",
            "dd-MM-yyyy",
            "dd-M-yyyy",
            "d-MM-yyyy",
            "d-M-yyyy",
            "yyyy/MM/dd",
            "yyyy/M/d",
            "yyyy-MM-dd",
            "yyyy-M-d"
        };
            return DateTime.TryParseExact(birthday, dateFormats, CultureInfo.InvariantCulture, DateTimeStyles.None, out var dateTime);
        }
    }   
}
