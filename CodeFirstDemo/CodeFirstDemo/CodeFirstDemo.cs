namespace CodeFirstDemo1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CodeFirstDemo : DbContext
    {
        public CodeFirstDemo()
            : base("name=CodeFirstDemo")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
