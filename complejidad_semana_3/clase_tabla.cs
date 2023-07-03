
using System;
using System.Collections.Generic;

namespace complejidad_semana_3
{

	public class TablaHash
{
    
    private int tam;
    private List<Empleado>[] tabla;

    public TablaHash(int tam)
    {
        this.tam = tam;
        tabla = new List<Empleado>[tam];
        for (int i = 0; i < tam; i++)
        {
            tabla[i] = new List<Empleado>();
        }
    }

    private int hash(int dni)
    {
        return dni % tam;
    }

    public void Insertar(Empleado empleado)
    {
        int posicion = hash(empleado.dni);
        tabla[posicion].Add(empleado);
    }

    public Empleado Buscar(string buscar)
    {
        // Recorre todas las posiciones de la tabla hash
        for (int i = 0; i < tam; i++)
        {
            // Recorre todas los empleados en la posición actual
            foreach (Empleado empleado in tabla[i])
            {
                // Si el DNI del empleado es igual al valor buscado, lo retorna
                if (empleado.dni.ToString() == buscar)
                {
                    return empleado;
                }
            }
        }
        return null;
    }

    public Empleado Eliminar(int dni)
    {
        int posicion = hash(dni);

        // Recorre todas los empleados en la posición correspondiente
        for (int i = 0; i < tabla[posicion].Count; i++)
        {
            Empleado empleado = tabla[posicion][i];
            // Si el DNI del empleado es igual al valor buscado, lo elimina
            if (empleado.dni == dni)
            {
                tabla[posicion].RemoveAt(i);
                return empleado;
            }
        }

        return null;
    }
    }  
    }

