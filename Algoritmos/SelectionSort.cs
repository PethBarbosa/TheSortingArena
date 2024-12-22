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

        for (var i = 0; i < (lista.Length - 1); i++)
        {
            if (lista[i] < lista[i + 1])
            {
                indiceMenorValor = i;
            }

 
        }

        return lista;
    }
}
