using DangKyHocPhan.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangKyHocPhan.ConnectDB
{
    public class DataBaseService: IDataBaseService
    {
        public Context context;
        public DataBaseService()
        {
            
        }
        public void CreateIfNotExistsDB()
        {
            using (context = new Context())
            {
                context.Database.CreateIfNotExists();
            }
        }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
            
        //}
        public Context GetContext()
        {
            return context;
        }
        public DbSet<NamHoc> LoadNamHoc()
        {
            return context.NamHocs;
        }
        public void UpdateNameHoc()
        {
            var data = context.NamHocs.FirstOrDefault();
            data.TenNamHoc = "";
            context.SaveChanges();
        }
        public void RemoveNameHoc()
        {
            var data = context.NamHocs.FirstOrDefault();
            context.NamHocs.Remove(data);
            context.SaveChanges();
        }
    }
}
