using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace XMLworker
{
    using System;
    using System.Collections.Generic;

    public partial class XMLDbContext : DbContext
    {
        public XMLDbContext()
            : base("name=XMLDbConnectionString")
        {
        }

        public virtual DbSet<models.File> Files { get; set; }

        public static XMLDbContext Create()
        {
            return new XMLDbContext();
        }
    }

}
