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
    class DungTichBUS
    {
        DataProvider data = new DataProvider();
        private static DungTichDAL dungtichDAL = new DungTichDAL();
        public static List<DungTichDTO> FindAll()
        {
            var dungtichDTO = new DungTichDTO();
            dungtichDTO.Code = "D00";
            dungtichDTO.Name = "Không rõ";
            var result = dungtichDAL.FindAll();
            result.Add(dungtichDTO);
            return result;
        }
        public bool checkDungTich(String code)
        {
            string sql = "SELECT * FROM DungTich WHERE Code = '" + code + "'";
            DataTable check = data.GetTable(sql);
            if (check.Rows.Count == 0)
                return false;
            else
                return true;
        }
        public DataTable getDungTich()
        {
            string sql = "SELECT * FROM DungTich";
            return data.GetTable(sql);
        }
        public bool insertDungTich(String code, String name)
        {
            string sql = "INSERT INTO DungTich VALUES ('" + code + "', '" + name + "')";
            if (data.ExecuteNonQuery(sql))
                return true;
            else
                return false;
        }
        public bool updateDungTich(String code, String name)
        {
            string sql = "UPDATE DungTich SET Name = '" + name + "' WHERE Code = '" + code + "'";
            if (data.ExecuteNonQuery(sql))
                return true;
            else
                return false;
        }
        public bool deleteDungTich(String code)
        {
            string sql = "DELETE DungTich WHERE Code = '" + code + "'";
            if (data.ExecuteNonQuery(sql))
                return true;
            else
                return false;
        }
    }
}
