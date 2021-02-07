using System;
using System.Collections.Generic;
using System.Text;
using OtoServis.Business.Abstract;
using OtoServis.DataAccess.Abstract;
using OtoServis.Entities.Concrete;

namespace OtoServis.Business.Concrete
{
    public class ServiceOperationManager : IServiceOperationService
    {
        private IServiceOperationDal _serviceOperationDal;
        public ServiceOperationManager(IServiceOperationDal serviceOperationDal)
        {
            _serviceOperationDal = serviceOperationDal;
        }
        
        public void Add(ServiceOperation serviceOperation)
        {
            _serviceOperationDal.Add(serviceOperation);
        }

        public string Delete(int id)
        {
            _serviceOperationDal.Delete(new ServiceOperation { Id = id });
            return "Deleted";
        }

        public ServiceOperation Get(int id)
        {
            return _serviceOperationDal.Get(x => x.Id == id);
        }

        public List<ServiceOperation> GetAll()
        {
            return _serviceOperationDal.GetAll();
        }

        public string Update(ServiceOperation serviceOperation)
        {
            _serviceOperationDal.Update(serviceOperation);
            return "Updated";
        }
    }
}
