using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace TheSortingArena.Algoritmos;

public class SeletionSort
{
  public double[]? Bubbles { get; set;}

    public SeletionSort(double[] lista) 
    {
        Bubbles = lista;
    }

    public double[] OrderBy()
    {
        //Saber quem é o menor de todos ?
        //Quem é o menor de todos e maior que o da primeira posição ?
        var lista = this.Bubbles;
        var indiceMenorValor = 0;

        for (var x = 0; x < lista.Length; x++)
        {
            for (var i = x; i < lista.Length; i++)
            {
                if (lista[i] < lista[indiceMenorValor])
                    indiceMenorValor = i;
            }

            var temp = lista[x];
            lista[x] = lista[indiceMenorValor];
            lista[indiceMenorValor] = temp;
        }

        return lista;
    }
}
