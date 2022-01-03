using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto10._12
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int cantidad = 10;
                int valor, posicion;
                int negativo = 0;
                int positivo = 0;
                int multiplode15 = 0;
                int acumulado = 0;

                for (int i = 0; i < cantidad; i++)
                {
                    posicion = i + 1;
                    Console.Write("Ingresa el valor #" + posicion + ": ");
                    valor = int.Parse(Console.ReadLine());

                    if (valor < 0)
                    {
                        negativo = negativo + 1;
                    }
                    else
                    {
                        positivo = positivo + 1;
                    }

                    if(valor%15==0)
                    {
                        multiplode15 = multiplode15 + 1;
                    }

                    if(valor%2==0)
                    {
                        acumulado = acumulado + valor;
                    }
                }
                Console.WriteLine("Hay "+positivo+" numeros positivos, "+negativo+" numeros negativos, "+multiplode15+" multiplos de 15 y el acumulado " +
                    "de los pares es "+acumulado);
            }
            catch (Exception)
            {
                Console.WriteLine("Ha introducido un dato invalido.");                
            }
            Console.ReadKey();
        }
    }
}
