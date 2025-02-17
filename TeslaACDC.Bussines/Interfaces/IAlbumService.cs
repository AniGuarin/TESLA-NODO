namespace TeslaACDC.Bussines.Interfaces;

using TeslaACDC.Data.Models;

public interface IAlbumService
{
    Task<List<Album>> GetList();
    Task<List<Album>> AddAlbum { get; }
}