namespace JWTAuthDotNET.Models
{
    public class TokenReponseDto
    {
       public required string Accesstoken { get; set; }
       public required string Refreshtoken { get; set; }
    }
}
