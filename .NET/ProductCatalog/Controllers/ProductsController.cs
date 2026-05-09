using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProductCatalog.Data;
using ProductCatalog.Models;

namespace ProductCatalog.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Products.Include(p => p.Category);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // 1. GET: Products/Create
        // This action ONLY loads the empty form page.
        [HttpGet]
        public IActionResult Create()
        {
            // Changed "Id" to "Name" so the dropdown shows the Category Name instead of just the Number
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name");
            return View();
        }

        // 2. POST: Products/Create
        // This action ONLY runs when you click the "Create" button on the form.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,Price,CategoryId")] Product product, IFormFile? ImageFile)
        {
            if (ModelState.IsValid)
            {
                // Handle File Upload
                if (ImageFile != null && ImageFile.Length > 0)
                {
                    string folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "products");
                    if (!Directory.Exists(folder)) Directory.CreateDirectory(folder);

                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(ImageFile.FileName);
                    string filePath = Path.Combine(folder, fileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await ImageFile.CopyToAsync(stream);
                    }

                    product.ImageUrl = "/images/products/" + fileName;
                }

                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            // If we reach here, something was wrong (Validation failed). 
            // Reload the Category list so the dropdown isn't empty.
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", product.CategoryId);
            return View(product);
        }


        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Id", product.CategoryId);
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,ImageUrl,Price,CategoryId")] Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
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
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Id", product.CategoryId);
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                _context.Products.Remove(product);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.Id == id);
        }

        // GET: /Product/ByCategory
        public IActionResult ByCategory(int id)
        {
            var products = _context.Products
                                   .Where(p => p.CategoryId == id)
                                   .ToList();
            return View(products);
        }

        //// GET: /Product/Details
        //public IActionResult Details(int id)
        //{
        //    var product = _context.Products
        //                          .FirstOrDefault(p => p.Id == id);
        //    if (product == null) return NotFound();
        //    return View(product);
        //}
    }
}
