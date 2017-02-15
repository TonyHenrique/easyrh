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
            var t = new Talento
            {
                //id_Talento = sera definido pelo Banco de Dados,
                Nome = "",
                Banco = "Itau",
                OBS_Conhecimentos = "",
                LinkCRUD = "https://",
                TipoDeConta = "CHAIN"   //TipoDeConta = "SAVINGS"
            };
            t.PopulateConhecimentos();

            return t;
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
            if (id == 0)
                return New();

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
            if (talento.id_Talento == 0)
            {
                #region // Novo talento
                using (var ctx = new rhEasyContext())
                {
                    ctx.Add(talento);
                    ctx.Entry(talento).State = Microsoft.EntityFrameworkCore.EntityState.Added;

                    ctx.SaveChanges();
                }
                #endregion
            }
            else
            {
                #region // Salvar talento existente
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
                #endregion
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