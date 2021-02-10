using System;
using Entites.Concrete;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class T_Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          
            optionsBuilder.UseSqlServer(@"workstation id=deneme1234.mssql.somee.com;packet size=4096;user id=sofy_SQLLogin_1;pwd=9np5pjtqol;data source=deneme1234.mssql.somee.com;persist security info=False;initial catalog=deneme1234");
            /*string connStr = "server=127.0.0.1/phpmyadmin;uid=root;pwd=;database=ReCapProject";
           
            try
            {
                MySqlConnection conn;
                conn = new MySqlConnection(connStr);
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("hajsfgaksjfhkajdla");
            }*/
            
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Brand> Brands { get; set; }
    }

}
