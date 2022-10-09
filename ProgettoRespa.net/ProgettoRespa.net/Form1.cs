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
    public partial class Form1 : Form
    {
        private Boolean presente = false; 
        public Form1()
        {
            
            InitializeComponent();
            
            AggiornamentoPresenza();
        }
        
        private void AggiornamentoPresenza()
        {
            if(!presente)
            {
               
                textPersonaggio.Text = "Assente";
               textPersonaggio.BackColor = Color.Red;
           }
           else
            {
                
                textPersonaggio.Text = "Presente";
                textPersonaggio.BackColor = Color.Green;
            }
        }
        private void button_START_Click(object sender, EventArgs e)
        {
            textStart.Text = "TRUE";
            masterTimer.Enabled = true;
            startTimer.Enabled = true;
        }

        private void button_presenza_Click(object sender, EventArgs e)
        {
            if (presente)
            {
                presente = false;
                AggiornamentoPresenza();
            }
            else
            {
                presente = true;
                AggiornamentoPresenza();
            }
            
        }

        private void startTimer_Tick(object sender, EventArgs e)
        {
            textStart.Text = "FALSE";
            textStart.Text = "";
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_RESET_Click(object sender, EventArgs e)
        {
            presente = false;
            AggiornamentoPresenza();
        }

        private void masterTimer_Tick(object sender, EventArgs e)
        {
            
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }
    }
}
