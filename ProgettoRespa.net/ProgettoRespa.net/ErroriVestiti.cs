using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoRespa.net
{
    class ErroriVestiti : Exception
    {/// <summary>
    /// riporta l'esito della ricerca di tutti i vestiti selezionati ordinati in base all'ordine di ricerca
    /// </summary>
        Dictionary<string, List<string>> errori = new Dictionary<string, List<string>>();
       /// <summary> dato una serie di scelte effettuate dall'utente, verifica la correttzza delle scelte rispetto i criteri di ricerca
       /// e salva il risultato della verifica nel dizionario che riporta il nome dell'indumento associato al suo colore l'esito del confronto <see cref="errori"/>
       /// </summary>
       /// <param name="d">dizionario che associa ad ogni indumento disponibile tutte le colorazioni in cui quest'ultimo è presente</param>
       /// <param name="scelte">dizionario che riporta le scelte dell'utente sulle quali bisogna effettuare la verifica </param>
        public ErroriVestiti(Dictionary<string, List<string>> d, Dictionary<string, List<string>> scelte)
        {
            
            foreach (string scelta in scelte.Keys)
            {
                List<string> appoggio = new List<string>();
                List<string> colori = new List<string>();
                scelte.TryGetValue(scelta, out colori);
                if (!d.ContainsKey(scelta)) {
                    //scelta è in nome dell'indumento
                    if (!errori.ContainsKey(scelta)){
                        
                        appoggio.Add("il vestito ricercato non esiste ");
                        errori.Add(scelta, appoggio);
                    }

                }
                else
                {
                    //se d contiene il nome dell'indumento posso cercare i colori (se esistono)
                    List<string> listacoloridesiderati = new List<string>();
                    scelte.TryGetValue(scelta, out listacoloridesiderati);
                    d.TryGetValue(scelta, out colori);
                    foreach(string colore in listacoloridesiderati)
                    {//* mi trovo nel caso in cui l'indumento esiste ma non ho corrispondenze per il colore
                        if (!colori.Contains(colore))
                        {
                            if (!errori.ContainsKey(scelta))
                            {
                                appoggio .Add( "("+ colore+")_"+"il vestito ricercato esiste ma non nel colore desiderato");
                                errori.Add(scelta, appoggio);
                            }
                            else
                            {
                                errori.TryGetValue(scelta, out appoggio);
                                appoggio.Add("(" + colore + ")_" + "il vestito ricercato esiste ma non nel colore desiderato");
                                errori.Remove(scelta);
                                errori.Add(scelta, appoggio);
                            }
                        }
                        else
                        {//* mi trovo nel caso in cui esiste l'indumento e il colore
                            if (!errori.ContainsKey(scelta))
                            {
                                appoggio.Add("(" + colore + ")_" + "il vestito esiste e puo essere ricercato");
                                errori.Add(scelta, appoggio);
                            }
                            else
                            {
                                errori.TryGetValue(scelta, out appoggio);
                                
                                appoggio.Add("(" + colore + ")_" + "il vestito esiste e puo essere ricercato");
                                errori.Remove(scelta);
                                errori.Add(scelta, appoggio);
                            }
                        }
                    }
                }
            }

        }
    
        public Dictionary<string, List <string>> GetErrori()
        {
            return errori;
        }
    }
}
