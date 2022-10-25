using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoRespa.net
{
    class ErroriVestiti : Exception
    {
        Dictionary<string, string> errori = new Dictionary<string, string>();
        string messaggio;
        string messaggio1;
        
        int cod ;
       public ErroriVestiti (Dictionary<string, List<string>> d, Dictionary<string, string> scelte)
        {
            foreach(string s in scelte.Keys)
            {
               
                string appoggio;
                   string vestito = s;
                string colore;
                scelte.TryGetValue(s, out colore);
                if (!d.ContainsKey(s))
                {
                    if (!errori.ContainsKey(s))
                    {
                        appoggio = " il vestito ricercato non esiste";
                        errori.Add(s, appoggio);
                    }
                }
                else
                {
                    List<string> colori;
                    d.TryGetValue(s, out colori);
                    if (!colori.Contains(colore))
                    {
                        appoggio = " il vestito ricercato esiste ma non nel colore desiderato";
                        errori.Add(s, appoggio);
                    }
                    else
                    {
                        appoggio = "il vestito esiste e puo essere ricercato";
                        
                        errori.Add(s, appoggio);
                    }
                }
                
            }
        }

        public ErroriVestiti(Dictionary<string, List<string>> d, string indumento1, string colore1, string indumento2, string colore2)
        {

            List<string> appoggio = new List<string>();
            List<string> appoggio2 = new List<string>();

            if (!indumento1.Equals(" ") && indumento2.Equals(" "))
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
            else if (indumento1.Equals(" ") && !indumento2.Equals(" "))
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
            else if (!indumento1.Equals(" ") && !indumento2.Equals(" "))
            {

                if (!d.ContainsKey(indumento2) && !d.ContainsKey(indumento1))
                {
                    messaggio = " nessuno dei due elementi esiste, inserisci elementi esistenti";
                    this.setCode(0);
                }
                if (d.ContainsKey(indumento2) && !d.ContainsKey(indumento1))
                {
                    d.TryGetValue(indumento2, out appoggio2);
                    if (!appoggio2.Contains(colore2))
                    {
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
                    if (!appoggio2.Contains(colore2) && (appoggio.Contains(colore1)))
                    {
                        messaggio = " Il primo indumento esiste e può essere cercato, il secondo esiste ma non nel colore richiesto";

                        this.setCode(1);
                    }
                    else if (appoggio2.Contains(colore2) && (!appoggio.Contains(colore1)))
                    {
                        messaggio = " Il secondo indumento esiste e può essere cercato, il primo esiste ma non nel colore richiesto";

                        this.setCode(2);
                    }
                    else if (!appoggio2.Contains(colore2) && (!appoggio.Contains(colore1)))
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
            if (indumento1.Equals(" ") && indumento2.Equals(" "))

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
        public Dictionary<string, string> GetErrori()
        {
            return errori;
        } 
    }
}
