using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DpProcedur.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using pro.Models;

namespace pro.Controllers
{
    public class ProcedureController : Controller
    {
        private DpContext cont;
        public ProcedureController(DpContext context)
        {
            cont = context;
        }
        public IActionResult Index()
        {
            var rowsAffected = cont.types.FromSqlRaw("EXEC bul 'yaso'").ToList();
            return View();
        }
    }
}
