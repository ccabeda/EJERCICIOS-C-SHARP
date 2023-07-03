using System;
using System.Collections.Generic;

namespace tp7
{
	/// <summary>
	/// Description of Grafo.
	/// </summary>
	public class Grafo<T>
	{
		public Grafo()
		{
		}
		
		private List<Vertice<T>>vertices = new List<Vertice<T>>();
	
		public void agregarVertice(Vertice<T> v) {
			v.setPosicion(vertices.Count + 1);
			vertices.Add(v);
		}

		public void eliminarVertice(Vertice<T> v) {
			vertices.Remove(v);
		}

		public void conectar(Vertice<T> origen, Vertice<T> destino, int peso) {
			origen.getAdyacentes().Add(new Arista<T>(destino,peso));
		}

		public void desConectar(Vertice<T> origen, Vertice<T> destino) {
			Arista<T> arista = origen.getAdyacentes().Find(a => a.getDestino().Equals(destino));
			origen.getAdyacentes().Remove(arista);
		}

	
		public List<Vertice<T>> getVertices() {
			return vertices;
		}

	
		public Vertice<T> vertice(int posicion) {
			return this.vertices[posicion];
		}
	

		public void DFS(Vertice<T> origen,) {
		}
		
		public void BFS(Vertice<T> origen, int distancia) {
			// inicialización de la cola y del vector de visitados
        Queue<Vertice<T>> cola = new Queue<Vertice<T>>();
        bool[] visitados = new bool[vertices.Count];
        List<Vertice<T>> verticesDistancia = new List<Vertice<T>>();

        // marcamos el vértice origen como visitado y lo agregamos a la cola
        visitados[origen.getPosicion() - 1] = true;
        cola.Enqueue(origen);

        // ejecutamos el BFS
        int nivel = 0;
        while (cola.Count > 0)
        {
            int tamano = cola.Count;
            for (int i = 0; i < tamano; i++)
            {
                Vertice<T> v = cola.Dequeue();
                if (nivel == distancia)
                {
                    verticesDistancia.Add(v);
                }
                foreach (Arista<T> arista in v.getAdyacentes())
                {
                    Vertice<T> w = arista.getDestino();
                    if (!visitados[w.getPosicion() - 1])
                    {
                        visitados[w.getPosicion() - 1] = true;
                        cola.Enqueue(w);
                    }
                }
            }
            nivel++;
        }

        return verticesDistancia;
		}
		
		
	}
}
