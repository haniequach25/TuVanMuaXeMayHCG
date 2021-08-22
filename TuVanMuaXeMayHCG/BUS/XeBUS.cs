using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuVanMuaXeMayHCG.DAL;
using TuVanMuaXeMayHCG.DTO;

namespace TuVanMuaXeMayHCG.BUS
{
    class XeBUS
    {
        DataProvider data = new DataProvider();
        static XeDAL xeDAL = new XeDAL();
        public static List<XeDTO> FindAll()
        {
            return xeDAL.FindAll();
        }
        public bool checkXe(String code)
        {
            string sql = "SELECT * FROM Xe WHERE Code = '" + code + "'";
            DataTable check = data.GetTable(sql);
            if (check.Rows.Count == 0)
                return false;
            else
                return true;
        }
        public DataTable getXe()
        {
            string sql = "SELECT * FROM Xe";
            return data.GetTable(sql);
        }
        public bool insertXe(String code, String name, String brand, int price, String type, String capacity)
        {
            string sql = "INSERT INTO Xe VALUES ('" + code + "', '" + name + "', '" + brand + "', '" + price + "', '" + type + "', '" + capacity + "')";
            if (data.ExecuteNonQuery(sql))
                return true;
            else
                return false;
        }
        public bool updateXe(String code, String name, String brand, int price, String type, String capacity)
        {
            string sql = "UPDATE Xe SET Name = '" + name + "', Brand = '" + brand + "', Price = '" + price + "', Type = '" + type + "', Capacity = '" + capacity + "' WHERE Code = '" + code + "'";
            if (data.ExecuteNonQuery(sql))
                return true;
            else
                return false;
        }
        public bool deleteXe(String code)
        {
            string sql = "DELETE Xe WHERE Code = '" + code + "'";
            if (data.ExecuteNonQuery(sql))
                return true;
            else
                return false;
        }
    }
}
