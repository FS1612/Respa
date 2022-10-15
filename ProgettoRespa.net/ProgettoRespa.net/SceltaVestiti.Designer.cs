
namespace ProgettoRespa.net
{
    partial class SceltaVestiti
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.bottoneCerca = new System.Windows.Forms.Button();
            this.BarraRicercaVestiti = new System.Windows.Forms.TextBox();
            this.RicercaVestitiLabel = new System.Windows.Forms.Label();
            this.List_Magliette = new System.Windows.Forms.ListBox();
            this.List_Pantaloni = new System.Windows.Forms.ListBox();
            this.List_Jeans = new System.Windows.Forms.ListBox();
            this.List_Scarpe = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.SalvaEdEsciButton = new System.Windows.Forms.Button();
            this.scelta1 = new System.Windows.Forms.TextBox();
            this.Scelta_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Scelta_label);
            this.panel1.Controls.Add(this.SalvaEdEsciButton);
            this.panel1.Controls.Add(this.scelta1);
            this.panel1.Controls.Add(this.bottoneCerca);
            this.panel1.Controls.Add(this.BarraRicercaVestiti);
            this.panel1.Controls.Add(this.RicercaVestitiLabel);
            this.panel1.Controls.Add(this.List_Magliette);
            this.panel1.Controls.Add(this.List_Pantaloni);
            this.panel1.Controls.Add(this.List_Jeans);
            this.panel1.Controls.Add(this.List_Scarpe);
            this.panel1.Location = new System.Drawing.Point(29, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 286);
            this.panel1.TabIndex = 0;
            // 
            // bottoneCerca
            // 
            this.bottoneCerca.Location = new System.Drawing.Point(590, 25);
            this.bottoneCerca.Name = "bottoneCerca";
            this.bottoneCerca.Size = new System.Drawing.Size(75, 23);
            this.bottoneCerca.TabIndex = 6;
            this.bottoneCerca.Text = "Cerca";
            this.bottoneCerca.UseVisualStyleBackColor = true;
            this.bottoneCerca.Click += new System.EventHandler(this.bottoneCerca_Click);
            // 
            // BarraRicercaVestiti
            // 
            this.BarraRicercaVestiti.Location = new System.Drawing.Point(378, 28);
            this.BarraRicercaVestiti.Name = "BarraRicercaVestiti";
            this.BarraRicercaVestiti.Size = new System.Drawing.Size(120, 20);
            this.BarraRicercaVestiti.TabIndex = 5;
            // 
            // RicercaVestitiLabel
            // 
            this.RicercaVestitiLabel.AutoSize = true;
            this.RicercaVestitiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RicercaVestitiLabel.Location = new System.Drawing.Point(197, 25);
            this.RicercaVestitiLabel.Name = "RicercaVestitiLabel";
            this.RicercaVestitiLabel.Size = new System.Drawing.Size(110, 24);
            this.RicercaVestitiLabel.TabIndex = 4;
            this.RicercaVestitiLabel.Text = "Cerca vestiti";
            // 
            // List_Magliette
            // 
            this.List_Magliette.FormattingEnabled = true;
            this.List_Magliette.Location = new System.Drawing.Point(16, 69);
            this.List_Magliette.Name = "List_Magliette";
            this.List_Magliette.Size = new System.Drawing.Size(120, 95);
            this.List_Magliette.TabIndex = 3;
            this.List_Magliette.SelectedIndexChanged += new System.EventHandler(this.List_magliette_SelectedIndexChanged);
            // 
            // List_Pantaloni
            // 
            this.List_Pantaloni.FormattingEnabled = true;
            this.List_Pantaloni.Location = new System.Drawing.Point(187, 69);
            this.List_Pantaloni.Name = "List_Pantaloni";
            this.List_Pantaloni.Size = new System.Drawing.Size(120, 95);
            this.List_Pantaloni.TabIndex = 2;
            this.List_Pantaloni.SelectedIndexChanged += new System.EventHandler(this.List_pantaloni_SelectedIndexChanged);
            // 
            // List_Jeans
            // 
            this.List_Jeans.FormattingEnabled = true;
            this.List_Jeans.Location = new System.Drawing.Point(378, 69);
            this.List_Jeans.Name = "List_Jeans";
            this.List_Jeans.Size = new System.Drawing.Size(120, 95);
            this.List_Jeans.TabIndex = 1;
            this.List_Jeans.SelectedIndexChanged += new System.EventHandler(this.List_Jeans_SelectedIndexChanged);
            // 
            // List_Scarpe
            // 
            this.List_Scarpe.FormattingEnabled = true;
            this.List_Scarpe.Location = new System.Drawing.Point(590, 69);
            this.List_Scarpe.Name = "List_Scarpe";
            this.List_Scarpe.Size = new System.Drawing.Size(120, 95);
            this.List_Scarpe.TabIndex = 0;
            this.List_Scarpe.SelectedIndexChanged += new System.EventHandler(this.Scarpe_SelectedIndexChanged);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // SalvaEdEsciButton
            // 
            this.SalvaEdEsciButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SalvaEdEsciButton.Location = new System.Drawing.Point(590, 260);
            this.SalvaEdEsciButton.Name = "SalvaEdEsciButton";
            this.SalvaEdEsciButton.Size = new System.Drawing.Size(156, 23);
            this.SalvaEdEsciButton.TabIndex = 7;
            this.SalvaEdEsciButton.Text = "Salva ed Esci";
            this.SalvaEdEsciButton.UseVisualStyleBackColor = true;
            this.SalvaEdEsciButton.Click += new System.EventHandler(this.SalvaEdEsciButton_Click);
            // 
            // scelta1
            // 
            this.scelta1.Location = new System.Drawing.Point(378, 200);
            this.scelta1.Name = "scelta1";
            this.scelta1.Size = new System.Drawing.Size(100, 20);
            this.scelta1.TabIndex = 8;
            // 
            // Scelta_label
            // 
            this.Scelta_label.AutoSize = true;
            this.Scelta_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scelta_label.Location = new System.Drawing.Point(298, 198);
            this.Scelta_label.Name = "Scelta_label";
            this.Scelta_label.Size = new System.Drawing.Size(56, 20);
            this.Scelta_label.TabIndex = 9;
            this.Scelta_label.Text = "Scelta";
            // 
            // SceltaVestiti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 353);
            this.Controls.Add(this.panel1);
            this.Name = "SceltaVestiti";
            this.Text = "SceltaVestiti";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox List_Scarpe;
        private System.Windows.Forms.ListBox List_Jeans;
        private System.Windows.Forms.ListBox List_Pantaloni;
        private System.Windows.Forms.ListBox List_Magliette;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Button bottoneCerca;
        private System.Windows.Forms.TextBox BarraRicercaVestiti;
        private System.Windows.Forms.Label RicercaVestitiLabel;
        private System.Windows.Forms.Button SalvaEdEsciButton;
        private System.Windows.Forms.TextBox scelta1;
        private System.Windows.Forms.Label Scelta_label;
    }
}