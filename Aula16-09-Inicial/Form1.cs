using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula16_09_Inicial
{
    public partial class Form1 : Form
    {
        private Timer t;
        public Brush brush = Brushes.Black;
    
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.DoubleBuffered = true;
            this.Paint += new PaintEventHandler(GameLoop);
            t = new Timer();
            t.Interval = 10;
            t.Tick += new EventHandler(t_Ticket);
            t.Start();
        }

        private void GameLoop(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(brush, 10, 10, 40, 40);

        }

            private void t_Ticket(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
