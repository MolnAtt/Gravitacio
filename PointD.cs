using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gravitáció
{
	struct PointD
	{
		public double X { get;}
		public double Y { get;}

		public PointD(double X, double Y)
		{
			this.X = X;
			this.Y = Y;
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

		private static double Deg2Rad(double x) => Math.PI * x / 180;
		private static double Rad2Deg(double x) => 180 * x / Math.PI;
		private static double Sin(double x) => Math.Sin(Deg2Rad(x));
		private static double Cos(double x) => Math.Cos(Deg2Rad(x));
		private static double ArcTan(double y,double x) => Rad2Deg(Math.Atan2(y,x));


		public double DistanceFrom(PointD P) { return (this - P).Hossz(); }
		public double DistanceFromNégyzet(PointD P) { return (this - P).HosszNégyzet(); }

		public PointD ToDescartes() => new PointD(Y * Cos(X), Y * Sin(X));
		public PointD ToPolar() => new PointD(ArcTan(Y,X),Hossz());
	}
}
