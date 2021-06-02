using System;
using System.Linq;

namespace AW1.Wiederholung.Experten
{
    public static class Password
    {
        //rules + 1 lowercase, 1 uppercase, 1 special char
        private static readonly int minLength = 12;

        public static void TaskB()
        {
            Console.WriteLine("Zu prüfendes Passwort eingeben:");
            string pw = Console.ReadLine();
            bool isValid = CheckPw(pw);
            Console.WriteLine("Das Passwort ist " + (isValid ? "gültig" : "ungültig"));
        }

        private static bool CheckPw(string pw)
        {
            return pw.Length >= minLength && pw.Any(char.IsUpper) && pw.Any(char.IsLower) && pw.Any(c => !char.IsLetterOrDigit(c));
        }

        private static string RandomString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstufvxyzÄÖÜäöüß0123456789!\"§$%&/()=?+*#-_.:,;";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static void TaskC()
        {
            Random rand = new Random();
            string pw = RandomString(minLength + rand.Next(minLength));
            while(!CheckPw(pw))
                pw = RandomString(minLength + rand.Next(minLength));

            Console.WriteLine($"Zufälliges Passwort: {pw}");
        }

    }
}
