using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoRespa.net
{
    class ErroriVestiti : Exception
    {
        Dictionary<string, List<string>> IndumentiColori = new Dictionary<string, List<string>>();
        string messaggio;
        //string indumento;
        //string colore;
        int cod ;
        bool entrambi =false;
        //public ErroriVestiti(Dictionary<string, List<string>> d, string indumento, string colore, string indumento1, string colore1, bool verifica)
        //{
        //    this.indumento = indumento;
        //    this.colore = colore;
        //    List<string> appoggio = new List<string>();
        //    List<string> appoggio1 = new List<string>();

        //    if (!d.ContainsKey(indumento))
        //    {
        //        messaggio = "attenzione, stai cercando un indumento inesistente";
        //    }
        //    else
        //    {
        //        d.TryGetValue(indumento, out appoggio);
        //        if (!appoggio.Contains(colore))
        //        {
        //            messaggio = " attenzioone, per questo tipo di indumento non esiste il colore richiesto";
        //        }
        //        else
        //        {
        //            messaggio = "True";
        //        }

        //    }
        //}
        public ErroriVestiti(Dictionary<string, List<string>> d, string indumento1, string colore1, string indumento2, string colore2, bool verifica)
        {
            
            List<string> appoggio = new List<string>();
            List<string> appoggio2 = new List<string>();

            if(!indumento1.Equals(" ")&& indumento2.Equals(" "))
            {
                if (!d.ContainsKey(indumento1))
                {
                    messaggio = "attenzione, stai cercando degli indumenti inesistenti";
                    this.setCode(0);
                }
                else
                {
                    d.TryGetValue(indumento1, out appoggio);
                    if (!appoggio.Contains(colore1))
                    {
                        messaggio = " attenzione, per l'indumento 1 non esiste il colore richiesto";
                        this.setCode(0);
                    }
                    else
                    {
                        messaggio = "True";
                        this.setCode(1);
                    }
                }
            }
            else if(indumento1.Equals(" ") && !indumento2.Equals(" "))
            {
                if (!d.ContainsKey(indumento2))
                {
                    messaggio = "attenzione, stai cercando degli indumenti inesistenti";
                    this.setCode(0);

                }
                else
                {
                    d.TryGetValue(indumento2, out appoggio2);
                    if (!appoggio2.Contains(colore2))
                    {
                        messaggio = " attenzioone, per l'indumento 2 non esiste il colore richiesto";
                        this.setCode(0);
                    }
                    else
                    {
                        messaggio = "True";
                        this.setCode(2);
                    }
                }
            }
            else if(!indumento1.Equals(" ") && !indumento2.Equals(" "))
            {
                entrambi = true;
                if (!d.ContainsKey(indumento2) && !d.ContainsKey(indumento1))
                {
                    messaggio = " nessuno dei due elementi esiste, inserisci elementi esistenti";
                    this.setCode(0);
                }
                 if(d.ContainsKey(indumento2) && !d.ContainsKey(indumento1))
                {
                    d.TryGetValue(indumento2, out appoggio2);
                    if (!appoggio2.Contains(colore2)){
                        messaggio = "il primo indumento non esiste, mentre il secondo esiste ma non nel colore richiesto";
                        this.setCode(0);
                    }
                    else
                    {
                        messaggio = "True";
                        this.setCode(2);
                    }
                }
                 if (d.ContainsKey(indumento1) && !d.ContainsKey(indumento2))
                {
                    d.TryGetValue(indumento1, out appoggio);
                    if (!appoggio.Contains(colore1))
                    {
                        messaggio = "il secondo indumento non esiste, mentre il primo esiste ma non nel colore richiesto";
                        this.setCode(0);
                    }
                    else
                    {
                        messaggio = "True";
                        this.setCode(1);
                    }
                }
                if (d.ContainsKey(indumento1) && d.ContainsKey(indumento2))
                {
                    d.TryGetValue(indumento1, out appoggio);
                    d.TryGetValue(indumento2, out appoggio2);
                    if (!appoggio2.Contains(colore2) && (appoggio.Contains(colore1))){
                        messaggio = " Il primo indumento esiste e può essere cercato, il secondo esiste ma non nel colore richiesto";
                        
                        this.setCode(1);
                    }
                   else if (appoggio2.Contains(colore2) && (!appoggio.Contains(colore1))){
                        messaggio = " Il secondo indumento esiste e può essere cercato, il primo esiste ma non nel colore richiesto";
                        
                        this.setCode(2);
                    }
                    else if(!appoggio2.Contains(colore2) && (!appoggio.Contains(colore1)))
                    {
                        messaggio = "Nessuno dei due indumenti esiste nel colore richiesto";
                        
                        this.setCode(0);
                    }
                    else
                    {
                        if (indumento1.Equals(indumento2) && colore1.Equals(colore2))
                        {
                            messaggio = "attenzione, stai cercando due vestiti identici";
                            
                            this.setCode(1);
                        }
                        else
                        {
                            messaggio = "True";
                            this.setCode(3);
                        }
                        
                    }
                }
            }
            if(indumento1.Equals(" ") && indumento2.Equals(" "))
            
            {
                messaggio = "inserisci vestiti validi per la ricerca";
            }
        }
        public string getMessaggio()
        {
            return messaggio;
        }
        public int getCod(){
            return cod;
        }
        private void setCode(int n)
        {
            this.cod = n;
        }
    }
}
