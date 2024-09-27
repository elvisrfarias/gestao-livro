using Microsoft.AspNetCore.Mvc;

namespace gestor_livraria.Controllers;
[Route("api/[controller]")]
[ApiController]
public class LivrosController : ControllerBase
{
    [HttpGet]
    public IActionResult GetLivro()
    {
        var listaLivros = new List<Livros>()
        {
            new Livros(){Id_livro = 1, Titulo = "Teste 1" , Autor = "Elvis 1", Genero = "Romance", Preco = 4, Quantidade = 2 },
            new Livros(){Id_livro = 2, Titulo = "Teste 2" , Autor = "Elvis 2", Genero = "Drama", Preco = 10, Quantidade = 4 },
            new Livros(){Id_livro = 3, Titulo = "Teste 3" , Autor = "Elvis 3", Genero = "Suspense", Preco = 77.10, Quantidade = 45 },
            new Livros(){Id_livro = 4, Titulo = "Teste 4" , Autor = "Elvis 4", Genero = "Romance", Preco = 10, Quantidade = 9 },
            new Livros(){Id_livro = 5, Titulo = "Teste 5" , Autor = "Elvis 5", Genero = "FiccaoCientifica", Preco = 184.30, Quantidade = 7 }
        };

        return Ok(listaLivros);
    }

    [HttpPost]
    public IActionResult Post([FromBody] Livros novoLivro)
    {
        var listaLivros = new List<Livros>()
        {
            new (){Id_livro = 1, Titulo = "Teste 1" , Autor = "Elvis 1", Genero = "Romance", Preco = 4, Quantidade = 2 },
            new (){Id_livro = 2, Titulo = "Teste 2" , Autor = "Elvis 2", Genero = "Drama", Preco = 10, Quantidade = 4 },
            new (){Id_livro = 3, Titulo = "Teste 3" , Autor = "Elvis 3", Genero = "Suspense", Preco = 77.10, Quantidade = 45 },
            new (){Id_livro = 4, Titulo = "Teste 4" , Autor = "Elvis 4", Genero = "Romance", Preco = 10, Quantidade = 9 },
            new (){Id_livro = 5, Titulo = "Teste 5" , Autor = "Elvis 5", Genero = "FiccaoCientifica", Preco = 184.30, Quantidade = 7 }
        };

        if (novoLivro == null) return BadRequest("Livro não pode ser nulo.");

        listaLivros.Add(novoLivro);

        return CreatedAtAction(nameof(Post), new { id = novoLivro.Id_livro }, novoLivro);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] Livros livro)
    {
        var listaLivros = new List<Livros>()
        {
            new (){Id_livro = 1, Titulo = "Teste 1" , Autor = "Elvis 1", Genero = "Romance", Preco = 4, Quantidade = 2 },
            new (){Id_livro = 2, Titulo = "Teste 2" , Autor = "Elvis 2", Genero = "Drama", Preco = 10, Quantidade = 4 },
            new (){Id_livro = 3, Titulo = "Teste 3" , Autor = "Elvis 3", Genero = "Suspense", Preco = 77.10, Quantidade = 45 },
            new (){Id_livro = 4, Titulo = "Teste 4" , Autor = "Elvis 4", Genero = "Romance", Preco = 10, Quantidade = 9 },
            new (){Id_livro = 5, Titulo = "Teste 5" , Autor = "Elvis 5", Genero = "FiccaoCientifica", Preco = 184.30, Quantidade = 7 }
        };

        // Encontra o livro na lista baseado no ID
        var livroExistente = listaLivros.FirstOrDefault(l => l.Id_livro == id);

        // Se não encontrar o livro, retorna 404
        if (livroExistente == null)
            return NotFound("Livro não encontrado.");

        // Atualiza os valores do livro existente com os novos dados
        livroExistente.Titulo = livro.Titulo;
        livroExistente.Autor = livro.Autor;
        livroExistente.Genero = livro.Genero;
        livroExistente.Preco = livro.Preco;
        livroExistente.Quantidade = livro.Quantidade;

        // Retorna o livro atualizado
        return Ok(livroExistente);
    }

    [HttpDelete("{id}")]
    public IActionResult Deletar(int id, Livros livro)
    {
        var listaLivros = new List<Livros>()
        {
            new (){Id_livro = 1, Titulo = "Teste 1" , Autor = "Elvis 1", Genero = "Romance", Preco = 4, Quantidade = 2 },
            new (){Id_livro = 2, Titulo = "Teste 2" , Autor = "Elvis 2", Genero = "Drama", Preco = 10, Quantidade = 4 },
            new (){Id_livro = 3, Titulo = "Teste 3" , Autor = "Elvis 3", Genero = "Suspense", Preco = 77.10, Quantidade = 45 },
            new (){Id_livro = 4, Titulo = "Teste 4" , Autor = "Elvis 4", Genero = "Romance", Preco = 10, Quantidade = 9 },
            new (){Id_livro = 5, Titulo = "Teste 5" , Autor = "Elvis 5", Genero = "FiccaoCientifica", Preco = 184.30, Quantidade = 7 }
        };

        // Encontra o livro na lista baseado no ID
        var livroExistente = listaLivros.FirstOrDefault(l => l.Id_livro == id);

        // Se não encontrar o livro, retorna 404
        if (livroExistente == null)
        {
            return NotFound("Livro não encontrado.");
        }

        // Remove o livro da lista
        listaLivros.Remove(livroExistente);

        // Retorna uma resposta NoContent (204) para deletar com sucesso
        return NoContent();
    }
}
