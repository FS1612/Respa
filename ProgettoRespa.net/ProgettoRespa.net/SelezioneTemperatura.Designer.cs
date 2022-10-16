
namespace ProgettoRespa.net
{
    partial class SelezioneTemperatura
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
            this.listTemperature = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Temperatura = new System.Windows.Forms.Label();
            this.Text_temperatura = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listTemperature
            // 
            this.listTemperature.FormattingEnabled = true;
            this.listTemperature.Location = new System.Drawing.Point(128, 12);
            this.listTemperature.Name = "listTemperature";
            this.listTemperature.Size = new System.Drawing.Size(120, 355);
            this.listTemperature.TabIndex = 0;
            this.listTemperature.SelectedIndexChanged += new System.EventHandler(this.listTemperature_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(262, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Salva ed  Esci";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Temperatura
            // 
            this.Temperatura.AutoSize = true;
            this.Temperatura.Location = new System.Drawing.Point(18, 394);
            this.Temperatura.Name = "Temperatura";
            this.Temperatura.Size = new System.Drawing.Size(98, 13);
            this.Temperatura.TabIndex = 3;
            this.Temperatura.Text = "Temperatura scelta";
            // 
            // Text_temperatura
            // 
            this.Text_temperatura.Location = new System.Drawing.Point(128, 389);
            this.Text_temperatura.Name = "Text_temperatura";
            this.Text_temperatura.Size = new System.Drawing.Size(100, 20);
            this.Text_temperatura.TabIndex = 4;
            this.Text_temperatura.TextChanged += new System.EventHandler(this.Text_temperatura_TextChanged);
            // 
            // SelezioneTemperatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 450);
            this.Controls.Add(this.Text_temperatura);
            this.Controls.Add(this.Temperatura);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listTemperature);
            this.Name = "SelezioneTemperatura";
            this.Text = "SelezioneTemperatura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listTemperature;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Temperatura;
        private System.Windows.Forms.TextBox Text_temperatura;
    }
}