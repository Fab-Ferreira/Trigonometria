/*
 * Created by SharpDevelop.
 * User: RM20212930048
 * Date: 22/03/2022
 * Time: 12:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace trigonometria
{
	/// <summary>
	/// Description of calcular.
	/// </summary>
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
		
		public string cosA() //cos de A
		{
			ladoA = (double.Parse(ladoC) / Math.Cos((angulo * Math.PI)/180)).ToString();
			ladoA = (Math.Round(double.Parse(ladoA), 2)).ToString();
			return ladoA;
		}
		
		public string cosC() //cos de C
		{
			ladoC = (double.Parse(ladoA) * Math.Cos((angulo * Math.PI)/180)).ToString();
			ladoC = (Math.Round(double.Parse(ladoC), 2)).ToString();
			return ladoC;
		}
		
		public string tanB() //tan de B
		{
			ladoB = (double.Parse(ladoC) * Math.Tan((angulo * Math.PI)/180)).ToString();
			ladoB = (Math.Round(double.Parse(ladoB), 2)).ToString();
			return ladoB;
		}
		
		public string tanC() //tan de C
		{
			ladoC = (double.Parse(ladoB) / Math.Tan((angulo * Math.PI)/180)).ToString();
			ladoC = (Math.Round(double.Parse(ladoC), 2)).ToString();
			return ladoC;
		}
	}
}
