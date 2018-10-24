using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SyC.CGRyF.Negocio.Catalogos
{
    public class ContribuyenteBL : IDisposable
    {
        AccesoDatos.CNA_SIRFIC_Entities _context;

        public ContribuyenteBL()
        {
            _context = new AccesoDatos.CNA_SIRFIC_Entities();
        }

        public async Task<int> Contar() {
            return await _context.tblPuucContribuyentes.CountAsync();
        }

        public IQueryable<AccesoDatos.tblPuucContribuyente> GetAll() {
            return _context.tblPuucContribuyentes.Include(x => x.tblPuucDomicilioContribuyentes);
        }

       


        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
