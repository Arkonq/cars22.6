using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication4.Data;
using WebApplication4.Models;
using WebApplication4.Services.Interfaces;

namespace WebApplication4.Controllers
{
	public class CarsController : Controller
	{
		private readonly IRepository _repository;

		public CarsController(IRepository repository)
		{
			_repository = repository;
		}

		// GET: Cars
		public IActionResult Index()
		{
			var model = _repository.GetAll();
			return View(model);
		}

		// GET: Cars/Details/5
		public IActionResult Details(int id)
		{
			var car = _repository.Get(id);
			if (car == null)
			{
				return NotFound();
			}

			return View(car);
		}

		// GET: Cars/Create
		public IActionResult Create()
		{
			return View();
		}

		// POST: Cars/Create
		// To protect from overposting attacks, enable the specific properties you want to bind to, for 
		// more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create([Bind("Id,Title,Color,Kuzov,Power")] Car car)
		{
			if (ModelState.IsValid)
			{
				_repository.Create(car);
				_repository.Save();
				return RedirectToAction(nameof(Index));
			}
			return View(car);
		}

		// GET: Cars/Edit/5
		public IActionResult Edit(int id)
		{
			var car = _repository.Get(id);
			if (car == null)
			{
				return NotFound();
			}
			return View(car);
		}

		// POST: Cars/Edit/5
		// To protect from overposting attacks, enable the specific properties you want to bind to, for 
		// more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Edit(int id, [Bind("Id,Title,Color,Kuzov,Power")] Car car)
		{
			if (id != car.Id)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				try
				{
					_repository.Edit(car);
					_repository.Save();
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!CarExists(car.Id))
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
			return View(car);
		}

		// GET: Cars/Delete/5
		public IActionResult Delete(int id)
		{
			var car = _repository.Get(id);
			if (car == null)
			{
				return NotFound();
			}

			return View(car);
		}

		// POST: Cars/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			var car = _repository.Get(id);
			_repository.Delete(car);
			_repository.Save();
			return RedirectToAction(nameof(Index));
		}

		private bool CarExists(int id)
		{
			return _repository.Get(id) != null;
		}
	}
}
