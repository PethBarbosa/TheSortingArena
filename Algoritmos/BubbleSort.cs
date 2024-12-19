namespace TheSortingArena.Algoritmos;

public class BubbleSort
{
  public double[]? Bubbles { get; set;}

    public BubbleSort(IEnumerable<double> lista) 
    {
        Bubbles = lista.ToArray();
    }

    public double[] OrderBy(double[] lista)
    {
        var contemAlteracao = false;
        do
        {
            if (contemAlteracao)
                contemAlteracao = false;

            for (var i = 0; i < lista.Length; i++)
            {
                if (lista[i] > lista[i + 1])
                {
                    var temp = lista[i];
                    lista[i] = lista[i + 1];
                    lista[i + 1] = temp;
                    contemAlteracao = true;
                }         
            }

        }while(contemAlteracao);
        
         return lista;
    }
}