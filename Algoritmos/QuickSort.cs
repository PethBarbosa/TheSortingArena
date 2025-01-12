using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace TheSortingArena.Algoritmos;

public class QuickSort
{
  public double[]? Bubbles { get; set;}

    public QuickSort(double[] lista) 
    {
        Bubbles = lista;
    }

    public double[] OrderBy()
    {
        var lista = this.Bubbles;
        var listaOrdenada = OrdenarRecursivo(lista);

        return listaOrdenada;
    }

    private double[] OrdenarRecursivo(double[] lista)
    {
        var indicePivo = 0;
        var direita = new double[lista.Length / 2];
        var esquerda = new double[lista.Length / 2 ];
        var contadorEsquerda = lista.Length - 1;

        for (var contadorDireita = 0; contadorDireita < lista[indicePivo]; contadorDireita++)
        {
            if (lista[contadorEsquerda] < indicePivo)
            {
                var temp = lista[contadorEsquerda];
                
            }
        }

        return default(double[]);
    }
}
