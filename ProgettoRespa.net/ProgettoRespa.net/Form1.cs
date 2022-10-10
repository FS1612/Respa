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
        Boolean presente = false;
        int durataspostamento = 5000;
        int spostamento = 297;
        int delta;
        int posiniziale = 250;
        int posAttuale;
        Boolean Start = false;
        Boolean Porta_timer = false;
        Boolean Tempo_porta = false;

        int pos;
        public Form1()
        {

            InitializeComponent();

            AggiornamentoPresenza();
            Porta_timer = false;
            Tempo_porta = false;
        }

        private void AggiornamentoPresenza()
        {
            if (!presente)
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
            Start = true;
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
            pos = posAttuale + posiniziale;
            delta = masterTimer.Interval;
            if (Start)
            {
                if (TextSensProssimita_porta.Text.Equals("True"))
                {
                    posAttuale = posAttuale + (int)(delta * spostamento) / durataspostamento;
                    textFcsPorta.Text = "False";
                    textFcsPorta.BackColor = Color.Red;
                }
                if (pos > 547)
                {
                    pos = 547;
                    textFcdPorta.Text = "True";
                    textFcdPorta.BackColor = Color.Green;
                    TextSensProssimita_porta.Text = "";

                }
                if (pos < 250)
                {
                    pos = 250;
                    textFcsPorta.Text = "True";
                    textFcsPorta.BackColor = Color.Green;

                }
                if (TextSensProssimita_porta.Text.Equals(""))
                {
                    if (!Porta_timer)
                    {
                        Porta_timer = true;
                        PortaTimer.Enabled = true;
                    }
                    if (Tempo_porta)
                    {
                        textFcdPorta.Text = "False";
                        textFcdPorta.BackColor = Color.Red;
                        posAttuale = posAttuale - (int)(delta * spostamento) / durataspostamento;
                    }
                   
                }


                porta.Left = pos;


            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }
        private void PresenzaPlayer()
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PortaTimer_Tick(object sender, EventArgs e)
        {
            Tempo_porta = true;
        }
    }
}
