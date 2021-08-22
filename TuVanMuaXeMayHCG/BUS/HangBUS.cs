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
    class HangBUS
    {
        DataProvider data = new DataProvider();
        private static HangDAL hangDAL = new HangDAL();
        public static List<HangDTO> FindAll()
        {
            var hangDTO = new HangDTO();
            hangDTO.Code = "B00";
            hangDTO.Name = "Không rõ";
            var result = hangDAL.FindAll();
            result.Add(hangDTO);
            return result;
        }
        public bool checkHang(String code)
        {
            string sql = "SELECT * FROM Hang WHERE Code = '" + code + "'";
            DataTable check = data.GetTable(sql);
            if (check.Rows.Count == 0)
                return false;
            else
                return true;
        }
        public DataTable getHang()
        {
            string sql = "SELECT * FROM Hang";
            return data.GetTable(sql);
        }
        public bool insertHang(String code, String name)
        {
            string sql = "INSERT INTO Hang VALUES ('" + code + "', '" + name + "')";
            if (data.ExecuteNonQuery(sql))
                return true;
            else
                return false;
        }
        public bool updateHang(String code, String name)
        {
            string sql = "UPDATE Hang SET Name = '" + name + "' WHERE Code = '" + code + "'";
            if (data.ExecuteNonQuery(sql))
                return true;
            else
                return false;
        }
        public bool deleteHang(String code)
        {
            string sql = "DELETE Hang WHERE Code = '" + code + "'";
            if (data.ExecuteNonQuery(sql))
                return true;
            else
                return false;
        }
    }
}
