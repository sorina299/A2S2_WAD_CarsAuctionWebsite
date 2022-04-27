#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarsAuction.DataAcces;
using CarsAuction.AppLogic.Models;

namespace CarsAuction.Controllers
{
    public class AuctionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AuctionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Auctions
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Auctions.Include(a => a.Buyer).Include(a => a.Car).Include(a => a.Seller);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Auctions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var auction = await _context.Auctions
                .Include(a => a.Buyer)
                .Include(a => a.Car)
                .Include(a => a.Seller)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (auction == null)
            {
                return NotFound();
            }

            return View(auction);
        }

        // GET: Auctions/Create
        public IActionResult Create()
        {
            ViewData["BuyerID"] = new SelectList(_context.Users, "ID", "ID");
            ViewData["CarID"] = new SelectList(_context.Cars, "ID", "ID");
            ViewData["SellerID"] = new SelectList(_context.Users, "ID", "ID");
            return View();
        }

        // POST: Auctions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Title,Description,CurrentBid,StartingDate,EndingDate,SellerID,BuyerID,CarID")] Auction auction)
        {
            if (ModelState.IsValid)
            {
                _context.Add(auction);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BuyerID"] = new SelectList(_context.Users, "ID", "ID", auction.BuyerID);
            ViewData["CarID"] = new SelectList(_context.Cars, "ID", "ID", auction.CarID);
            ViewData["SellerID"] = new SelectList(_context.Users, "ID", "ID", auction.SellerID);
            return View(auction);
        }

        // GET: Auctions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var auction = await _context.Auctions.FindAsync(id);
            if (auction == null)
            {
                return NotFound();
            }
            ViewData["BuyerID"] = new SelectList(_context.Users, "ID", "ID", auction.BuyerID);
            ViewData["CarID"] = new SelectList(_context.Cars, "ID", "ID", auction.CarID);
            ViewData["SellerID"] = new SelectList(_context.Users, "ID", "ID", auction.SellerID);
            return View(auction);
        }

        // POST: Auctions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Title,Description,CurrentBid,StartingDate,EndingDate,SellerID,BuyerID,CarID")] Auction auction)
        {
            if (id != auction.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(auction);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AuctionExists(auction.ID))
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
            ViewData["BuyerID"] = new SelectList(_context.Users, "ID", "ID", auction.BuyerID);
            ViewData["CarID"] = new SelectList(_context.Cars, "ID", "ID", auction.CarID);
            ViewData["SellerID"] = new SelectList(_context.Users, "ID", "ID", auction.SellerID);
            return View(auction);
        }

        // GET: Auctions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var auction = await _context.Auctions
                .Include(a => a.Buyer)
                .Include(a => a.Car)
                .Include(a => a.Seller)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (auction == null)
            {
                return NotFound();
            }

            return View(auction);
        }

        // POST: Auctions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var auction = await _context.Auctions.FindAsync(id);
            _context.Auctions.Remove(auction);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AuctionExists(int id)
        {
            return _context.Auctions.Any(e => e.ID == id);
        }
    }
}
