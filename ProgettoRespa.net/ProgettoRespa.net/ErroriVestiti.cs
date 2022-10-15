using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoRespa.net
{
    class ErroriVestiti:Exception
    {
        Dictionary<string, List<string>> IndumentiColori = new Dictionary<string, List<string>>();
        string messaggio;
        public ErroriVestiti(Dictionary<string, List<string>> d, string indumento, string colore)
        {
            List<string> appoggio = new List<string>();
            if (!d.ContainsKey(indumento))
            {
                messaggio = "attenzione, stai cercando un indumento inesistente";
            }
            else  
                    {
                d.TryGetValue(indumento, out appoggio);
                if (!appoggio.Contains(colore))
                {
                    messaggio = " attenziione, per questo tipo di indumento non esiste il colore richiesto";
                }
                else
                {
                    messaggio = "True";
                }
            
                    }
        }
        //private void setIndumentiColori(Dictionary<string, string> d)
        //{
        //    IndumentiColori = d;
        //}
        public string getMessaggio()
        {
            return messaggio;
        }
    }
}
