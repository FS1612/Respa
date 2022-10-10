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
        int chiusura = 0;
        Boolean Chiusura_aggiornata = false; 
        int pos;

        public Form1()
        {

            InitializeComponent();

            AggiornamentoPresenza();
            Porta_timer = false;
            Tempo_porta = false;
            Chiusura_aggiornata = false;
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
            textStart.Text = "True";
            textStart.BackColor = Color.Green;
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
            textStart.Text = "False";
            textStart.BackColor = Color.Red;

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_RESET_Click(object sender, EventArgs e)
        {
            textReset.Text = "True";
            textReset.BackColor = Color.Green;
            resetTimer.Enabled = true;
           

            Start = false;
            Porta_timer = false;
            Tempo_porta = false;
            chiusura = 0;
            Chiusura_aggiornata = false;
            presente = false;
            AggiornamentoPresenza();
        }

        private void masterTimer_Tick(object sender, EventArgs e)
        {
            pos = posAttuale + posiniziale;
            delta = masterTimer.Interval;
            if (Start)
            {
                textFcdPorta.Text = "False";
                textFcdPorta.BackColor = Color.Red;
                if (TextSensProssimita_porta.Text.Equals("True") || (TextSensorePortaInterno.Text.Equals("True")))
                {
                    posAttuale = posAttuale + (int)(delta * spostamento) / durataspostamento;
                    textFcsPorta.Text = "False";
                    textFcsPorta.BackColor = Color.Red;
                }
                if (pos > 547)
                {
                    if (!Chiusura_aggiornata)
                    {
                        Chiusura_aggiornata = true;
                        chiusura++;
                    }
                    pos = 547;
                    textFcdPorta.Text = "True";
                    textFcdPorta.BackColor = Color.Green;
                    TextSensProssimita_porta.Text = "";
                    TextSensorePortaInterno.Text = "";

                }
                if (pos < 250)

                {
                    Chiusura_aggiornata = false;
                  
                    if (chiusura == 1)
                    {
                        presente = true;
                        AggiornamentoPresenza();
                    }
                    if (chiusura > 1)
                    {
                        presente = false;
                        AggiornamentoPresenza();
                    }

                    pos = 250;
                    textFcsPorta.Text = "True";
                    textFcsPorta.BackColor = Color.Green;

                }
                if (TextSensProssimita_porta.Text.Equals("") && (TextSensorePortaInterno.Text.Equals("")))
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
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PortaTimer_Tick(object sender, EventArgs e)
        {
            Tempo_porta = true;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void text_dxporta_TextChanged(object sender, EventArgs e)
        {

        }

        private void resetTimer_Tick(object sender, EventArgs e)
        {
            textReset.Text = "False";
            textReset.BackColor = Color.Red;
        }
    }
}
