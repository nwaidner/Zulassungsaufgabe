// Namensraum 'Datenaustausch' enthält KLassen für den Informationstransport aus der Schicht 'Datenhaltung'
// Konsolenanwendung
// Verantwortlichkeit: Nick Waidner 64946

using System;

namespace EasyBankingPersonal.Datenaustausch
{

    /// <summary>
    /// Klasse zur aufnahme der Werte einer Zeile der Tabelle 'Personalkosten'
    /// </summary>
    public class Personalkosten
    {
        private Währung _durchschnittsjahresgehalt;
        private Währung _kostenProEinstellung;
        private Währung _kostenProEntlassung;
        private Währung _trainingskostenProTagUndMitarbeiter;

        public Währung Durchschnittsjahresgehalt { get => _durchschnittsjahresgehalt; }
        public Währung KostenProEinstellung { get => _kostenProEinstellung; }
        public Währung KostenProEntlassung { get => _kostenProEntlassung; }
        public Währung TrainingskostenProTagUndMitarbeiter { get => _trainingskostenProTagUndMitarbeiter; }

        /// <summary>
        /// Konstruktor der Klasse Personalkosten
        /// </summary>
        /// <param name="durchschnittsjahresgehalt"></param>
        /// <param name="kostenProEinstellung"></param>
        /// <param name="kostenProEntlassung"></param>
        /// <param name="trainingskostenProTagUndMitarbeiter"></param>
        /// <exception bei negativen Werten></exception>
        public Personalkosten(Währung durchschnittsjahresgehalt, Währung kostenProEinstellung, Währung kostenProEntlassung, Währung trainingskostenProTagUndMitarbeiter)
        {
            if (durchschnittsjahresgehalt.Betrag < 0)
                throw new Exception();
            if (kostenProEinstellung.Betrag < 0)
                throw new Exception();
            if (kostenProEntlassung.Betrag < 0)
                throw new Exception();
            if (trainingskostenProTagUndMitarbeiter.Betrag < 0)
                throw new Exception();

            _durchschnittsjahresgehalt = durchschnittsjahresgehalt;
            _kostenProEinstellung = kostenProEinstellung;
            _kostenProEntlassung = kostenProEntlassung;
            _trainingskostenProTagUndMitarbeiter = trainingskostenProTagUndMitarbeiter;
        }
    }
}