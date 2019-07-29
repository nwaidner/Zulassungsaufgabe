// Namensraum 'Datenaustausch' enthält KLassen für den Informationstransport aus der Schicht 'Datenhaltung'
// Konsolenanwendung
// Verantwortlichkeit: Nick Waidner 64946

using System;

namespace EasyBankingPersonal.Datenaustausch
{
    /// <summary>
    /// Klasse zur Aufnahme der Werte einer Zeile der Tabelle 'Mitarbeiter'
    /// </summary>
    public class Mitarbeiter
    {
        private readonly int _kreditberater;
        private readonly int _anlageberater;
        private readonly int _backofficemitarbeiter;
        private readonly double _fluktuation;
        private readonly int _trainingstageProMitarbeiter;
        private readonly int _insgesamt;

        public int Kreditberater { get => _kreditberater; }
        public int Anlageberater { get => _anlageberater; }
        public int Backofficemitarbeiter { get => _backofficemitarbeiter; }
        public int TrainingstageProMitarbeiter { get => _trainingstageProMitarbeiter; }
        public double Fluktuation { get => _fluktuation; }
        public int Frontofficemitarbeiter { get => Anlageberater + Kreditberater; }
        public int Insgesamt { get => _insgesamt; }

        /// <summary>
        /// Konstruktor der Klasse Mitarbeiter
        /// </summary>
        /// <param name="kreditberater"></param>
        /// <param name="anlageberater"></param>
        /// <param name="backofficemitarbeiter"></param>
        /// <param name="fluktuation"></param>
        /// <param name="trainingstageProMitarbeiter"></param>
        /// <exception bei negativen werten></exception>
        public Mitarbeiter(int kreditberater, int anlageberater, int backofficemitarbeiter, double fluktuation, int trainingstageProMitarbeiter)
        {
            if (kreditberater < 0)
                throw new Exception();
            if (anlageberater < 0)
                throw new Exception();
            if (backofficemitarbeiter < 0)
                throw new Exception();
            if (trainingstageProMitarbeiter < 0)
                throw new Exception();
            if (fluktuation > 1 || fluktuation < 0)
                throw new Exception();

            _kreditberater = kreditberater;
            _anlageberater = anlageberater;
            _backofficemitarbeiter = backofficemitarbeiter;
            _fluktuation = fluktuation;
            _trainingstageProMitarbeiter = trainingstageProMitarbeiter;
            _insgesamt = Backofficemitarbeiter + Frontofficemitarbeiter;
        }
    }
}