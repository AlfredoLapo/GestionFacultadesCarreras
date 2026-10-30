
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GestionFacultadesCarreras.Models;

public class FacultadesController : Controller
{
    private readonly GestionFacultadesCarrerasContext _context;

    public FacultadesController(GestionFacultadesCarrerasContext context)
    {
        _context = context;
    }

    // GET: FACULTADS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.Facultad.ToListAsync());
    }

    // GET: FACULTADS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var facultad = await _context.Facultad
            .FirstOrDefaultAsync(m => m.Id == id);
        if (facultad == null)
        {
            return NotFound();
        }

        return View(facultad);
    }

    // GET: FACULTADS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: FACULTADS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Nombre,Telefono_Contacto,Carreras")] Facultad facultad)
    {
        if (ModelState.IsValid)
        {
            _context.Add(facultad);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(facultad);
    }

    // GET: FACULTADS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var facultad = await _context.Facultad.FindAsync(id);
        if (facultad == null)
        {
            return NotFound();
        }
        return View(facultad);
    }

    // POST: FACULTADS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,Nombre,Telefono_Contacto,Carreras")] Facultad facultad)
    {
        if (id != facultad.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(facultad);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FacultadExists(facultad.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }
        return View(facultad);
    }

    // GET: FACULTADS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var facultad = await _context.Facultad
            .FirstOrDefaultAsync(m => m.Id == id);
        if (facultad == null)
        {
            return NotFound();
        }

        return View(facultad);
    }

    // POST: FACULTADS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var facultad = await _context.Facultad.FindAsync(id);
        if (facultad != null)
        {
            _context.Facultad.Remove(facultad);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool FacultadExists(int? id)
    {
        return _context.Facultad.Any(e => e.Id == id);
    }
}
