using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gravitáció
{
	struct PointD
	{
		double X, Y;

		public PointD(double X, double Y)
		{
			this.X = X;
			this.Y = Y;
		}
		public static PointD operator +(PointD p, PointD q){ return new PointD(p.X + q.X, p.Y + q.Y); }

		public static PointD operator -(PointD p, PointD q) { return new PointD(p.X - q.X, p.Y - q.Y); }
		public static PointD operator /(PointD p, double a) { return new PointD(p.X / a, p.Y / a); }
		public static PointD operator *(double a, PointD p) { return new PointD(a * p.X, a * p.Y); }
		public static PointD operator *(PointD p, double a) { return new PointD(a * p.X, a * p.Y); }

		public double Hossz() { return Math.Sqrt(X * X + Y * Y); }
		public double HosszNégyzet() { return X * X + Y * Y; }
		/*public static void operator +=(PointD p, PointD q)
		{
			p.X += q.X;
			p.Y += q.Y;
		}*/

		public int intX() { return (int)Math.Round(X); }
		public int intY() { return (int)Math.Round(Y); }

		public double DistanceFrom(PointD P) { return (this - P).Hossz(); }
		public double DistanceFromNégyzet(PointD P) { return (this - P).HosszNégyzet(); }
	}
}
