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
        public string vestito2;
        public bool sceltaeffettuataVestito2;
        string indumento1;
        string colore1;
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
            try { scelta1.Text = List_Pantaloni.Items[List_Pantaloni.SelectedIndex].ToString(); }
            catch{}   
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
            //try
            //{

            //    string[] divisione = BarraRicercaVestiti1.Text.Split(' ');
            //    char let = divisione[0].First();
            //    char letToUp = Char.ToUpper(let);
            //     indumento1 = divisione[0].Replace(let, letToUp);

            //    if (divisione.Length == 2)
            //    {
            //        if (!divisione[1].Equals(""))
            //        {
            //            colore1 = divisione[1].ToLower();

            //            throw new ErroriVestiti(IndumentiColori, indumento1, colore1," "," ",false);
            //        }

            //    }

            //    throw new ErroriVestiti(IndumentiColori, indumento1," ", " ", " ", false);
            //}
            try
            {
                string indumento1;
                 string colore1;
                 string indumento2;
                 string colore2;
                // if (!BarraRicercaVestiti1.Text.Equals("")&& BarraRicercaVestiti2.Text.Equals("") )
                // {
                //     MessageBox.Show("caso1");
                string[] divisione = BarraRicercaVestiti1.Text.Split(' ');
                if (!divisione[0].Equals(string.Empty))
                {
                    if(!divisione[0].Equals(" ")) {
                        char let = divisione[0].First();
                        char letToUp = Char.ToUpper(let);
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
                //     if(divisione.Length == 2)
                //     {
                //         colore1 = divisione[1].ToLower();
                //         throw new ErroriVestiti(IndumentiColori, indumento1, colore1, " ", " ", false);
                //     }
                //     throw new ErroriVestiti(IndumentiColori, indumento1, " ", " ", " ", false);
                // }
                // if(BarraRicercaVestiti1.Text.Equals("") && !BarraRicercaVestiti2.Text.Equals(""))
                // {
                    string[] divisione1 = BarraRicercaVestiti2.Text.Split(' ');
                if (!divisione1[0].Equals(string.Empty)) {
                    if(!divisione1[0].Equals(" ")) {
                        char let1 = divisione1[0].First();
                        char letToUp1 = Char.ToUpper(let1);
                        indumento2 = divisione1[0].Replace(let1, letToUp1);
                        textBox1.Text = indumento2;
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
                    
                //     if (divisione1.Length == 2)
                //     {
                //         colore2 = divisione1[1].ToLower();
                //         throw new ErroriVestiti(IndumentiColori, " " , " ",indumento2, colore2, false);
                //     }
                //     throw new ErroriVestiti(IndumentiColori, " ", " ", indumento2, " ", false);
                // }
                // if (BarraRicercaVestiti1.Text.Equals("") && BarraRicercaVestiti2.Text.Equals(""))
                // {
                //     string[] divisione = BarraRicercaVestiti1.Text.Split(' ');
                //     char let = divisione[0].First();
                //     char letToUp = Char.ToUpper(let);
                //     indumento1 = divisione[0].Replace(let, letToUp);
                //     string[] divisione1 = BarraRicercaVestiti2.Text.Split(' ');
                //     char let1 = divisione1[0].First();
                //     char letToUp1 = Char.ToUpper(let1);
                //     indumento2 = divisione1[0].Replace(let1, letToUp1);
                //     if(divisione.Length == 2&& divisione1.Length == 1)
                //     {
                //         colore1 = divisione[1].ToLower();
                //         throw new ErroriVestiti(IndumentiColori, indumento1, colore1, indumento2, " ", false);
                //     }
                //     if (divisione1.Length == 2 && divisione.Length == 1)
                //     {
                //         colore2 = divisione1[1].ToLower();
                //         throw new ErroriVestiti(IndumentiColori, indumento1, " ", indumento2, colore2, false);
                //     }
                //     else
                //     {
                //         colore1 = divisione[1].ToLower();
                //         colore2 = divisione1[1].ToLower();
                //         throw new ErroriVestiti(IndumentiColori, indumento1, colore1, indumento2, colore2, false);
                //     }
                // }
                //colore1 = divisione[1].ToLower();
                //colore2 = divisione1[1].ToLower();
                throw new ErroriVestiti(IndumentiColori, indumento1, colore1, indumento2, colore2, false);
            }



            catch (ErroriVestiti ev)
            {
                if (!ev.getMessaggio().Equals("True")){
                    MessageBox.Show(ev.getMessaggio());
                }
                else
                {               
                    sceltaeffettuataVestito1 = true;
                    scelta1.Text = BarraRicercaVestiti1.Text;
                    TextIndumento2.Text = BarraRicercaVestiti2.Text;
                }
            }
        }    
        private void cercaVestito2()
        {
            if (!BarraRicercaVestiti2.Text.Equals(""))
            {
                string[] divisione1 = BarraRicercaVestiti2.Text.Split(' ');
                char let1 = divisione1[0].First();
                char letToUp1 = Char.ToUpper(let1);
                string indumento2 = divisione1[0].Replace(let1, letToUp1);
                string colore2;
                if (divisione1.Length == 2)
                {
                    if (!divisione1[1].Equals(""))
                    {
                        colore2 = divisione1[1].ToLower();
                        TextIndumento2.Text = indumento2;
                        throw new ErroriVestiti(IndumentiColori, indumento2, colore1, indumento2, colore2, true);
                        
                    }

                }
                throw new ErroriVestiti(IndumentiColori, indumento2, colore1, indumento2, " ", true);
            }
            else
            {
                TextIndumento2.Text = "nessuno";
                vestito2 = "nessuno";
            }
            
        }
        private void SalvaEdEsciButton_Click(object sender, EventArgs e)
        {
            vestito1 = scelta1.Text;
            this.Close();
            
        }

        
    }
}
