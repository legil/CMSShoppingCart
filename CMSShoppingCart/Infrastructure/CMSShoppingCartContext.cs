﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CMSShoppingCart.Infrastructure
{
    public class CMSShoppingCartContext : DbContext
    {
        public CMSShoppingCartContext(DbContextOptions<CMSShoppingCartContext> options) : base(options)
        {

        }
    }
}
