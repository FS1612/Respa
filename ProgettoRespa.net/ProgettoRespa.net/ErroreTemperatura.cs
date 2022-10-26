using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoRespa.net
{
    public class ErroreTemperatura : FormatException
    {
        string messaggio;
        

        public ErroreTemperatura() { }
        /// <summary>
        /// funzione che controlla la correttezza della temperatura selezionata
        /// </summary>
        /// <param name="tempDesiderata">valore della temperatura scelto dall'utente tramite interfaccia</param>
        /// <param name="tempMinima">temperatura minima definita in <see cref="Form1"/></param>
        /// <param name="tempMax">temperatura massima definita in <see cref="Form1"/></param>
        /// <param name="tempDesiderataNumero"></param>
        public ErroreTemperatura(string tempDesiderata, int tempMinima, int tempMax, int tempDesiderataNumero)
        {
            if (tempDesiderata.Equals("") || tempDesiderata.Contains("-"))
            {
                if (tempDesiderata.Equals(""))
                {
                    messaggio = "la temperatura desiderata non puo essere un valore indefinito, per avviare il programma imposta un valore maggiore di 19";
                }
                if (tempDesiderata.Contains("-"))
                {
                    messaggio = "Brrrr, che freddo conviene alzare la temperatura";
                }
            }
            else
            {
                if (tempDesiderataNumero > tempMax)
                {
                    string t = tempMax.ToString();
                    messaggio = "attenzione la temperatura della stanza non può superare: " + t + " gradi, perfavore abbassare la temperatura";
                }
                if (tempDesiderataNumero > 0 && tempDesiderataNumero < tempMinima)
                {
                    messaggio = "Attenzione la temperatura non può essere minore della temperatura iniziale della stanza";
                }
                if (tempDesiderataNumero == 0)
                {
                    //form1.text_tempdesiderata.Text = "";
                    messaggio = "Brrrr, che freddo conviene alzare la temperatura";
                }
                if(tempDesiderataNumero > tempMinima&& tempDesiderataNumero < tempMax)
                {
                    messaggio = "True";
                }
            }
        }
        /// <summary>
        /// funzione che ritorna il messaggio di errore 
        /// </summary>
        /// <returns> codice errore relativo alla temperatura</returns>
        public string getMsg()
        {
            return messaggio;

        }
    }
}
