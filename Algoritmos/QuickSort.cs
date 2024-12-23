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

        return lista;
    }

    private double[] OrdenarRecursivo(double[] lista)
    {

        return default(double[]);
    }
}
