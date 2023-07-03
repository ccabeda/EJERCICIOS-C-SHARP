using System;
using System.Collections.Generic; 
namespace complejidad_semana_1
{
	public class ArbolBinario<T>
	{
		
	
		private T dato;
		private ArbolBinario<T> hijoIzquierdo;
		private ArbolBinario<T> hijoDerecho;
	
		
		public ArbolBinario(T dato) {
			this.dato = dato;
		}
	
		public T getDatoRaiz() {
			return this.dato;
		}
	
		public ArbolBinario<T> getHijoIzquierdo() {
			return this.hijoIzquierdo;
		}
	
		public ArbolBinario<T> getHijoDerecho() {
			return this.hijoDerecho;
		}
	
		public void agregarHijoIzquierdo(ArbolBinario<T> hijo) {
			this.hijoIzquierdo=hijo;
		}
	
		public void agregarHijoDerecho(ArbolBinario<T> hijo) {
			this.hijoDerecho=hijo;
		}
	
		public void eliminarHijoIzquierdo() {
			this.hijoIzquierdo=null;
		}
	
		public void eliminarHijoDerecho() {
			this.hijoDerecho=null;
		}
	
		public int ContarHojas() {			
			if (this.hijoIzquierdo == null && this.hijoDerecho == null)
    		{
        		return 1;
    		}
    		else
    		{
        		int hojasIzquierdo = 0;
        		int hojasDerecho = 0;
        		if (this.hijoIzquierdo != null)
        		{
            		hojasIzquierdo = this.hijoIzquierdo.ContarHojas();
        		}
        		if (this.hijoDerecho != null)
        		{
            		hojasDerecho = this.hijoDerecho.ContarHojas();
        		}
        		return hojasIzquierdo + hojasDerecho;
    }
}
		
		// ejercicio 1
		// creamos incluye
		public bool incluye(T elemento)
   		{           
        	 if (this.dato.Equals(elemento)) //si el dato es igual al elemento buscado retorna true
    		{
        		return true;
    		}
    		if (this.hijoIzquierdo != null && this.hijoIzquierdo.incluye(elemento)) //se busca en los hijos ver si el dato es igual al pedido
    		{
        		return true;
    		}
    	if (this.hijoDerecho != null && this.hijoDerecho.incluye(elemento))
    	{
        	return true;
    	}
    	return false;
		}
		//agregamos la función que recorre inorden un arbol binario
		public void inorden() {
			if (this.hijoIzquierdo != null) //si el hijo izq no es null
			{ 
				this.hijoIzquierdo.inorden(); //hacemos la recursividad 
			}
			Console.WriteLine(this.dato); //escribimos la raiz
			if (this.hijoDerecho != null) //si el hijo der no es null
			{ 
				this.hijoDerecho.inorden(); //hacemos la recursividad
			}
			
		}
		
		public void preorden() { //funcion pre
			Console.WriteLine(this.dato); //escribimos raiz
			if (hijoIzquierdo != null) // si el hijo izq no es nulo
			{
				hijoIzquierdo.preorden(); //recursividad
			}
			if (hijoDerecho != null) //si el hijo der no es nulo 
			{
				hijoDerecho.preorden(); //recursividad
			}
		}
		
		public void postorden() {
			if (hijoIzquierdo != null) 	
			{
        		hijoIzquierdo.postorden();
    		}
    		if (hijoDerecho != null) 
    		{
        		hijoDerecho.postorden();
  			}
    		Console.WriteLine(this.dato);
		
		}
		
		public void recorridoPorNiveles() { //por niveles
			Queue<ArbolBinario<T>> cola = new Queue<ArbolBinario<T>>(); //creamos una cola 
    		cola.Enqueue(this); //encolamos el dato
    		while (cola.Count > 0) { 
        		ArbolBinario<T> actual = cola.Dequeue();
        		Console.WriteLine(actual.getDatoRaiz());

        		if (actual.getHijoIzquierdo() != null) {
            		cola.Enqueue(actual.getHijoIzquierdo());
        		}

        		if (actual.getHijoDerecho() != null) {
            		cola.Enqueue(actual.getHijoDerecho());
        		}
    		}
		}
		
	
		public int esHojas() {
			return 0;
		}
		
		public void entreNiveles(int n, int m) {
   		
    	}
	}
}