
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GestionFacultadesCarreras.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
public class CarrerasController : Controller
{
    private readonly GestionFacultadesCarrerasContext _context;

    public CarrerasController(GestionFacultadesCarrerasContext context)
    {
        _context = context;
    }

    // GET: CARRERAS

    public async Task<IActionResult> Index()
    {
        var carreras = await _context.Carrera
            .Include(c => c.Facultad)
            .ToListAsync();

        return View(carreras);
    }


    // GET: CARRERAS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }


        var carrera = await _context.Carrera
            .Include(c => c.Facultad)
            .FirstOrDefaultAsync(m => m.Id == id);

        if (carrera == null)
        {
            return NotFound();
        }

        return View(carrera);
    }

    // GET: CARRERAS/Create
    public IActionResult Create()
    {
        ViewData["FacultadId"] = new SelectList(
            _context.Set<Facultad>(),
            "Id",
            "Nombre"
        );

        return View();
    }

    // POST: CARRERAS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Nombre,DuracionSemestres,Modulacion,FacultadId")] Carrera carrera)
    {
        if (ModelState.IsValid)
        {
            _context.Add(carrera);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        ViewData["FacultadId"] = new SelectList(
            _context.Set<Facultad>(),
            "Id",
            "Nombre",
            carrera.FacultadId
        );

        return View(carrera);
    }


    // GET: CARRERAS/Edit/5

    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var carrera = await _context.Carrera.FindAsync(id);

        if (carrera == null)
        {
            return NotFound();
        }

        ViewData["FacultadId"] = new SelectList(
            _context.Set<Facultad>(),
            "Id",
            "Nombre",
            carrera.FacultadId
        );

        return View(carrera);
    }


    // POST: CARRERAS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,Nombre,DuracionSemestres,Modulacion,FacultadId")] Carrera carrera)
    {
        if (id != carrera.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(carrera);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarreraExists(carrera.Id))
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

        ViewData["FacultadId"] = new SelectList(
            _context.Set<Facultad>(),
            "Id",
            "Nombre",
            carrera.FacultadId
        );

        return View(carrera);
    }


    // GET: CARRERAS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }


        var carrera = await _context.Carrera
            .Include(c => c.Facultad)
            .FirstOrDefaultAsync(m => m.Id == id);

        if (carrera == null)
        {
            return NotFound();
        }

        return View(carrera);
    }

    // POST: CARRERAS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var carrera = await _context.Carrera.FindAsync(id);
        if (carrera != null)
        {
            _context.Carrera.Remove(carrera);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool CarreraExists(int? id)
    {
        return _context.Carrera.Any(e => e.Id == id);
    }
}
