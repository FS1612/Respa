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
        
        Type scarpe = typeof(Scarpe);
        Type jeans = typeof(Jeans);
        Type pantaloni = typeof(Pantaloni);
        Type magliette = typeof(Magliette);
        public string vestito1;
        public bool sceltaeffettuataVestito1;
        
        Dictionary<string, List<string>> IndumentiColori = new Dictionary<string, List<string>>();
        
        public SceltaVestiti()
        {
            
            InitializeComponent();
            sceltaeffettuataVestito1 = true;
            CondivisioneElementi();
            GestioneVestiti();
            
        }
        private void CondivisioneElementi()
        {
            CreaListaIndumenti(scarpe);
            CreaListaIndumenti(pantaloni);
            CreaListaIndumenti(jeans);
            CreaListaIndumenti(magliette);
        }
        
        private void CreaListaIndumenti(Type e)
        {
            foreach (string s in Enum.GetNames(e))
            {
                //*splitto le stringhe in due sottostringhe una con i colori e una con gli indumenti
                string[] appoggio = s.Split('_');       
                string indumento = appoggio[0];
                string colore = appoggio[1];
                //AggiungiIndumentiLista(indumento);
                AggiornaDizionario(indumento, colore);
                //IndumentiColori.Add(indumento, colore);

            }
        }
        
        private void AggiornaDizionario(string key, string value)
        {
            List<string> a = new List<string>();
            if (!IndumentiColori.ContainsKey(key))
            {
                
                a.Add(value);
                IndumentiColori.Add(key,a);
            }
            else
            {
                IndumentiColori.TryGetValue(key, out a);
                a.Add(value);
                IndumentiColori.Remove(key);
                IndumentiColori.Add(key,a);
            }
        }
       
       private void GestioneVestiti()
        {


            //*aggiungo scarpe
            InserisciOggetti(scarpe,List_Scarpe);
            //*aggiungo jeans
 
            InserisciOggetti(jeans,List_Jeans);
            ////*aggiungo Pantaloni
            InserisciOggetti(pantaloni, List_Pantaloni);
            ////* aggiungoMagliette
            InserisciOggetti(magliette, List_Magliette);




        }
       private void InserisciOggetti( Type e,ListBox l){
            foreach (string s in Enum.GetNames(e))
            {
                //* rimpiazzo vecchio carattere '_' con uno spazio ' '
               string r= s.Replace('_', ' ');
                l.Items.Add(r);
            }
        }

        private void List_pantaloni_SelectedIndexChanged(object sender, EventArgs e)
        {
            scelta1.Text = List_Pantaloni.Items[List_Pantaloni.SelectedIndex].ToString();
        }

        private void List_magliette_SelectedIndexChanged(object sender, EventArgs e)
        {
            scelta1.Text = List_Magliette.Items[List_Magliette.SelectedIndex].ToString();
        }

        private void List_Jeans_SelectedIndexChanged(object sender, EventArgs e)
        {
            scelta1.Text = List_Jeans.Items[List_Jeans.SelectedIndex].ToString();
        }

        private void Scarpe_SelectedIndexChanged(object sender, EventArgs e)
        {
            scelta1.Text = List_Scarpe.Items[List_Scarpe.SelectedIndex].ToString();
        }


        private void bottoneCerca_Click(object sender, EventArgs e)
        {
            try
            {
                string[] divisione = BarraRicercaVestiti.Text.Split(' ');
                char let = divisione[0].First();
                char letToUp = Char.ToUpper(let);
                string indumento = divisione[0].Replace(let, letToUp);
                
                
                string colore;
                if (divisione.Length == 2)
                {
                    if (!divisione[1].Equals(""))
                    {
                        colore = divisione[1].ToLower();
                       
                        throw new ErroriVestiti(IndumentiColori, indumento, colore);
                    }
                    
                }
                throw new ErroriVestiti(IndumentiColori, indumento, "");


            }
            catch(ErroriVestiti ev)
            {
                if (!ev.getMessaggio().Equals("True")){
                    
                }
                else
                {               
                    sceltaeffettuataVestito1 = true;
                    scelta1.Text = BarraRicercaVestiti.Text;    
                }
            }
        }

        private void SalvaEdEsciButton_Click(object sender, EventArgs e)
        {
            vestito1 = scelta1.Text;
            this.Close();
            
        }
        
       
    }
}
