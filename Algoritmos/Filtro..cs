
namespace TheSortingArena.Algoritmos;

public static class Filtro
{
    public static double[] Tratamento(string listaNumerica)
    {
            var conversaoArray = listaNumerica.Trim().Split(',');
            return conversaoArray.Select(x => Convert.ToDouble(x)).ToArray();
    }
}