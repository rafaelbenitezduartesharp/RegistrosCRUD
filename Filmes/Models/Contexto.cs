﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Filmes.Models
{
    public class Contexto : DbContext
    { 
        public DbSet<Pessoa> pessoa { get; set; }

    }
}