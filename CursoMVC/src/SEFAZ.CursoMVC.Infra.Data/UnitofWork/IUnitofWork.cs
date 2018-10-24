using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFAZ.CursoMVC.Infra.Data.UnitofWork
{
    public interface IUnitofWork
    {
        void Commit();
    }
}
