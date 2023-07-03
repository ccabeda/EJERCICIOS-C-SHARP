using System;

namespace tp7
{
	/// <summary>
	/// Description of Arista.
	/// </summary>
	public class Arista<T>
	{
		private Vertice<T> destino;
		private int peso;
	
		public Arista(Vertice<T> dest, int p){
				destino = dest;
				peso = p;
		}
		
		public Vertice<T> getDestino() {
			return destino;
		}
		
		public int getPeso() {
			return peso;
		}
		
		public void setDestino(Vertice<T> destino) {
			this.destino= destino;
		}
		
		public void setPeso(int peso) {
			this.peso = peso;
		}
	
	}
}
