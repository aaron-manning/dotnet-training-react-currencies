using System.ComponentModel.DataAnnotations;

namespace audBackEnd.Models;

public class CurrencyItem 
{
    [Key]
    public int Timestamp { get; set; }
    public string? Name{ get; set; }
    public string? moneyCode{ get; set; }
    public float baseValue { get; set; }
    public float value { get; set; }
}