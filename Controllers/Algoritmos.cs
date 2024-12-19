using Microsoft.AspNetCore.Mvc;
using TheSortingArena.Algoritmos;
using TheSortingArena.Entidades;

namespace TheSortingArena.Controllers;

[Route("algoritmos")]
public class AlgoritmosController : ControllerBase
{
    [HttpPost]
    public IActionResult Processar([FromBody] Conjunto listaNumerica)
    {
        try
        {
            Console.WriteLine("Acessando a controller");
            var listaValida = Filtro.Tratamento(listaNumerica.lista);

            if (listaNumerica.TipoAlgoritmo == TipoAlgoritmo.BubbleSort)
            {
                var listaBubble = new BubbleSort(listaValida){};
                Console.WriteLine(listaBubble.OrderBy(listaBubble.Bubbles));
            }

            return StatusCode(200);
        
        }catch(Exception ex)
        {
            return new ContentResult();
        }
    }
}