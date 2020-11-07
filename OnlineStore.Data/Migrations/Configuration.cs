using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Text;

namespace OnlineStore.Data.Migrations
{
    internal sealed class Configuration:DbMigrationsConfiguration<OnlineStoreContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
        }
    }
}
