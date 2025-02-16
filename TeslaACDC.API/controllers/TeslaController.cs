namespace TeslaACDC.Controllers;

using TeslaACDC.Business.Services;
using TeslaACDC.Data.Models; 
using Microsoft.AspNetCore.Mvc;
using TeslaACDC.Bussines.Interfaces;

[ApiController]
[Route("api/[controller]")]

public class TeslaController : ControllerBase
{
    private readonly IAlbumService _albumService;

    public TeslaController(IAlbumService albumService)
    {
        _albumService = albumService;
    }


    [HttpGet]
    [Route("GetAlbum")]
public async Task<IActionResult> GetAlbum()
    {
        
        var lista = await _albumService.GetList();
        return Ok(lista);
    }

    [HttpPost]
    [Route("ReciboValor")]

    public async Task<IActionResult> ReciboValor([FromBody] string album)
    {
        return Ok(album); 
    }
}