﻿namespace AW1.Vererbung.Model
{
    public class Mitarbeiter : Person
    {
        private string abteilung;
        public Mitarbeiter(string name, string abteilung) : base(name)
        {
            SetAbteilung(abteilung);
        }

        public string GetAbteilung() => abteilung;

        public void SetAbteilung(string ab)
        {
            abteilung = ab;
        }
    }
}
