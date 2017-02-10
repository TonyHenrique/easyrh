using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WinRH;

namespace RH.Controllers
{
    interface IBasicCRUD
    {
        [HttpGet]
        object New();

        [HttpGet]
        IEnumerable<object> GetAll();

        [HttpGet("{id}")]
        object Get(string id);

        [HttpPost]
        void Update([FromBody]object talento);

        [HttpDelete("{id}")]
        void Delete(string id);       
    }
}
