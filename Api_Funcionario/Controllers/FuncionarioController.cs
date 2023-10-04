using Microsoft.AspNetCore.Mvc;
using Api_Funcionario.Models;
using Api_Funcionario.Data;
using Microsoft.EntityFrameworkCore;

namespace Api_Funcionario.Controllers;

[ApiController]
[Route("[controller]")]
public class FuncionarioController : ControllerBase
{
    private FuncionarioDbContext _context;

    public FuncionarioController(FuncionarioDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    [Route("listar")]
    public async Task<ActionResult<IEnumerable<Funcionario>>> Listar()
    {
        if(_context.Funcionario is null)
            return NotFound();
        return await _context.Funcionario.ToListAsync();
    }
    [HttpGet()]
    [Route("buscar/{nome}")]
    public async Task<ActionResult<Funcionario>> Buscar([FromRoute] string nome)
    {
        if(_context.Funcionario is null)
            return NotFound();
        var funcionario = await _context.Funcionario.FindAsync(nome);
        if (funcionario is null)
            return NotFound();
        return funcionario;
    }
    [HttpPost]
    [Route("cadastrar")]
    public async Task<ActionResult> Cadastrar(Funcionario funcionario)
    {
        if(_context is null) return NotFound();
        if(_context.Funcionario is null) return NotFound();
        await _context.AddAsync(funcionario);
        await _context.SaveChangesAsync();
        return Created("",funcionario);
    }
    [HttpPut()]
    [Route("alterar")]
    public async Task<ActionResult> Alterar(Funcionario funcionario)
    {
        if(_context is null) return NotFound();
        if(_context.Funcionario is null) return NotFound();
        var funcionarioTemp = await _context.Funcionario.FindAsync(funcionario.Nome);
        if(funcionarioTemp is null) return NotFound();       
        _context.Funcionario.Update(funcionario);
        await _context.SaveChangesAsync();
        return Ok();
    }
    [HttpDelete()]
    [Route("excluir/{nome}")]
    public async Task<ActionResult> Excluir(string nome)
    {
        if(_context is null) return NotFound();
        if(_context.Funcionario is null) return NotFound();
        var funcionarioTemp = await _context.Funcionario.FindAsync(nome);
        if(funcionarioTemp is null) return NotFound();
        _context.Remove(funcionarioTemp);
        await _context.SaveChangesAsync();
        return Ok();
    }
}





