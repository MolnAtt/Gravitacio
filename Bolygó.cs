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
		private PointD Hely;
		//public Point Location;
		private PointD Sebességvektor;
		public Color szín;
		public double Tömeg;
		public int Méret;
		private SolidBrush br;
		private List<PointD> gravitációvektorok;

		public static List<Bolygó> lista = new List<Bolygó>();

		public Bolygó(PointD h, PointD v, Color sz, double m)
		{
			Hely = h;
			Sebességvektor = v;
			szín = sz;
			Tömeg = m;
			Méret = (int)Math.Round(Tömeg/1000);
			lista.Add(this);
			br = new SolidBrush(sz);
			gravitációvektorok = new List<PointD>();
		}

		private void GravitációsanKölcsönhat(Bolygó másik)
		{
			double dnégyzet = this.Hely.DistanceFromNégyzet(másik.Hely);
			PointD kettőköztivektor = this.Hely - másik.Hely;
			PointD kettőköztiegységvektor = (this.Hely - másik.Hely)/(Math.Sqrt(dnégyzet));

			this.gravitációvektorok.Add(-1 * másik.Tömeg * kettőköztiegységvektor / dnégyzet);
			másik.gravitációvektorok.Add(this.Tömeg *kettőköztiegységvektor / dnégyzet); // -1 azért van itt, mert a másik irányba hat!
		}

		// ITT TARTOTTUNK, még nem teszteltük, biztosan át kell még nézni.

		public void Lép()
		{
			Hely += Sebességvektor;
		}

		public void Rajz(PaintEventArgs e)
		{
			e.Graphics.FillEllipse(br, Hely.intX()-(Méret/2), Hely.intY() - (Méret / 2), Méret, Méret);
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
					bolygó.Sebességvektor += gravitációvektor;
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
