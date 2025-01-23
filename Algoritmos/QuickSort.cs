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
        OrdenarRecursivo(lista, 0, lista.Length - 1);

        return lista;
    }

    private void OrdenarRecursivo(double[] lista, int indiceInicial, int IndicePivo)
    {
  
        var indice = indiceInicial - 1;
        var pivo = lista[IndicePivo];

        for (var cont = indiceInicial; cont <= IndicePivo; cont++)
        {
            if (lista[cont] <= pivo)
            {
                indice++;
                Trocar(lista, indice, cont);
            }
        }
        
        if(indice != IndicePivo)
            OrdenarRecursivo( lista, indiceInicial, indice);
        if (indice < IndicePivo)
            OrdenarRecursivo( lista, indice + 1, IndicePivo);

    }

    private void Trocar(double[] lista, int indiceAtual, int indicaValorEncontrado)
    {
        var temp = lista[indiceAtual];
        lista[indiceAtual] = lista[indicaValorEncontrado];
        lista[indicaValorEncontrado] = temp;
    }
}
