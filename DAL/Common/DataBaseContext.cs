using DAL.Finance;
using DAL.POS;
using DAL.Registration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Common
{
    public class DataBaseContext : DbContext
    {

        public void SetCommandTimeOut(int timeOut)
        {
            /// Database.SetCommandTimeout(timeOut);
        }


        public DataBaseContext(DbContextOptions<DataBaseContext> options)
           : base(options)
        {
            SetCommandTimeOut(10000);
        }

        DbSet <Student> students { get; set; }
        DbSet<Product> products { get; set; }
        DbSet<Activity> activitys { get; set; }
        DbSet<ChartOfAccount> chartOfaccounts { get; set; }
        DbSet<ChartOfAccountGroup> chartofaccountgroups { get; set; }
        DbSet<GeneralLedgers> generalledgers { get; set; }






    }
}
