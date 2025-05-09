using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCCRUDwithoutEF1.Models;

namespace MVCCRUDwithoutEF1.Data
{
    public class MVCCRUDwithoutEF1Context : DbContext
    {
        public MVCCRUDwithoutEF1Context (DbContextOptions<MVCCRUDwithoutEF1Context> options)
            : base(options)
        {
        }

        public DbSet<MVCCRUDwithoutEF1.Models.BookViewModel> BookViewModel { get; set; } = default!;
    }
}
