using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Assignment2.Data;
using Assignment2.Models;

namespace Assignment2.Controllers
{
    public class RoomsController : Controller
    {
        private readonly Assignment2Context _context;

        public RoomsController(Assignment2Context context)
        {
            _context = context;
        }

        // GET: Rooms
        public async Task<IActionResult> Index()
        {
            ViewData["Hotels"] = await _context.Hotel.ToListAsync();

            return View(await _context.Room.ToListAsync());
        }

        // GET: Rooms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Room == null)return NotFound();
            var room = await _context.Room.FirstOrDefaultAsync(m => m.RoomID == id);
            if (room == null)return NotFound();

            ViewData["Hotel"] = await _context.Hotel.Where(h => h.HotelID == room.HotelID).FirstAsync();

            return View(room);
        }

        // GET: Rooms/Create
        public async Task<IActionResult> Create()
        {
            ViewData["Hotels"] = await _context.Hotel.ToListAsync();

            return View();
        }
        
        // POST: Rooms/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RoomID,RoomDailyCost,RoomType,RoomStatus,HotelID")] Room room)
        {
            ViewData["Hotels"] = await _context.Hotel.ToListAsync();

            if (ModelState.IsValid)
            {
                _context.Add(room);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(room);
        }

        // GET: Rooms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Room == null) return NotFound();
            var room = await _context.Room.FindAsync(id);
            if (room == null) return NotFound();

            ViewData["Hotels"] = await _context.Hotel.ToListAsync();

            return View(room);
        }

        // POST: Rooms/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RoomID,RoomDailyCost,RoomType,RoomStatus,HotelID")] Room room)
        {
            if (id != room.RoomID) return NotFound();

            ViewData["Hotels"] = await _context.Hotel.ToListAsync();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(room);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoomExists(room.RoomID))
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
            return View(room);
        }

        // GET: Rooms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Room == null)return NotFound();
            var room = await _context.Room.FirstOrDefaultAsync(m => m.RoomID == id);
            if (room == null)return NotFound();

            ViewData["Hotel"] = await _context.Hotel.Where(h => h.HotelID == room.HotelID).FirstAsync();

            return View(room);
        }

        // POST: Rooms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Room == null)
            {
                return Problem("Entity set 'Assignment2Context.Room'  is null.");
            }
            var room = await _context.Room.FindAsync(id);
            if (room != null)
            {
                _context.Room.Remove(room);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoomExists(int id)
        {
          return _context.Room.Any(e => e.RoomID == id);
        }
    }
}
