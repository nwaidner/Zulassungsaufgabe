// Namensraum 'Datenaustausch' enthält KLassen für den Informationstransport aus der Schicht 'Datenhaltung'
// Konsolenanwendung
// Verantwortlichkeit: Nick Waidner 64946

using System;

namespace EasyBankingPersonal.Datenaustausch
{
    /// <summary>
    /// Klasse zur Aufnahme der Werte einer Zeile der Tabelle 'Durchschnittsgrößen'
    /// </summary>
    public class Durchschnittsgrößen : Produkte
    {
        /// <summary>
        /// Konstruktor der Klasse Durchschnittsgröße
        /// </summary>
        /// <param name="autokredite"></param>
        /// <param name="girokonten"></param>
        /// <param name="hypothekenkredite"></param>
        /// <param name="konsumkredite"></param>
        /// <param name="spareinlagen"></param>
        /// <param name="termingelder"></param>#
        /// <exception bei nicht positiem Wert></exception>
        public Durchschnittsgrößen(Währung konsumkredite, Währung autokredite, Währung hypothekenkredite, Währung girokonten, Währung spareinlagen, Währung termingelder) : base(konsumkredite, autokredite,  hypothekenkredite, girokonten, spareinlagen, termingelder)
        {
            if (autokredite.Betrag == 0)
                throw new Exception();
            if (girokonten.Betrag == 0)
                throw new Exception();
            if (hypothekenkredite.Betrag == 0)
                throw new Exception();
            if (konsumkredite.Betrag == 0)
                throw new Exception();
            if (spareinlagen.Betrag == 0)
                throw new Exception();
            if (termingelder.Betrag == 0)
                throw new Exception();
        }
    }
}