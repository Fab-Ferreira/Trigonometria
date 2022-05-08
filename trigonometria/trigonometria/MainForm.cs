using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace trigonometria
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		calcular calc = new calcular();
		
		void CalculateClick(object sender, EventArgs e)
		{	
			//Se alguma das Text Boxes ainda estiverem com o texto padrão
			if(textA.Text == "A" || textB.Text == "B" || textC.Text == "C" || textAngle.Text == "Angle")
			{
				MessageBox.Show(" Insira um valor no lugar que está faltando. \n \n Valores aceitáveis: \n x para a incógnita \n * para o lado que não é preciso no cálculo \n Qualquer número maior que 0 para a medida disponível.");
			}
			else
			{	
				calc.ladoA = textA.Text;
				calc.ladoB = textB.Text;
				calc.ladoC = textC.Text;
				calc.angulo = double.Parse(textAngle.Text);
				
				//Seno de A
				if(calc.ladoA == "x" && calc.ladoC == "*" && int.Parse(textB.Text) > 0 && calc.angulo > 0 && calc.angulo < 90)
				{
					painelR.Visible = true;
					resultado.Text = calc.senA();
					labelResultado.Text = "Valor do Lado A:";
				}
				
				//Seno de B
				if(textB.Text == "x" && textC.Text == "*" && int.Parse(textA.Text) > 0 && calc.angulo > 0 && calc.angulo < 90)
				{
					painelR.Visible = true;
					resultado.Text = calc.senB();
					labelResultado.Text = "Valor do Lado B:";
				}
				
				//Cosseno de A
				if(textA.Text == "x" && textB.Text == "*" && int.Parse(textC.Text) > 0 && calc.angulo > 0 && calc.angulo < 90)
				{
					painelR.Visible = true;
					resultado.Text = calc.cosA();
					labelResultado.Text = "Valor do Lado A:";
				}
				
				//Cosseno de C
				if(textC.Text == "x" && textB.Text == "*" && int.Parse(textA.Text) > 0 && calc.angulo > 0 && calc.angulo < 90)
				{
					painelR.Visible = true;
					resultado.Text = calc.cosC();
					labelResultado.Text = "Valor do Lado C:";
				}
				
				//Tangente de B
				if(textB.Text == "x" && textA.Text == "*" && int.Parse(textC.Text) > 0 && calc.angulo > 0 && calc.angulo < 90)
				{
					painelR.Visible = true;
					resultado.Text = calc.tanB();
					labelResultado.Text = "Valor do Lado B:";
				}
				
				//Tangente de C
				if(textC.Text == "x" && textA.Text == "*" && int.Parse(textB.Text) > 0 && calc.angulo > 0 && calc.angulo < 90)
				{
					painelR.Visible = true;
					resultado.Text = calc.tanC();
					labelResultado.Text = "Valor do Lado C:";
				}
			}
		}
		
		//Limpar
		void ClearClick(object sender, EventArgs e)
		{
			painelR.Visible = false;
			textA.Text = "A";
			textB.Text = "B";
			textC.Text = "C";
			textAngle.Text = "Angle";
		}
		
		//Instruções
		void InstructionsClick(object sender, EventArgs e)
		{
			MessageBox.Show("Bem-vindo(a) ao meu programa de calcular Trigonometria! Segue abaixo algumas instruções para o bom uso do programa: \n \n" +
			                "1- Há quatro valores a serem inseridos. Nos lados A, B e C, um dos três deve ter valor x (que seria a incógnita/valor a ser descoberto), " +
			                "o outro valor deve ter caracter * (que seria o lado onde não será utilizado na conta) e o terceiro valor será a medida que você tem disponível. \n \n" +
			                "2- O quarto valor é o valor do ângulo alpha, podendo ser aceito um ângulo de 1° à 89°. \n \n" +
			                "3- Não deixe os text boxes vazios, com texto fora do padrão ou sem número. \n \n" +
			                "Obs: O resultado será mostrado em decimal.");
		}
	}
}
