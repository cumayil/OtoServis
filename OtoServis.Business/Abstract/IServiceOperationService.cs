using System;
using System.Collections.Generic;
using System.Text;
using OtoServis.Entities.Concrete;

namespace OtoServis.Business.Abstract
{
    public interface IServiceOperationService
    {
        void Add(ServiceOperation serviceOperation);
        string Delete(int id);
        string Update(ServiceOperation serviceOperation);
        ServiceOperation Get(int id);
        List<ServiceOperation> GetAll();
    }
}
