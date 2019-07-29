// Namensraum 'Datenaustausch' enthält KLassen für den Informationstransport aus der Schicht 'Datenhaltung'
// Konsolenanwendung
// Verantwortlichkeit: Nick Waidner 64946

using System;

namespace EasyBankingPersonal.Datenaustausch
{
    /// <summary>
    /// Klasse zur Aufnahme der Werte einer Zeile der Tabelle 'VolumenProMitarbeiter'
    /// </summary>
    public class VolumenProMitarbeiter : Anzahlen
    {
        /// <summary>
        /// Kosntruktor der Klasse VolumenProMitarbeiter
        /// </summary>
        /// <param name="autokredite"></param>
        /// <param name="konsumkredite"></param>
        /// <param name="hypothekenkredite"></param>
        /// <param name="girokonten"></param>
        /// <param name="spareinlagen"></param>
        /// <param name="termingelder"></param>
        /// <exception bei nicht positiven Werten></exception>
        public VolumenProMitarbeiter(int konsumkredite, int autokredite, int hypothekenkredite, int girokonten, int spareinlagen, int termingelder) : base(konsumkredite, autokredite, hypothekenkredite, girokonten, spareinlagen, termingelder)
        {
            if (autokredite == 0)
                throw new Exception();
            if (konsumkredite == 0)
                throw new Exception();
            if (hypothekenkredite == 0)
                throw new Exception();
            if (girokonten == 0)
                throw new Exception();
            if (spareinlagen == 0)
                throw new Exception();
            if (termingelder == 0)
                throw new Exception();
        }
    }
}