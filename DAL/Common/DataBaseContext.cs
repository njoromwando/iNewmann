using DAL.Finance;
using DAL.POS;
using DAL.Registration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using static DAL.ViewModels.Finance.FinanceViewModels;

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

       // Models Dbsets

        DbSet <Student> students { get; set; }
        DbSet<Product> products { get; set; }
        DbSet<Activity> activitys { get; set; }
        DbSet<ChartOfAccount> chartOfaccounts { get; set; }
        DbSet<ChartOfAccountGroup> chartofaccountgroups { get; set; }
        DbSet<GeneralLedgers> generalledgers { get; set; }
        DbSet<CodeGenerator> codeGenerators { get; set; }
        DbSet<ProductCategory> productCategories { get; set; }
        DbSet<Invoice> invoices { get; set; }
        DbSet<InvoiceItem> InvoiceItems { get; set; }
        DbSet<StockControl> stockControls { get; set; }
        DbSet<Supplier> suppliers { get; set; }

        //ViewModel DBSets
        public DbQuery<COA> coas { get; set; }
        public DbQuery<COAGroup> COAGroups { get; set; }
      //  public DbQuery<> coa { get; set; }











    }
}
