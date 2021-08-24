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
    class DacDiemBUS
    {
        DataProvider data = new DataProvider();
        private static DacDiemDAL dacdiemDAL = new DacDiemDAL();
        public static List<DacDiemDTO> FindAll()
        {
            var DTO = new DacDiemDTO();
            DTO.Code = "D00";
            DTO.Name = "Không rõ";
            var result = dacdiemDAL.FindAll();
            result.Add(DTO);
            return result;
        }
        public bool checkDacDiem(String code)
        {
            string sql = "SELECT * FROM DacDiem WHERE Code = '" + code + "'";
            DataTable check = data.GetTable(sql);
            if (check.Rows.Count == 0)
                return false;
            else
                return true;
        }
        public DataTable getDacDiem()
        {
            string sql = "SELECT * FROM DacDiem";
            return data.GetTable(sql);
        }
        public bool insertDacDiem(String code, String name)
        {
            string sql = "INSERT INTO DacDiem VALUES ('" + code + "', '" + name + "')";
            if (data.ExecuteNonQuery(sql))
                return true;
            else
                return false;
        }
        public bool updateDacDiem(String code, String name)
        {
            string sql = "UPDATE DacDiem SET Name = '" + name + "' WHERE Code = '" + code + "'";
            if (data.ExecuteNonQuery(sql))
                return true;
            else
                return false;
        }
        public bool deleteDacDiem(String code)
        {
            string sql = "DELETE DacDiem WHERE Code = '" + code + "'";
            if (data.ExecuteNonQuery(sql))
                return true;
            else
                return false;
        }
    }
}
