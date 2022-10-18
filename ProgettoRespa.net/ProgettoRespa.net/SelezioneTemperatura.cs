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
    public partial class SelezioneTemperatura : Form
    {
        int tempmin;
        int tempmax;
        public string valore;
       public bool TimerAbilitato = false;
        private bool ErroreTempNonValida = false;
        private string temp ;        
        public int tempnumero;
        public SelezioneTemperatura(int tempmin,int tempmax)
        {
            this.tempmax = tempmax;
            this.tempmin = tempmin;
            InitializeComponent();
            InserisciTemperature();
           
        }
        private void InserisciTemperature()
        {
            
            for(int i=-10; i < 40; i++)
            {
                listTemperature.Items.Add(i);
            }
        }
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