using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WinRH;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace RH.Controllers
{
    [Route("api/data/[controller]")]
    public class talentoController : Controller//, IBasicCRUD
    {
        [Route("New")]
        [HttpGet()]
        public Talento New()
        {
            using (var ctx = new rhEasyContext())
            {
                var t = new Talento
                {
                    //id_Talento = 1,
                    Nome = "",
                    Banco = "Itau",
                    OBS_Conhecimentos = "",
                    LinkCRUD = "https://",
                    TipoDeConta = "CHAIN"
                    //TipoDeConta = "SAVINGS"
                };
                t.Populate();               //t.Conhecimentos.Add(new Conhecimento() { Nome = "teste", Nota = 4 });

                ctx.Add(t);
                ctx.Entry(t).State = Microsoft.EntityFrameworkCore.EntityState.Added;

                ctx.SaveChanges();

                return t;           //return Json(t); // json is default return on ASP.Net core ?
            }
        }

        [Route("GetAll")]
        [HttpGet()]
        public IEnumerable<Talento> GetAll()
        {
            using (var ctx = new rhEasyContext())
            {
                var t = ctx.Talento.Where(tt => tt.Nome != "")
                    .OrderByDescending(tt => tt.id_Talento)
                    //.Take(10)
                    .ToList();

                return t;
            }
        }

        [Route("Get")]
        [HttpGet("{id}")]
        public object Get(long id)
        {
            using (var ctx = new rhEasyContext())
            {
                var t = ctx.Talento
                    .Where(tt => tt.id_Talento == id).Include(o => o.Conhecimento)
                    .FirstOrDefault();

                t.Conhecimento.Count();
                return t;
            }
        }

        [Route("Update")]
        [HttpPost]
        public void Update([FromBody] Talento talento)
        {
            using (var ctx = new rhEasyContext())
            {
                ctx.Attach(talento);
                ctx.Entry(talento).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                foreach (var c in talento.Conhecimento)
                {
                    ctx.Entry(c).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                }
                ctx.SaveChanges();
            }
        }

        [Route("Delete")]
        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            using (var ctx = new rhEasyContext())
            {
                var talento = ctx.Talento.Where(t => t.id_Talento == id)
                    .Include(t => t.Conhecimento)
                    .FirstOrDefault();
                if (talento != null)
                {
                    ctx.Remove(talento);
                    ctx.SaveChanges();
                }
            }
        }

    }
}