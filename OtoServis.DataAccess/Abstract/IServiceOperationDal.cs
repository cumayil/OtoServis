using OtoServis.Core.DataAccess;
using OtoServis.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace OtoServis.DataAccess.Abstract
{
    public interface IServiceOperationDal:IEntityRepository<ServiceOperation>
    {
    }
}
