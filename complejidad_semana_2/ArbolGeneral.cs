using System;
using System.Collections.Generic;

namespace tp2
{
	public class ArbolGeneral<T>
	{
		
		private T dato;
		private List<ArbolGeneral<T>> hijos = new List<ArbolGeneral<T>>();

		public ArbolGeneral(T dato) {
			this.dato = dato;
		}
	
		public T getDatoRaiz() {
			return this.dato;
		}
	
		public List<ArbolGeneral<T>> getHijos() {
			return hijos;
		}
	
		public void agregarHijo(ArbolGeneral<T> hijo) {
			this.getHijos().Add(hijo);
		}
	
		public void eliminarHijo(ArbolGeneral<T> hijo) {
			this.getHijos().Remove(hijo);
		}
	
		public bool esHoja() {
			return this.getHijos().Count == 0;
		}
	
		public int altura() {
			if (esHoja())
			{
				return 0;
			}
			else
			{
				int maxAltura =0;
				foreach (ArbolGeneral<T> hijo in hijos)
				{
					int alturaHijo = hijo.altura();
					if (alturaHijo > maxAltura)
					{
						maxAltura = alturaHijo;
					}
				}
				return maxAltura +1;
			}
		}
	
		
		public int nivel(T dato) {
			return 0;
		}
	
	}
}
