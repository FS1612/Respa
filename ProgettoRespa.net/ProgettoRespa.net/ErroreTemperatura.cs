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
        int valore;
        int tempIniziale;
        int tempmax=30;
        public ErroreTemperatura() { }
        public ErroreTemperatura(int num)
        {
            if (num == 0)
            {
                messaggio = "la temperatura non può essere pari a 0";
                valore = num;
            }
            if (num < 0)
            {
                messaggio = "Brrrr, che freddo conviene alzare la temperatura";
                valore = num;
            }
            if (num < tempIniziale)
            {
                messaggio = "Attenzione la temperatura non può essere minore della temperatura iniziale dellastanza";
            }
            if (num > tempmax)
            {
                string t = tempmax.ToString();
                messaggio = "attenzione la temperatura della stanza non può superare: " + t + " gradi, perfavore abbassare la temperatura";
            }

        }
        public ErroreTemperatura(String val)
        {
            if (val.Equals(""))
            {
                messaggio = "la temperatura desiderata non puo essere un valore indefinito, per avviare il programma imposta un valore maggiore di 19";
            }
            
        }
        public string getMsg()
        {
            return messaggio;
        }
        public int getValore()
        {
            return valore;
        }
        public void SetTempIniziale(int temp)
        {
            tempIniziale = temp;
        }
        public void SetTempmax(int temp)
        {
            tempIniziale = temp;
        }
    }
}
