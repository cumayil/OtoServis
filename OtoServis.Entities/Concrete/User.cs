using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace OtoServis.Entities.Concrete
{
    [Keyless]
    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
