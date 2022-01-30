#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AgendaOficialQuarta26.Models;

namespace AgendaOficialQuarta26.Controllers
{
    public class AgendasController : Controller
    {
        private readonly Contexto _context;

        public AgendasController(Contexto context)
        {
            _context = context;
        }

        // GET: Agendas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Agenda.ToListAsync());
        }

        // GET: Agendas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var agenda = await _context.Agenda
                .FirstOrDefaultAsync(m => m.Id == id);
            if (agenda == null)
            {
                return NotFound();
            }

            return View((Agenda)agenda);
        }

        // GET: Agendas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Agendas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nome")] Agenda agenda)
        {


            _context.Add(agenda);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));


        }

        // GET: Agendas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var agenda = await _context.Agenda.FindAsync(id);

            if (agenda == null)
            {
                return NotFound();
            }

            return View((Agenda)agenda);
        }

        // POST: Agendas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome")] Agenda agenda)
        {
            if (id != agenda.Id)
            {
                return NotFound();
            }

            try
            {
                _context.Update(agenda);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateConcurrencyException)
            {
                return View(agenda);
            }



        }

        // GET: Agendas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var agenda = await _context.Agenda
                .FirstOrDefaultAsync(m => m.Id == id);

            if (agenda == null)
            {
                return NotFound();
            }

            return View((Agenda)agenda);
        }

        // POST: Agendas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var agenda = await _context.Agenda.FindAsync(id);
            _context.Agenda.Remove(agenda);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
