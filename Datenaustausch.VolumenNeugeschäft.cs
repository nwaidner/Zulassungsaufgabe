// Namensraum 'Datenaustausch' enthält KLassen für den Informationstransport aus der Schicht 'Datenhaltung'
// Konsolenanwendung
// Verantwortlichkeit: Nick Waidner 64946

using System;

namespace EasyBankingPersonal.Datenaustausch
{
    public class VolumenNeugeschäft : Produkte
    {
        /// <summary>
        /// Konstruktor der Klasse VolumenNeugeschäft
        /// </summary>
        /// <param name="autokredite"></param>
        /// <param name="girokonten"></param>
        /// <param name="hypothekenkredite"></param>
        /// <param name="konsumkredite"></param>
        /// <param name="spareinlagen"></param>
        /// <param name="termingelder"></param>
        /// <exception bei negativen Werten></exception>
        public VolumenNeugeschäft(Währung konsumkredite, Währung autokredite, Währung hypothekenkredite, Währung girokonten, Währung spareinlagen, Währung termingelder) : base(konsumkredite, autokredite, hypothekenkredite, girokonten, spareinlagen, termingelder)
        { }
    }
}