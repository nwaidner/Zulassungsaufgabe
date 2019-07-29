// Namensraum 'Datenaustausch' enthält KLassen für den Informationstransport aus der Schicht 'Datenhaltung'
// Konsolenanwendung
// Verantwortlichkeit: Nick Waidner 64946

using System;

namespace EasyBankingPersonal.Datenaustausch
{
    /// <summary>
    /// Klasse für einen Prozentwert
    /// </summary>
    public struct Prozent
    {
        private readonly double _wert;

        public double Wert { get => _wert; }

        /// <summary>
        /// Konstruktor der Klasse Prozent mit einem Übergabewert dieser wird  kaufmännisch auf drei Nachkommastellen gerundet
        /// </summary>
        /// <param name="wert"></param>
        public Prozent(double wert)
        {
            _wert = Math.Round(wert, 3, MidpointRounding.AwayFromZero);
        }
        /// <summary>
        /// Konstruktor der Klasse Prozent mit zwei Übergabewerten
        /// Berechnet den Unterschied in Prozent zwischen zwei Werten und Rundet diesen kaufmännisch auf drei Nachkommastellen
        /// </summary>
        /// <param name="neuerWert"></param>
        /// <param name="alterWert"></param>
        public Prozent(double neuerWert, double alterWert)
        {
            _wert = Math.Round(((neuerWert / alterWert) - 1), 3, MidpointRounding.AwayFromZero);
        }

        /// <summary>
        /// Methode die eine Druckbare Darstellung der Klasse Prozent liefert 
        /// </summary>
        /// <returns>eine Druckare ansicht der KLasse Prozent</returns>
        public override string ToString()
        {
            return string.Format("{0:0.0}", (Wert * 100)) + " %";
        }

        /// <summary>
        /// Methode, die einen Vergleich zwischen zwej Objekten der Klasse Prozent erlaubt
        /// </summary>
        /// <param name="obj">objekt der KLasse Prozent</param>
        /// <returns>Boolschen wert, true falls die Objekte übereinstimmen </returns>
        public override bool Equals(object obj)
        {
            return (obj is Prozent) && ((Prozent)obj).Wert == this.Wert;
        }

        /// <summary>
        /// Methode, die es erlaubtn einen Hash-Code aus einem Objekt der KLasse Prozent zu erzeugen
        /// </summary>
        /// <returns>ganzzahligen Hashwert</returns>
        public override int GetHashCode()
        {
            return Wert.GetHashCode();
        }

        /// <summary>
        /// Operator zur Konvertierung einer GKZ in ein Objekt der Klasse Prozent 
        /// </summary>
        /// <param name="op"></param>
        public static implicit operator Prozent(double op)
        {
            return new Prozent(op);
        }

        /// <summary>
        /// Operator zur Konvertierung eines Objektes vom Typ Prozent in einen Gleitkommawert
        /// </summary>
        /// <param name="op"></param>
        public static implicit operator double(Prozent op)
        {
            return op.Wert;
        }
    }
}