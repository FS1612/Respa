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
        Form1 form1 = new Form1();

        public ErroreTemperatura() { }
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
                    form1.text_tempdesiderata.Text = "";
                    messaggio = "Brrrr, che freddo conviene alzare la temperatura";
                }
            }
        }
        public string getMsg()
        {
            return messaggio;

        }
    }
}
