//Agregue a la clase ArbolBinario el siguiente método:
// - contarHojas() #devuelve la cantidad de subárboles hojas del árbol receptor.


using System;

namespace complejidad_semana_1
{
	 class Program
    {
        static void Main(string[] args)
        {
ArbolBinario<int> arbol = new ArbolBinario<int>(1); //raiz del arbol
arbol.agregarHijoIzquierdo(new ArbolBinario<int>(2)); //agregamos hijo izq
arbol.agregarHijoDerecho(new ArbolBinario<int>(3)); //agregamos hijo der
arbol.getHijoIzquierdo().agregarHijoIzquierdo(new ArbolBinario<int>(4)); //agregamos hijoizq al hijo izq
arbol.getHijoDerecho().agregarHijoDerecho(new ArbolBinario<int>(5)); //agregamos hijoder al hijo der
RedBinariaLlena red = new RedBinariaLlena(5,3);



Console.Write("Inorden: ");
arbol.inorden();
Console.WriteLine("");
Console.Write("Preorden: ");
arbol.preorden();
Console.WriteLine("");
Console.Write("Postorden: ");
arbol.postorden();
Console.Write("Por niveles: ");
arbol.recorridoPorNiveles();
Console.WriteLine("");
Console.WriteLine("El arbol tiene : {0} hojas", arbol.ContarHojas());
int retardototal = red.RetardoReenvio();
Console.WriteLine("El retardo es de : {0} segundos", retardototal);
Console.ReadLine();
        }
	 }
}