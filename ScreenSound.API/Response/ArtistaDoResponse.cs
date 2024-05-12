namespace ScreenSound.API.Response;

public record ArtistaDoResponse(int Id, string Nome, string Bio, string? FotoPerfil) 
{
    public double?  Classificacao { get; set; }
};