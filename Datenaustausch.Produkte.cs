// Namensraum 'Datenaustausch' enthält KLassen für den Informationstransport aus der Schicht 'Datenhaltung'
// Konsolenanwendung
// Verantwortlichkeit: Nick Waidner 64946

using System;

namespace EasyBankingPersonal.Datenaustausch
{
    /// <summary>
    /// abstrakte Basisklasse für Geldwerte bezüglich der sechs Bankprodukte
    /// </summary>
    public abstract class Produkte
    {
        private Währung _autokredite = new Währung();
        private Währung _girokonten = new Währung();
        private Währung _hypothekenkredite = new Währung();
        private Währung _konsumkredite = new Währung();
        private Währung _spareinlagen = new Währung();
        private Währung _termingelder = new Währung();

        public Währung Autokredite { get => _autokredite; }
        public Währung Girokonten { get => _girokonten; }
        public Währung Hypothekenkredite { get => _hypothekenkredite; }
        public Währung Konsumkredite { get => _konsumkredite; }
        public Währung Spareinlagen { get => _spareinlagen; }
        public Währung Termingelder { get => _termingelder; }

        /// <summary>
        /// Konstruktor der abstrakten Klasse Währung
        /// </summary>
        /// <param name="konsumkredite"></param>
        /// <param name="autokredite"></param>
        /// <param name="hypothekenkredite"></param>
        /// <param name="girokonten"></param>
        /// <param name="spareinlagen"></param>
        /// <param name="termingelder"></param>
        /// <exception bei negativen Werten></exception>
        public Produkte(Währung konsumkredite, Währung autokredite, Währung hypothekenkredite, Währung girokonten, Währung spareinlagen, Währung termingelder)
        {
            if (autokredite.Betrag < 0)
                throw new Exception();
            if (girokonten.Betrag < 0)
                throw new Exception();
            if (hypothekenkredite.Betrag < 0)
                throw new Exception();
            if (konsumkredite.Betrag < 0)
                throw new Exception();
            if (spareinlagen.Betrag < 0)
                throw new Exception();
            if (termingelder.Betrag < 0)
                throw new Exception();

            _autokredite = autokredite;
            _girokonten = girokonten;
            _hypothekenkredite = hypothekenkredite;
            _konsumkredite = konsumkredite;
            _spareinlagen = spareinlagen;
            _termingelder = termingelder;
        }
    }
}