using DDDSample.InfrastructureLayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDSample.InfrastructureLayer.Migrations
{
    //internal sealed class Configuration : DbMigrationsConfiguration<SurveyContext>
     internal sealed class Configuration : DropCreateDatabaseAlways<SurveyContext>
    {
        public Configuration()
        {
            //AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SurveyContext context)
        {
           
        }
    }
}
