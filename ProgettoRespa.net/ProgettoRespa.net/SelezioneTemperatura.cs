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
        
        public string valore;
        public SelezioneTemperatura()
        {
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
            valore = listTemperature.Items[listTemperature.SelectedIndex].ToString();
            this.Close();
        }
    }
}
