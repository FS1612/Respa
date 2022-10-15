using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoRespa.net
{
    public class ErroriIndumenti:Exception
    { Dictionary<string, string> IndumentiColori = new Dictionary<string, string>();
        string messaggio;
        public ErroriIndumenti() { };
        public ErroriInduomenti(String indumento, String Colore) { };
        public ErroriIndumenti(Dictionary<string, string> d,string indumento,string colore) {
            if (!d.ContainsKey)
            {
                messaggio = "attenzione, stai cercando un indumento inesistente";
            }
            else (d.ContainsKey){
                if (!d.ContainsValue)
                {
                    messaggio = " attenziione, per questo tipo di indumento non esiste il colore richiesto";
                }
                else
                {
                    messaggio = "True";
                }
            }
        };
        private void setIndumentiColori(Dictionary<string, string> d)
        {
            IndumentiColori = d;
        }
        public string getMessaggio()
        {
            return messaggio;
        }
    }
}
