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
	class Bolygó
	{
		private string név;
		public string Név => név;
		private PointD hely;
		private PointD velocity;
		private Color szín;
		private double tömeg;
		private int méret;
		private SolidBrush toll;
		private List<PointD> gravitációvektorok;

		public static List<Bolygó> lista = new List<Bolygó>();

		public Bolygó(string név, PointD hely, PointD velocity, Color szín, double tömeg)
		{
			this.név = név;
			this.hely = hely;
			this.velocity = velocity;
			this.szín = szín;
			this.tömeg = tömeg;
			this.méret = (int)Math.Round(Math.Sqrt(tömeg/10));
			this.toll = new SolidBrush(szín);
			gravitációvektorok = new List<PointD>();
			lista.Add(this);
		}

		private void GravitációsanKölcsönhat(Bolygó másik)
		{
			double dnégyzet = this.hely.DistanceFromNégyzet(másik.hely);
			PointD kettőköztivektor = this.hely - másik.hely;
			PointD kettőköztiegységvektor = (this.hely - másik.hely)/(Math.Sqrt(dnégyzet));

			this.gravitációvektorok.Add(-1 * másik.tömeg * kettőköztiegységvektor / dnégyzet);
			másik.gravitációvektorok.Add(this.tömeg *kettőköztiegységvektor / dnégyzet); // -1 azért van itt, mert a másik irányba hat!
		}

		// ITT TARTOTTUNK, még nem teszteltük, biztosan át kell még nézni.

		public void Lép()
		{
			hely += velocity;
		}

		public void Rajz(PaintEventArgs e)
		{
			e.Graphics.FillEllipse(toll, hely.intX()-(méret/2), hely.intY() - (méret / 2), méret, méret);
		}

		public static void Léptetések()
		{

			// lenullázzuk a bolygókra ható gravitációs vonzásokat
			foreach (Bolygó b in lista)
			{
				b.gravitációvektorok = new List<PointD>();
			}

			// kiszámoljuk az új helyzet alapján minden bolygóra, hogy milyen erők hatnak rájuk
			for (int i = 0; i < lista.Count; i++)
			{

				for (int j = i+1; j < lista.Count; j++)
				{
					lista[i].GravitációsanKölcsönhat(lista[j]);
				}
			}

			// A bolygóra ható erőket összegezzük (a régi sebességükhöz adjuk hozzá az új gravitációs vektorokat)
			foreach (Bolygó bolygó in lista)
			{
				foreach (PointD gravitációvektor in bolygó.gravitációvektorok)
				{
					bolygó.velocity += gravitációvektor;
				}
			}

			// Végrehajtjuk a mozgásokat.
			foreach (Bolygó bolygó in Bolygó.lista)
			{
				bolygó.Lép();
			}
		}
	}
}
