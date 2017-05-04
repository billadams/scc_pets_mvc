using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace SCCPetsMVC.DataContexts
{
    public class PetDb : DbContext
    {
        public PetDb():base("name=CustomerContext") { }

        public virtual DbSet<Models.Pet> Pets { get; set; }


    }
}