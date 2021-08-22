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
    class GiaTienBUS
    {
        DataProvider data = new DataProvider();
        private static GiaTienDAL giatienDAL = new GiaTienDAL();
        public static List<GiaTienDTO> FindAll()
        {
            var giatienDTO = new GiaTienDTO();
            giatienDTO.Code = "A00";
            giatienDTO.Name = "Không rõ";
            var result = giatienDAL.FindAll();
            result.Add(giatienDTO);
            return result;
        }
        public bool checkGiaTien(String code)
        {
            string sql = "SELECT * FROM GiaTien WHERE Code = '" + code + "'";
            DataTable check = data.GetTable(sql);
            if (check.Rows.Count == 0)
                return false;
            else
                return true;
        }
        public DataTable getGiaTien()
        {
            string sql = "SELECT * FROM GiaTien";
            return data.GetTable(sql);
        }
        public bool insertGiaTien(String code, String name)
        {
            string sql = "INSERT INTO GiaTien VALUES ('" + code + "', '" + name + "')";
            if (data.ExecuteNonQuery(sql))
                return true;
            else
                return false;
        }
        public bool updateGiaTien(String code, String name)
        {
            string sql = "UPDATE GiaTien SET Name = '" + name + "' WHERE Code = '" + code + "'";
            if (data.ExecuteNonQuery(sql))
                return true;
            else
                return false;
        }
        public bool deleteGiaTien(String code)
        {
            string sql = "DELETE GiaTien WHERE Code = '" + code + "'";
            if (data.ExecuteNonQuery(sql))
                return true;
            else
                return false;
        }
    }
}
