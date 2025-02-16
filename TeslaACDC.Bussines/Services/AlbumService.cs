using System;
using TeslaACDC.Bussines.Interfaces;
using TeslaACDC.Data.Models;

namespace TeslaACDC.Business.Services;

public class AlbumService : IAlbumService
{
    public Task<List<Album>> AddAlbum => throw new NotImplementedException();

    public async Task<List<Album>> GetList()
    {
        Album album = new ()
        {
          Name= "Metallica",
          Genre = "Rock",
          Year = 2022
        };
        return new List<Album> { album };
    }

}
