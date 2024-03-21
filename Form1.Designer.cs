namespace Progetto_Planetario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.btnScia = new System.Windows.Forms.Button();
            this.txtPianeta = new System.Windows.Forms.TextBox();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.btnRimuovi = new System.Windows.Forms.Button();
            this.lstPianeti = new System.Windows.Forms.ListBox();
            this.Cronometro = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "massa,  velocita su X; velocita su Y,  posizione su X; posizione su Y  colore";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnStartStop
            // 
            this.btnStartStop.Location = new System.Drawing.Point(12, 12);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(83, 23);
            this.btnStartStop.TabIndex = 8;
            this.btnStartStop.Text = "start/stop";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // btnScia
            // 
            this.btnScia.Location = new System.Drawing.Point(101, 12);
            this.btnScia.Name = "btnScia";
            this.btnScia.Size = new System.Drawing.Size(121, 23);
            this.btnScia.TabIndex = 9;
            this.btnScia.Text = "Scia ON/OFF";
            this.btnScia.UseVisualStyleBackColor = true;
            this.btnScia.Click += new System.EventHandler(this.btnScia_Click);
            // 
            // txtPianeta
            // 
            this.txtPianeta.Location = new System.Drawing.Point(11, 78);
            this.txtPianeta.Name = "txtPianeta";
            this.txtPianeta.Size = new System.Drawing.Size(221, 22);
            this.txtPianeta.TabIndex = 10;
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(253, 70);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(105, 30);
            this.btnAggiungi.TabIndex = 11;
            this.btnAggiungi.Text = "AGGIUNGI";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // btnRimuovi
            // 
            this.btnRimuovi.Location = new System.Drawing.Point(253, 106);
            this.btnRimuovi.Name = "btnRimuovi";
            this.btnRimuovi.Size = new System.Drawing.Size(105, 35);
            this.btnRimuovi.TabIndex = 12;
            this.btnRimuovi.Text = "RIMUOVI";
            this.btnRimuovi.UseVisualStyleBackColor = true;
            this.btnRimuovi.Click += new System.EventHandler(this.btnRimuovi_Click);
            // 
            // lstPianeti
            // 
            this.lstPianeti.FormattingEnabled = true;
            this.lstPianeti.ItemHeight = 16;
            this.lstPianeti.Location = new System.Drawing.Point(11, 116);
            this.lstPianeti.Name = "lstPianeti";
            this.lstPianeti.Size = new System.Drawing.Size(219, 324);
            this.lstPianeti.TabIndex = 13;
            // 
            // Cronometro
            // 
            this.Cronometro.Tick += new System.EventHandler(this.Cronometro_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.lstPianeti);
            this.Controls.Add(this.btnRimuovi);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.txtPianeta);
            this.Controls.Add(this.btnScia);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Planetario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Button btnScia;
        private System.Windows.Forms.TextBox txtPianeta;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Button btnRimuovi;
        private System.Windows.Forms.ListBox lstPianeti;
        private System.Windows.Forms.Timer Cronometro;
    }
}

