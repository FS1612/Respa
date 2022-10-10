
namespace ProgettoRespa.net
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bOTTONI_PANEL = new System.Windows.Forms.Panel();
            this.button_presenza = new System.Windows.Forms.Button();
            this.button_RESET = new System.Windows.Forms.Button();
            this.button_START = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TextSensProssimita_porta = new System.Windows.Forms.TextBox();
            this.sens_prossimita = new System.Windows.Forms.Label();
            this.textPersonaggio = new System.Windows.Forms.TextBox();
            this.personaggio = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Label();
            this.textReset = new System.Windows.Forms.TextBox();
            this.textStart = new System.Windows.Forms.TextBox();
            this.textTemperatura = new System.Windows.Forms.TextBox();
            this.textFcdFinestra = new System.Windows.Forms.TextBox();
            this.textFcsFinestra = new System.Windows.Forms.TextBox();
            this.textFcdPorta = new System.Windows.Forms.TextBox();
            this.textFcsPorta = new System.Windows.Forms.TextBox();
            this.temperatura = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Label();
            this.fcdFinestra = new System.Windows.Forms.Label();
            this.fcsFinestra = new System.Windows.Forms.Label();
            this.fcdPorta = new System.Windows.Forms.Label();
            this.fcsPorta = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.text_ALLARME = new System.Windows.Forms.TextBox();
            this.text_sxfinestra = new System.Windows.Forms.TextBox();
            this.text_dxfinestra = new System.Windows.Forms.TextBox();
            this.text_sxporta = new System.Windows.Forms.TextBox();
            this.text_dxporta = new System.Windows.Forms.TextBox();
            this.ALLARME = new System.Windows.Forms.Label();
            this.SX_FINESTRA = new System.Windows.Forms.Label();
            this.DX_FINESTRA = new System.Windows.Forms.Label();
            this.SX_PORTA = new System.Windows.Forms.Label();
            this.DX_PORTA = new System.Windows.Forms.Label();
            this.masterTimer = new System.Windows.Forms.Timer(this.components);
            this.startTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.Sensore_Prossimità = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.fcs_sensore = new System.Windows.Forms.PictureBox();
            this.porta = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PortaTimer = new System.Windows.Forms.Timer(this.components);
            this.bOTTONI_PANEL.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sensore_Prossimità)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fcs_sensore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bOTTONI_PANEL
            // 
            this.bOTTONI_PANEL.Controls.Add(this.button_presenza);
            this.bOTTONI_PANEL.Controls.Add(this.button_RESET);
            this.bOTTONI_PANEL.Controls.Add(this.button_START);
            this.bOTTONI_PANEL.Location = new System.Drawing.Point(12, 3);
            this.bOTTONI_PANEL.Name = "bOTTONI_PANEL";
            this.bOTTONI_PANEL.Size = new System.Drawing.Size(1164, 32);
            this.bOTTONI_PANEL.TabIndex = 5;
            // 
            // button_presenza
            // 
            this.button_presenza.Location = new System.Drawing.Point(848, 5);
            this.button_presenza.Name = "button_presenza";
            this.button_presenza.Size = new System.Drawing.Size(160, 19);
            this.button_presenza.TabIndex = 2;
            this.button_presenza.Text = "PRESENTE";
            this.button_presenza.UseVisualStyleBackColor = true;
            this.button_presenza.Click += new System.EventHandler(this.button_presenza_Click);
            // 
            // button_RESET
            // 
            this.button_RESET.Location = new System.Drawing.Point(369, 3);
            this.button_RESET.Name = "button_RESET";
            this.button_RESET.Size = new System.Drawing.Size(165, 22);
            this.button_RESET.TabIndex = 1;
            this.button_RESET.Text = "RESET";
            this.button_RESET.UseVisualStyleBackColor = true;
            this.button_RESET.Click += new System.EventHandler(this.button_RESET_Click);
            // 
            // button_START
            // 
            this.button_START.Location = new System.Drawing.Point(3, 3);
            this.button_START.Name = "button_START";
            this.button_START.Size = new System.Drawing.Size(121, 22);
            this.button_START.TabIndex = 0;
            this.button_START.Text = "START";
            this.button_START.UseVisualStyleBackColor = true;
            this.button_START.Click += new System.EventHandler(this.button_START_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TextSensProssimita_porta);
            this.groupBox2.Controls.Add(this.sens_prossimita);
            this.groupBox2.Controls.Add(this.textPersonaggio);
            this.groupBox2.Controls.Add(this.personaggio);
            this.groupBox2.Controls.Add(this.reset);
            this.groupBox2.Controls.Add(this.textReset);
            this.groupBox2.Controls.Add(this.textStart);
            this.groupBox2.Controls.Add(this.textTemperatura);
            this.groupBox2.Controls.Add(this.textFcdFinestra);
            this.groupBox2.Controls.Add(this.textFcsFinestra);
            this.groupBox2.Controls.Add(this.textFcdPorta);
            this.groupBox2.Controls.Add(this.textFcsPorta);
            this.groupBox2.Controls.Add(this.temperatura);
            this.groupBox2.Controls.Add(this.start);
            this.groupBox2.Controls.Add(this.fcdFinestra);
            this.groupBox2.Controls.Add(this.fcsFinestra);
            this.groupBox2.Controls.Add(this.fcdPorta);
            this.groupBox2.Controls.Add(this.fcsPorta);
            this.groupBox2.Location = new System.Drawing.Point(9, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(533, 282);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SENSORI";
            // 
            // TextSensProssimita_porta
            // 
            this.TextSensProssimita_porta.Location = new System.Drawing.Point(340, 29);
            this.TextSensProssimita_porta.Name = "TextSensProssimita_porta";
            this.TextSensProssimita_porta.Size = new System.Drawing.Size(100, 20);
            this.TextSensProssimita_porta.TabIndex = 31;
            this.TextSensProssimita_porta.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // sens_prossimita
            // 
            this.sens_prossimita.AutoSize = true;
            this.sens_prossimita.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.sens_prossimita.Location = new System.Drawing.Point(237, 32);
            this.sens_prossimita.Name = "sens_prossimita";
            this.sens_prossimita.Size = new System.Drawing.Size(74, 13);
            this.sens_prossimita.TabIndex = 30;
            this.sens_prossimita.Text = "Sensore Porta";
            // 
            // textPersonaggio
            // 
            this.textPersonaggio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPersonaggio.Location = new System.Drawing.Point(113, 250);
            this.textPersonaggio.Name = "textPersonaggio";
            this.textPersonaggio.ReadOnly = true;
            this.textPersonaggio.Size = new System.Drawing.Size(100, 20);
            this.textPersonaggio.TabIndex = 29;
            // 
            // personaggio
            // 
            this.personaggio.AutoSize = true;
            this.personaggio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.personaggio.Location = new System.Drawing.Point(11, 250);
            this.personaggio.Name = "personaggio";
            this.personaggio.Size = new System.Drawing.Size(89, 26);
            this.personaggio.TabIndex = 28;
            this.personaggio.Text = "PERSONAGGIO \r\nPRESENTE";
            // 
            // reset
            // 
            this.reset.AutoSize = true;
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.reset.Location = new System.Drawing.Point(13, 218);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(43, 13);
            this.reset.TabIndex = 27;
            this.reset.Text = "RESET";
            // 
            // textReset
            // 
            this.textReset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textReset.Location = new System.Drawing.Point(113, 217);
            this.textReset.Name = "textReset";
            this.textReset.ReadOnly = true;
            this.textReset.Size = new System.Drawing.Size(100, 20);
            this.textReset.TabIndex = 26;
            // 
            // textStart
            // 
            this.textStart.Location = new System.Drawing.Point(113, 183);
            this.textStart.Name = "textStart";
            this.textStart.Size = new System.Drawing.Size(100, 20);
            this.textStart.TabIndex = 25;
            // 
            // textTemperatura
            // 
            this.textTemperatura.Location = new System.Drawing.Point(113, 149);
            this.textTemperatura.Name = "textTemperatura";
            this.textTemperatura.Size = new System.Drawing.Size(100, 20);
            this.textTemperatura.TabIndex = 24;
            // 
            // textFcdFinestra
            // 
            this.textFcdFinestra.Location = new System.Drawing.Point(113, 121);
            this.textFcdFinestra.Name = "textFcdFinestra";
            this.textFcdFinestra.Size = new System.Drawing.Size(100, 20);
            this.textFcdFinestra.TabIndex = 23;
            // 
            // textFcsFinestra
            // 
            this.textFcsFinestra.Location = new System.Drawing.Point(113, 94);
            this.textFcsFinestra.Name = "textFcsFinestra";
            this.textFcsFinestra.Size = new System.Drawing.Size(100, 20);
            this.textFcsFinestra.TabIndex = 22;
            // 
            // textFcdPorta
            // 
            this.textFcdPorta.Location = new System.Drawing.Point(113, 62);
            this.textFcdPorta.Name = "textFcdPorta";
            this.textFcdPorta.Size = new System.Drawing.Size(100, 20);
            this.textFcdPorta.TabIndex = 21;
            // 
            // textFcsPorta
            // 
            this.textFcsPorta.Location = new System.Drawing.Point(113, 32);
            this.textFcsPorta.Name = "textFcsPorta";
            this.textFcsPorta.Size = new System.Drawing.Size(100, 20);
            this.textFcsPorta.TabIndex = 20;
            // 
            // temperatura
            // 
            this.temperatura.AutoSize = true;
            this.temperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.temperatura.Location = new System.Drawing.Point(11, 153);
            this.temperatura.Name = "temperatura";
            this.temperatura.Size = new System.Drawing.Size(89, 13);
            this.temperatura.TabIndex = 19;
            this.temperatura.Text = "TEMPERATURA\r\n";
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.start.Location = new System.Drawing.Point(16, 185);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(43, 13);
            this.start.TabIndex = 18;
            this.start.Text = "START";
            // 
            // fcdFinestra
            // 
            this.fcdFinestra.AutoSize = true;
            this.fcdFinestra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fcdFinestra.Location = new System.Drawing.Point(13, 123);
            this.fcdFinestra.Name = "fcdFinestra";
            this.fcdFinestra.Size = new System.Drawing.Size(84, 13);
            this.fcdFinestra.TabIndex = 17;
            this.fcdFinestra.Text = "FCD FINESTRA";
            // 
            // fcsFinestra
            // 
            this.fcsFinestra.AutoSize = true;
            this.fcsFinestra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fcsFinestra.Location = new System.Drawing.Point(15, 94);
            this.fcsFinestra.Name = "fcsFinestra";
            this.fcsFinestra.Size = new System.Drawing.Size(83, 13);
            this.fcsFinestra.TabIndex = 16;
            this.fcsFinestra.Text = "FCS FINESTRA";
            // 
            // fcdPorta
            // 
            this.fcdPorta.AutoSize = true;
            this.fcdPorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fcdPorta.Location = new System.Drawing.Point(16, 62);
            this.fcdPorta.Name = "fcdPorta";
            this.fcdPorta.Size = new System.Drawing.Size(68, 13);
            this.fcdPorta.TabIndex = 15;
            this.fcdPorta.Text = "FCD PORTA";
            // 
            // fcsPorta
            // 
            this.fcsPorta.AutoSize = true;
            this.fcsPorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fcsPorta.Location = new System.Drawing.Point(15, 32);
            this.fcsPorta.Name = "fcsPorta";
            this.fcsPorta.Size = new System.Drawing.Size(67, 13);
            this.fcsPorta.TabIndex = 14;
            this.fcsPorta.Text = "FCS PORTA";
            this.fcsPorta.Click += new System.EventHandler(this.label14_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.text_ALLARME);
            this.groupBox1.Controls.Add(this.text_sxfinestra);
            this.groupBox1.Controls.Add(this.text_dxfinestra);
            this.groupBox1.Controls.Add(this.text_sxporta);
            this.groupBox1.Controls.Add(this.text_dxporta);
            this.groupBox1.Controls.Add(this.ALLARME);
            this.groupBox1.Controls.Add(this.SX_FINESTRA);
            this.groupBox1.Controls.Add(this.DX_FINESTRA);
            this.groupBox1.Controls.Add(this.SX_PORTA);
            this.groupBox1.Controls.Add(this.DX_PORTA);
            this.groupBox1.Location = new System.Drawing.Point(723, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 226);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ATTUATORI";
            // 
            // text_ALLARME
            // 
            this.text_ALLARME.Location = new System.Drawing.Point(135, 194);
            this.text_ALLARME.Name = "text_ALLARME";
            this.text_ALLARME.Size = new System.Drawing.Size(100, 20);
            this.text_ALLARME.TabIndex = 24;
            // 
            // text_sxfinestra
            // 
            this.text_sxfinestra.Location = new System.Drawing.Point(135, 146);
            this.text_sxfinestra.Name = "text_sxfinestra";
            this.text_sxfinestra.Size = new System.Drawing.Size(100, 20);
            this.text_sxfinestra.TabIndex = 23;
            // 
            // text_dxfinestra
            // 
            this.text_dxfinestra.Location = new System.Drawing.Point(135, 107);
            this.text_dxfinestra.Name = "text_dxfinestra";
            this.text_dxfinestra.Size = new System.Drawing.Size(100, 20);
            this.text_dxfinestra.TabIndex = 22;
            // 
            // text_sxporta
            // 
            this.text_sxporta.Location = new System.Drawing.Point(135, 60);
            this.text_sxporta.Name = "text_sxporta";
            this.text_sxporta.Size = new System.Drawing.Size(100, 20);
            this.text_sxporta.TabIndex = 21;
            // 
            // text_dxporta
            // 
            this.text_dxporta.Location = new System.Drawing.Point(135, 18);
            this.text_dxporta.Name = "text_dxporta";
            this.text_dxporta.Size = new System.Drawing.Size(100, 20);
            this.text_dxporta.TabIndex = 20;
            // 
            // ALLARME
            // 
            this.ALLARME.AutoSize = true;
            this.ALLARME.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ALLARME.Location = new System.Drawing.Point(12, 198);
            this.ALLARME.Name = "ALLARME";
            this.ALLARME.Size = new System.Drawing.Size(57, 13);
            this.ALLARME.TabIndex = 19;
            this.ALLARME.Text = "ALLARME";
            // 
            // SX_FINESTRA
            // 
            this.SX_FINESTRA.AutoSize = true;
            this.SX_FINESTRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.SX_FINESTRA.Location = new System.Drawing.Point(12, 150);
            this.SX_FINESTRA.Name = "SX_FINESTRA";
            this.SX_FINESTRA.Size = new System.Drawing.Size(77, 13);
            this.SX_FINESTRA.TabIndex = 17;
            this.SX_FINESTRA.Text = "SX FINESTRA";
            // 
            // DX_FINESTRA
            // 
            this.DX_FINESTRA.AutoSize = true;
            this.DX_FINESTRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.DX_FINESTRA.Location = new System.Drawing.Point(12, 111);
            this.DX_FINESTRA.Name = "DX_FINESTRA";
            this.DX_FINESTRA.Size = new System.Drawing.Size(78, 13);
            this.DX_FINESTRA.TabIndex = 16;
            this.DX_FINESTRA.Text = "DX FINESTRA";
            // 
            // SX_PORTA
            // 
            this.SX_PORTA.AutoSize = true;
            this.SX_PORTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.SX_PORTA.Location = new System.Drawing.Point(12, 66);
            this.SX_PORTA.Name = "SX_PORTA";
            this.SX_PORTA.Size = new System.Drawing.Size(61, 13);
            this.SX_PORTA.TabIndex = 15;
            this.SX_PORTA.Text = "SX PORTA";
            // 
            // DX_PORTA
            // 
            this.DX_PORTA.AutoSize = true;
            this.DX_PORTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.DX_PORTA.Location = new System.Drawing.Point(12, 22);
            this.DX_PORTA.Name = "DX_PORTA";
            this.DX_PORTA.Size = new System.Drawing.Size(62, 13);
            this.DX_PORTA.TabIndex = 14;
            this.DX_PORTA.Text = "DX PORTA";
            // 
            // masterTimer
            // 
            this.masterTimer.Tick += new System.EventHandler(this.masterTimer_Tick);
            // 
            // startTimer
            // 
            this.startTimer.Interval = 500;
            this.startTimer.Tick += new System.EventHandler(this.startTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox21);
            this.panel1.Controls.Add(this.Sensore_Prossimità);
            this.panel1.Controls.Add(this.pictureBox17);
            this.panel1.Controls.Add(this.fcs_sensore);
            this.panel1.Controls.Add(this.porta);
            this.panel1.Controls.Add(this.pictureBox11);
            this.panel1.Controls.Add(this.pictureBox9);
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 327);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1275, 348);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox21
            // 
            this.pictureBox21.BackColor = System.Drawing.Color.DeepPink;
            this.pictureBox21.Location = new System.Drawing.Point(85, 94);
            this.pictureBox21.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(22, 78);
            this.pictureBox21.TabIndex = 20;
            this.pictureBox21.TabStop = false;
            // 
            // Sensore_Prossimità
            // 
            this.Sensore_Prossimità.BackColor = System.Drawing.Color.DarkViolet;
            this.Sensore_Prossimità.Location = new System.Drawing.Point(239, 278);
            this.Sensore_Prossimità.Margin = new System.Windows.Forms.Padding(2);
            this.Sensore_Prossimità.Name = "Sensore_Prossimità";
            this.Sensore_Prossimità.Size = new System.Drawing.Size(15, 14);
            this.Sensore_Prossimità.TabIndex = 19;
            this.Sensore_Prossimità.TabStop = false;
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackColor = System.Drawing.Color.Red;
            this.pictureBox17.Location = new System.Drawing.Point(606, 237);
            this.pictureBox17.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(15, 14);
            this.pictureBox17.TabIndex = 16;
            this.pictureBox17.TabStop = false;
            // 
            // fcs_sensore
            // 
            this.fcs_sensore.BackColor = System.Drawing.Color.Lime;
            this.fcs_sensore.Location = new System.Drawing.Point(239, 237);
            this.fcs_sensore.Margin = new System.Windows.Forms.Padding(2);
            this.fcs_sensore.Name = "fcs_sensore";
            this.fcs_sensore.Size = new System.Drawing.Size(15, 14);
            this.fcs_sensore.TabIndex = 15;
            this.fcs_sensore.TabStop = false;
            // 
            // porta
            // 
            this.porta.BackColor = System.Drawing.Color.Maroon;
            this.porta.Location = new System.Drawing.Point(250, 255);
            this.porta.Margin = new System.Windows.Forms.Padding(2);
            this.porta.Name = "porta";
            this.porta.Size = new System.Drawing.Size(297, 12);
            this.porta.TabIndex = 13;
            this.porta.TabStop = false;
            this.porta.Click += new System.EventHandler(this.pictureBox14_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox11.Location = new System.Drawing.Point(45, 248);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(208, 32);
            this.pictureBox11.TabIndex = 10;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox9.Location = new System.Drawing.Point(547, 248);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(400, 32);
            this.pictureBox9.TabIndex = 8;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox8.Location = new System.Drawing.Point(929, 248);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(208, 32);
            this.pictureBox8.TabIndex = 7;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox7.Location = new System.Drawing.Point(929, 2);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(208, 32);
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox6.Location = new System.Drawing.Point(547, 2);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(390, 32);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox5.Location = new System.Drawing.Point(368, 2);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(208, 32);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox4.Location = new System.Drawing.Point(45, 2);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(332, 32);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox3.Location = new System.Drawing.Point(1101, 25);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 256);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.Location = new System.Drawing.Point(45, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 256);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PortaTimer
            // 
            this.PortaTimer.Interval = 1000;
            this.PortaTimer.Tick += new System.EventHandler(this.PortaTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 682);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bOTTONI_PANEL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bOTTONI_PANEL.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sensore_Prossimità)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fcs_sensore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bOTTONI_PANEL;
        private System.Windows.Forms.Button button_presenza;
        private System.Windows.Forms.Button button_RESET;
        private System.Windows.Forms.Button button_START;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textPersonaggio;
        private System.Windows.Forms.Label personaggio;
        private System.Windows.Forms.Label reset;
        private System.Windows.Forms.TextBox textReset;
        private System.Windows.Forms.TextBox textStart;
        private System.Windows.Forms.TextBox textTemperatura;
        private System.Windows.Forms.TextBox textFcdFinestra;
        private System.Windows.Forms.TextBox textFcsFinestra;
        private System.Windows.Forms.TextBox textFcdPorta;
        private System.Windows.Forms.TextBox textFcsPorta;
        private System.Windows.Forms.Label temperatura;
        private System.Windows.Forms.Label start;
        private System.Windows.Forms.Label fcdFinestra;
        private System.Windows.Forms.Label fcsFinestra;
        private System.Windows.Forms.Label fcdPorta;
        private System.Windows.Forms.Label fcsPorta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox text_ALLARME;
        private System.Windows.Forms.TextBox text_sxfinestra;
        private System.Windows.Forms.TextBox text_dxfinestra;
        private System.Windows.Forms.TextBox text_sxporta;
        private System.Windows.Forms.TextBox text_dxporta;
        private System.Windows.Forms.Label ALLARME;
        private System.Windows.Forms.Label SX_FINESTRA;
        private System.Windows.Forms.Label DX_FINESTRA;
        private System.Windows.Forms.Label SX_PORTA;
        private System.Windows.Forms.Label DX_PORTA;
        private System.Windows.Forms.Timer masterTimer;
        private System.Windows.Forms.Timer startTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox porta;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox fcs_sensore;
        private System.Windows.Forms.PictureBox pictureBox21;
        private System.Windows.Forms.PictureBox Sensore_Prossimità;
        private System.Windows.Forms.TextBox TextSensProssimita_porta;
        private System.Windows.Forms.Label sens_prossimita;
        private System.Windows.Forms.Timer PortaTimer;
    }
}

