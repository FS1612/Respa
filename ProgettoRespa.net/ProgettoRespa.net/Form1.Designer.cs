
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
            this.bOTTONI_PANEL.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bOTTONI_PANEL
            // 
            this.bOTTONI_PANEL.Controls.Add(this.button_presenza);
            this.bOTTONI_PANEL.Controls.Add(this.button_RESET);
            this.bOTTONI_PANEL.Controls.Add(this.button_START);
            this.bOTTONI_PANEL.Location = new System.Drawing.Point(18, 18);
            this.bOTTONI_PANEL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bOTTONI_PANEL.Name = "bOTTONI_PANEL";
            this.bOTTONI_PANEL.Size = new System.Drawing.Size(1792, 126);
            this.bOTTONI_PANEL.TabIndex = 5;
            // 
            // button_presenza
            // 
            this.button_presenza.Location = new System.Drawing.Point(1418, 20);
            this.button_presenza.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_presenza.Name = "button_presenza";
            this.button_presenza.Size = new System.Drawing.Size(315, 68);
            this.button_presenza.TabIndex = 2;
            this.button_presenza.Text = "PRESENTE";
            this.button_presenza.UseVisualStyleBackColor = true;
            this.button_presenza.Click += new System.EventHandler(this.button_presenza_Click);
            // 
            // button_RESET
            // 
            this.button_RESET.Location = new System.Drawing.Point(735, 20);
            this.button_RESET.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_RESET.Name = "button_RESET";
            this.button_RESET.Size = new System.Drawing.Size(315, 68);
            this.button_RESET.TabIndex = 1;
            this.button_RESET.Text = "RESET";
            this.button_RESET.UseVisualStyleBackColor = true;
            this.button_RESET.Click += new System.EventHandler(this.button_RESET_Click);
            // 
            // button_START
            // 
            this.button_START.Location = new System.Drawing.Point(28, 20);
            this.button_START.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_START.Name = "button_START";
            this.button_START.Size = new System.Drawing.Size(315, 68);
            this.button_START.TabIndex = 0;
            this.button_START.Text = "START";
            this.button_START.UseVisualStyleBackColor = true;
            this.button_START.Click += new System.EventHandler(this.button_START_Click);
            // 
            // groupBox2
            // 
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
            this.groupBox2.Location = new System.Drawing.Point(18, 169);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(723, 611);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SENSORI";
            // 
            // textPersonaggio
            // 
            this.textPersonaggio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPersonaggio.Location = new System.Drawing.Point(464, 528);
            this.textPersonaggio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textPersonaggio.Name = "textPersonaggio";
            this.textPersonaggio.ReadOnly = true;
            this.textPersonaggio.Size = new System.Drawing.Size(149, 26);
            this.textPersonaggio.TabIndex = 29;
            // 
            // personaggio
            // 
            this.personaggio.AutoSize = true;
            this.personaggio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personaggio.Location = new System.Drawing.Point(129, 517);
            this.personaggio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.personaggio.Name = "personaggio";
            this.personaggio.Size = new System.Drawing.Size(265, 74);
            this.personaggio.TabIndex = 28;
            this.personaggio.Text = "PERSONAGGIO \r\nPRESENTE";
            // 
            // reset
            // 
            this.reset.AutoSize = true;
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(129, 434);
            this.reset.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(122, 37);
            this.reset.TabIndex = 27;
            this.reset.Text = "RESET";
            // 
            // textReset
            // 
            this.textReset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textReset.Location = new System.Drawing.Point(464, 442);
            this.textReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textReset.Name = "textReset";
            this.textReset.ReadOnly = true;
            this.textReset.Size = new System.Drawing.Size(149, 26);
            this.textReset.TabIndex = 26;
            // 
            // textStart
            // 
            this.textStart.Location = new System.Drawing.Point(464, 377);
            this.textStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textStart.Name = "textStart";
            this.textStart.Size = new System.Drawing.Size(148, 26);
            this.textStart.TabIndex = 25;
            // 
            // textTemperatura
            // 
            this.textTemperatura.Location = new System.Drawing.Point(464, 306);
            this.textTemperatura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textTemperatura.Name = "textTemperatura";
            this.textTemperatura.Size = new System.Drawing.Size(148, 26);
            this.textTemperatura.TabIndex = 24;
            // 
            // textFcdFinestra
            // 
            this.textFcdFinestra.Location = new System.Drawing.Point(464, 242);
            this.textFcdFinestra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textFcdFinestra.Name = "textFcdFinestra";
            this.textFcdFinestra.Size = new System.Drawing.Size(148, 26);
            this.textFcdFinestra.TabIndex = 23;
            // 
            // textFcsFinestra
            // 
            this.textFcsFinestra.Location = new System.Drawing.Point(464, 182);
            this.textFcsFinestra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textFcsFinestra.Name = "textFcsFinestra";
            this.textFcsFinestra.Size = new System.Drawing.Size(148, 26);
            this.textFcsFinestra.TabIndex = 22;
            // 
            // textFcdPorta
            // 
            this.textFcdPorta.Location = new System.Drawing.Point(464, 112);
            this.textFcdPorta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textFcdPorta.Name = "textFcdPorta";
            this.textFcdPorta.Size = new System.Drawing.Size(148, 26);
            this.textFcdPorta.TabIndex = 21;
            // 
            // textFcsPorta
            // 
            this.textFcsPorta.Location = new System.Drawing.Point(464, 43);
            this.textFcsPorta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textFcsPorta.Name = "textFcsPorta";
            this.textFcsPorta.Size = new System.Drawing.Size(148, 26);
            this.textFcsPorta.TabIndex = 20;
            // 
            // temperatura
            // 
            this.temperatura.AutoSize = true;
            this.temperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperatura.Location = new System.Drawing.Point(129, 306);
            this.temperatura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.temperatura.Name = "temperatura";
            this.temperatura.Size = new System.Drawing.Size(257, 37);
            this.temperatura.TabIndex = 19;
            this.temperatura.Text = "TEMPERATURA\r\n";
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(129, 368);
            this.start.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(122, 37);
            this.start.TabIndex = 18;
            this.start.Text = "START";
            // 
            // fcdFinestra
            // 
            this.fcdFinestra.AutoSize = true;
            this.fcdFinestra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fcdFinestra.Location = new System.Drawing.Point(129, 232);
            this.fcdFinestra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fcdFinestra.Name = "fcdFinestra";
            this.fcdFinestra.Size = new System.Drawing.Size(250, 37);
            this.fcdFinestra.TabIndex = 17;
            this.fcdFinestra.Text = "FCD FINESTRA";
            // 
            // fcsFinestra
            // 
            this.fcsFinestra.AutoSize = true;
            this.fcsFinestra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fcsFinestra.Location = new System.Drawing.Point(129, 172);
            this.fcsFinestra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fcsFinestra.Name = "fcsFinestra";
            this.fcsFinestra.Size = new System.Drawing.Size(248, 37);
            this.fcsFinestra.TabIndex = 16;
            this.fcsFinestra.Text = "FCS FINESTRA";
            // 
            // fcdPorta
            // 
            this.fcdPorta.AutoSize = true;
            this.fcdPorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fcdPorta.Location = new System.Drawing.Point(129, 103);
            this.fcdPorta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fcdPorta.Name = "fcdPorta";
            this.fcdPorta.Size = new System.Drawing.Size(202, 37);
            this.fcdPorta.TabIndex = 15;
            this.fcdPorta.Text = "FCD PORTA";
            // 
            // fcsPorta
            // 
            this.fcsPorta.AutoSize = true;
            this.fcsPorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fcsPorta.Location = new System.Drawing.Point(130, 42);
            this.fcsPorta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fcsPorta.Name = "fcsPorta";
            this.fcsPorta.Size = new System.Drawing.Size(200, 37);
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
            this.groupBox1.Location = new System.Drawing.Point(939, 177);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(741, 603);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ATTUATORI";
            // 
            // text_ALLARME
            // 
            this.text_ALLARME.Location = new System.Drawing.Point(464, 306);
            this.text_ALLARME.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_ALLARME.Name = "text_ALLARME";
            this.text_ALLARME.Size = new System.Drawing.Size(148, 26);
            this.text_ALLARME.TabIndex = 24;
            // 
            // text_sxfinestra
            // 
            this.text_sxfinestra.Location = new System.Drawing.Point(464, 242);
            this.text_sxfinestra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_sxfinestra.Name = "text_sxfinestra";
            this.text_sxfinestra.Size = new System.Drawing.Size(148, 26);
            this.text_sxfinestra.TabIndex = 23;
            // 
            // text_dxfinestra
            // 
            this.text_dxfinestra.Location = new System.Drawing.Point(464, 182);
            this.text_dxfinestra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_dxfinestra.Name = "text_dxfinestra";
            this.text_dxfinestra.Size = new System.Drawing.Size(148, 26);
            this.text_dxfinestra.TabIndex = 22;
            // 
            // text_sxporta
            // 
            this.text_sxporta.Location = new System.Drawing.Point(464, 112);
            this.text_sxporta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_sxporta.Name = "text_sxporta";
            this.text_sxporta.Size = new System.Drawing.Size(148, 26);
            this.text_sxporta.TabIndex = 21;
            // 
            // text_dxporta
            // 
            this.text_dxporta.Location = new System.Drawing.Point(464, 43);
            this.text_dxporta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_dxporta.Name = "text_dxporta";
            this.text_dxporta.Size = new System.Drawing.Size(148, 26);
            this.text_dxporta.TabIndex = 20;
            // 
            // ALLARME
            // 
            this.ALLARME.AutoSize = true;
            this.ALLARME.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ALLARME.Location = new System.Drawing.Point(129, 306);
            this.ALLARME.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ALLARME.Name = "ALLARME";
            this.ALLARME.Size = new System.Drawing.Size(166, 37);
            this.ALLARME.TabIndex = 19;
            this.ALLARME.Text = "ALLARME";
            // 
            // SX_FINESTRA
            // 
            this.SX_FINESTRA.AutoSize = true;
            this.SX_FINESTRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SX_FINESTRA.Location = new System.Drawing.Point(129, 232);
            this.SX_FINESTRA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SX_FINESTRA.Name = "SX_FINESTRA";
            this.SX_FINESTRA.Size = new System.Drawing.Size(226, 37);
            this.SX_FINESTRA.TabIndex = 17;
            this.SX_FINESTRA.Text = "SX FINESTRA";
            // 
            // DX_FINESTRA
            // 
            this.DX_FINESTRA.AutoSize = true;
            this.DX_FINESTRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DX_FINESTRA.Location = new System.Drawing.Point(129, 172);
            this.DX_FINESTRA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DX_FINESTRA.Name = "DX_FINESTRA";
            this.DX_FINESTRA.Size = new System.Drawing.Size(228, 37);
            this.DX_FINESTRA.TabIndex = 16;
            this.DX_FINESTRA.Text = "DX FINESTRA";
            // 
            // SX_PORTA
            // 
            this.SX_PORTA.AutoSize = true;
            this.SX_PORTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SX_PORTA.Location = new System.Drawing.Point(129, 103);
            this.SX_PORTA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SX_PORTA.Name = "SX_PORTA";
            this.SX_PORTA.Size = new System.Drawing.Size(178, 37);
            this.SX_PORTA.TabIndex = 15;
            this.SX_PORTA.Text = "SX PORTA";
            // 
            // DX_PORTA
            // 
            this.DX_PORTA.AutoSize = true;
            this.DX_PORTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DX_PORTA.Location = new System.Drawing.Point(129, 35);
            this.DX_PORTA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DX_PORTA.Name = "DX_PORTA";
            this.DX_PORTA.Size = new System.Drawing.Size(180, 37);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bOTTONI_PANEL);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bOTTONI_PANEL.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}

