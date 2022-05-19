using System;

namespace trigonometria
{
	public class calcular
	{
		public calcular()
		{
		}
		
		public string ladoA {get; set;}
		public string ladoB {get; set;}
		public string ladoC {get; set;}
		public double angulo {get; set;}
		
		public string senA() //seno de A
		{
			ladoA = (double.Parse(ladoB) / Math.Sin((angulo * Math.PI)/180)).ToString();
			ladoA = (Math.Round(double.Parse(ladoA), 2)).ToString();
			return ladoA;
		}
		public string senB() //seno de B
		{
			ladoB = (double.Parse(ladoA) * Math.Sin((angulo * Math.PI)/180)).ToString();
			ladoB = (Math.Round(double.Parse(ladoB), 2)).ToString();
			return ladoB;
		}
		
		public string cosA() //cosseno de A
		{
			ladoA = (double.Parse(ladoC) / Math.Cos((angulo * Math.PI)/180)).ToString();
			ladoA = (Math.Round(double.Parse(ladoA), 2)).ToString();
			return ladoA;
		}
		
		public string cosC() //cosseno de C
		{
			ladoC = (double.Parse(ladoA) * Math.Cos((angulo * Math.PI)/180)).ToString();
			ladoC = (Math.Round(double.Parse(ladoC), 2)).ToString();
			return ladoC;
		}
		
		public string tanB() //tangente de B
		{
			ladoB = (double.Parse(ladoC) * Math.Tan((angulo * Math.PI)/180)).ToString();
			ladoB = (Math.Round(double.Parse(ladoB), 2)).ToString();
			return ladoB;
		}
		
		public string tanC() //tangente de C
		{
			ladoC = (double.Parse(ladoB) / Math.Tan((angulo * Math.PI)/180)).ToString();
			ladoC = (Math.Round(double.Parse(ladoC), 2)).ToString();
			return ladoC;
		}
	}
}
