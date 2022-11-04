using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProgettoRespa.net
{/// <summary>
/// nuovo form che permette al player di scegliere i estiti, che saranno ricercati se soddisferanno determinati caratteristiche
 ///<see cref="ErroriVestiti "/>
/// </summary>

    public partial class SceltaVestiti : Form
    {
        //creo nuovi tipi associati ai vestiti  per inserirli nelle varie i typi sono definiti tramite delle stringhe costanti (enum)
        Type scarpe = typeof(Scarpe);
        Type jeans = typeof(Jeans);
        Type pantaloni = typeof(Pantaloni);
        Type magliette = typeof(Magliette);
        Type felpe = typeof(Felpa);
        Type giacche = typeof(Giacca);
        public string vestito1;// variabile pubblica che salva vastito e colore del primo indumento in modo tale da passarlo al form1 
        public bool sceltaeffettuataVestito1;// variabile pubblica che indica se il vestito 1 è stato scelto con successo
        public string vestito2;// variabile pubblica che salva vastito e colore del secondo indumento in modo tale da passarlo al form1 
        public bool sceltaeffettuataVestito2;// variabile pubblica che indica se il vestito 2 è stato scelto con successo
        string indumento1;
        string colore1;
        string indumento2;
        string colore2;
        // collezione che collega il nome dell'indumento con la lista dei possibili colori
        Dictionary<string, List<string>> IndumentiColori = new Dictionary<string, List<string>>();
        
        string v1iniziale;
        string v2iniziale;
        string appoggio;
        string Abito2;
        string Abito1;
        string[] indumenti;
        Dictionary<string, List <string>> scelte = new Dictionary<string, List<string>>();
        public SceltaVestiti()
        {

        }/// <summary>
         /// inizializza il form con due vestiti qualora nel <see cref="Form1"/> fossero gia stati selezionati 2 vestiti
         ///  <see cref="Inizializza"/>
         ///  <seealso cref=" CondivisioneElementi();"/>
         ///  <seealso cref=" GestioneVestiti;"/>
         /// </summary>
         /// <param name="v1"> stringa che indica il primo indumento </param>
         /// <param name="v2"> stringa che indica il secondo elemento </param>
         ///
        public SceltaVestiti(String v1, string v2)
        {
             v1iniziale=v1;
             v2iniziale=v2;
            InitializeComponent();
            Inizializza();
            sceltaeffettuataVestito1 = true;
            CondivisioneElementi();
            GestioneVestiti();


            //*inizializzazione autocomplete testo 
            SetUpAutocomplete();
            
        }/// <summary>
         /// verifica che non esistano indumenti gia scelti nel <see cref="Form1"/> e qualora esistessero li inserisce tra le scelte 
         /// </summary>

        private void Inizializza()
        {

            if(v1iniziale.Replace(" ", "").Replace("scegli", "").TrimStart().TrimEnd().Equals("unindumento"))
            {
                BarraRicercaVestiti1.Text =  "";
            }
            else
            {
                BarraRicercaVestiti1.Text = v1iniziale;
            }
            if (v2iniziale.Equals(string.Empty))
            {

                BarraRicercaVestiti2.Text = "";
            }
            else
            {
                BarraRicercaVestiti2.Text = v2iniziale;
            }
          
        }/// <summary>
        /// funzione che permette la creazione delle liste degli oggetti contenuti in <see cref="Indumenti"/> e fa uso di <see cref="CreaListaIndumenti(Type)"/>
        /// </summary>
        private void CondivisioneElementi()
        {
            CreaListaIndumenti(giacche);
            CreaListaIndumenti(felpe);
            CreaListaIndumenti(scarpe);
            CreaListaIndumenti(pantaloni);
            CreaListaIndumenti(jeans);
            CreaListaIndumenti(magliette);
            
        }
        /// <summary>
        /// funzione che riceve come parametro un tipo generico 'e' e crea un dizionario contenente tutti i vestiti ciascuno associato ai suoi colori tramite la funzione <see cref="AggiornaDizionario(string, string)"/>
        /// </summary>
        /// <param name="e"> tipo di vestito da inserire nella lista </param>
        private void CreaListaIndumenti(Type e)
        {
            string[] appoggio;
            string indumento;
            string colore;
            //ciclo che estrae i nomi dagli enum e li iserisce nel dizionario dei vestiti
            foreach (string s in Enum.GetNames(e))

            {
                if (e.Name.Equals("Giacca"))
                {//*splitto le stringhe in due sottostringhe una con i colori e una con gli indumenti


                    appoggio = s.Remove(s.IndexOf('d'), 3).Split('_');
                    indumento = appoggio[0];
                    colore = appoggio[1];

                }
                else
                {
                    appoggio = s.Split('_');
                    indumento = appoggio[0];
                    colore = appoggio[1];
                }
                AggiornaDizionario(indumento, colore);

            }
        }
        /// <summary>
        /// funzione che crea un dizionario <see cref="IndumentiColori"/> di oggetti indumento e li associa ciascuno ai colori che quel vestito
        /// 
        /// </summary>
        /// <param name="key"> stringa rappresentante il tipo dell'indumento </param>
        /// <param name="value">stringa rappresentante il colore dell'indumento key</param>
        private void AggiornaDizionario(string key, string value)
        {// aggiorno il dizionario dei vestiti
            List<string> a = new List<string>();
            //i dizionari non ammettono chiavi ripetute perciò devo controllare che lachiave non sia già presente prima di aggiungerla nuovamente
            if (!IndumentiColori.ContainsKey(key))
            {
                //se la chiave non esiste, creo una lista inserendo il colore della 
                a.Add(value);
                IndumentiColori.Add(key, a);
            }
            else
            {//se la chiave è presente estraggo la lista con i relativi elementi e aggiungo in coda l'ultimo
                IndumentiColori.TryGetValue(key, out a);
                a.Add(value);
                //poiche non posso inserire <key, value> in un dizionario se questa è gia presente, prima la devo eliminare
                IndumentiColori.Remove(key);
                IndumentiColori.Add(key, a);
            }
        }
        /// <summary>
        /// funzione che crea liste in cui inserire gli elementi tipo <see cref="Indumenti"/> nelle liste visualizzate nell'interfaccia usando a supporto la funzione <see cref="InserisciOggetti(Type, ListBox)"/>
        /// </summary>
        private void GestioneVestiti()
        {


            //*aggiungo scarpe
            InserisciOggetti(scarpe, List_Scarpe);
            //*aggiungo jeans

            InserisciOggetti(jeans, List_Jeans);
            //*aggiungo Pantaloni
            InserisciOggetti(pantaloni, List_Pantaloni);
            //* aggiungoMagliette
            InserisciOggetti(magliette, List_Magliette);
            //* aggiungoGiacche
            InserisciOggetti(giacche, List_giacche);
            //* aggiungoFelpe
            InserisciOggetti(felpe, List_felpe);

        }/// <summary>
        /// funzione che inserisce gli oggetti tipo <see cref="Indumenti"/> nelle relative liste visibili nell'interfaccia
        /// </summary>
        /// <param name="e"> elemento tipo <see cref="Indumenti"/> </param>
        /// <param name="l"> lista in cui inserire l'oggetto </param>
        
        private void InserisciOggetti(Type e, ListBox l)
        {//inserico gli oggetti nella lista di appartenenza
            foreach (string s in Enum.GetNames(e))
            {
                // con replace rimuvo il carattere separatore, inserendo al suo posto uno spazio
                string r = s.Replace('_', ' ');
                l.Items.Add(r);
            }
        }

        //private void List_pantaloni_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try { scelta1.Text = List_Pantaloni.Items[List_Pantaloni.SelectedIndex].ToString(); }
        //    catch { }
        //}

        //private void List_magliette_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try { scelta1.Text = List_Magliette.Items[List_Magliette.SelectedIndex].ToString(); }
        //    catch { }
        //}

        //private void List_Jeans_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try { scelta1.Text = List_Jeans.Items[List_Jeans.SelectedIndex].ToString(); }
        //    catch { }
        //}

        //private void Scarpe_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try { scelta1.Text = List_Scarpe.Items[List_Scarpe.SelectedIndex].ToString(); }
        //    catch { }
        //}

        /// <summary>
        /// funzione associata ad un bottone sull'interfaccia che permette all'utente di ricercare i vestiti desiderati 
        /// fa uso di <see cref="SplittaIndumentiColore(string, int)"/> , <see cref="ErroriVestiti"/>, <see cref="stampaErrori(Dictionary{string, List{string}})"/> e <see cref="Modificasalvataggi(Dictionary{string, List{string}}) "/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bottoneCerca_Click(object sender, EventArgs e)
        {
            scelte.Clear();
            try
            {
                
                SplittaIndumentiColore(BarraRicercaVestiti1.Text, 1);
                SplittaIndumentiColore(BarraRicercaVestiti2.Text, 2);

                throw new ErroriVestiti(IndumentiColori, scelte);             
            }
            catch (ErroriVestiti ev)
            {               
                stampaErrori(ev.GetErrori());
                Modificasalvataggi(ev.GetErrori());
            }
        }/// <summary>
         /// funzione che divide una stringa in 2 parti in base ad un carattere di "separazione" creando 2 sottostringe raffiguranti nome dell'indumento e colore con la particolarita di eliminare la sensibilità alle maiuscole e minuscole durante la ricerca dei vestiti
         /// </summary>
         /// <param name="abito"> vestito scelto dall'utente comprensivo di colore </param>
         /// <param name="num">numero relativo alla scelta </param>

        private void SplittaIndumentiColore(string abito, int num)
        {

            string indumentoappoggio;
            string colore;
            string[] divisione;
            string appoggiocolore;
            //controllo la stringa del vestito scelto per vedere se è una giacca. Se è una giacca prima di separare in indumento e colore, devo rimuovere il 'di' e '_' altrimenti la separazione in indumento e colore non ha effetto
            if (abito.ToLower().StartsWith("giacca"))
            {// per rimuovere i caratteri necessari ho bisogno del carattere di inizio(che trovovo con il metodo .indexOf()) e definisco quanti caratteri devo rimuovere con l'intero (3) e con split separo le parole
                divisione = abito.TrimStart().Remove(abito.IndexOf('d'), 3).Split(' ');
            }
            else
            {
                divisione = abito.TrimStart().Split(' ');

            }

            if (!divisione[0].Equals(string.Empty))
            {// se non ho alcun elemento salvato in divisione[0] significa che l'utente non ha inserito un vestito da cercare, quindi per definire il nome dell'indumento, salvato in divisione[0], devo avere che divisione[0] non sia vuoto(string.null poichè divisione è un array di string)
                if (!divisione[0].Equals(" "))
                {// per rendere il codice non case-Sensitive (lato utente) e far si che la ricerca vada sempre a buon fine estraggo dalla stringa contenente l'indumento il primo carattere (con .first()) questa la metto in maiuscolo con char.ToUpper() e il resto dell'indumento 
                    string rimpicciolita;


                    rimpicciolita = divisione[0].ToLower();
                    char prima = rimpicciolita.First();
                    char primaup = char.ToUpper(prima);

                    indumentoappoggio = rimpicciolita.Replace(prima, primaup);
                    //* creo una nuova stringa eliminando il tipo di indumento cercato e ottenendo cosi una sottostringa contenente solo il colore desiderato privo di spazi a inizio e fine e formattato in modo da permettere sempre la ricerca del colore
                    
                    //nel caso in cui la stringa venisse autocompletata con i suggerimenti allora avrebbe la formattazione gia corretta e dunque la lettera iniziale sarebbe maiuscola mentre il resto resterebbe minuscolo. Per rensere ancora valido questo metodo occorre inserire prima della ricerca dell'indice della prima lettera un toLower() cosi da permettere al codice di trovare all'interno della stringa già normalizzata una corrispondenza .
                    appoggiocolore = abito.Remove(abito.ToLower().IndexOf(prima), rimpicciolita.Length).Trim().ToLower();

                    if (abito.Contains("di"))
                    {
                        appoggiocolore = abito.Remove(abito.ToLower().IndexOf('d'), 3).Remove(abito.ToLower().IndexOf(prima), rimpicciolita.Length).Trim().ToLower();
                    }
                }
                else
                {

                    indumentoappoggio = " ";
                    appoggiocolore = " ";
                }
            }
            else
            {
                indumentoappoggio = " ";
                appoggiocolore = " ";
            }

            if (appoggiocolore != null && !appoggiocolore.Equals(" "))
            {

                colore = appoggiocolore;

            }
            else
            {
                colore = "";
            }
            if (num == 1)
            {
                indumento1 = indumentoappoggio;
                colore1 = colore;
            }
            else if (num == 2)
            {
                indumento2 = indumentoappoggio;
                colore2 = colore;
            }
            if (indumentoappoggio != null && !indumentoappoggio.Equals(" "))
            {
                if (!scelte.ContainsKey(indumentoappoggio))
                {
                    List<string> colori = new List<string>();
                    colori.Add(colore);
                    scelte.Add(indumentoappoggio, colori);
                }
                else
                {
                    List<String> colori = new List<string>();
                    scelte.TryGetValue(indumentoappoggio, out colori);
                    if (!colori.Contains(colore))
                    {
                        colori.Add(colore);
                        scelte.Remove(indumentoappoggio);
                        scelte.Add(indumentoappoggio, colori);
                    }
                    else
                    {
                        MessageBox.Show(" non puoi ricercare due vestiti identici");
                        BarraRicercaVestiti2.Text = "";
                    }
                }

            }

        }
        /// <summary>
        /// funzione che riporta le scelte nella barra dei vestiti trovati qualora la classe <see cref="ErroriVestiti"/> non abbia riscontrato errori durante la loro ricerca si avvale dell'ausilio di <see cref="ModificasaVestiti(string, string, int) "/> e <see cref="aggiornamentoscelte(string, string)"/>
        /// </summary>
        /// <param name="errori"> la lista degli errori prodotti da <see cref="ErroriVestiti.ErroriVestiti(Dictionary{string, List{string}}, Dictionary{string, List{string}}) "/> durante la ricerca degli indumenti</param>

        public void Modificasalvataggi(Dictionary<string, List<string>> errori)
        {

            //BarraRicercaVestiti1.AutoCompleteCustomSource = AutoCompleteStringCollection;
            int num = 1;
            foreach (string s in errori.Keys)
            {

                //num = 1;
                List<string> messaggi;

                errori.TryGetValue(s, out messaggi);
                foreach (string messaggio in messaggi)
                {
                    string[] divisa;
                    divisa = messaggio.Split('_');
                    //se il vestito non esiste allora il messaggio non conterr° solo l'errore e non il colore dell'indumento, quindi l'indice 1 non esiste nell'array di stringhe generato dalla divisione del messaggio
                    if (divisa[0] != null && !divisa[0].Equals("il vestito ricercato non esiste "))
                    {
                        if (divisa[1].Equals("il vestito esiste e puo essere ricercato"))
                        {

                            string colore = divisa[0].Replace('(', ' ').Replace(')', ' ').TrimEnd().TrimStart();

                            ModificasaVestiti(s, colore, num);
                            aggiornamentoscelte(s, colore);
                            num++;
                        }
                    }


                }

            }
        }
        /// <summary>
        /// funzione che scrive all'interno delle textbox relativi agli indumenti trovati l'indumento e la specifica di colore
        /// </summary>
        /// <param name="indumento">riporta in nome dell'indumento trovato</param>
        /// <param name="colore">riporta il colore dell'indumento trovato</param>
        /// <param name="num">riporta il numero della scelta </param>

        private void ModificasaVestiti(string indumento, string colore, int num)
        {

            switch (indumento)
            {
                case "Giacca":
                    appoggio = indumento + " di " + colore;

                    break;
                default:
                    appoggio = indumento + " " + colore;
                    break;
            }
            if (num == 1)
            {
                Abito1 = appoggio;
            }
            else if (num == 2)
            {
                Abito2 = appoggio;
                }
            scelta1.Text = Abito1;
            TextIndumento2.Text = Abito2;
            
            }
        private void SalvaEdEsciButton_Click(object sender, EventArgs e)
        {
            
            
            vestito2 = Abito2;
            vestito1 = Abito1;
            this.Close();

        }

        //private void List_felpe_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try { scelta1.Text = List_felpe.Items[List_felpe.SelectedIndex].ToString(); }
        //    catch { }
        //}

        //private void List_giacche_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try { scelta1.Text = List_giacche.Items[List_giacche.SelectedIndex].ToString(); }
        //    catch { }
        //}
        /// <summary>
        /// funzione che aggiorna la visualizzazione degli indumenti nelle liste, evidenziando quelle trovate
        /// </summary>
        /// <param name="indumento">nome dell'induimento ricercato</param>
        /// <param name="colore"> colore dell'indumento ricercato</param>
        private void aggiornamentoscelte(string indumento, string colore)
        { string risultato;
            switch (indumento)
            {
                case "Giacca":
                    risultato = indumento + " di " + colore;
                    List_giacche.SelectedItem = risultato;
                    break;
                case "Pantalone":
                    risultato = indumento + " " + colore;
                    List_Pantaloni.SelectedItem = risultato;
                    break;
                case "Jeans":
                    risultato = indumento + " " + colore;
                    List_Jeans.SelectedItem = risultato;
                    break;
                case "Maglietta":
                    risultato = indumento + " " + colore;
                    List_Magliette.SelectedItem = risultato;
                    break;
                case "Felpa":
                    risultato = indumento + " " + colore;
                    List_felpe.SelectedItem = risultato;
                    break;
                case "Scarpe":
                    risultato = indumento + " " + colore;
                    List_Scarpe.SelectedItem = risultato;
                    break;
            }
        }
        private void scelta1_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void scelta1_DragEnter(object sender, DragEventArgs e)
        {

        }
        /// <summary>
        /// funzione che stampa a schermo la lista degli errori generata da <see cref="ErroriVestiti.ErroriVestiti(Dictionary{string, List{string}}, Dictionary{string, List{string}}) "/>durante la ricerca <see cref="ErroriVestiti.GetErrori"/>
        /// </summary>
        /// <param name="errori">errori di ricerca</param>
        private void stampaErrori(Dictionary<string, List<string>> errori)
        {
            string messaggio = "";
            foreach (string s in errori.Keys)
            {
                int i = 1;
                List<string> erroriattuali = new List<string>();
                errori.TryGetValue(s, out erroriattuali);
                foreach (string errore in erroriattuali)
                {
                    if (!errore.Equals("il vestito ricercato non esiste "))
                    {
                        string[] divisa;
                        divisa = errore.Split('_');
                        messaggio = messaggio + "\n" + "indumento " + s + " " + divisa[0] + ": " + divisa[1];
                    }
                    else
                    {
                        messaggio = errore;
                    }

                }


            }
            MessageBox.Show(messaggio);
        }


        private void BarraRicercaVestiti1_TextChanged(object sender, EventArgs e)
        {
          
            
        }
       private void SetUpAutocomplete()
        {
            
            BarraRicercaVestiti1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            BarraRicercaVestiti1.AutoCompleteMode = AutoCompleteMode.Suggest;
            BarraRicercaVestiti2.AutoCompleteSource = AutoCompleteSource.CustomSource;
            BarraRicercaVestiti2.AutoCompleteMode = AutoCompleteMode.Suggest;
           

            foreach (string indumento in IndumentiColori.Keys)
            {
                List<string> colori = new List<string>();
                IndumentiColori.TryGetValue(indumento, out colori);
                if (colori.Count() > 0)
                {
                    foreach (string colore in colori)
                    {
                        
                        if (indumento.ToLower().Equals("giacca"))
                        {
                            BarraRicercaVestiti1.AutoCompleteCustomSource.Add(indumento + " di " + colore);
                            BarraRicercaVestiti2.AutoCompleteCustomSource.Add(indumento + " di " + colore);
                        }
                        else
                        {
                            BarraRicercaVestiti1.AutoCompleteCustomSource.Add(indumento + " " + colore);
                            BarraRicercaVestiti2.AutoCompleteCustomSource.Add(indumento + " " + colore);
                        }
                    }
                }
            }
            
        }
    }
}
