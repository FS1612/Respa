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
{
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
        //Form1 f1=new Form1();
        string v1iniziale;
        string v2iniziale;
        string appoggio;
        public SceltaVestiti(String v1, string v2)
        {
             v1iniziale=v1;
             v2iniziale=v2;
            //f1 = f;
           
            InitializeComponent();
            Inizializza();
            sceltaeffettuataVestito1 = true;
            CondivisioneElementi();
            GestioneVestiti();

        }
        private void Inizializza()
        {

            if(v1iniziale.Replace(" ", "").Replace("scegli", "").TrimStart().TrimEnd().Equals("unindumento"))
            {
                scelta1.Text =  "";
            }
            else
            {
                scelta1.Text = v1iniziale;
            }
            if (v2iniziale.Equals(string.Empty))
            {
                scelta1.Text = "";
            }
            else
            {
                TextIndumento2.Text = v2iniziale;
            }
           
        }
        private void CondivisioneElementi()
        {
            CreaListaIndumenti(giacche);
            CreaListaIndumenti(felpe);
            CreaListaIndumenti(scarpe);
            CreaListaIndumenti(pantaloni);
            CreaListaIndumenti(jeans);
            CreaListaIndumenti(magliette);
            
        }

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
                IndumentiColori.Remove(key);
                IndumentiColori.Add(key, a);
            }
        }

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

        }
        private void InserisciOggetti(Type e, ListBox l)
        {//inserico gli oggetti nella lista di appartenenza
            foreach (string s in Enum.GetNames(e))
            {
                // con replace rimuvo il carattere separatore, inserendo al suo posto uno spazio
                string r = s.Replace('_', ' ');
                l.Items.Add(r);
            }
        }

        private void List_pantaloni_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { scelta1.Text = List_Pantaloni.Items[List_Pantaloni.SelectedIndex].ToString(); }
            catch { }
        }

        private void List_magliette_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { scelta1.Text = List_Magliette.Items[List_Magliette.SelectedIndex].ToString(); }
            catch { }
        }

        private void List_Jeans_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { scelta1.Text = List_Jeans.Items[List_Jeans.SelectedIndex].ToString(); }
            catch { }
        }

        private void Scarpe_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { scelta1.Text = List_Scarpe.Items[List_Scarpe.SelectedIndex].ToString(); }
            catch { }
        }


        private void bottoneCerca_Click(object sender, EventArgs e)
        {
            try
            {
                
                string[] divisione;
                string[] divisione1;
                //controllo la stringa del vestito scelto per vedere se è una giacca. Se è una giacca prima di separare in indumento e colore, devo rimuovere il 'di' e '_' altrimenti la separazione in indumento e colore non ha effetto
                if (BarraRicercaVestiti1.Text.ToLower().StartsWith("giacca"))
                {// per rimuovere i caratteri necessari ho bisogno del carattere di inizio(che trovovo con il metodo .indexOf()) e definisco quanti caratteri devo rimuovere con l'intero (3) e con split separo le parole
                    divisione = BarraRicercaVestiti1.Text.Remove(BarraRicercaVestiti1.Text.IndexOf('d'), 3).Split(' ');
                }
                else
                {
                    divisione = BarraRicercaVestiti1.Text.Split(' ');
                }

                if (!divisione[0].Equals(string.Empty))
                {// se non ho alcun elemento salvato in divisione[0] significa che l'utente non ha inserito un vestito da cercare, quindi per definire il nome dell'indumento, salvato in divisione[0], devo avere che divisione[0] non sia vuoto(string.null poichè divisione è un array di string)
                    if (!divisione[0].Equals(" "))
                    {// per rendere il codice non case-Sensitive (lato utente) e far si che la ricerca vada sempre a buon fine estraggo dalla stringa contenente l'indumento il primo carattere (con .first()) questa la metto in maiuscolo con char.ToUpper() e il resto dell'indumento 
                        char let = divisione[0].First();
                        char letToUp = Char.ToUpper(let);
                        //indumento1.ToLower();
                        indumento1 = divisione[0].Replace(let, letToUp);
                    }
                    else
                    {
                        indumento1 = " ";
                    }
                }
                else
                {
                    indumento1 = " ";
                }
                if (divisione.Length == 2)
                {

                    colore1 = divisione[1].ToLower();


                }
                else
                {

                    colore1 = "";
                }
                if (BarraRicercaVestiti2.Text.ToLower().StartsWith("giacca"))
                {
                    divisione1 = BarraRicercaVestiti2.Text.Remove(BarraRicercaVestiti2.Text.IndexOf('d'), 3).Split(' ');
                }
                else
                {
                    divisione1 = BarraRicercaVestiti2.Text.Split(' ');
                }

                if (!divisione1[0].Equals(string.Empty))
                {
                    if (!divisione1[0].Equals(" "))
                    {
                        char let1 = divisione1[0].First();
                        char letToUp1 = Char.ToUpper(let1);
                        divisione1[0].ToLower();
                        indumento2 = divisione1[0].Replace(let1, letToUp1);

                    }
                    else { indumento2 = " "; }
                }
                else
                {
                    indumento2 = " ";
                }
                if (divisione1.Length == 2)
                {
                    colore2 = divisione1[1].ToLower();
                }
                else
                {
                    colore2 = "";
                }
                throw new ErroriVestiti(IndumentiColori, indumento1, colore1, indumento2, colore2);
            }



            catch (ErroriVestiti ev)
            {
                switch (ev.getCod())
                {
                    case 0 when !ev.getMessaggio().Equals("True"):
                        MessageBox.Show(ev.getMessaggio());
                        break;
                    case 1 when !ev.getMessaggio().Equals("True"):
                        aggiornamentoscelte(indumento1, colore1);
                        scelta1.Text = BarraRicercaVestiti1.Text;
                        MessageBox.Show(ev.getMessaggio());
                        break;
                    case 2 when !ev.getMessaggio().Equals("True"):
                        aggiornamentoscelte(indumento2, colore2);
                        TextIndumento2.Text = BarraRicercaVestiti2.Text;
                        MessageBox.Show(ev.getMessaggio());
                        break;
                    case 1 when ev.getMessaggio().Equals("True"):
                        sceltaeffettuataVestito1 = true;
                        scelta1.Text = BarraRicercaVestiti1.Text;
                        TextIndumento2.Text = " ";
                        aggiornamentoscelte(indumento1, colore1);
                        
                        break;
                    case 2 when ev.getMessaggio().Equals("True"):
                        aggiornamentoscelte(indumento2, colore2);
                        TextIndumento2.Text = BarraRicercaVestiti2.Text;
                        scelta1.Text = " ";
                        sceltaeffettuataVestito2 = true;
                        
                        break;
                    case 3 when ev.getMessaggio().Equals("True"):
                        aggiornamentoscelte(indumento1, colore1);
                        aggiornamentoscelte(indumento2, colore2);
                        TextIndumento2.Text = BarraRicercaVestiti2.Text;
                        sceltaeffettuataVestito2 = true;
                        sceltaeffettuataVestito1 = true;
                        scelta1.Text = BarraRicercaVestiti1.Text;
                        break;
                }
            }
        }

        private void SalvaEdEsciButton_Click(object sender, EventArgs e)
        {
            vestito2 = TextIndumento2.Text;
            vestito1 = scelta1.Text;
            this.Close();

        }

        private void List_felpe_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { scelta1.Text = List_felpe.Items[List_felpe.SelectedIndex].ToString(); }
            catch { }
        }

        private void List_giacche_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { scelta1.Text = List_giacche.Items[List_giacche.SelectedIndex].ToString(); }
            catch { }
        }
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
    }
}
