using AW1GUI.Lists.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AW1GUI.Lists
{
    public class ImmobilienWindowViewmodel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public List<Immobilie> Immobilien { get; } = new List<Immobilie>();

        public string Straße { get; set; }
        public string Hausnummer { get; set; }
        public string PLZ { get; set; }
        public string Stadt { get; set; }
        public string Baujahr { get; set; }
        public string Grundstücksgröße { get; set; }
        public string Wohnfläche { get; set; }
        public string Kellerfläche { get; set; }
        public string Heizungsanlage { get; set; }

        public ImmobilienWindowViewmodel() { }

        public void AddEntry()
        {
            Immobilie immobilie = new Immobilie
            {
                Baujahr = Convert.ToInt32(Baujahr),
                Grundstücksgröße = Convert.ToDouble(Grundstücksgröße),
                Hausnummer = Convert.ToInt32(Hausnummer),
                Heizungsanlage = Heizungsanlage,
                Kellerfläche = Convert.ToDouble(Kellerfläche),
                PLZ = Convert.ToInt32(PLZ),
                Stadt = Stadt,
                Straße = Straße,
                Wohnfläche = Convert.ToInt32(Wohnfläche)
            };
            Immobilien.Add(immobilie);
        }
    }
}
