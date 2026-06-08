using System;
using System.ComponentModel.DataAnnotations;

namespace checkpointVIII_FORMULARIO_CADASTRO_ALUNO.Models;

public class Aluno
{
    [Required(ErrorMessage = "O nome é obrigatório")]
    [StringLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres")]
    public string Nome { get; set; } = string.Empty;

    [Required(ErrorMessage = "O email é obrigatório")]
    [EmailAddress(ErrorMessage = "Informe um email válido")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "O RA é obrigatório")]
    [StringLength(20, ErrorMessage = "O RA deve ter no máximo 20 caracteres")]
    public string RA { get; set; } = string.Empty;

    [Required(ErrorMessage = "O curso é obrigatório")]
    [StringLength(60, ErrorMessage = "O curso deve ter no máximo 60 caracteres")]
    public string Curso { get; set; } = string.Empty;

    [Required(ErrorMessage = "O CEP é obrigatório")]
    [Display(Name = "CEP")]
    public string CEP { get; set; } = string.Empty;

    [Display(Name = "Logradouro")]
    public string Logradouro { get; set; } = string.Empty;

    [Display(Name = "Bairro")]
    public string Bairro { get; set; } = string.Empty;

    [Display(Name = "Cidade")]
    public string Cidade { get; set; } = string.Empty;

    [Display(Name = "UF")]
    public string UF { get; set; } = string.Empty;

    [Required(ErrorMessage = "A data de nascimento é obrigatória")]
    [DataType(DataType.Date)]
    [Display(Name = "Data de Nascimento")]
    public DateTime DataNascimento { get; set; }
}
