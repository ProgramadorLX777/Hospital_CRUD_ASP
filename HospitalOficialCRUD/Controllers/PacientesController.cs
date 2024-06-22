using Microsoft.AspNetCore.Mvc;
using HospitalOficialCRUD.Data;
using HospitalOficialCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalOficialCRUD.Controllers
{
    public class PacientesController : Controller
    {
        private readonly AppDBContext _appDbContext;
        public PacientesController(AppDBContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        // Retornar lista de pacientes
        [HttpGet]
        public async Task<IActionResult> Lista()
        {
            List<Pacientes> lista = await _appDbContext.Pacientes.ToListAsync();
            return View(lista);
        }

        // Crear Pacientes mediante Método GET
        [HttpGet]
        public IActionResult Nuevo()
        {
            return View();
        }

        // Crear Pacientes mediante Método POST
        [HttpPost]
        public async Task<IActionResult> Nuevo(Pacientes pacientes)
        {
            await _appDbContext.Pacientes.AddAsync(pacientes);
            await _appDbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Lista));
        }

        // Editar pacientes mediante ID:
        [HttpGet]
        public async Task<IActionResult> Editar(int idPaciente)
        {
            Pacientes pacientes = await _appDbContext.Pacientes.FirstAsync(p => p.IdPaciente == idPaciente);
            return View(pacientes);
        }

        [HttpPost]
        public async Task<IActionResult> Editar(Pacientes pacientes)
        {
            _appDbContext.Pacientes.Update(pacientes);
            await _appDbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Lista));
        }

        // Eliminar pacientes mediante ID:
        [HttpGet]
        public async Task<IActionResult> Eliminar(int idPaciente)
        {
            Pacientes pacientes = await _appDbContext.Pacientes.FirstAsync(p => p.IdPaciente == idPaciente);
            _appDbContext.Pacientes.Remove(pacientes);
            await _appDbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Lista));
        }
    }
}