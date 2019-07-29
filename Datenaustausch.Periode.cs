// Namensraum 'Datenaustausch' enthält KLassen für den Informationstransport aus der Schicht 'Datenhaltung'
// Konsolenanwendung
// Verantwortlichkeit: Nick Waidner 64946

using System;

namespace EasyBankingPersonal.Datenaustausch
{
    /// <summary>
    /// Klasse zur Aufnahme der Werte einer Zeile der Tabelle 'Perioden'
    /// </summary>
    public class Periode
    {
        private readonly DateTime _beginn;
        private readonly DateTime _ende;
        private readonly int _nummer;

        public DateTime Beginn { get => _beginn; }
        public DateTime Ende { get => _ende; }
        public int Nummer { get => _nummer; }

        /// <summary>
        /// Konstrukor der Klasse Periode
        /// </summary>
        /// <param name="nummer"></param>
        /// <param name="beginn"></param>
        /// <param name="ende"></param>
        /// <exception wenn nummer nicht Positiv ></exception>
        public Periode(int nummer, DateTime beginn, DateTime ende)
        {
            if (nummer <= 0)
                throw new Exception();
            _beginn = beginn;
            _ende = ende;
            _nummer = nummer;
        }

        /// <summary>
        /// Methode um ein Objekt der Klasse Periode druckbar darzustellen
        /// </summary>
        /// <returns> gibt einen string zurück, der alle felder des Objektes enthält</returns>
        public override string ToString()
        {
            return "Periode Nummer: " + Nummer + "\nBeginn: " + Beginn + "\nEnde: " + Ende;
        }

    }
}