﻿using System;
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
			ketyege = false;
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

		}

		private void Példabolygók_létrehozása_Click(object sender, EventArgs e)
		{
			new Bolygó(this, "Nap", new PointD(600, 200), new PointD(45, 1.5), Color.Red, 12000);
			new Bolygó(this, "Föld", new PointD(800, 300), new PointD(225, 6), Color.Blue, 3000);
			new Bolygó(this, "Hold", new PointD(800, 350), new PointD(0, 3), Color.Gray, 300);
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
			}
			else
			{
				metronom.Start();
				ketyege = true;
				foreach (Bolygó b in Bolygó.lista)
				{
					b.Monitor_szerkeszthetőség = false;
				}
			}
		}
	}
}
