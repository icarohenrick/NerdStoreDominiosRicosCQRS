using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NerdStore.Core.Data.EventSourcing;

namespace NerdStore.WebApp.MVC.Controllers
{
    public class EventosController : Controller
    {
        private readonly IEventSourcingRepository _eventSourcingRepository;
        public EventosController(IEventSourcingRepository eventSourcingRepository) => _eventSourcingRepository = eventSourcingRepository;

        [HttpGet("eventos/{id:guid}")]
        public async Task<IActionResult> Index(Guid id)
        {
            var eventos = await _eventSourcingRepository.ObterEventos(id);
            return View(eventos);
        }
    }
}