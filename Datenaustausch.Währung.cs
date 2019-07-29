// Namensraum 'Datenaustausch' enthält KLassen für den Informationstransport aus der Schicht 'Datenhaltung'
// Konsolenanwendung
// Verantwortlichkeit: Nick Waidner 64946

using System;

namespace EasyBankingPersonal.Datenaustausch
{

    /// <summary>
    /// Klasse für einen Geldbetrag
    /// </summary>
    public struct Währung
    {
        private readonly decimal _betrag;

        public decimal Betrag { get => _betrag; }

        /// <summary>
        /// Konstruktor der Klasse Währung, der betrag wird kaufmännisch auf zwei Nachkommastellen gerundet
        /// </summary>
        /// <param name="betrag"></param>
        public Währung(decimal betrag)
        {
            _betrag = Math.Round(betrag, 2, MidpointRounding.AwayFromZero);
        }

        /// <summary>
        /// Methode um ein Objekt der Klasse Währung druckbar darzustellen, der Betrag wird wie eine Währung formatiert
        /// </summary>
        /// <returns>einen string, der den Betrag enthält</returns>
        public override string ToString()
        {
            return String.Format("{0:C}", Betrag);
        }

        /// <summary>
        /// Methode um ein Objekt der Klasse Währung druckbar darzustellen, der Betrag wird in Million Dargestellt 
        /// </summary>
        /// <returns>einen string, der den Betrag in Milliondenschreibweise enthält</returns>
        public string ToMillionenString()
        {
            return (Betrag / 1000000).ToString("N0") + " Mio€";
        }

        /// <summary>
        /// Methode um ein Objekt der KLasse Währung druckbar darzustellen, der Betrag wird in Tausend Dargestellt 
        /// </summary>
        /// <returns>einen string, der den Betrag in Tausenderdarstellung enthält</returns>
        public string ToTausenderString()
        {
            return (Betrag / 1000).ToString("N0") + " T€";
        }

        /// <summary>
        /// Methode, die es erlaubtn einen Hash-Code aus einem Objekt der KLasse Währung zu erzeugen
        /// </summary>
        /// <returns>ganzzahligen Hashwert</returns>
        public override bool Equals(object obj)
        {
            return (obj is Währung) && ((Währung)obj).Betrag == this.Betrag;
        }

        /// <summary>
        /// Methode, die einen Vergleich zwischen zwej Objekten der KLasse Betrag erlaubt
        /// </summary>
        /// <param name="obj">objekt der KLasse Prozent</param>
        /// <returns>Boolschen wert, true falls die Objekte übereinstimmen </returns>
        public override int GetHashCode()
        {
            return Betrag.GetHashCode();
        }

        /// <summary>
        /// Operator zur Konvertierung einer GKZ in ein Objekt der Klasse Währung 
        /// </summary>
        /// <param name="op"></param>
        public static implicit operator Währung(decimal op)
        {
            return new Währung(op);
        }

        /// <summary>
        /// Operator zur Konvertierung eines Objektes vom Typ Währung in einen Gleitkommawert
        /// </summary>
        /// <param name="op"></param>
        public static implicit operator decimal(Währung op)
        {
            return op.Betrag;
        }
    }
}