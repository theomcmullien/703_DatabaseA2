using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Assignment2.Data;
using Assignment2.Models;
using Microsoft.AspNetCore.Authorization;
using Assignment2.Core;
using Assignment2.Models.ViewDataModels;

namespace Assignment2.Controllers
{
    [Authorize(Roles = $"{Constants.Roles.Customer},{Constants.Roles.Manager},{Constants.Roles.Reception}")]
    public class BookingsController : Controller
    {
        private readonly Assignment2Context _context;

        public BookingsController(Assignment2Context context)
        {
            _context = context;
        }

        // GET: Bookings
        public async Task<IActionResult> Index()
        {
            ViewData["Accounts"] = await _context.Users.ToListAsync();
            ViewData["Rooms"] = await _context.Room.ToListAsync();

            return View(await _context.Booking.ToListAsync());
        }

        // GET: Bookings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Booking == null) return NotFound();
            var booking = await _context.Booking.FirstOrDefaultAsync(m => m.BookingID == id);
            if (booking == null) return NotFound();

            ViewData["Account"] = await _context.Users.Where(u => u.Id == booking.CustomerID).FirstAsync();
            
            Room room = await _context.Room.Where(r => r.RoomID == booking.RoomID).FirstAsync();
            Hotel hotel = await _context.Hotel.Where(h => h.HotelID == room.HotelID).FirstAsync();

            ViewData["RoomDetails"] = new RoomDetails()
            {
                HotelName = hotel.HotelName,
                RoomID = $"R{room.RoomID}",
                RoomType = room.RoomType,
                RoomDailyCost = string.Format("${0:0.00} per night", room.RoomDailyCost)
            };

            return View(booking);
        }

        // GET: Bookings/Create
        public async Task<IActionResult> Create()
        {
            List<Hotel> hotels = await _context.Hotel.ToListAsync();
            List<RoomDescription> roomDescriptions = new List<RoomDescription>();
            
            foreach (Room r in await _context.Room.Where(r => r.RoomStatus == "Vacant Clean").ToListAsync())
            {
                Hotel hotel = hotels.Where(h => h.HotelID == r.HotelID).First();

                roomDescriptions.Add(new RoomDescription()
                {
                    Room = r,
                    Description = string.Format("{0}, R{1} {2}, ${3:0.00} per night", hotel.HotelName, r.RoomID, r.RoomType, r.RoomDailyCost)
                });
            }

            ViewData["RoomDescriptions"] = roomDescriptions;

            return View();
        }

        // POST: Bookings/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BookingID,BookingStartDate,BookingEndDate,BookingIsPaid,BookingCardNumber,BookingCardExiryDate,BookingCardCCV,CustomerID,RoomID,HasCarPark")] Booking booking)
        {
            List<Hotel> hotels = await _context.Hotel.ToListAsync();
            List<RoomDescription> roomDescriptions = new List<RoomDescription>();

            foreach (Room r in await _context.Room.Where(r => r.RoomStatus == "Vacant Clean").ToListAsync())
            {
                Hotel hotel = hotels.Where(h => h.HotelID == r.HotelID).First();

                roomDescriptions.Add(new RoomDescription()
                {
                    Room = r,
                    Description = string.Format("{0}, R{1} {2}, ${3:0.00} per night", hotel.HotelName, r.RoomID, r.RoomType, r.RoomDailyCost)
                });
            }

            ViewData["RoomDescriptions"] = roomDescriptions;

            if (ModelState.IsValid)
            {
                _context.Add(booking);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(booking);
        }

        // GET: Bookings/Edit/5
        [Authorize(Roles = $"{Constants.Roles.Manager},{Constants.Roles.Reception}")]
        public async Task<IActionResult> Edit(int? id)
        {
            List<Hotel> hotels = await _context.Hotel.ToListAsync();
            List<RoomDescription> roomDescriptions = new List<RoomDescription>();

            foreach (Room r in await _context.Room.Where(r => r.RoomStatus == "Vacant Clean").ToListAsync())
            {
                Hotel hotel = hotels.Where(h => h.HotelID == r.HotelID).First();

                roomDescriptions.Add(new RoomDescription()
                {
                    Room = r,
                    Description = string.Format("{0}, R{1} {2}, ${3:0.00} per night", hotel.HotelName, r.RoomID, r.RoomType, r.RoomDailyCost)
                });
            }

            ViewData["RoomDescriptions"] = roomDescriptions;

            if (id == null || _context.Booking == null)
            {
                return NotFound();
            }

            var booking = await _context.Booking.FindAsync(id);
            if (booking == null)
            {
                return NotFound();
            }
            return View(booking);
        }

        // POST: Bookings/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = $"{Constants.Roles.Manager},{Constants.Roles.Reception}")]
        public async Task<IActionResult> Edit(int id, [Bind("BookingID,BookingStartDate,BookingEndDate,BookingIsPaid,BookingCardNumber,BookingCardExiryDate,BookingCardCCV,CustomerID,RoomID,HasCarPark")] Booking booking)
        {
            List<Hotel> hotels = await _context.Hotel.ToListAsync();
            List<RoomDescription> roomDescriptions = new List<RoomDescription>();

            foreach (Room r in await _context.Room.Where(r => r.RoomStatus == "Vacant Clean").ToListAsync())
            {
                Hotel hotel = hotels.Where(h => h.HotelID == r.HotelID).First();

                roomDescriptions.Add(new RoomDescription()
                {
                    Room = r,
                    Description = string.Format("{0}, R{1} {2}, ${3:0.00} per night", hotel.HotelName, r.RoomID, r.RoomType, r.RoomDailyCost)
                });
            }

            ViewData["RoomDescriptions"] = roomDescriptions;

            if (id != booking.BookingID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(booking);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookingExists(booking.BookingID))
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
            return View(booking);
        }

        // GET: Bookings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Booking == null)return NotFound();
            var booking = await _context.Booking.FirstOrDefaultAsync(m => m.BookingID == id);
            if (booking == null) return NotFound();

            ViewData["Account"] = await _context.Users.Where(u => u.Id == booking.CustomerID).FirstAsync();

            Room room = await _context.Room.Where(r => r.RoomID == booking.RoomID).FirstAsync();
            Hotel hotel = await _context.Hotel.Where(h => h.HotelID == room.HotelID).FirstAsync();

            ViewData["RoomDetails"] = new RoomDetails()
            {
                HotelName = hotel.HotelName,
                RoomID = $"R{room.RoomID}",
                RoomType = room.RoomType,
                RoomDailyCost = string.Format("${0:0.00} per night", room.RoomDailyCost)
            };

            return View(booking);
        }

        // POST: Bookings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Booking == null)
            {
                return Problem("Entity set 'Assignment2Context.Booking'  is null.");
            }
            var booking = await _context.Booking.FindAsync(id);

            ViewData["Account"] = await _context.Users.Where(u => u.Id == booking.CustomerID).FirstAsync();

            Room room = await _context.Room.Where(r => r.RoomID == booking.RoomID).FirstAsync();
            Hotel hotel = await _context.Hotel.Where(h => h.HotelID == room.HotelID).FirstAsync();

            ViewData["RoomDetails"] = new RoomDetails()
            {
                HotelName = hotel.HotelName,
                RoomID = $"R{room.RoomID}",
                RoomType = room.RoomType,
                RoomDailyCost = string.Format("${0:0.00} per night", room.RoomDailyCost)
            };

            if (booking != null)
            {
                _context.Booking.Remove(booking);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookingExists(int id)
        {
          return _context.Booking.Any(e => e.BookingID == id);
        }
    }
}
