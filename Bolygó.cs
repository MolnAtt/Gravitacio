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
		public string Név { get; }
		private PointD hely;
		private PointD velocity;
		private Color szín;
		private double tömeg;
		private int méret;
		private SolidBrush toll;
		private List<PointD> gravitációvektorok;

		// Formos megjelenítés a monitorpanelre
		private GravSzim form;
		private Label nev_label = new Label();
		private Label h_label = new Label();
		private TextBox h_textbox = new TextBox();
		private Label v_label = new Label();
		private TextBox v_textbox = new TextBox();
		private Label m_label = new Label();
		private TextBox m_textbox = new TextBox();
		private PictureBox szin_picturebox = new PictureBox();
		private Button törlőgomb = new Button();
		private Control[] kontroltömb;

		const int bolygóhelyfoglalás_monitoron = 30;
		const int hezag_monitoron = 5;
		static int monitoron_hova_Y = 10;

		public static List<Bolygó> lista = new List<Bolygó>();

		public Bolygó(GravSzim form, string név, PointD hely, PointD v, Color szín, double tömeg)
		{
			this.form = form;
			this.Név = név;
			this.hely = hely;
			this.velocity = v.ToDescartes();
			this.szín = szín;
			this.tömeg = tömeg;
			this.méret = (int)Math.Round(Math.Sqrt(tömeg/10));
			this.toll = new SolidBrush(szín);
			gravitációvektorok = new List<PointD>();
			lista.Add(this);

			#region  Monitorpanelhez tartozó rész beállításai:

			kontroltömb = new Control[]{ nev_label, h_label, h_textbox, v_label, v_textbox, m_label, m_textbox, szin_picturebox, törlőgomb };

			if (Bolygó.lista.Count > 3)
			{
				form.monitorpanel.Height += bolygóhelyfoglalás_monitoron;
			}

			Monitor_frissítése();
			nev_label.Text = név;
			h_label.Text = "hely:";
			v_label.Text = "v = ";
			m_label.Text = "m = ";
			m_textbox.Text = tömeg.ToString();
			szin_picturebox.BackColor = szín;
			törlőgomb.Text = "Töröl";


			int monitoron_hova_X = 100;
			nev_label.TextAlign = ContentAlignment.MiddleRight;
			nev_label.AutoSize = false;
			nev_label.Width = 100;
			nev_label.Location = new Point(monitoron_hova_X, monitoron_hova_Y);
			
			monitoron_hova_X += nev_label.Width + hezag_monitoron;

			szin_picturebox.Size = new Size(bolygóhelyfoglalás_monitoron-5, bolygóhelyfoglalás_monitoron-5);
			szin_picturebox.Location = new Point(monitoron_hova_X, monitoron_hova_Y);

			monitoron_hova_X += szin_picturebox.Width + hezag_monitoron;

			h_label.AutoSize = false;
			h_label.Width = 40;
			h_label.TextAlign = ContentAlignment.MiddleRight;
			h_label.Location = new Point(monitoron_hova_X, monitoron_hova_Y);

			monitoron_hova_X += h_label.Width + hezag_monitoron;

			h_textbox.Width = 100;
			h_textbox.TextAlign = HorizontalAlignment.Center;
			h_textbox.Location = new Point(monitoron_hova_X, monitoron_hova_Y);

			monitoron_hova_X += h_textbox.Width + hezag_monitoron;

			v_label.AutoSize = false;
			v_label.Width = 40;
			v_label.TextAlign = ContentAlignment.MiddleRight;
			v_label.Location = new Point(monitoron_hova_X, monitoron_hova_Y);
			
			monitoron_hova_X += v_label.Width + hezag_monitoron;

			v_textbox.Width = 100;
			v_textbox.TextAlign = HorizontalAlignment.Center;
			v_textbox.Location = new Point(monitoron_hova_X, monitoron_hova_Y);

			monitoron_hova_X += v_textbox.Width + hezag_monitoron;

			m_label.AutoSize = false;
			m_label.Width = 40;
			m_label.TextAlign = ContentAlignment.MiddleRight;
			m_label.Location = new Point(monitoron_hova_X, monitoron_hova_Y);

			monitoron_hova_X += m_label.Width + hezag_monitoron;

			m_textbox.Width = 60;
			m_textbox.TextAlign = HorizontalAlignment.Center;
			m_textbox.Location = new Point(monitoron_hova_X, monitoron_hova_Y);

			monitoron_hova_X += m_textbox.Width + hezag_monitoron;

			törlőgomb.Location = new Point(monitoron_hova_X, monitoron_hova_Y);

			foreach (Control c in kontroltömb)
			{
				form.monitorpanel.Controls.Add(c);
			}

			monitoron_hova_Y += bolygóhelyfoglalás_monitoron;

			törlőgomb.Click += Törlés;
			

			#endregion
			form.Refresh();
		}

		private void Törlés(object sender, EventArgs e)
		{
			int ix = Bolygó.lista.IndexOf(this);
			for (int i = ix+1; i < Bolygó.lista.Count; i++)
			{
				foreach (Control c in Bolygó.lista[i].kontroltömb)
				{
					c.Location = new Point(c.Location.X, c.Location.Y - bolygóhelyfoglalás_monitoron);
					//MessageBox.Show($"hátrébb toltam {c}-t");
				}
			}

			Bolygó.lista.RemoveAt(ix);
			foreach (Control c in kontroltömb)
			{
				form.monitorpanel.Controls.Remove(c);
			}

			monitoron_hova_Y -= bolygóhelyfoglalás_monitoron;
			if (Bolygó.lista.Count>2)
			{
				form.monitorpanel.Height -= bolygóhelyfoglalás_monitoron;
			}

			//			form.monitorpanel.Refresh();
			form.Refresh();

			GC.SuppressFinalize(this);

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

		public void Monitor_frissítése()
		{
			h_textbox.Text = $"({this.hely.X.ToString("0.00")};{this.hely.Y.ToString("0.00")})";
			PointD v = this.velocity.ToPolar();
			v_textbox.Text = $"({v.X.ToString("0.00")};{v.Y.ToString("0.00")})";
		}
		private bool monitor_szerkeszthető_e = true;
		public bool Monitor_szerkeszthetőség
		{ 
			get { return monitor_szerkeszthető_e; }
			set 
			{
				h_textbox.Enabled = value;
				v_textbox.Enabled = value;
				m_textbox.Enabled = value;
				monitor_szerkeszthető_e = value;
			}
		}
	}
}
