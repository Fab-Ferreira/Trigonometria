/*
 * Criado por SharpDevelop.
 * Usuário: Fab
 * Data: 22/03/2022
 * Hora: 00:01
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace trigonometria
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button calculate;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textC;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textAngle;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox resultado;
		private System.Windows.Forms.Label labelResultado;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Panel painelR;
		private System.Windows.Forms.Panel painelC;
		private System.Windows.Forms.Panel painelB;
		private System.Windows.Forms.TextBox textB;
		private System.Windows.Forms.Panel painelA;
		private System.Windows.Forms.TextBox textA;
		private System.Windows.Forms.Button clear;
		private System.Windows.Forms.Button instructions;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.calculate = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.textC = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textAngle = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.painelC = new System.Windows.Forms.Panel();
			this.painelB = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.textB = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.painelA = new System.Windows.Forms.Panel();
			this.label9 = new System.Windows.Forms.Label();
			this.textA = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.resultado = new System.Windows.Forms.TextBox();
			this.labelResultado = new System.Windows.Forms.Label();
			this.painelR = new System.Windows.Forms.Panel();
			this.clear = new System.Windows.Forms.Button();
			this.label13 = new System.Windows.Forms.Label();
			this.instructions = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.painelC.SuspendLayout();
			this.painelB.SuspendLayout();
			this.painelA.SuspendLayout();
			this.painelR.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(268, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "TRIGONOMETRIA";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// calculate
			// 
			this.calculate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.calculate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.calculate.Location = new System.Drawing.Point(547, 269);
			this.calculate.Name = "calculate";
			this.calculate.Size = new System.Drawing.Size(89, 29);
			this.calculate.TabIndex = 1;
			this.calculate.Text = "Calcular";
			this.calculate.UseVisualStyleBackColor = false;
			this.calculate.Click += new System.EventHandler(this.CalculateClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(23, 62);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(287, 236);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// textC
			// 
			this.textC.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textC.Location = new System.Drawing.Point(85, 1);
			this.textC.Name = "textC";
			this.textC.Size = new System.Drawing.Size(100, 26);
			this.textC.TabIndex = 8;
			this.textC.Text = "C";
			this.textC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(75, 32);
			this.label4.TabIndex = 7;
			this.label4.Text = "Lado C:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textAngle
			// 
			this.textAngle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textAngle.Location = new System.Drawing.Point(532, 204);
			this.textAngle.Name = "textAngle";
			this.textAngle.Size = new System.Drawing.Size(65, 26);
			this.textAngle.TabIndex = 10;
			this.textAngle.Text = "Angle";
			this.textAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(414, 200);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(112, 32);
			this.label5.TabIndex = 9;
			this.label5.Text = "Medida de α: ";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(603, 200);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(18, 32);
			this.label7.TabIndex = 12;
			this.label7.Text = "°";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(191, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(34, 32);
			this.label8.TabIndex = 13;
			this.label8.Text = "cm";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.Red;
			this.label11.Location = new System.Drawing.Point(354, 41);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(331, 44);
			this.label11.TabIndex = 16;
			this.label11.Text = "Inserir um 0 no valor que deseja descobrir e um -0 no valor que não é necessário " +
	"para o cálculo";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// painelC
			// 
			this.painelC.Controls.Add(this.label4);
			this.painelC.Controls.Add(this.textC);
			this.painelC.Controls.Add(this.label8);
			this.painelC.Location = new System.Drawing.Point(395, 164);
			this.painelC.Name = "painelC";
			this.painelC.Size = new System.Drawing.Size(232, 33);
			this.painelC.TabIndex = 25;
			// 
			// painelB
			// 
			this.painelB.Controls.Add(this.label2);
			this.painelB.Controls.Add(this.textB);
			this.painelB.Controls.Add(this.label3);
			this.painelB.Location = new System.Drawing.Point(395, 125);
			this.painelB.Name = "painelB";
			this.painelB.Size = new System.Drawing.Size(232, 33);
			this.painelB.TabIndex = 26;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 32);
			this.label2.TabIndex = 7;
			this.label2.Text = "Lado B:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textB
			// 
			this.textB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textB.Location = new System.Drawing.Point(85, 1);
			this.textB.Name = "textB";
			this.textB.Size = new System.Drawing.Size(100, 26);
			this.textB.TabIndex = 8;
			this.textB.Text = "B";
			this.textB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(191, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 32);
			this.label3.TabIndex = 13;
			this.label3.Text = "cm";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// painelA
			// 
			this.painelA.Controls.Add(this.label9);
			this.painelA.Controls.Add(this.textA);
			this.painelA.Controls.Add(this.label10);
			this.painelA.Location = new System.Drawing.Point(395, 87);
			this.painelA.Name = "painelA";
			this.painelA.Size = new System.Drawing.Size(232, 33);
			this.painelA.TabIndex = 27;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(75, 32);
			this.label9.TabIndex = 7;
			this.label9.Text = "Lado A:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textA
			// 
			this.textA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textA.Location = new System.Drawing.Point(85, 1);
			this.textA.Name = "textA";
			this.textA.Size = new System.Drawing.Size(100, 26);
			this.textA.TabIndex = 8;
			this.textA.Text = "A";
			this.textA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(191, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(34, 32);
			this.label10.TabIndex = 13;
			this.label10.Text = "cm";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// resultado
			// 
			this.resultado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resultado.Location = new System.Drawing.Point(378, 37);
			this.resultado.Name = "resultado";
			this.resultado.ReadOnly = true;
			this.resultado.Size = new System.Drawing.Size(100, 26);
			this.resultado.TabIndex = 17;
			this.resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// labelResultado
			// 
			this.labelResultado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelResultado.Location = new System.Drawing.Point(204, 33);
			this.labelResultado.Name = "labelResultado";
			this.labelResultado.Size = new System.Drawing.Size(168, 32);
			this.labelResultado.TabIndex = 18;
			this.labelResultado.Text = "Valor do lado B:";
			this.labelResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// painelR
			// 
			this.painelR.Controls.Add(this.clear);
			this.painelR.Controls.Add(this.label13);
			this.painelR.Controls.Add(this.labelResultado);
			this.painelR.Controls.Add(this.resultado);
			this.painelR.Location = new System.Drawing.Point(0, 330);
			this.painelR.Name = "painelR";
			this.painelR.Size = new System.Drawing.Size(690, 97);
			this.painelR.TabIndex = 20;
			this.painelR.Visible = false;
			// 
			// clear
			// 
			this.clear.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.clear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.clear.Location = new System.Drawing.Point(547, 35);
			this.clear.Name = "clear";
			this.clear.Size = new System.Drawing.Size(89, 29);
			this.clear.TabIndex = 28;
			this.clear.Text = "Limpar";
			this.clear.UseVisualStyleBackColor = false;
			this.clear.Click += new System.EventHandler(this.ClearClick);
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(484, 33);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(46, 32);
			this.label13.TabIndex = 19;
			this.label13.Text = "cm";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// instructions
			// 
			this.instructions.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.instructions.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.instructions.Location = new System.Drawing.Point(406, 269);
			this.instructions.Name = "instructions";
			this.instructions.Size = new System.Drawing.Size(102, 29);
			this.instructions.TabIndex = 28;
			this.instructions.Text = "Instruções";
			this.instructions.UseVisualStyleBackColor = false;
			this.instructions.Click += new System.EventHandler(this.InstructionsClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(716, 437);
			this.Controls.Add(this.instructions);
			this.Controls.Add(this.painelA);
			this.Controls.Add(this.painelB);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textAngle);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.calculate);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.painelR);
			this.Controls.Add(this.painelC);
			this.Name = "MainForm";
			this.Text = "trigonometria";
			this.Click += new System.EventHandler(this.CalculateClick);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.painelC.ResumeLayout(false);
			this.painelC.PerformLayout();
			this.painelB.ResumeLayout(false);
			this.painelB.PerformLayout();
			this.painelA.ResumeLayout(false);
			this.painelA.PerformLayout();
			this.painelR.ResumeLayout(false);
			this.painelR.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
