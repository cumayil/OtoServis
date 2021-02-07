using OtoServis.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OtoServis.UI.Models
{
    public class ServiceOperationViewModel
    {
        public ServiceOperation serviceOperation { get; set; }
        public List<ServiceOperation> serviceOperations { get; set; }
    }
}
