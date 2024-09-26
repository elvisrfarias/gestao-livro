using Microsoft.AspNetCore.Mvc;

namespace gestor_livraria.Controllers;
[Route("api/[controller]")]
[ApiController]
public class LivrosController : ControllerBase
{
    [HttpGet]
    public IActionResult GetLivro(Livros livro)
    {
        return Ok(livro);
    }

    [HttpPost]
    public IActionResult Post([FromBody] Livros livro)
    {
        return Created(livro);
    }

    private IActionResult Created(Livros livro)
    {
        throw new NotImplementedException();
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] Livros livro)
    {
        return Ok(livro);
    }

    [HttpDelete("{id}")]
    public IActionResult Deletar(int id, Livros livro)
    {
        
        if (id != livro.Id_livro)
        {
            return BadRequest();
        } 

        return Ok(livro);
    }
}
