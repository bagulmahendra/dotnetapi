using GCPAPi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GCPAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecurityController : ControllerBase
    {
        private readonly SecurityAPIContext _context;

        public SecurityController(SecurityAPIContext context)
        {
            this._context = context;
        }


        [HttpGet]
        public ActionResult<List<Security>> GetAll()
        {
            return _context.Security.ToList();
        }

        [HttpGet("{id}", Name = "Security")]
        public ActionResult<Security> GetById(int id)
        {
            var item = _context.Security.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }


        
        [HttpPost]
        public   bool Add([FromBody] Security security)
        {
            try
            {
                _context.Add(security);
                 _context.SaveChanges();
                return true;
            }
            catch (Exception e )
            {

                return false;
            }
        }
        
        [HttpDelete("{id}", Name = "Security")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            try
            {
                var item = _context.Security.Find(id);
                if (item == null)
                {
                    return NotFound();
                }
                _context.Remove(item);
                await _context.SaveChangesAsync();
            }
            catch ( Exception)
            {
                return new EmptyResult();
            }
            return new OkResult();
        }
        
        [HttpPut]
        public async Task<bool> UpdateAsync([FromBody] Security security)
        {
            try
            {
                _context.Update(security);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

    }
}
