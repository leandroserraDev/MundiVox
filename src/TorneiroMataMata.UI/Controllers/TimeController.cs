using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TorneiroMataMata.Application.Interfaces;
using TorneiroMataMata.Domain.Entities;
using TorneiroMataMata.UI.Models.ViewModels.TimeViewModel;

namespace TorneiroMataMata.UI.Controllers
{
    public class TimeController : Controller
    {
        private readonly IAppTime _timeApp;
        private readonly IAppGrupo _grupoApp;

        public TimeController(IAppTime timeApp, IAppGrupo appGrupo)
        {
            _timeApp = timeApp;
            _grupoApp = appGrupo;
        }

        // GET: Time
        public ActionResult FaseDeGrupos()
        {
            var timeView = Mapper.Map<IEnumerable<Time>, IEnumerable<TimeIndexViewModel>>(_timeApp.GetAll());
            return View(timeView);
        }

        public ActionResult OitavasDeFinal()
        {
            var timeView = Mapper.Map<IEnumerable<Time>, IEnumerable<TimeIndexViewModel>>(_timeApp.GetAll().Where(x => x.GrupoId == 5));
            return View(timeView);
        }
        public ActionResult SemiFinal()
        {
            var timeView = Mapper.Map<IEnumerable<Time>, IEnumerable<TimeIndexViewModel>>(_timeApp.GetAll().Where(x => x.GrupoId == 6));
            return View(timeView);
        }

        public ActionResult Final()
        {
            var timeView = Mapper.Map<IEnumerable<Time>, IEnumerable<TimeIndexViewModel>>(_timeApp.GetAll().Where(x => x.GrupoId == 7));
            return View(timeView);
        }



        // GET: Time/Details/5
        public ActionResult Details(int id)
        {
            var TimeDetalhes = Mapper.Map<Time, TimeIndexViewModel>(_timeApp.GetById(id));
            return View(TimeDetalhes);
        }

        // GET: Time/Create
        public ActionResult Create()
        {
            ViewBag.GrupoId = new SelectList(_grupoApp.GetAll(), "GrupoId", "Nome");
            return View();
        }

        // POST: Time/Create
        [HttpPost]
        public ActionResult Create(TimeIndexViewModel time)
        {
            var timeCreate = Mapper.Map<TimeIndexViewModel, Time>(time);

            _timeApp.Add(timeCreate);
            _timeApp.SaveChanges();

            return RedirectToAction("FaseDeGrupos");
         
        }

        // GET: Time/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.GrupoId = new SelectList(_grupoApp.GetAll(), "GrupoId", "Nome");
            var TimeEditar = Mapper.Map<Time, TimeIndexViewModel>(_timeApp.GetById(id));
            return View(TimeEditar);
        }

        // POST: Time/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, TimeIndexViewModel time)
        {
            var TimeEditar = Mapper.Map<TimeIndexViewModel, Time>(time);
            _timeApp.Edit(TimeEditar);
            _timeApp.SaveChanges();

            return RedirectToAction("FaseDeGrupos");
        }

        //POST: Time/AvancarTime/5
        public ActionResult AvancarTime(int id)
        {
            var TimeEditar = Mapper.Map<Time, TimeIndexViewModel>(_timeApp.GetById(id));
            switch (TimeEditar.GrupoId)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    ViewBag.GrupoId = new SelectList(_grupoApp.GetAll().Where(x => x.Nome.Contains("Oitavas")), "GrupoId", "Nome");
                    break;
                case 5:
                    ViewBag.GrupoId = new SelectList(_grupoApp.GetAll().Where(x => x.Nome.Contains("Semi")), "GrupoId", "Nome");
                    break;
                case 6:
                    ViewBag.GrupoId = new SelectList(_grupoApp.GetAll().Where(x => x.Nome.Contains("Final")), "GrupoId", "Nome");
                    break;

                default:
                    break;

            }

            return View(TimeEditar);
        }

        [HttpPost]
        public ActionResult AvancarTime(TimeIndexViewModel time)
        {
            var TimeEditar = Mapper.Map<TimeIndexViewModel, Time>(time);
            _timeApp.AvancarTime(TimeEditar);
            _timeApp.SaveChanges();

            return RedirectToAction("FaseDeGrupos");
        }

        // GET: Time/Delete/5
        public ActionResult Delete(int id)
        {
            var timeDeletar = Mapper.Map<Time, TimeIndexViewModel>(_timeApp.GetById(id));
            return View(timeDeletar);
        }

        // POST: Time/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var timeDeletar = _timeApp.GetById(id);
            _timeApp.Delete(timeDeletar);
            _timeApp.SaveChanges();

            return RedirectToAction("FaseDeGrupos");
        }
    }
}
