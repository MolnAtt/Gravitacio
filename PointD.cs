using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gravitáció
{
	struct PointD
	{
		private double X { get; set; }
		private double Y { get; set; }

		public PointD(double X, double Y)
		{
			this.X = X;
			this.Y = Y;
		}

		public PointD(double X, double Y, string koordinátatípus) // igazából mindegy, milyen string jön...
		{
			this.X = 0; // nem világos, hogy a C# most ehhez miért ragaszkodik, más projektben, pl Logo, nem ragaszkodott.
			this.Y = 0;
			this.X = Y * Cos(X);
			this.Y = Y * Sin(X);
		}
		public static PointD operator +(PointD p, PointD q) => new PointD(p.X + q.X, p.Y + q.Y);
		public static PointD operator -(PointD p, PointD q) => new PointD(p.X - q.X, p.Y - q.Y);
		public static PointD operator /(PointD p, double a) => new PointD(p.X / a, p.Y / a);
		public static PointD operator *(double a, PointD p) =>  new PointD(a * p.X, a * p.Y);
		public static PointD operator *(PointD p, double a) => new PointD(a * p.X, a * p.Y);

		public double Hossz() => Math.Sqrt(X * X + Y * Y); 
		public double HosszNégyzet()  => X * X + Y * Y;
		/*public static void operator +=(PointD p, PointD q)
		{
			p.X += q.X;
			p.Y += q.Y;
		}*/

		public int intX() => (int)Math.Round(X);
		public int intY() => (int)Math.Round(Y);

		private double Deg2Rad(double x) => Math.PI * x / 180;
		private double Rad2Deg(double x) => Math.PI * x / 180;
		private double Sin(double x) => Math.Sin(Deg2Rad(x));
		private double Cos(double x) => Math.Cos(Deg2Rad(x));


		public double DistanceFrom(PointD P) { return (this - P).Hossz(); }
		public double DistanceFromNégyzet(PointD P) { return (this - P).HosszNégyzet(); }
	}
}
