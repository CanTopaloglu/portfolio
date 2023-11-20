namespace Server.WebApi.Models;

public sealed class Skill
{
    public Guid Id { get; set; }
    public string ImageUrl { get; set; }
    public byte[] Image {  get; set; }
    public int Order { get; set; }
}


//Dosya saklamak 3 yol

//mevcut bir klasöre saklamak
//Başka bir sunucuya saklama //ftp ye kaydetmek oluyor
//Database saklama
