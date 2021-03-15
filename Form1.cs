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
			DoubleBuffered = true;
			InitializeComponent();
			ketyege = false;
			WindowState = FormWindowState.Maximized;
			ujb_panel_SizeChanged(new object(), new EventArgs());
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			foreach (Bolygó bolygó in Bolygó.lista)
			{
				bolygó.Rajz(e);
			}
		}

		private void Új_bolygó_létrehozása_Click(object sender, EventArgs e)
		{
			new Bolygó(this, 
				ujb_neve.Text,
				new PointD(double.Parse(ujb_helyex.Text), double.Parse(ujb_helyey.Text)),
				new PointD(double.Parse(ujb_irany.Text), double.Parse(ujb_speed.Text)),
				új_bolygó_színe, 
				int.Parse(ujb_tomege.Text));
			Refresh();
		}

		private void Példabolygók_létrehozása_Click(object sender, EventArgs e)
		{
			double y = 0.7 * Height;
			double x = 0.5 * Width;
			new Bolygó(this, "Nap", new PointD(x, y), new PointD(0, -2), Color.Red, 17000);
			new Bolygó(this, "Föld", new PointD(x, y + 180), new PointD(0, 10), Color.Blue, 3000);
			new Bolygó(this, "Hold", new PointD(x, y + 180 + 45), new PointD(0, 20), Color.Gray, 300);
		}

		int t = 0;
		private void metronom_Tick(object sender, EventArgs e)
		{
			Bolygó.Léptetések();
			Invalidate();
			időlabel.Text = t++.ToString();
		}

		bool ketyege;
		private void start_Click(object sender, EventArgs e)
		{
			if (ketyege)
			{
				metronom.Stop();
				ketyege = false;
				foreach (Bolygó b in Bolygó.lista)
				{
					b.Monitor_frissítése();
					b.Monitor_szerkeszthetőség = true;
				}
				ment.Enabled = true;
				start.Text = "START";
				ujb_panel.Enabled = true;
			}
			else
			{
				metronom.Start();
				ketyege = true;
				foreach (Bolygó b in Bolygó.lista)
				{
					b.Monitor_szerkeszthetőség = false;
				}
				ment.Enabled = false;
				start.Text = "STOP";
				ujb_panel.Enabled = false;
			}
		}

		private void ment_Click(object sender, EventArgs e)
		{
			foreach (Bolygó b in Bolygó.lista)
			{
				b.Módosítás();
			}
			Refresh();
		}

		private void ujb_panel_SizeChanged(object sender, EventArgs e)
		{
			ujb_panel.Location = new Point(this.Width - ujb_panel.Width - 5, 5);
		}

		private Color új_bolygó_színe = Color.Black;


		private void Új_bolygó_színválasztása()
		{
			szinvalasztas.AllowFullOpen = false;
			szinvalasztas.AnyColor = true;
			szinvalasztas.SolidColorOnly = false;
			szinvalasztas.Color = Color.Red;

			if (szinvalasztas.ShowDialog() == DialogResult.OK)
			{
				új_bolygó_színe = szinvalasztas.Color;
			}

			szinvalaszto_picturebox.BackColor = új_bolygó_színe;
		}

		private void szinvalaszto_gomb_Click(object sender, EventArgs e)
		{
			Új_bolygó_színválasztása();
		}

		private void szinvalaszto_picturebox_Click(object sender, EventArgs e)
		{
			Új_bolygó_színválasztása();
		}
	}
}
