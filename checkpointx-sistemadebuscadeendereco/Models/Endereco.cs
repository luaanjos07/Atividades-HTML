using System.ComponentModel.DataAnnotations;

namespace checkpointx_sistemadebuscadeendereco.Models;

public class Endereco
{
    [Required(ErrorMessage = "O CEP é obrigatório")]
    [Display(Name = "CEP")]
    [RegularExpression(@"\d{8}", ErrorMessage = "Informe um CEP válido com 8 dígitos.")]
    public string CEP { get; set; } = string.Empty;

    [Display(Name = "Logradouro")]
    public string Logradouro { get; set; } = string.Empty;

    [Display(Name = "Bairro")]
    public string Bairro { get; set; } = string.Empty;

    [Display(Name = "Cidade")]
    public string Cidade { get; set; } = string.Empty;

    [Display(Name = "UF")]
    public string UF { get; set; } = string.Empty;
}
