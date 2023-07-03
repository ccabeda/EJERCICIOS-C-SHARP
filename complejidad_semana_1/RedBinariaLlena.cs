
using System;

namespace complejidad_semana_1
{
	public class RedBinariaLlena
	{
		public int altura;
    	public int retardo;
		public RedBinariaLlena(int altura, int retardo)
		{	
        this.altura =altura;
        this.retardo = retardo;
    	}

    	public int RetardoReenvio()
    	{
        int nodos = (int)Math.Pow(2, altura) - 1;
        int retardoTotal = nodos * retardo;
        return retardoTotal;
    	}

	}
}
