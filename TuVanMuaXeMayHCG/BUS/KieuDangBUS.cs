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
    class KieuDangBUS
    {
        DataProvider data = new DataProvider();
        private static KieuDangDAL DAL = new KieuDangDAL();
        public static List<KieuDangDTO> FindAll()
        {
            var DTO = new KieuDangDTO();
            DTO.Code = "D00";
            DTO.Name = "Không rõ";
            var result = DAL.FindAll();
            result.Add(DTO);
            return result;
        }
        public bool checkKieuDang(String code)
        {
            string sql = "SELECT * FROM KieuDang WHERE Code = '" + code + "'";
            DataTable check = data.GetTable(sql);
            if (check.Rows.Count == 0)
                return false;
            else
                return true;
        }
        public DataTable getKieuDang()
        {
            string sql = "SELECT * FROM KieuDang";
            return data.GetTable(sql);
        }
        public bool insertKieuDang(String code, String name)
        {
            string sql = "INSERT INTO KieuDang VALUES ('" + code + "', '" + name + "')";
            if (data.ExecuteNonQuery(sql))
                return true;
            else
                return false;
        }
        public bool updateKieuDang(String code, String name)
        {
            string sql = "UPDATE KieuDang SET Name = '" + name + "' WHERE Code = '" + code + "'";
            if (data.ExecuteNonQuery(sql))
                return true;
            else
                return false;
        }
        public bool deleteKieuDang(String code)
        {
            string sql = "DELETE KieuDang WHERE Code = '" + code + "'";
            if (data.ExecuteNonQuery(sql))
                return true;
            else
                return false;
        }
    }
}
