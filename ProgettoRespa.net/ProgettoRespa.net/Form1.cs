﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using TwinCAT.Ads;

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
        int posinizialeRobot = 521;
        int durataspostRobot = 5000;
        int spostRobot = 387;
        int deltaRobot;
        int posAttualeRobot;
        int posRobot;
        int tempmax = 30;
  
        private bool sceltaVestito1Effettuata = false;
        private string vestito1;
        PictureBox pic1;
        PictureBox pic2;
        public object CranePicture { get; private set; }
        //variabili booleane robot 
        //bool FineCorsaAltoRobot = false;
        //bool FineCorsaBassoRobot = false;
        //bool FineCorsaCentraleSinistroRobot = true;
        //bool FineCorsaCentraleDestroRobot = false;
        //bool FineCorsaDestro1 = false;
        //bool FineCorsaDestro2 = false;
        //bool FineCorsaDestro3 = false;
        bool MagliettaBianca = false;
        bool MagliettaNera = false;
        bool GiaccaPelle = false;
        bool FelpaVerde = false;
        bool JeansChiaro = false;
        bool PantaloneNero = false;
        bool ScarpeNere = false;
        bool ScarpeBianche = false;
        bool Braccio1Carico = false;
        bool Braccio3Carico = false;
        int scarico1 = 1;
        int scarico2 = 1;
        bool reset_effettuato = false;
        bool salita_effettuata = false;
        string comandoRobot;
        string comandoBraccio;
        int numerobraccio;
        int posybraccio1;
        int posxbraccio1;
        int posybraccio1iniziale;
        int posxbraccio1iniziale;
        int posyRobot;
        int posYinizialeRobot; //106
        bool spostam = false;
        private Graphics gfx;
        //inizializzazione ads
        //private TcAdsClient tcClient;
        private int[] hConnect;
        //private AdsStream dataStream;
        //private AdsBinaryReader binRead;
        private int[] hvar_name;
        private string[] dataPLC ={"MAIN.FCS","MAIN.FCC",
        "MAIN.FCA","MAIN.FCB","MAIN.FC1","MAIN.FC2"
        ,"MAIN.START","MAIN.RESET","MAIN.BRACCIOSUP"
        ,"MAIN.BRACCIOINF","MAIN.DX","MAIN.SX",
        "MAIN.SU","MAIN.GIU","MAIN.CARICATO1","MAIN.CARICATO2",
        "MAIN.M1","MAIN.M2","MAIN.P1","MAIN.P2","MAIN.G1","MAIN.G2",
        "MAIN.S1","MAIN.S2","MAIN.ALLARME","MAIN.T_ALLARME"};
        private int NUM_ELEM_BOOL = 11;
        private int NUM_ELEM_TIME = 1;
        
        public Form1()
        {
            posybraccio1iniziale = 94;
            posxbraccio1iniziale = 540;
            InitializeComponent();
            tempAttuale = tempIniziale;
            textTemperatura.Text = tempAttuale.ToString();
            AggiornamentoPresenza();

            Porta_timer = false;
            Tempo_porta = false;
            Chiusura_aggiornata = false;
            posYinizialeRobot = robot.Location.Y;
            gfx = this.CreateGraphics();

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
        private void codificaComandi()
        {
            if (textDxRobot.Text.Equals("True") && !textSxRobot.Text.Equals("True"))
            {

                comandoRobot = "dx";

            }
            else if (!textDxRobot.Text.Equals("True") && textSxRobot.Text.Equals("True"))
            {
                comandoRobot = "sx";
            }
            else if (textBassoRobot.Text.Equals("True") && !Text_AltoRobot.Text.Equals("True"))
            {
                comandoRobot = "giu";
            }
            else if (!textBassoRobot.Text.Equals("True") && Text_AltoRobot.Text.Equals("True"))
            {
                comandoRobot = "su";
            }

            else
            {
                comandoRobot = "";
            }

        }
        private void codificaComandiRobot()
        {
            if (textBraccio1.Text.Equals("True") && !textBraccio3.Text.Equals("True"))
            {
                comandoBraccio = "allunga";
                numerobraccio = 1;
            }

            else if (textBraccio3.Text.Equals("True") && !textBraccio1.Text.Equals("True"))
            {
                comandoBraccio = "allunga";
                numerobraccio = 3;
            }
            else
            {
                comandoBraccio = "";
                numerobraccio = -1;
            }
        }
        private void aggiornamentoVestiti()
        {
            using (SceltaVestiti sv = new SceltaVestiti(this.RicercaVestiti1.Text.ToString(), this.text2indumento.Text.ToString()))
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
                        this.text2indumento.Text = sv.vestito2;
                        this.RicercaVestiti1.Text = this.vestito1;
                    }
                }
            }

            aggiornamentoVestitiBooleani(vestito1);
            aggiornamentoVestitiBooleani(text2indumento.Text);

        }
        private void aggiornamentoVestitiBooleani(string vestito)
        {
            if (vestito!=null)
            {
                if (vestito.Equals("Maglietta bianca"))
                {
                    MagliettaBianca = true;
                }
                if (vestito.Equals("Maglietta nera"))
                {
                    MagliettaNera = true;
                }
                if (vestito.Equals("Jeans chiaro"))
                {
                    JeansChiaro = true;
                }
                if (vestito.Equals("Pantalone nero"))
                {
                    PantaloneNero = true;
                }
                if (vestito.Equals("Felpa verde"))
                {
                    FelpaVerde = true;
                }
                if (vestito.Equals("Giacca di pelle"))
                {
                    GiaccaPelle = true;
                }
                if (vestito.Equals("Scarpe nere"))
                {
                    ScarpeNere = true;
                }
                if (vestito.Equals("Scarpe bianche"))
                {
                    ScarpeBianche = true;
                }

            }
            

        }
        private void button_START_Click(object sender, EventArgs e)
        {
            textStart.Text = "True";
            textStart.BackColor = Color.Green;
            textFcsRobot.BackColor = Color.Green;
            textAlto.BackColor = Color.Red;
            textBasso.BackColor = Color.Red;
            textFc1.BackColor = Color.Red;
            textFc2.BackColor = Color.Red;
            textFcdRobot.BackColor = Color.Red;
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
            reset_effettuato = true;
            
            
           




        }
        private void masterTimer_Tick(object sender, EventArgs e)
        {//ciclo di funzionamento del programma

            pos = posAttuale + posiniziale;
            delta = masterTimer.Interval;
            if (Start && !text_ALLARME.Text.Equals("True"))
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
                    if (chiusura % 2 != 0)
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
                codificaComandi();
                codificaComandiRobot();
                presaVestitiB1();
                presaVestitiB2();
                GestioneSpostamento();
                GestioneBracci();

            }
            //ALLARME
            if (text_ALLARME.Text.Equals("True"))
            {
                Allarme_picture.Visible = true;
            }
            else
            {
                Allarme_picture.Visible = false;
            }
           
            if(reset_effettuato)
            {
                resettaPosizioni();
            }
        }
        private void PortaTimer_Tick(object sender, EventArgs e)
        {//timer che pone a true la variabile tempo_porta permettendo la ciusura della porta appena trascorso il tempo
            Tempo_porta = true;

        }
        private void resetTimer_Tick(object sender, EventArgs e)
        {
            text_ALLARME.Text = "False";
            textReset.Text = "False";
            textReset.BackColor = Color.Red;
            reset_effettuato = false;
        }
        private void AggiornamentoTemperatura()
        {
            //funzione che deve gestire la temperatura della stanza per mantenerla tra il range compreso tra 19 gradi e la temperatura desiderata dall'utente 
            using (SelezioneTemperatura st = new SelezioneTemperatura(tempIniziale, tempmax))
            {
                if (st.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.temp1 = st.tempnumero;
                    this.Tasto_sceltaTemp.Text = st.valore;
                    timerTemp.Enabled = st.TimerAbilitato;
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
        
        private void GestioneSpostamento()
        {
           
            deltaRobot = masterTimer.Interval;
            posyRobot = robot.Location.Y;
            switch (comandoRobot)
            {
                case "dx":
                    posAttualeRobot = posAttualeRobot + (int)(deltaRobot * spostRobot) / durataspostRobot;
                    braccio1.Location = new Point(robot.Location.X + 37, braccio1.Location.Y);
                    braccio3.Location = new Point(robot.Location.X + 37, braccio3.Location.Y);

                    break;
                case "sx":
                    posAttualeRobot = posAttualeRobot - (int)(deltaRobot * spostRobot) / durataspostRobot;
                    braccio1.Location = new Point(robot.Location.X + 25, braccio1.Location.Y);
                    braccio3.Location = new Point(robot.Location.X + 25, braccio3.Location.Y);

                    break;
                case "su":
                    timerSalita.Enabled = true;
                    if (salita_effettuata)
                    {
                        robot.Location = new Point(robot.Location.X, robot.Location.Y - 5);
                        braccio1.Location = new Point(braccio1.Location.X, robot.Location.Y - 10);
                        braccio3.Location = new Point(braccio3.Location.X, robot.Location.Y + 56);
                        salita_effettuata = false;
                    }

                    break;
                case "giu":
                    timerSalita.Enabled = true;
                    if (salita_effettuata)
                    {
                        robot.Location = new Point(robot.Location.X, robot.Location.Y + 5);
                        braccio3.Location = new Point(braccio3.Location.X, robot.Location.Y + 60);
                        braccio1.Location = new Point(braccio1.Location.X, robot.Location.Y - 2);
                        salita_effettuata = false;
                    }

                    break;
                case "" when posyRobot - posYinizialeRobot != 0 && !comandoBraccio.Equals("allunga"):

                    braccio1.Location = new Point(robot.Location.X + 30, robot.Location.Y - 5);
                    braccio3.Location = new Point(robot.Location.X + 30, robot.Location.Y + 60);

                    break;
                default:
                    posAttualeRobot = 0 + posAttualeRobot;
                   
                    break;
            }
            posxbraccio1 = braccio1.Location.X;
            posybraccio1 = braccio1.Location.Y;
            posRobot = posAttualeRobot + posinizialeRobot;

            if (posRobot > 700)
            {
                
                fcs_Robot.BackColor = Color.Red;
                textFcsRobot.Text = "False";
                textFcsRobot.BackColor = Color.Red;
               
                fcd_Robot.BackColor = Color.Green;
                textFcdRobot.Text = "True";
                textFcdRobot.BackColor = Color.Green;
               
                fc1.BackColor = Color.Red;
                textFc1.Text = "False";
                textFc1.BackColor = Color.Red;
               
                fc2.BackColor = Color.Red;
                textFc2.Text = "False";
                textFc2.BackColor = Color.Red;
                
                alto_Robot.BackColor = Color.Red;
                textAlto.Text = "False";
                textAlto.BackColor = Color.Red;
                
                basso_Robot.BackColor = Color.Red;
                textBasso.Text = "False";
                textBasso.BackColor = Color.Red;


            }

            if (posyRobot < 60)
            {
                alto_Robot.BackColor = Color.Green;
                textAlto.Text = "True";
                textAlto.BackColor = Color.Green;
                
                basso_Robot.BackColor = Color.Red;
                textBasso.Text = "False";
                textBasso.BackColor = Color.Red;
               
                fcd_Robot.BackColor = Color.Red;
                textFcdRobot.Text = "False";
                textFcdRobot.BackColor = Color.Red;
            }
            if (posyRobot > 160)
            {
                alto_Robot.BackColor = Color.Red;
                textAlto.Text = "False";
                textAlto.BackColor = Color.Red;
               
                basso_Robot.BackColor = Color.Green;
                textBasso.Text = "True";
                textBasso.BackColor = Color.Green;
                
                fcd_Robot.BackColor = Color.Red;
                textFcdRobot.Text = "False";
                textFcdRobot.BackColor = Color.Red;
            }
            if (posRobot > 825/* && comandoRobot.Equals("dx")*/)
            {
                alto_Robot.BackColor = Color.Green;
                textAlto.Text = "True";
                textAlto.BackColor = Color.Green;

                basso_Robot.BackColor = Color.Red;
                textBasso.Text = "False";
                textBasso.BackColor = Color.Red;

                fcd_Robot.BackColor = Color.Red;
                textFcdRobot.Text = "False";
                textFcdRobot.BackColor = Color.Red;
               
                fc1.BackColor = Color.Green;
                textFc1.Text = "True";
                textFc1.BackColor = Color.Green;
            }
            if (posRobot > 930 /*&& comandoRobot.Equals("dx")*/)
            {
                alto_Robot.BackColor = Color.Green;
                textAlto.Text = "True";
                textAlto.BackColor = Color.Green;
               
                basso_Robot.BackColor = Color.Red;
                textBasso.Text = "False";
                textBasso.BackColor = Color.Red;
               
                fcd_Robot.BackColor = Color.Red;
                textFcdRobot.Text = "False";
                textFcdRobot.BackColor = Color.Red;
                
                fc1.BackColor = Color.Red;
                textFc1.Text = "False";
                textFc1.BackColor = Color.Red;
                
                fc2.BackColor = Color.Green;
                textFc2.Text = "True";
                textFc2.BackColor = Color.Green;
            }
            if (posRobot==posinizialeRobot)
            {
                fcs_Robot.BackColor = Color.Green;
                textFcsRobot.Text = "True";
                textFcsRobot.BackColor = Color.Green;
               
                fcd_Robot.BackColor = Color.Red;
                textFcdRobot.Text = "False";
                textFcdRobot.BackColor = Color.Red;
                
                fc1.BackColor = Color.Red;
                textFc1.Text = "False";
                textFc1.BackColor = Color.Red;
                
                fc2.BackColor = Color.Red;
                textFc2.Text = "False";
                textFc2.BackColor = Color.Red;
               
                alto_Robot.BackColor = Color.Red;
                textAlto.Text = "False";
                textAlto.BackColor = Color.Red;
               
                basso_Robot.BackColor = Color.Red;
                textBasso.Text = "False";
                textBasso.BackColor = Color.Red;


            }


            robot.Left = posRobot;
            if(textFcsRobot.Text.Equals("True") && (Braccio1Carico || Braccio3Carico) && robot.Location.Y==posYinizialeRobot && robot.Location.X==posinizialeRobot)
            //if(textFcsRobot.Text.Equals("True")&&(Braccio1Carico||Braccio3Carico))
            {
         
                if (Braccio1Carico)
                { 
                    scarico1++;
                    Braccio1Carico = false;
                    MagliettaBianca = false;
                    MagliettaNera = false;
                    GiaccaPelle = false;
                    FelpaVerde = false;
                     pic1.Location = new Point(cesta_panni.Location.X+10*scarico1, cesta_panni.Location.Y);                  
                    pic1.BringToFront();
                    
                }
                else if (Braccio3Carico)
                {
                    scarico2++;
                    Braccio3Carico = false;
                    JeansChiaro = false;
                    PantaloneNero = false;
                    ScarpeNere = false;
                    ScarpeBianche = false;
                    pic2.Location= new Point(cesta_panni.Location.X+10*scarico2, cesta_panni.Location.Y+40);
                    pic2.BringToFront();
                }
            }
           
        }
        private void cesta_panni_DragOver(object sender, DragEventArgs e)
        {
           
        }
        private void cesta_panni_Paint(object sender, PaintEventArgs e)
        {
            

        }
        private void GestioneBracci()
        {
            switch (numerobraccio)
            {
                case 1 when comandoBraccio.Equals("allunga") && comandoRobot.Equals(""):
                    braccio1.Location = new Point(braccio1.Location.X, robot.Location.Y - 30);

                    braccio1.Height = 40;
                    break;
                case -1 when posRobot == posinizialeRobot && comandoRobot.Equals("") && posyRobot == posYinizialeRobot:
                    braccio1.Location = new Point(posxbraccio1iniziale, posybraccio1iniziale);
                    braccio1.Height = 15;
                    braccio3.Height = 14;
                    break;
                case -1 when comandoRobot.Equals("") && posyRobot != posYinizialeRobot :
                    braccio1.Location = new Point(braccio1.Location.X, braccio1.Location.Y );
                    braccio3.Location = new Point(braccio3.Location.X, braccio3.Location.Y);
                    braccio1.Height = 15;
                    braccio3.Height = 14;
                    break;
                case 3 when comandoBraccio.Equals("allunga") && comandoRobot.Equals(""):
                    braccio3.Height = 40;
                    break;
                
                default:

                    break;
            }
            
        }
        
        private void resettaPosizioni()
        {
            posAttualeRobot = 0;
            GestioneSpostamento();
            GestioneBracci();
            
            resetTimer.Enabled = true;

        }
        private void presaVestitiB1()
        {
            if (braccio1.Bounds.IntersectsWith(maglietta_nera.Bounds) && MagliettaNera)
            {
                Braccio1Carico = true;
                pic1 = maglietta_nera;
                
            }
            else if (braccio1.Bounds.IntersectsWith(maglietta_bianca.Bounds) && MagliettaBianca)
            {
                Braccio1Carico = true;               
                pic1 = maglietta_bianca;
            }
            else if (braccio1.Bounds.IntersectsWith(giacchetto_di_pelle.Bounds) && GiaccaPelle)
            {
                Braccio1Carico = true;
                pic1 = giacchetto_di_pelle;
            }
             if (braccio1.Bounds.IntersectsWith(felpa_verde.Bounds) && FelpaVerde)
            {
                Braccio1Carico = true;
                pic1 = felpa_verde;
            }
            spostaVestitob1(pic1);
        }
        private void presaVestitiB2()
        {
            if (braccio3.Bounds.IntersectsWith(jeans_chiaro.Bounds) && JeansChiaro)
            {
                Braccio3Carico = true;

                pic2 = jeans_chiaro;
            }
            else if (braccio3.Bounds.IntersectsWith(pantalone_nero.Bounds) && PantaloneNero)
            {
                Braccio3Carico = true;
                pic2 = pantalone_nero;
            }
            else if (braccio3.Bounds.IntersectsWith(scarpe_bianche.Bounds) && ScarpeBianche)
            {
                Braccio3Carico = true;
                pic2 = scarpe_bianche;

            }
            if (braccio3.Bounds.IntersectsWith(scarpe_nere.Bounds) && ScarpeNere)
            {
                Braccio3Carico = true;
                pic2 = scarpe_nere;
            }
            spostaVestitob2(pic2);
        }
      
        private void spostaVestitob1(PictureBox vestito)
        {
            if(vestito != null) {
                if (Braccio1Carico)
                {
                    //vestito.Location = new Point(robot.Location.X + 20, robot.Location.Y - 20);
                    vestito.Location = new Point(braccio1.Location.X-5 , braccio1.Location.Y - 5);
                }
                else
                {
                    vestito.Location = new Point(vestito.Location.X, vestito.Location.Y);
                }
            }
            

        }
        private void spostaVestitob2(PictureBox vestito1)
        {
            if (vestito1 != null)
            {
                if (Braccio3Carico)
                {
                    if (textAlto.Text.Equals("True")) {

                     vestito1.Location = new Point(braccio3.Location.X - 5, braccio3.Height + 100);//+100
                    //vestito1.Location = new Point(robot.Location.X + 20, robot.Location.Y + 60);
                    }
                    
                    else if (textBasso.Text.Equals("True"))
                    {
                        vestito1.Location = new Point(braccio3.Location.X - 5, braccio3.Height + 250);
                    }
                }
                else
                {
                   
                    vestito1.Location = new Point(vestito1.Location.X, vestito1.Location.Y);
                }
            }
           
            }

        private void button1_Click(object sender, EventArgs e)
        {
            aggiornamentoVestiti();
        }
        private void Tasto_sceltaTemp_Click(object sender, EventArgs e)
        {
            AggiornamentoTemperatura();
        }
        

        private void timerSalita_Tick_1(object sender, EventArgs e)
        {
            salita_effettuata = true;
        }

        private void jeans_chiaro_Click(object sender, EventArgs e)
        {

        }

        private void jeans_chiaro_LocationChanged(object sender, EventArgs e)
        {
            
        }

        private void cONNECT_Click(object sender, EventArgs e)
        {
            //tcClient = new TcAdsClient();
            //tcClient.Connect("127.0.0.1.1.1", 851);
            //dataStream = new AdsStream(NUM_ELEM_BOOL + NUM_ELEM_TIME * 4);
            //binRead = new AdsBinaryReader(dataStream);
            //hConnect = new int[NUM_ELEM_BOOL + NUM_ELEM_TIME];

            //hConnect[0] = tcClient.AddDeviceNotification(dataPLC[0], dataStream, 0, 1, AdsTransMode.OnChange, 100, 0, textFcsRobot);
            //hConnect[1] = tcClient.AddDeviceNotification(dataPLC[1], dataStream, 1, 1, AdsTransMode.OnChange, 100, 0, textFcdRobot);
            //hConnect[2] = tcClient.AddDeviceNotification(dataPLC[2], dataStream, 2, 1, AdsTransMode.OnChange, 100, 0, textAlto);
            //hConnect[3] = tcClient.AddDeviceNotification(dataPLC[3], dataStream, 3, 1, AdsTransMode.OnChange, 100, 0, textBasso);
            //hConnect[4] = tcClient.AddDeviceNotification(dataPLC[4], dataStream, 4, 1, AdsTransMode.OnChange, 100, 0, textFc1);
            //hConnect[5] = tcClient.AddDeviceNotification(dataPLC[5], dataStream, 5, 1, AdsTransMode.OnChange, 100, 0, textFc2);
            //hConnect[6] = tcClient.AddDeviceNotification(dataPLC[6], dataStream, 6, 1, AdsTransMode.OnChange, 100, 0, textStart);
            //hConnect[7] = tcClient.AddDeviceNotification(dataPLC[7], dataStream, 7, 1, AdsTransMode.OnChange, 100, 0, textReset);
            //hConnect[8] = tcClient.AddDeviceNotification(dataPLC[8], dataStream, 8, 1, AdsTransMode.OnChange, 100, 0, textBraccio1);
            //hConnect[9] = tcClient.AddDeviceNotification(dataPLC[9], dataStream, 9, 1, AdsTransMode.OnChange, 100, 0, textBraccio3);
            //hConnect[10] = tcClient.AddDeviceNotification(dataPLC[10], dataStream, 10, 1, AdsTransMode.OnChange, 100, 0, textDxRobot);
            //hConnect[11] = tcClient.AddDeviceNotification(dataPLC[11], dataStream, 11, 1, AdsTransMode.OnChange, 100, 0, textSxRobot);
            //hConnect[12] = tcClient.AddDeviceNotification(dataPLC[12], dataStream, 12, 1, AdsTransMode.OnChange, 100, 0, Text_AltoRobot);
            //hConnect[13] = tcClient.AddDeviceNotification(dataPLC[13], dataStream, 13, 1, AdsTransMode.OnChange, 100, 0, textBassoRobot);
            //hConnect[14] = tcClient.AddDeviceNotification(dataPLC[14], dataStream, 14, 1, AdsTransMode.OnChange, 100, 0, Braccio1Carico);
            //hConnect[15] = tcClient.AddDeviceNotification(dataPLC[15], dataStream, 15, 1, AdsTransMode.OnChange, 100, 0, Braccio3Carico);
            //hConnect[16] = tcClient.AddDeviceNotification(dataPLC[16], dataStream, 16, 1, AdsTransMode.OnChange, 100, 0, MagliettaNera);
            //hConnect[17] = tcClient.AddDeviceNotification(dataPLC[17], dataStream, 17, 1, AdsTransMode.OnChange, 100, 0, MagliettaBianca);
            //hConnect[18] = tcClient.AddDeviceNotification(dataPLC[18], dataStream, 18, 1, AdsTransMode.OnChange, 100, 0, jeans_chiaro);
            //hConnect[19] = tcClient.AddDeviceNotification(dataPLC[19], dataStream, 19, 1, AdsTransMode.OnChange, 100, 0, PantaloneNero);
            //hConnect[20] = tcClient.AddDeviceNotification(dataPLC[20], dataStream, 20, 1, AdsTransMode.OnChange, 100, 0, GiaccaPelle);
            //hConnect[21] = tcClient.AddDeviceNotification(dataPLC[21], dataStream, 21, 1, AdsTransMode.OnChange, 100, 0, FelpaVerde);
            //hConnect[22] = tcClient.AddDeviceNotification(dataPLC[22], dataStream, 22, 1, AdsTransMode.OnChange, 100, 0, ScarpeBianche);
            //hConnect[23] = tcClient.AddDeviceNotification(dataPLC[23], dataStream, 23, 1, AdsTransMode.OnChange, 100, 0, ScarpeNere);
            //hConnect[24] = tcClient.AddDeviceNotification(dataPLC[24], dataStream, 24, 1, AdsTransMode.OnChange, 100, 0, text_ALLARME);
            //hConnect[25] = tcClient.AddDeviceNotification(dataPLC[25], dataStream, 25, 4, AdsTransMode.OnChange, 100, 0, Text_Timer);
            //tcClient.AdsNotification += new AdsNotificationEventHandler(OnNotification);  
            //textconnect.Text = " OK ";
            //hvar_name = new int[NUM_ELEM_BOOL + NUM_ELEM_TIME];
            //for (int i = 0; i < NUM_ELEM_BOOL + NUM_ELEM_TIME; i++)
            //{
            //    hvar_name[i] = tcClient.CreateVariableHandle(dataPLC[i]);
            //}
        }

        private void robot_Click(object sender, EventArgs e)
        {

        }
        //private void OnNotification(object sender, AdsNotificationEventArgs e)
        //{
            //string strValue = "";
            //if (e.NotificationHandle == hConnect[0])
            //    strValue = binRead.ReadBoolean().ToString();
            //if (e.NotificationHandle == hConnect[1])
            //    strValue = binRead.ReadBoolean().ToString();
            //if (e.NotificationHandle == hConnect[2])
            //    strValue = binRead.ReadBoolean().ToString();
            //if (e.NotificationHandle == hConnect[3])
            //    strValue = binRead.ReadBoolean().ToString();
            //if (e.NotificationHandle == hConnect[4])
            //    strValue = binRead.ReadBoolean().ToString();
            //if (e.NotificationHandle == hConnect[5])
            //    strValue = binRead.ReadBoolean().ToString();
            //if (e.NotificationHandle == hConnect[6])
            //    strValue = binRead.ReadBoolean().ToString();
            //if (e.NotificationHandle == hConnect[7])
            //    strValue = binRead.ReadBoolean().ToString();
            //if (e.NotificationHandle == hConnect[8])
            //    strValue = binRead.ReadBoolean().ToString();
            //if (e.NotificationHandle == hConnect[9])
            //    strValue = binRead.ReadBoolean().ToString();
            //if (e.NotificationHandle == hConnect[10])
            //    strValue = binRead.ReadBoolean().ToString();
            //if (e.NotificationHandle == hConnect[11])
            //    strValue = binRead.ReadBoolean().ToString();
            //if (e.NotificationHandle == hConnect[12])
            //    strValue = binRead.ReadBoolean().ToString();
            //if (e.NotificationHandle == hConnect[13])
            //    strValue = binRead.ReadBoolean().ToString();
            //if (e.NotificationHandle == hConnect[14])
            //    strValue = binRead.ReadBoolean().ToString();
            //if (e.NotificationHandle == hConnect[15])
            //    strValue = binRead.ReadBoolean().ToString();
            //if (e.NotificationHandle == hConnect[16])
            //    strValue = binRead.ReadBoolean().ToString();
            //if (e.NotificationHandle == hConnect[17])
            //    strValue = binRead.ReadBoolean().ToString();
            //if (e.NotificationHandle == hConnect[18])
            //    strValue = binRead.ReadBoolean().ToString();
            //if (e.NotificationHandle == hConnect[19])
            //    strValue = binRead.ReadBoolean().ToString();
            //if (e.NotificationHandle == hConnect[20])
            //    strValue = binRead.ReadBoolean().ToString();
            //if (e.NotificationHandle == hConnect[21])
            //    strValue = binRead.ReadBoolean().ToString();
            //if (e.NotificationHandle == hConnect[22])
            //    strValue = binRead.ReadBoolean().ToString();
            //if (e.NotificationHandle == hConnect[23])
            //    strValue = binRead.ReadBoolean().ToString();
            //if (e.NotificationHandle == hConnect[24])
            //    strValue = binRead.ReadBoolean().ToString();
            //if (e.NotificationHandle == hConnect[25])
            //    strValue = binRead.ReadInt32().ToString();
            //((TextBox)e.UserData).Invoke(new Action(() =>((TextBox)e.UserData).Text = String.Format(strValue)));
        //}

        private void textFcsRobot_TextChanged(object sender, EventArgs e)
        {
            //if (hvar_name != null)
            //{
            //    if (textFcsRobot.Text.Equals("True"))
            //        tcClient.WriteAny(hvar_name[0], true);
            //    if(textFcsRobot.Text.Equals("False"))
            //        tcClient.WriteAny(hvar_name[0], false);
            //}
        }

        private void buttonPausa_Click(object sender, EventArgs e)
        {
            //masterTimer.Enabled = !masterTimer.Enabled;
        }
        
    }
}