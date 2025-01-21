using System;
using System.Collections.Generic;


namespace Academia_admin_cursos
{
	
	public class GestorCurso
	{
		
		private List<Curso> _ejemplar;
		public List<Curso> Ejemplar {get {return _ejemplar;} set {_ejemplar = value;}}
		
		public GestorCurso()
		{
			Ejemplar = new List<Curso>();
		}
		
		public void Registrar(Curso x)
		{
			Ejemplar.Add(x);
		}
		
		public Curso Consultar(String n)
		{
			Curso u = new Curso();
			Boolean x = false;
			Int16 w = 0;
			while ((w < Ejemplar.Count) && (!x))
			{
				if (Ejemplar[w].Codigo == n && Ejemplar[w].Activo == true) x = true;
				   else w++;
			}
			if (x == true) u = Ejemplar[w];
			return u;
		}
		
		public void Actualizar(Curso x)
		{
			Int16 w = 0;
			
			foreach (Curso item in Ejemplar)
			{
				if (Ejemplar[w].Codigo == x.Codigo) 
				{
					Ejemplar[w].Profesor = x.Profesor;
					Ejemplar[w].Titulo = x.Titulo;
					Ejemplar[w].Tipo_curso = x.Tipo_curso;
					Ejemplar[w].Cant_horas = x.Cant_horas;
					Ejemplar[w].Fecha_inicio = x.Fecha_inicio;
					Ejemplar[w].Fecha_culm  = x.Fecha_culm;
					Ejemplar[w].Cant_estudiantes  = x.Cant_estudiantes;
					
					
				} else w++;
			}
		}
		
		public Boolean Validar_exist(String n)
		{
			Boolean x = false;
			foreach (Curso item in Ejemplar)
			{
				if (item.Codigo == n)
					{
					x = true;
					break;
					}
			}
			return x;
		}		
		public void Borrar(Curso x)
		{
			Int16 w = 0;
			while (w < Ejemplar.Count)
			{
				if (Ejemplar[w].Codigo == x.Codigo) 
				{
					Ejemplar[w].Activo = false;
                    break;
				} else w++;
			}}
			
	
		}
	}
