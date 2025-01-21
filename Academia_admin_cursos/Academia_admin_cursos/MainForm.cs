//Heracles Sánchez && Angela Arenas
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Academia_admin_cursos
{
	public partial class MainForm : Form
	{
	
		private GestorCurso CursoRegistrado = new GestorCurso();
		public MainForm()
	{
			InitializeComponent();	
			
			Eliminar.Click += new EventHandler(Eliminar_Click);
			Eliminar.Click += new EventHandler(Reiniciar_Click);
			Fecha_inicio.ValueChanged += new EventHandler(Verificar_Fechas);
			Fecha_culm.ValueChanged += new EventHandler(Verificar_Fechas);
			
			Registrar.Click += delegate {
			String codigo = Codigo.Text;
			if (CursoRegistrado.Validar_exist(codigo) == false)
		{
			decimal Horas_decimal = Cant_horas.Value;
			short Horas_int16 = Convert.ToInt16(Horas_decimal);
			decimal Estudiantes_decimal = Cant_estudiantes.Value;
			short Estudiantes_int16 = Convert.ToInt16(Estudiantes_decimal);
			String FormatoCodigo = @"^[a-zA-ZÑñ]{2}-\d{2}$";
			String FormatoProfesor = @"^[a-zA-ZÑñáéíóúÁÉÍÓÚ]{2,14} [a-zA-ZÑñáéíóúÁÉÍÓÚ]{2,14}$";
			String FormatoTitulo = @"^([a-zA-ZÑñáéíóúÁÉÍÓÚ]{2,14}\s*){1,6}$";
			Regex ValidoCodigo = new Regex (FormatoCodigo);
			Regex ValidoProfesor = new Regex (FormatoProfesor);
			Regex ValidoTitulo = new Regex (FormatoTitulo);
			
			if (!ValidoCodigo.IsMatch(Codigo.Text))
			{
				MessageBox.Show("Error: Formato de Código Incorrecto, el código del curso debe contener 2 letras y 2 números cualquiera, separadas por un guión).", "Mensaje");
			}
			else 
			{
				if (!ValidoProfesor.IsMatch(Profesor.Text) || !ValidoTitulo.IsMatch(Titulo.Text))
				{
				MessageBox.Show("Error: Formato de Profesor o Titulo Incorrecto. Ingrese todos los datos. El nombre del profesor ha de incluír un único nombre y apellido, de mínimo 2 letras y máximo 14 cada uno).", "Mensaje");
				}
				else
				{	
				Curso c = new Curso();
				c.Codigo = Codigo.Text;
				c.Profesor = Profesor.Text;
				c.Titulo = Titulo.Text;
				c.Fecha_inicio = Fecha_inicio.Value;
				c.Fecha_culm = Fecha_culm.Value;
				c.Cant_horas = Horas_int16;
				c.Cant_estudiantes = Estudiantes_int16;
				c.Activo = true;
				c.Tipo_curso = Convert.ToString(Tipo_curso.SelectedItem);
				
				CursoRegistrado.Registrar(c);
				MessageBox.Show("El curso se ha registrado!","Mensaje");
				}
			}				
		}
				else
			{
				MessageBox.Show("Error: El curso ya se registró antes","Mensaje");				
			}
		};
			
			Actualizar.Click += delegate		{
			decimal Horas_decimal = Cant_horas.Value;
			short Horas_int16 = Convert.ToInt16(Horas_decimal);
			decimal Estudiantes_decimal = Cant_estudiantes.Value;
			short Estudiantes_int16 = Convert.ToInt16(Estudiantes_decimal);
			
			String codigo = Codigo.Text;
			if (CursoRegistrado.Validar_exist(codigo) == true)
				{
			String FormatoCodigo = @"^[a-zA-ZÑñ]{2}-\d{2}$";
			String FormatoProfesor = @"^[a-zA-ZÑñáéíóúÁÉÍÓÚ]{2,14} [a-zA-ZÑñáéíóúÁÉÍÓÚ]{2,14}$";
			String FormatoTitulo = @"^([a-zA-ZÑñáéíóúÁÉÍÓÚ]{2,14}\s*){1,6}$";
			Regex ValidoCodigo = new Regex (FormatoCodigo);
			Regex ValidoProfesor = new Regex (FormatoProfesor);
			Regex ValidoTitulo = new Regex (FormatoTitulo);
			
			if (!ValidoCodigo.IsMatch(Codigo.Text))
			{
				MessageBox.Show("Error: Formato de Código Incorrecto, el código del curso debe contener 2 letras y 2 números cualquiera, separadas por un guión).", "Mensaje");
			}
			else 
		{

				if (!ValidoProfesor.IsMatch(Profesor.Text) || !ValidoTitulo.IsMatch(Titulo.Text))
				{
				MessageBox.Show("Error: Formato de Profesor Incorrecto, el nombre del profesor ha de incluír un único nombre y apellido, de mínimo 2 letras y máximo 14 cada uno).", "Mensaje");
				}
				else
				{	
				Curso c = new Curso();
				c.Codigo = Codigo.Text;
				c.Profesor = Profesor.Text;
				c.Titulo = Titulo.Text;
				c.Fecha_inicio = Fecha_inicio.Value;
				c.Fecha_culm = Fecha_culm.Value;
				c.Cant_horas = Horas_int16;
				c.Cant_estudiantes = Estudiantes_int16;
				c.Tipo_curso = Convert.ToString(Tipo_curso.SelectedItem);
				c.Activo = true;
				CursoRegistrado.Actualizar(c);
				MessageBox.Show("Datos del Curso actualizados","Mensaje");					
					} 
				}
			}
			else
				{
				MessageBox.Show("Código de curso incorrecto o inexistente.","Mensaje");				
				}
	};
		
			Consultar.Click += delegate {
   			String FormatoCodigo = @"^[a-zA-ZÑñ]{2}-\d{2}$";
   			Regex ValidoCodigo = new Regex(FormatoCodigo);
    		if (!ValidoCodigo.IsMatch(Codigo.Text))
    			{
        		MessageBox.Show("Error: Formato de Código Incorrecto, el código del curso debe contener 2 letras y 2 números cualquiera, separadas por un guión.", "Mensaje");
    			}
   			else 
    			{
       		String codigo = Codigo.Text;
        	if (CursoRegistrado.Validar_exist(codigo) == true)
        	{
            Curso c = CursoRegistrado.Consultar(codigo);
            	if (c != null)
            	{
                	if (c.Activo == false)
                	{
                    MessageBox.Show("El curso que busca se encuentra registrado más inactivo", "Mensaje");
                    Registrar.Enabled = true;
                    Actualizar.Enabled = false;
                    Eliminar.Enabled = false;
                    Fecha_culm.Focus();
                	}
                	else
                	{
                    Titulo.Text = c.Titulo;
                    Tipo_curso.SelectedItem = c.Tipo_curso;
                    Profesor.Text = c.Profesor;
                    Fecha_inicio.Value = c.Fecha_inicio;
                    Fecha_culm.Value = c.Fecha_culm;
                    Cant_horas.Value = Math.Max(Cant_horas.Minimum, Math.Min(Cant_horas.Maximum, c.Cant_horas));
                    Cant_estudiantes.Value = Math.Max(Cant_estudiantes.Minimum, Math.Min(Cant_estudiantes.Maximum, c.Cant_estudiantes));

                    Registrar.Enabled = false;
                    Actualizar.Enabled = true;
                    Eliminar.Enabled = true;
                }
            	}
            	else
            	{
                MessageBox.Show("Curso no registrado", "Mensaje");
                Fecha_inicio.Value = DateTime.Now;
                Fecha_culm.Value = Fecha_inicio.Value.AddDays(1);
                Cant_estudiantes.Value = Math.Max(Cant_estudiantes.Minimum, 4);
                Cant_horas.Value = Math.Max(Cant_horas.Minimum, 20);
                Tipo_curso.SelectedIndex = -1;
                Titulo.Text = "";
                Profesor.Text = "";

                Registrar.Enabled = true;
                Actualizar.Enabled = false;
                Eliminar.Enabled = false;
                Codigo.Focus();
            	}
        	}
        else
        {
        MessageBox.Show("Curso no registrado", "Mensaje");
        Fecha_inicio.Value = DateTime.Now;
        Fecha_culm.Value = Fecha_inicio.Value.AddDays(1);
        Cant_estudiantes.Value = Math.Max(Cant_estudiantes.Minimum, 4);
        Cant_horas.Value = Math.Max(Cant_horas.Minimum, 20);
        Tipo_curso.SelectedIndex = -1;
        Titulo.Text = "";
        Profesor.Text = "";

        Registrar.Enabled = true;
        Actualizar.Enabled = false;
        Eliminar.Enabled = false;
        Codigo.Focus();
        }
    }
};

			}
		
		
		void Eliminar_Click(object sender, EventArgs e)
		{	
			String FormatoCodigo = @"^[a-zA-ZÑñ]{2}-\d{2}$";
			Regex ValidoCodigo = new Regex (FormatoCodigo);
			if (!ValidoCodigo.IsMatch(Codigo.Text))
			{
				MessageBox.Show("Error: Formato de Código Incorrecto, el código del curso debe contener 2 letras y 2 números cualquiera, separadas por un guión).", "Mensaje");
			}
			else 
			{
			String codigo = Codigo.Text;
			if (CursoRegistrado.Validar_exist(codigo) == true)
			{
    		    Curso c = CursoRegistrado.Consultar(codigo);
				DialogResult w = MessageBox.Show("Está seguro de eliminar los datos del curso: " + c.Codigo,
    		                                     "Pregunta de Confirmación",MessageBoxButtons.YesNo,
    		                                     MessageBoxIcon.Question);
    		    if (w == DialogResult.Yes)
    		    {
				    CursoRegistrado.Borrar(c);
				    MessageBox.Show("Curso Eliminado de la Lista","Mensaje");					
    		    }
			} else 
			{
				MessageBox.Show("Código de curso incorrecto o inexistente.","Mensaje");				
			}
			
		}
	}
						
			void Reiniciar_Click(object sender, EventArgs e)
			{
			decimal Horas_decimal = Cant_horas.Value;
			short Horas_int16 = Convert.ToInt16(Horas_decimal);
			decimal Estudiantes_decimal = Cant_estudiantes.Value;
			short Estudiantes_int16 = Convert.ToInt16(Estudiantes_decimal);
			
                Fecha_inicio.Value = DateTime.Now;
                Fecha_culm.Value = Fecha_inicio.Value.AddDays(1);
                Cant_estudiantes.Value = 4;
                Cant_horas.Value = 20;
                Tipo_curso.SelectedIndex = -1;
                Titulo.Text = "";
				Profesor.Text = "";
				Codigo.Text = "";
                
				Registrar.Enabled = true;
				Actualizar.Enabled = false;
			    Eliminar.Enabled = false;				
				Codigo.Focus();
			}
			 private void Verificar_Fechas(object sender, EventArgs e) 
				{ 
				if (Fecha_inicio.Value >= Fecha_culm.Value) 
				{ 		MessageBox.Show("Error: La fecha de inicio debe ser menor que la fecha de culminación.", "Mensaje");
						Fecha_culm.Value = Fecha_inicio.Value.AddDays(1); } }

			}
	}
		
	
