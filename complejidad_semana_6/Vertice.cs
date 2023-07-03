using System;
using System.Collections.Generic;

namespace tp7
{
	/// <summary>
	/// Description of Vertice.
	/// </summary>
	public class Vertice<T>
	{
		public Vertice()
		{
		}
		
		private List<Arista<T>> adyacentes; 
    
		private T dato;
    
		private int posicion;
	
	    public Vertice(T d){
			dato = d;
			adyacentes = new List<Arista<T>>();
			
		}
    
		public T getDato() {
			return dato;
		}

		public void setDato(T unDato) {
			dato = unDato;
		}

		
		public int getPosicion() {
			return posicion;
		}
	
		public List<Arista<T>> getAdyacentes(){
			return adyacentes;
		}
	
		
		public void setPosicion(int pos){
			posicion = pos; 
		}

		
		
	}
}
