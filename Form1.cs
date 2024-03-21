using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progetto_Planetario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisegnaPlanetario();
        }
        Planetario planetario = new Planetario();
        int startStop = 0;
        int scia = 0;

        public void DisegnaPlanetario()
        {
            Graphics g = this.CreateGraphics();
            if (scia == 1) //per togliere la scia dei pianeti
            {
                this.BackgroundImage = (System.Drawing.Image)BackgroundImage.Clone();
                
            }
            foreach (Pianeta pianeta in planetario.Pianeti) //disegna ogni pianeta
            {
                Color cPianeta = Color.FromName(pianeta.Colore);
                Brush brush = new SolidBrush(cPianeta);
                g.FillEllipse(brush, (float)pianeta.Posizione.X, (float)pianeta.Posizione.Y, (float)(Math.Pow(pianeta.Massa, 0.3333)), (float)(Math.Pow(pianeta.Massa, 0.3333)));
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Cronometro_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 500; i++) //ogni tick aggiorna 500 volte le posizioni e la velocità dei pianeti
            {
                planetario.Move();
            }
            DisegnaPlanetario();

        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (startStop == 0)
            {
                Cronometro.Enabled = true;
                startStop++;
            }
            else
            {
                Cronometro.Enabled = false;
                startStop--;
            }
        }

        private void btnScia_Click(object sender, EventArgs e)
        {
            if (scia == 0)
            {
                scia++;

            }
            else
            {
                scia--;
            }
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            Pianeta p = new Pianeta();
            if (!Pianeta.TryParse(txtPianeta.Text, out p))
            {
                MessageBox.Show("Errore");
            }
            else
            {
                lstPianeti.Items.Add(p);
                planetario.Pianeti.Add(p);
                txtPianeta.Clear();
            }
        }

        private void btnRimuovi_Click(object sender, EventArgs e)
        {
            if (lstPianeti.SelectedIndex != -1)
            {
                planetario.Pianeti.RemoveAt(lstPianeti.SelectedIndex);
                lstPianeti.Items.RemoveAt(lstPianeti.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Nessun elemento è stato selezionato");
            }
        }
    }
}
