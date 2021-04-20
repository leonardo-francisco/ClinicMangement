using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Clinic.Dominio.Entities;
using Clinic.Servico.Interface;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Clinic.Web.Controllers
{
    public class DoutoresController : Controller
    {
        private readonly IDoutoresService _doutoresService;
        private readonly IHostingEnvironment hostingEnvironment;

        public DoutoresController(IDoutoresService doutoresService, IHostingEnvironment environment)
        {
            _doutoresService = doutoresService;
            hostingEnvironment = environment;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _doutoresService.GetAllDoctors());
        }

        public IActionResult CadastrarDoutores()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CadastrarDoutores(Doutores doct)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (doct.FotoPerfil != null)
                    {
                        var name = Path.GetFileName(doct.FotoPerfil.FileName);
                        var path = Path.Combine(hostingEnvironment.WebRootPath, "images");
                        var uniquepath = Path.Combine(path, name);
                        doct.FotoPerfil.CopyTo(new FileStream(uniquepath, FileMode.Create));
                        doct.UrlFoto = "~/images/" + doct.FotoPerfil.FileName;
                    }
                    await _doutoresService.CreateDoctorsAsync(doct);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Unable to save changes.");
            }
            return View(doct);
        }

        public async Task<IActionResult> EditarDoutores(int id)
        {
            return View(await _doutoresService.GetDoctorsById(id));
        }

        [HttpPost]
        public async Task<IActionResult> EditarDoutores(int id, Doutores doct)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var dbDoc = await _doutoresService.GetDoctorsById(id);
                    if (await TryUpdateModelAsync<Doutores>(dbDoc))
                    {
                        await _doutoresService.UpdateDoctorsAsync(dbDoc);
                        return RedirectToAction(nameof(Index));
                    }
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Unable to save changes.");
            }
            return View(doct);
        }

        public async Task<IActionResult> Profile(int id)
        {
            return View(await _doutoresService.GetDoctorsById(id));
        }

        [HttpDelete]
        public async void DeleteDoutor(int id)
        {
            Doutores dt = new Doutores();
            dt = await _doutoresService.GetDoctorsById(id);
            await _doutoresService.DeleteDoctorsAsync(dt);
        }
    }
}