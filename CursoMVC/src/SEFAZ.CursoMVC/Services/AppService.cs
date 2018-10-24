using SEFAZ.CursoMVC.Infra.Data.UnitofWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFAZ.CursoMVC.Application.Services
{
    public class AppService
    {
        private readonly IUnitofWork _uow;
        private AppService(IUnitofWork uow) {
            _uow = uow;
        }

        protected void Commit() {
            _uow.Commit();
        }
    }
}
