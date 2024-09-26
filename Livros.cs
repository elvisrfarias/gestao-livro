using System.ComponentModel.DataAnnotations;

namespace gestor_livraria;

public class Livros
{
    [Key]
    public int Id_livro {  get; set; }
    public required string Titulo { get; set; }
    public required string Autor { get; set; }
    public GeneroLivro Genero { get; set; }
    public decimal Preco { get; set; }
    public int Quantidade { get; set; }
}
