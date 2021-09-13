using System;
using System.Collections.Generic;
using System.Text;

namespace TP2_LogueoConNlog.Controllers
{
	class Empleado
	{
		private string apellNombre;
		private int edad;
		private string direccion;
		private int numCalle;
		private DateTime fechaIngreso;
		private float sueldoBasico;
		private float salario; 

		public Empleado(string apellNombre, int edad , string direccion , int numCalle , DateTime fechaIngreso, float sueldoBasico)
		{
			this.ApellNombre = apellNombre;
			this.Edad = edad;
			this.Direccion = direccion;
			this.NumCalle = numCalle;
			this.FechaIngreso = fechaIngreso;
			this.sueldoBasico = sueldoBasico;
		}

		public string ApellNombre { get => apellNombre; set => apellNombre = value; }
		public int Edad { get => edad; set => edad = value; }
		public string Direccion { get => direccion; set => direccion = value; }
		public int NumCalle { get => numCalle; set => numCalle = value; }
		public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
		public float Salario { get => salario; set => salario = value; }

		public int calcularAntiguedad()
		{
			int antiguedad = DateTime.Now.Year - this.fechaIngreso.Year;
			return antiguedad;
		}

		public float calcularSalario()
		{
			float adicional;
			float descuento = (float)(0.15 * this.sueldoBasico);
			if(calcularAntiguedad() < 20) {
				adicional = calcularAntiguedad() / 100 * this.sueldoBasico;
			}else {
				adicional = (float)(0.25 * this.sueldoBasico);
			}
			this.salario = this.sueldoBasico + adicional - descuento;
			return this.salario;
		}

		public void mostrarEmpleado()
		{
			Console.WriteLine("\npellido y nombre: " +this.apellNombre+ "\nedad:" +this.edad+ "\nAntiguedad: " +this.calcularAntiguedad()+ "\nSalario: " +this.calcularSalario()+ "\n");
		}

	}
}
