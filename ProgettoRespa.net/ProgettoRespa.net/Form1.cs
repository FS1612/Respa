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
        Boolean presente = false; // vale 1 se il giocatore è nella stanza, 0 altrimenti 
        int durataspostamento = 5000;
        int spostamento = 297;// spostamento totale della porta ottenuto come differenza tra la posizione della porta completamente chiusa e quella della porta completamente chiusa
        int delta;
        int posiniziale = 250;
        int posAttuale;
        Boolean Start = false;// vale 1 se il giocatore ha premuto start, 0 altrimenti
        Boolean Porta_timer = false;//vale 1 se il timer della porta è stato avviato, 0 altrimenti
        Boolean Tempo_porta = false;// vale 1 se il tempo di apertura della porta è terminato, 0 altrimenti
        int chiusura = 0;// conta quante volte si è chiusa la porta 
        Boolean Chiusura_aggiornata = false; // vale 1 solo se viene aggiornato il valore di chiusura, 0 altrimenti
        int pos;
        double tempAttuale;
        int tempIniziale = 19;//temperatura iniziale della stanza
        int temp1;
        Boolean Robot = false;
        // int posinizialeRobot = 782;
        int posinizialeRobot = 521;
        int durataspostRobot = 5000;
        //int spostRobot = 740;
        int spostRobot = 387;
        int deltaRobot;
        int posAttualeRobot;
        int posRobot;
        int yposRobot;
        int spostverticaleRobot = 60;
        int yposinizialeRobot = 103;
        int yposAttuale;
        bool ErroreTempNonValida = false;
        int tempmax = 30;
        SceltaVestiti sceltaVestiti= new SceltaVestiti();
        private bool sceltaVestito1Effettuata = false;
        private string vestito1;
        public object CranePicture { get; private set; }

        public Form1()
        {

            InitializeComponent();
            tempAttuale = tempIniziale;
            textTemperatura.Text = tempAttuale.ToString();
            AggiornamentoPresenza();
            Porta_timer = false;
            Tempo_porta = false;
            Chiusura_aggiornata = false;
            
        }
        private void AggiornamentoPresenza()
        {
            //funzione di supporto che verica la presenza del giocatore e aggiorna le variabili di stato 
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
        private void aggiornamentoVestiti()
        {
            using (SceltaVestiti sv = new SceltaVestiti())
            {
                if (sv.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.sceltaVestito1Effettuata = sv.sceltaeffettuataVestito1;
                    
                    if (!sceltaVestito1Effettuata)
                    {
                        RicercaVestiti1.Text = " scegli un un indumento";
                    }
                    else
                    {
                        this.vestito1 = sv.vestito1;
                        this.text2indumento .Text= sv.vestito2;
                        this.RicercaVestiti1.Text = this.vestito1;
                    }
                }
            }
           


        }
        private void button_START_Click(object sender, EventArgs e)
        {
            textStart.Text = "True";
            textStart.BackColor = Color.Green;
            masterTimer.Enabled = true;
            startTimer.Enabled = true;
            TimerRobot.Enabled = true;
            Start = true;
        }
        private void button_presenza_Click(object sender, EventArgs e)
        {//funzione che gestisce la presenza del player tramite tasto
            if (presente)
            {
                //presente = false;
                chiusura++;
                AggiornamentoPresenza();
            }
            else
            {
                chiusura++;
                //presente = true;
                AggiornamentoPresenza();
            }

        }
        private void startTimer_Tick(object sender, EventArgs e)
        {//serve per riportare a false la variabile start appena il programma è avviato
            textStart.Text = "False";
            textStart.BackColor = Color.Red;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button_RESET_Click(object sender, EventArgs e)
        {//riporta il programma allo stato iniziale 
            textReset.Text = "True";
            textReset.BackColor = Color.Green;
            resetTimer.Enabled = true;
            // si può resettare il timer?

            //Start = false;
            Porta_timer = false;
            Tempo_porta = false;
            chiusura = 0;
            Chiusura_aggiornata = false;
            presente = false;
            AggiornamentoPresenza();

        }
        private void masterTimer_Tick(object sender, EventArgs e)
        {//ciclo di funzionamento del programma

            pos = posAttuale + posiniziale;
            delta = masterTimer.Interval;
            if (Start)
            {
                Sensore_Prossimitàesterna.BackColor = Color.Red;
                Prossimitainterna_sensore.BackColor = Color.Red;
                fcdSensore.BackColor = Color.Red;
                textFcdPorta.BackColor = Color.Red;
                // se ho avviato il programma(start=true), quando il player si trova all'esterno della porta (sensore prossimità esterno= true) la porta si deve aprire per permettere l'accesso del player per poi richiudersi trascorsi 5 secondi. Stesso meccanismo si avvia quando il player vuole uscire e dunque il sensore di prossimità esterno divaenta vero
                if (TextSensProssimita_porta.Text.Equals("True") || (TextSensorePortaInterno.Text.Equals("True")))
                {
                    posAttuale = posAttuale + (int)(delta * spostamento) / durataspostamento;
                    textFcsPorta.Text = "False";
                    textFcsPorta.BackColor = Color.Red;
                    fcs_sensore.BackColor = Color.Red;
                    if (TextSensProssimita_porta.Text.Equals("True"))
                    {
                        Sensore_Prossimitàesterna.BackColor = Color.Green;
                    }
                    if (TextSensorePortaInterno.Text.Equals("True"))
                    {
                        Prossimitainterna_sensore.BackColor = Color.Green;

                    }
                }
                if (pos > 547)
                {//se la porta è completamente aperta (posizione x=547) allora fcd è verificato e aumento iil contatore delle chiusure di uno dopo aver aggiornato il valore di Chiusura_aggiornata
                    if (!Chiusura_aggiornata)
                    {
                        Chiusura_aggiornata = true;
                        chiusura++;
                    }
                    pos = 547;
                    textFcdPorta.Text = "True";
                    textFcdPorta.BackColor = Color.Green;
                    fcdSensore.BackColor = Color.Green;
                    TextSensProssimita_porta.Text = "";
                    TextSensorePortaInterno.Text = "";

                }
                if (pos < 250)
                //se mi trovo a x=250 allora la porta è completamente chiusa e fcs è true
                {
                    Chiusura_aggiornata = false;
                    //la variabile booleana di appoccio chiusura porta viene settata a true appena la porta si apre e riportata a false appena la porta si richiude cosi che il contatore delle chiusure sia aggiornato una sola volta per ciclo                   
                    if(chiusura%2==0)
                    {
                        presente = true;
                        AggiornamentoPresenza();
                    }
                    
                    else
                    {
                        presente = false;
                        AggiornamentoPresenza();
                    }

                    pos = 250;
                    textFcsPorta.Text = "True";
                    textFcsPorta.BackColor = Color.Green;
                    fcs_sensore.BackColor = Color.Green;

                }
                if (TextSensProssimita_porta.Text.Equals("") && (TextSensorePortaInterno.Text.Equals("")))
                {//la porta si chiude solo se i due sensori di prossiimita risultano falsi 
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
        private void PortaTimer_Tick(object sender, EventArgs e)
        {//timer che pone a true la variabile tempo_porta permettendo la ciusura della porta appena trascorso il tempo
            Tempo_porta = true;

        }
        private void resetTimer_Tick(object sender, EventArgs e)
        {
            textReset.Text = "False";
            textReset.BackColor = Color.Red;
        }
        private void AggiornamentoTemperatura()
        {
            //funzione che deve gestire la temperatura della stanza per mantenerla tra il range compreso tra 19 gradi e la temperatura desiderata dall'utente 
            //String temp = text_tempdesiderata.Text;
            //string temp3 = temp;
            //errTemp.SetTempIniziale(tempIniziale);
            //errTemp.SetTempmax(tempmax);
            //if (presente)

            //{
            //    // per poter paragonare le temperature entrambe devono essere intere, perciò deco convertire la temperatura inserita dall'utente nell'interfaccia da tipo String a tipo intero. Per la conversione uso il metodo int.Parse() che però può sollevare un'eccezione di tipo FormatException e, sollevata l'eccezione, per non far terminare il programma, la "gestisco" tramite il costrutto Try-catch
            //    try
            //    {
            //        if (temp == string.Empty || temp.Contains("-"))
            //        {
            //            text_tempdesiderata.Text = "";
            //            throw new ErroreTemperatura(temp3, tempIniziale, tempmax, 0);
            //        }
            //        else
            //        {

            //            temp1 = int.Parse(temp);
            //            if (temp1 > tempIniziale && temp1 < tempmax)
            //            {
            //                timerTemp.Enabled = true;
            //            }
            //            else { text_tempdesiderata.Text = "";
            //                throw new ErroreTemperatura(temp3, tempIniziale, tempmax, temp1);
            //            }

            //        }
            //    }
            //    catch (ErroreTemperatura e)
            //    {
            //        if (!temp3.Equals("")) { MessageBox.Show(e.getMsg()); }
            //        else
            //        {
            //            if (!ErroreTempNonValida)
            //            {
            //                ErroreTempNonValida = true;
            //                MessageBox.Show(e.getMsg());
            //            }
            //        }
            //}
            //finally
            //{
            //    ErroreTempNonValida = true;
            //    //per far eseguire al codice qualcosa indipendentemente dall'esito del try
            //}

            //}
            using (SelezioneTemperatura st = new SelezioneTemperatura(tempIniziale,tempmax))
            {
                if (st.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.Tasto_sceltaTemp.Text = st.valore;
                    
                    
                }
            }
        }
        private void timerTemp_Tick(object sender, EventArgs e)
        {
            // voglio che la temperatura aumenti solo se la temperatura della staza risulta minore della temperatura desiderata, se la porta è chiusa e se il personaggio è presente
            if (tempAttuale < temp1 && textFcsPorta.Text.Equals("True") && textPersonaggio.Text.Equals("Presente"))
            {
                tempAttuale = tempAttuale + 0.5;
            }
            //se la temperatura attuale della stanza è maggiore di quella iniziale allora, essendo la porta aperta, deve diminuire
            if (tempAttuale > tempIniziale && !textFcsPorta.Text.Equals("True"))
            {
                tempAttuale = tempAttuale - 0.5;
            }
            //la temperatura deve rimanere compresa fra la temperatura minima e la temperatura max
            if (tempAttuale > temp1)
            {
                tempAttuale = temp1;
            }
            if (tempAttuale < tempIniziale)
            {
                tempAttuale = tempIniziale;
            }

            textTemperatura.Text = tempAttuale.ToString();
        }
        private void TimerRobot_Tick(object sender, EventArgs e)
        {
            posRobot = posAttualeRobot + posinizialeRobot;
            deltaRobot = TimerRobot.Interval;            
                //textBraccio1.Enabled = true;
                //textBraccio2.Enabled = true;
                //textBraccio3.Enabled = true;
                //textDxRobot.Enabled = true;
                //textSxRobot.Enabled = true;
                if (textDxRobot.Text.Equals("True"))
                {
                    posAttualeRobot = posAttualeRobot + (int)(deltaRobot * spostRobot) / durataspostRobot;
                    fcs_Robot.BackColor = Color.Red;
                    textFcsRobot.Text = "False";
                }

                if (posRobot > 720)
                {
                    posRobot = 720;
                    textDxRobot.Text = "";
                    fcd_Robot.BackColor = Color.Green;
                    textFcdRobot.Text = "True";

                }
                if (textDxRobot.Text.Equals("") && textSxRobot.Text.Equals("") && textBraccio2.Text.Equals("True"))
                {
                    braccio2.Width = 80;
                }

                if (textDxRobot.Text.Equals("") && textSxRobot.Text.Equals("") && textBraccio3.Text.Equals("True"))
                {
                    braccio3.Height = 80;

                }
                if (textDxRobot.Text.Equals("") && textSxRobot.Text.Equals("") && textBraccio1.Text.Equals("True"))
                {
                    braccio1.Top = 35;
                    braccio1.Height = 80;

                }
                if (textBraccio2.Text.Equals(""))
                {
                    braccio2.Width = 30;
                }
                if (textBraccio3.Text.Equals(""))
                {
                    braccio3.Height = 30;
                }
                if (textBraccio1.Text.Equals(""))
                {
                    braccio1.Location = new Point(547, 88);
                    braccio1.Height = 35;
                }
                if (posRobot < 526)
                {
                    posRobot = 526;
                    textSxRobot.Text = "";
                    fcs_Robot.BackColor = Color.Green;
                    textFcsRobot.Text = "True";
                    fcd_Robot.BackColor = Color.Red;
                    textFcdRobot.Text = "False";

                }

                if (textSxRobot.Text.Equals("True"))
                {
                    posAttualeRobot = posAttualeRobot - (int)(deltaRobot * spostRobot) / durataspostRobot;
                }
            
            if(textSxRobot.Text.Equals("True")|| textDxRobot.Text.Equals("True"))
            {
                robot.Left = posRobot;
                braccio1.Left = posRobot + 26;
                braccio2.Left = posRobot + 26;
                braccio3.Left = posRobot + 26;
            }
            else
            {
                if(Text_AltoRobot.Text.Equals("True"))
                {
                    braccio1.Location = new Point(742, 50);
                    braccio2.Location = new Point(755, 78);
                    braccio3.Location = new Point(742, 78);
                }
                else
                {
                    braccio1.Left = posRobot + 26;
                    braccio2.Left = posRobot + 26;
                    braccio3.Left = posRobot + 26;
                }
            }
                

            //MOVIMENTO VERTICALE// 
            yposRobot = yposinizialeRobot + yposAttuale;
            
            if (Text_AltoRobot.Text.Equals("True"))
            {
                yposAttuale = yposAttuale + (int)(deltaRobot * spostverticaleRobot) / durataspostRobot;
                basso_Robot.BackColor = Color.Red;
                textBasso.Text = "False";
                robot.Location = new Point(720,60);
                //braccio1.Location= new Point(742,50);
                //braccio2.Location = new Point(755,85);
                //braccio3.Location = new Point(742,104);
                //robot.Top = yposAttuale;
            }
            if (yposRobot > 60)
            {
                yposRobot = 60;
                //Text_AltoRobot.Text = "";
                alto_Robot.BackColor = Color.Green;
                textAlto.Text = "True";
                //robot.Top = yposAttuale;

            }



        }
        private void button1_Click(object sender, EventArgs e)
        {
            aggiornamentoVestiti();         
        }

        private void TextSensProssimita_porta_TextChanged(object sender, EventArgs e)
        {

        }

        private void jeans_Click(object sender, EventArgs e)
        {

        }

        private void pantalonenero_Click(object sender, EventArgs e)
        {

        }

        private void Tasto_sceltaTemp_Click(object sender, EventArgs e)
        {
            AggiornamentoTemperatura();
        }

        private void Robot_automatico_Click(object sender, EventArgs e)
        {

        }

        private void text_ALLARME_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}

    






