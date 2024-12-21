using Microsoft.AspNetCore.Mvc;
using TheSortingArena.Algoritmos;
using TheSortingArena.Entidades;
using System.Diagnostics;

namespace TheSortingArena.Controllers;

[Route("algoritmos")]
public class AlgoritmosController : ControllerBase
{
    [HttpPost]
    public IActionResult Processar([FromBody] Conjunto listaNumerica)
    {
        try
        {
            var listaValida = Filtro.Tratamento(listaNumerica.lista ?? "");
            var bodyRetorno = new Dictionary<string, string>();
            var temporizador = new Stopwatch();

            if (listaNumerica.TipoAlgoritmo == TipoAlgoritmo.BubbleSort)
            {
                var conjunto = new BubbleSort(listaValida){};
                temporizador.Start();
                var listaOrdenada = conjunto.OrderBy();
                temporizador.Stop();

                bodyRetorno.Add("conjunto", string.Join(",", listaOrdenada));
                bodyRetorno.Add("tempoMs", $"{ temporizador.ElapsedMilliseconds} ms");
                bodyRetorno.Add("tempoTicks", $"{temporizador.ElapsedTicks} ticks");

                return Ok(bodyRetorno);
            }

            return StatusCode(200);
        
        }catch(Exception ex)
        {
            return StatusCode(500);
        }
    }
}