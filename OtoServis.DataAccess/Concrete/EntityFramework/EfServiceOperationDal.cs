using System;
using System.Collections.Generic;
using System.Text;
using OtoServis.Core.DataAccess.EntityFramework;
using OtoServis.DataAccess.Abstract;
using OtoServis.Entities.Concrete;

namespace OtoServis.DataAccess.Concrete.EntityFramework
{
    public class EfServiceOperationDal : EfEntityRepositoryBase<ServiceOperation, OtoServisContext>, IServiceOperationDal
    {
    }
}
