using SEFAZ.CursoMVC.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFAZ.CursoMVC.Infra.Data.UnitofWork
{
    public class UnitofWork : IUnitofWork
    {

        private readonly CursoMVCContext _context;
        private bool _disposed;

        public UnitofWork(CursoMVCContext context) {
            _context = context;
            _disposed = false;
        }

        public virtual void Dispose(bool disposing) {
            if (!_disposed) {
                if (disposing)
                    _context.Dispose();
                _disposed = true;
            }
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
