using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace PosDal
{
    public class ProductDal : BaseAdoDal, IRepository<view_Product>
    {




        public ProductDal(string connectionString) : base(connectionString)
        {
        }

        public void Add(view_Product entity)
        {
            var str = "INSERT INTO [dbo].[udt_Product] " +
"           ([Name]" +
"           ,[Code]" +
"           ,[CategoryId]" +
"           ,[Price]" +
"           ,[UnitType])" +
"     VALUES" +
"           ('{0}'" +
"           ,'{1}'" +
"           ,{2}" +
"           ,{3}" +
"           ,{4}";




            base.ExecuteNonQuery(string.Format(str, entity.Name, entity.Code, entity.CategoryId, entity.Price, entity.UnitType));
        }

        public void Delete(int id)
        {
            base.ExecuteNonQuery("delete from udt_Product where id " + id);
        }

        public void Delete(view_Product entity)
        {
            Delete((int)entity.Id);
        }

        public IQueryable<view_Product> GetAll()
        {
            return base.GetDataTable("select * from udt_Product ").Rows.AsParallel().Cast<DataRow>().Select(r => new view_Product
            {
                Id = r.Field<long>("Id"),
                Name = r.Field<string>("Name"),
                Code = r.Field<string>("Code"),
                Price = r.Field<Decimal>("Price"),
                CategoryId = r.Field<int>("CategoryId"),
                UnitType = r.Field<int>("UnitType")

            }).AsQueryable();




        }


        public List<view_Product> GetShortCuts()
        {

            var d =  ExecuteStoredProcedure("udsp_GetShortcuts", new System.Data.SqlClient.SqlParameter[] { });

            return d.Rows.AsParallel().Cast<DataRow>().Select(r => new view_Product
            {
                Id = r.Field<long>("Id"),
                Name = r.Field<string>("Name"),
                Code = r.Field<string>("Code"),
                Price = r.Field<Decimal>("Price"),
                CategoryId = r.Field<int>("CategoryId"),
                UnitType = r.Field<int>("UnitType"),
                Description= r.Field<string>("Description"),
                Unit = r.Field<string>("Unit")
               
            }).ToList();

        }

        public view_Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(view_Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
