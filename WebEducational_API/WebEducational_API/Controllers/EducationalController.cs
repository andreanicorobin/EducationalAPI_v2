using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebEducational_API.Infrastructure.Model;

[ApiController]
[Route("api/[controller]")]
public class EstudiantesController : ControllerBase
{
    private readonly EducationalDbContext _context;

    public EstudiantesController(EducationalDbContext context)
    {
        _context = context;
    }

    // GET: api/Estudiantes
    [HttpGet]
    public async Task<IActionResult> GetEstudiantes()
    {
        var estudiantes = await _context.Estudiantes.ToListAsync();
        return Ok(estudiantes);
    }

    // POST: api/Estudiantes
    [HttpPost]
    public async Task<IActionResult> CrearEstudiante([FromBody] Estudiante estudiante)
    {
        _context.Estudiantes.Add(estudiante);
        await _context.SaveChangesAsync();
        return Ok(estudiante);
    }

    // GET: api/Estudiantes/5
    [HttpGet("{id}")]
    public async Task<IActionResult> GetEstudiante(int id)
    {
        var estudiante = await _context.Estudiantes.FindAsync(id);
        if (estudiante == null) return NotFound();
        return Ok(estudiante);
    }

    // PUT: api/Estudiantes/5
    [HttpPut("{id}")]
    public async Task<IActionResult> ActualizarEstudiante(int id, [FromBody] Estudiante estudianteActualizado)
    {
        var estudiante = await _context.Estudiantes.FindAsync(id);
        if (estudiante == null) return NotFound();

        estudiante.Nombre = estudianteActualizado.Nombre;
        await _context.SaveChangesAsync();
        return Ok(estudiante);
    }

    // DELETE: api/Estudiantes/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> EliminarEstudiante(int id)
    {
        var estudiante = await _context.Estudiantes.FindAsync(id);
        if (estudiante == null) return NotFound();

        _context.Estudiantes.Remove(estudiante);
        await _context.SaveChangesAsync();
        return Ok();
    }
}