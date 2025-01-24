
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
        var lista = this.Bubbles;
        var indiceMenorValor = 0;

        for (var x = 0; x < lista.Length; x++)
        {
            for (var i = x; i < lista.Length; i++)
            {
                if (lista[i] < lista[x])
                    indiceMenorValor = i;
            }

            var temp = lista[x];
            lista[x] = lista[indiceMenorValor];
            lista[indiceMenorValor] = temp;
        }

        return lista;
    }
}
