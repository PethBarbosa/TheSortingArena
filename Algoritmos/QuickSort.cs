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
        var pivoValor = lista[lista.Length - 1];
        var  pivoIndice = lista.Length - 1;
        var indice = -1;
        for(var contador = 0; contador < lista.Length; contador ++)
        {
            if (lista[contador] > pivoValor)
            {
                indice++;
                Trocar(lista, lista[contador], pivoIndice);
                
            }    
        }

        return default(double[]);
    }

    private void Trocar(double[] lista, double a, double b)
    {

    }
}
