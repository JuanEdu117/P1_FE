﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proyecto1_KatherineMurillo.Models;

namespace Proyecto1_KatherineMurillo.Controllers
{
    public class RegistroEmpleados : Controller
    {
        public IList<Empleados> listaEmpleados = new List<Empleados>();
        // GET: RegistroEmpleados
        public ActionResult Index()
        {           
            return View(listaEmpleados);
        }       

        // GET: RegistroEmpleados/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RegistroEmpleados/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Empleados empleadoNuevo)
        {
            try
            {
                if (empleadoNuevo == null)
                {
                    return View();
                }
                else
                {
                    listaEmpleados.Add(empleadoNuevo);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RegistroEmpleados/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RegistroEmpleados/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Empleados empleadoEditado)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RegistroEmpleados/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RegistroEmpleados/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Empleados empleadoEditado)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}