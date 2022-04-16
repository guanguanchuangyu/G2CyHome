using Microsoft.EntityFrameworkCore;
using OSharp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G2CyHome.EntityConfiguration
{
    public class DeviceDbContext:DbContextBase
    {
        public DeviceDbContext(DbContextOptions options, IServiceProvider serviceProvider)
            :base(options, serviceProvider)
        {

        }
    }
}
