// Namensraum 'Datenaustausch' enthält KLassen für den Informationstransport aus der Schicht 'Datenhaltung'
// Konsolenanwendung
// Verantwortlichkeit: Nick Waidner 64946

using System;

namespace EasyBankingPersonal.Datenaustausch
{
    /// <summary>
    /// Klasse zur Speicherung von Anzahlen bezüglich unserer sechs Bankenprodukte
    /// </summary>
    public class Anzahlen
    {
        private readonly int _autokredite;
        private readonly int _konsumkredite;
        private readonly int _hypothekenkredite;
        private readonly int _girokonten;
        private readonly int _spareinlagen;
        private readonly int _termingelder;

        public int Autokredite { get => _autokredite; }
        public int Konsumkredite { get => _konsumkredite; }
        public int Hypothekenkredite { get => _hypothekenkredite; }
        public int Girokonten { get => _girokonten; }
        public int Spareinlagen { get => _spareinlagen; }
        public int Termingelder { get => _termingelder; }

        /// <summary>
        /// Konstruktor der Klasse Anzahlen
        /// </summary>
        /// <param name="konsumkredite"></param>
        /// <param name="autokredite"></param>
        /// <param name="hypothekenkredite"></param>
        /// <param name="girokonten"></param>
        /// <param name="spareinlagen"></param>
        /// <param name="termingelder"></param>
        /// <exception negative werte ></exception>
        public Anzahlen(int konsumkredite, int autokredite, int hypothekenkredite, int girokonten, int spareinlagen, int termingelder)
        {
            if (autokredite < 0)
                throw new ArgumentException();
            if (konsumkredite < 0)
                throw new Exception();
            if (hypothekenkredite < 0)
                throw new Exception();
            if (girokonten < 0)
                throw new Exception();
            if (spareinlagen < 0)
                throw new Exception();
            if (termingelder < 0)
                throw new Exception();

            _autokredite = autokredite;
            _konsumkredite = konsumkredite;
            _hypothekenkredite = hypothekenkredite;
            _girokonten = girokonten;
            _spareinlagen = spareinlagen;
            _termingelder = termingelder;
        }
    }
}