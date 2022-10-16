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
        public SelezioneTemperatura(int tempmin,int tempmax)
        {
            InitializeComponent();
            InserisciTemperature();
            VerificaTemperatura();
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
            valore = listTemperature.Items[listTemperature.SelectedIndex].ToString();
            this.Close();
        }
        private void VerificaTemperatura()
        {
            //int temp1;
            //string temp3 =temp ;



            //    try
            //        {
            //        if(!listTemperature.Items[listTemperature.SelectedIndex].ToString().Equals(string.Empty))
            //        temp = listTemperature.Items[listTemperature.SelectedIndex].ToString();

            //        if (temp == string.Empty || temp.Contains("-"))
            //            {
            //                Text_temperatura.Text = "";
            //            TimerAbilitato = false;
            //            throw new ErroreTemperatura(temp, tempmin, tempmax, 0);
            //            }
            //            else
            //            {

            //                temp1 = int.Parse(temp);
            //                if (temp1 > tempmin && temp1 < tempmax)
            //                {
            //                TimerAbilitato = true; 

            //                }
            //                else
            //                {
            //                Text_temperatura.Text = "";
            //                TimerAbilitato = false;
            //                throw new ErroreTemperatura(temp, tempmin, tempmax, temp1);
            //                }

            //            }
            //        }
            //        catch (ErroreTemperatura e)
            //        {
            //            if (!temp.Equals("")) { MessageBox.Show(e.getMsg()); }
            //            else
            //            {
            //                if (!ErroreTempNonValida)
            //                {
            //                    ErroreTempNonValida = true;
            //                    MessageBox.Show(e.getMsg());
            //                }
            //            }
            //        }
            //        finally
            //        {
            //            ErroreTempNonValida = true;
            //            //per far eseguire al codice qualcosa indipendentemente dall'esito del try
            //        }
            try
            {
                if (listTemperature.SelectedIndex == -1)
                {

                }
            }
            catch
            {

            }
            }
        }
    }

