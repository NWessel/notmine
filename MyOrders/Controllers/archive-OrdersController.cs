using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyOrders.Data;
using MyOrders.Models;
using MyOrders.Services.Interfaces;
using MyOrders.ViewModels;

namespace MyOrders.Controllers
{
    public class archiveOrdersController : Controller
    {
        private readonly ILogger<archiveOrdersController> _logger;
        private readonly IOrderService _orderService;
        private readonly OrderContext _context;

        public archiveOrdersController(ILogger<archiveOrdersController> logger, IOrderService orderService, OrderContext context)
        {
            _logger = logger;
            _orderService = orderService;
            _context = context;
        }

        // GET: Orders
        public async Task<IActionResult> Index(int orderNumber = 0)
        {
            
            // retreive items
            var orders = _orderService.GetAll();

            // place in View Model
            // var model = (from o in orders);

            // return view
            // return View("Index", model);

            throw new NotImplementedException();

            // // Get items from db
            // var items = await _todoItemService.GetIncompleteItemsAsync();
            
            // // Place items in model
            // var model = new TodoViewModel()
            // {
            //     Items = items 
            // };
            
            // // Render view using model
            // return View(model);
            
            /*
            // Get items from db
            var model = await _orderService.GetAll();
            
            // Place items in model
            var query = (from o in model.o
                            join c in _context.Customers on o.CustomerId equals c.Id
                            join op in _context.OrderProduct on o.Id equals op.Id
                            join p in _context.Products on op.ProductId equals p.Id
                            join pg in _context.ProductGroups on p.ProductGroupingId equals pg.Id
                            select new OrderViewModel
                            {
                                OrderId = o.Id,
                                OrderNumber = o.OrderNumber,
                                OrderDate = o.OrderDate,
                                ProductNumber = p.ProductNumber,
                                Name = p.Name,
                                Description = p.Description,
                                Price = p.Price,
                                CustomerNumber = c.CustomerNumber,
                                CustomerName = c.CustomerName,
                                ProductGroup = pg.ProductGroup,
                                Quantity = op.Quantity,
                                OrderLineNumber = op.OrderLineNumber
                            });
            
            if (orderNumber != 0)
            {
                query = model.GetByOrderNumber(orderNumber);
            }

            return View("Index", await query.ToListAsync());
            */


            /*
            var orderContext = _context.OrderViewModel
                .Include(o => o.Orders)
                .Include(c => c.Customers)
                .Include(p => p.Products)
                .Include(g => g.ProductGroup);
            return View(await orderContext.ToListAsync());
            */

        }

        /*

        // GET: Orders/Create
        public IActionResult Create()
        {
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "CustomerName");
            return View();
        }

        // POST: Orders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,OrderNumber,OrderDate,CustomerId")] Order order)
        {
            if (ModelState.IsValid)
            {
                _context.Add(order);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "CustomerName", order.CustomerId);
            return View(order);
        }

        // GET: Orders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "CustomerName", order.CustomerId);
            return View(order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,OrderNumber,OrderDate,CustomerId")] Order order)
        {
            if (id != order.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(order);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExists(order.Id))
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
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "CustomerName", order.CustomerId);
            return View(order);
        }

        // GET: Orders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .Include(o => o.Customer)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderExists(int id)
        {
            return _context.Orders.Any(e => e.Id == id);
        }
        */
    }
}
