﻿using Microsoft.EntityFrameworkCore;
using ProductOfferGrpcServices.Entities;
using System.Collections.Generic;
using System.Data;

namespace ProductOfferGrpcServices.Data
{
    public class DbContextClass:DbContext
    {
        protected readonly IConfiguration Configuration;

        public DbContextClass(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<Offer> Offer { get; set; }
    }
}
