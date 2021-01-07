using DangKyHocPhan.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangKyHocPhan.ConnectDB
{
    public class Context : DbContext
    {
        public Context() : base("name=ConnectionString")
        {

        }
        public DbSet<CanBoDaoTao> CanBoDaoTaos { get; set; }
        public DbSet<ChuyenNganh> ChuyenNganhs { get; set; }
        public DbSet<GiangVien> GiangViens { get; set; }
        public DbSet<HocKi> HocKis { get; set; }
        public DbSet<Khoa> Khoas { get; set; }
        public DbSet<LoaiDaoTao> LoaiDaoTaos { get; set; }
        public DbSet<Lop> Lops { get; set; }
        public DbSet<LopHocPhan> LopHocPhans { get; set; }
        public DbSet<MonHoc> MonHocs { get; set; }
        public DbSet<MonHocHocPhan> MonHocHocPhans { get; set; }
        public DbSet<NamHoc> NamHocs { get; set; }
        public DbSet<PhongHoc> PhongHocs { get; set; }
        public DbSet<SinhVien> SinhViens { get; set; }
        public DbSet<SinhVien_MonHocHocPhan> SinhVien_MonHocHocPhans { get; set; }
        public DbSet<TaiKhoan> TaiKhoans { get; set; }
        public DbSet<TietHoc> TietHocs { get; set; }
        public DbSet<ChiTietLopHocPhan> ChiTietLopHocPhans { get; set; }
        public DbSet<Thu> Thus { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<Context>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}
