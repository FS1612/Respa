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
/// form che permette la scelta della temperatura da parte dell'utente
/// </summary>
    public partial class SelezioneTemperatura : Form
    {
        int tempmin;
        int tempmax;
        public string valore;
       public bool TimerAbilitato = false;
        private string temp ;        
        public int tempnumero;
        /// <summary>
        /// inizializza il nuovo form passandogli i valori stabiliti nel <see cref="Form1 "/> facendo uso di <see cref="InserisciTemperature"/>
        /// </summary>
        /// <param name="tempmin">valore minimo della temperatura</param>
        /// <param name="tempmax">valore max della temperatura</param>
        public SelezioneTemperatura(int tempmin,int tempmax)
        {
            this.tempmax = tempmax;
            this.tempmin = tempmin;
            InitializeComponent();
            InserisciTemperature();
           
        }/// <summary>
        /// funzione che crea una lista di temperature comprese tra tempmin e tempmax tra cui l'utente puo scegliere 
        /// </summary>
        private void InserisciTemperature()
        {
            
            for(int i=-10; i < 40; i++)
            {
                listTemperature.Items.Add(i);
            }
        }
        /// <summary>
        /// aggiorna il testo della temperatura deasiderata in base al valore contenuto nella casella della lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listTemperature_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { 
                Text_temperatura.Text = listTemperature.Items[listTemperature.SelectedIndex].ToString();
            }
            catch { }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            valore = temp;
            this.Close();
        }       
        /// <summary>
        /// funzione che lancia una verifica della temperatura (effettuata da <see cref="ErroreTemperatura.ErroreTemperatura(string, int, int, int)"/>ogni volta che il valore della casella testuale cambia e qualora la temperatura rispettasse i vincoli, avvia il timer che permette l'innalzamento della temperatura
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Text_temperatura_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                if (Text_temperatura.Text.Equals("") || Text_temperatura.Text.Contains('-'))
                {
                    if (Text_temperatura.Text.Contains('-'))
                    {
                        temp = listTemperature.Items[listTemperature.SelectedIndex].ToString();
                        tempnumero = 0;
                    }
                    else
                    {
                        temp = "";
                        tempnumero = 0;
                    }

                }
                else
                {
                    temp = listTemperature.Items[listTemperature.SelectedIndex].ToString();
                    tempnumero = int.Parse(temp);
                }
                throw new ErroreTemperatura(temp, tempmin, tempmax, tempnumero);
            }

            catch (ErroreTemperatura et)
            {
                if (!et.getMsg().Equals("True"))
                {
                    MessageBox.Show(et.getMsg());
                }
                else
                {
                    TimerAbilitato = true;
                }
                
            }
        }
    }
    }