using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LuminiHireApi.Models;

namespace LuminiHireApi.Data
{
    public class DataNetContext : DbContext
    {
        public DataNetContext(DbContextOptions<DataNetContext> options)
            : base(options)
        {
        }

        public virtual DbSet<City> Citys { get; set; }

    }
}
