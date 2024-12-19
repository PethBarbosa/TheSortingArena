
namespace TheSortingArena.Algoritmos;

public static class Filtro
{
    public static double[] Tratamento(string listaNumerica)
    {
            Console.WriteLine("Dentro do método de tratamento.");
            var conversaoArray = listaNumerica.Trim().Split(',');
            return conversaoArray.Select(x => Convert.ToDouble(x)).ToArray();
    }
}