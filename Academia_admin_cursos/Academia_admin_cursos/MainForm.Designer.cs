/*
 * Created by SharpDevelop.
 * User: Heracles Sánchez
 * Date: 19/1/2025
 * Time: 12:23 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Academia_admin_cursos
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Codigo = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.Titulo = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.Tipo_curso = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.Fecha_inicio = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.Fecha_culm = new System.Windows.Forms.DateTimePicker();
			this.label7 = new System.Windows.Forms.Label();
			this.Cant_estudiantes = new System.Windows.Forms.NumericUpDown();
			this.label8 = new System.Windows.Forms.Label();
			this.Registrar = new System.Windows.Forms.Button();
			this.Consultar = new System.Windows.Forms.Button();
			this.Actualizar = new System.Windows.Forms.Button();
			this.Eliminar = new System.Windows.Forms.Button();
			this.Profesor = new System.Windows.Forms.TextBox();
			this.Cant_horas = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Cant_estudiantes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Cant_horas)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(407, 1);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(185, 122);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(79, 69);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 37);
			this.label1.TabIndex = 1;
			this.label1.Text = "Código del Curso:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Codigo
			// 
			this.Codigo.BackColor = System.Drawing.Color.AliceBlue;
			this.Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Codigo.Location = new System.Drawing.Point(177, 82);
			this.Codigo.Name = "Codigo";
			this.Codigo.Size = new System.Drawing.Size(77, 23);
			this.Codigo.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(79, 121);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Su Título:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Titulo
			// 
			this.Titulo.BackColor = System.Drawing.Color.LightCyan;
			this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Titulo.Location = new System.Drawing.Point(177, 123);
			this.Titulo.Name = "Titulo";
			this.Titulo.Size = new System.Drawing.Size(77, 23);
			this.Titulo.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(79, 156);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 36);
			this.label3.TabIndex = 5;
			this.label3.Text = "Cantidad de Horas:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Tipo_curso
			// 
			this.Tipo_curso.BackColor = System.Drawing.Color.LightCyan;
			this.Tipo_curso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Tipo_curso.FormattingEnabled = true;
			this.Tipo_curso.Items.AddRange(new object[] {
									"Presencial",
									"Virtual",
									"Semipresencial"});
			this.Tipo_curso.Location = new System.Drawing.Point(302, 135);
			this.Tipo_curso.Name = "Tipo_curso";
			this.Tipo_curso.Size = new System.Drawing.Size(121, 21);
			this.Tipo_curso.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(292, 104);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(142, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "Modalidad de Curso:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Fecha_inicio
			// 
			this.Fecha_inicio.Location = new System.Drawing.Point(79, 264);
			this.Fecha_inicio.Name = "Fecha_inicio";
			this.Fecha_inicio.Size = new System.Drawing.Size(200, 20);
			this.Fecha_inicio.TabIndex = 12;
			// 
			// label5
			// 
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(79, 234);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(110, 23);
			this.label5.TabIndex = 13;
			this.label5.Text = "Fecha de inicio:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(302, 234);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(154, 23);
			this.label6.TabIndex = 15;
			this.label6.Text = "Fecha de culminación:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Fecha_culm
			// 
			this.Fecha_culm.Location = new System.Drawing.Point(302, 264);
			this.Fecha_culm.Name = "Fecha_culm";
			this.Fecha_culm.Size = new System.Drawing.Size(200, 20);
			this.Fecha_culm.TabIndex = 14;
			this.Fecha_culm.Value = new System.DateTime(2025, 1, 22, 2, 57, 0, 0);
			// 
			// label7
			// 
			this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(79, 201);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(175, 20);
			this.label7.TabIndex = 16;
			this.label7.Text = "Cantidad de estudiantes:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Cant_estudiantes
			// 
			this.Cant_estudiantes.Location = new System.Drawing.Point(257, 202);
			this.Cant_estudiantes.Maximum = new decimal(new int[] {
									10,
									0,
									0,
									0});
			this.Cant_estudiantes.Minimum = new decimal(new int[] {
									4,
									0,
									0,
									0});
			this.Cant_estudiantes.Name = "Cant_estudiantes";
			this.Cant_estudiantes.Size = new System.Drawing.Size(36, 20);
			this.Cant_estudiantes.TabIndex = 17;
			this.Cant_estudiantes.Value = new decimal(new int[] {
									4,
									0,
									0,
									0});
			// 
			// label8
			// 
			this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(298, 168);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(135, 23);
			this.label8.TabIndex = 18;
			this.label8.Text = "Profesor del Curso:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Registrar
			// 
			this.Registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Registrar.Location = new System.Drawing.Point(69, 306);
			this.Registrar.Name = "Registrar";
			this.Registrar.Size = new System.Drawing.Size(78, 26);
			this.Registrar.TabIndex = 20;
			this.Registrar.Text = "Registrar";
			this.Registrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.Registrar.UseVisualStyleBackColor = true;
			// 
			// Consultar
			// 
			this.Consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Consultar.Location = new System.Drawing.Point(186, 306);
			this.Consultar.Name = "Consultar";
			this.Consultar.Size = new System.Drawing.Size(86, 26);
			this.Consultar.TabIndex = 21;
			this.Consultar.Text = "Consultar";
			this.Consultar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.Consultar.UseVisualStyleBackColor = true;
			// 
			// Actualizar
			// 
			this.Actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Actualizar.Location = new System.Drawing.Point(301, 306);
			this.Actualizar.Name = "Actualizar";
			this.Actualizar.Size = new System.Drawing.Size(86, 26);
			this.Actualizar.TabIndex = 22;
			this.Actualizar.Text = "Actualizar";
			this.Actualizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.Actualizar.UseVisualStyleBackColor = true;
			// 
			// Eliminar
			// 
			this.Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Eliminar.Location = new System.Drawing.Point(432, 306);
			this.Eliminar.Name = "Eliminar";
			this.Eliminar.Size = new System.Drawing.Size(86, 26);
			this.Eliminar.TabIndex = 23;
			this.Eliminar.Text = "Eliminar";
			this.Eliminar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.Eliminar.UseVisualStyleBackColor = true;
			// 
			// Profesor
			// 
			this.Profesor.BackColor = System.Drawing.Color.LightCyan;
			this.Profesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Profesor.Location = new System.Drawing.Point(299, 200);
			this.Profesor.Name = "Profesor";
			this.Profesor.Size = new System.Drawing.Size(144, 23);
			this.Profesor.TabIndex = 19;
			// 
			// Cant_horas
			// 
			this.Cant_horas.Location = new System.Drawing.Point(177, 171);
			this.Cant_horas.Maximum = new decimal(new int[] {
									80,
									0,
									0,
									0});
			this.Cant_horas.Minimum = new decimal(new int[] {
									20,
									0,
									0,
									0});
			this.Cant_horas.Name = "Cant_horas";
			this.Cant_horas.Size = new System.Drawing.Size(39, 20);
			this.Cant_horas.TabIndex = 24;
			this.Cant_horas.Value = new decimal(new int[] {
									20,
									0,
									0,
									0});
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(591, 355);
			this.Controls.Add(this.Cant_horas);
			this.Controls.Add(this.Eliminar);
			this.Controls.Add(this.Actualizar);
			this.Controls.Add(this.Consultar);
			this.Controls.Add(this.Registrar);
			this.Controls.Add(this.Profesor);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.Cant_estudiantes);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.Fecha_culm);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.Fecha_inicio);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.Tipo_curso);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Titulo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Codigo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(607, 394);
			this.MinimumSize = new System.Drawing.Size(607, 394);
			this.Name = "MainForm";
			this.Text = "La CursoBox";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Cant_estudiantes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Cant_horas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.NumericUpDown Cant_horas;
		private System.Windows.Forms.Button Eliminar;
		private System.Windows.Forms.Button Actualizar;
		private System.Windows.Forms.Button Consultar;
		private System.Windows.Forms.Button Registrar;
		private System.Windows.Forms.TextBox Profesor;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.NumericUpDown Cant_estudiantes;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DateTimePicker Fecha_culm;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker Fecha_inicio;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox Tipo_curso;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox Titulo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox Codigo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
