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
	
	public partial class Form1 : Form
	{
		Label l = new Label();
		Button b = new Button();
		Timer t = new Timer();

		public Form1()
		{
			InitializeComponent();
			l.Text = "Debuglabel";
			l.Location = new Point(50, 50);
			Controls.Add(l);

			b.Text = "Start";
			b.Location = new Point(100, 200);
			Controls.Add(b);

			b.Click += Start_Click;

			t.Interval = 100;
			t.Tick += Tikk;

			Bolygó pirosbolygó = new Bolygó(new PointD(100, 200), new PointD(1.41, Math.PI), Color.Red, 100);
			Bolygó kékbolygó = new Bolygó(new PointD(500, 300), new PointD(3, -4), Color.Blue, 50);

		}
		int i = 0;
		private void Tikk(object sender, EventArgs e)
		{
			l.Text=i++.ToString();

			Bolygó.Léptetések();

			Invalidate();
		}

		private void Start_Click(object sender, EventArgs e)
		{
			l.Text = "Halihó";
			t.Start();
		}

		SolidBrush br = new SolidBrush(Color.Red);
		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			foreach (Bolygó bolygó in Bolygó.lista)
			{
				bolygó.Rajz(e);
			}
		}
	}
}
