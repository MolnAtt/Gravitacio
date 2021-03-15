using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gravitáció
{
	public partial class GravSzim : Form
	{

		public GravSzim()
		{
			//DoubleBuffered = true;
			InitializeComponent();

			Size = new Size(1500, 1000);

		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			foreach (Bolygó bolygó in Bolygó.lista)
			{
				bolygó.Rajz(e);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void ujb_Peldabolygok_Click(object sender, EventArgs e)
		{
			Bolygó nap = new Bolygó("Nap", new PointD(600, 200), new PointD(1, -1), Color.Red, 12000);
			Bolygó föld = new Bolygó("Föld", new PointD(800, 300), new PointD(-4, 4), Color.Blue, 3000);
			Bolygó hold = new Bolygó("Hold", new PointD(800, 350), new PointD(3, 0), Color.Gray, 300);
		}

		private void metronom_Tick(object sender, EventArgs e)
		{
			Bolygó.Léptetések();
			Invalidate();
		}
	}
}
