using System;

namespace Academia_admin_cursos
{
	public class Curso
	{
		protected String codigo;
		protected String profesor;
		protected String titulo;
		protected String tipo_curso;
		protected Int16 cant_horas;
		protected DateTime fecha_inicio;
		protected DateTime fecha_culm;
		protected Int16 cant_estudiantes;
		protected Boolean activo;
		public String Codigo {get{return codigo;}set{codigo=value;}}
		public String Profesor {get{return profesor;}set{profesor=value;}}
		public String Titulo {get{return titulo;}set{titulo=value;}}
		public String Tipo_curso {get{return tipo_curso;}set{tipo_curso=value;}}
		public Int16 Cant_horas {get{return cant_horas;}set{cant_horas=value;}}
		public DateTime Fecha_inicio {get{return fecha_inicio;}set{fecha_inicio=value;}}
		public DateTime Fecha_culm {get{return fecha_culm;}set{fecha_culm=value;}}
		public Int16 Cant_estudiantes {get{return cant_estudiantes;}set{cant_estudiantes=value;}}
		public Boolean Activo {get{return activo;}set{activo=value;}}
		
		public Curso()
		{
			Codigo = ""; Profesor = ""; Titulo = ""; Tipo_curso = ""; Cant_horas = 0; Fecha_inicio = DateTime.Now; Fecha_culm = DateTime.Now.AddDays(1); Cant_estudiantes = 0; Activo = true;
		}
		public Curso(String a, String b, String c, String d, Int16 e, DateTime f, DateTime g, Int16 h, Boolean i)
		{
			Codigo = ""; Profesor = ""; Titulo = ""; Tipo_curso = ""; Cant_horas = 0; Fecha_inicio = f; Fecha_culm = g; Cant_estudiantes = 0; Activo = true;
		}
	}
}
