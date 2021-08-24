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
    class DoiTuongBUS
    {
        DataProvider data = new DataProvider();
        private static DoiTuongDAL DAL = new DoiTuongDAL();
        public static List<DoiTuongDTO> FindAll()
        {
            var DTO = new DoiTuongDTO();
            DTO.Code = "D00";
            DTO.Name = "Không rõ";
            var result = DAL.FindAll();
            result.Add(DTO);
            return result;
        }
        public bool checkDoiTuong(String code)
        {
            string sql = "SELECT * FROM DoiTuong WHERE Code = '" + code + "'";
            DataTable check = data.GetTable(sql);
            if (check.Rows.Count == 0)
                return false;
            else
                return true;
        }
        public DataTable getDoiTuong()
        {
            string sql = "SELECT * FROM DoiTuong";
            return data.GetTable(sql);
        }
        public bool insertDoiTuong(String code, String name)
        {
            string sql = "INSERT INTO DoiTuong VALUES ('" + code + "', '" + name + "')";
            if (data.ExecuteNonQuery(sql))
                return true;
            else
                return false;
        }
        public bool updateDoiTuong(String code, String name)
        {
            string sql = "UPDATE DoiTuong SET Name = '" + name + "' WHERE Code = '" + code + "'";
            if (data.ExecuteNonQuery(sql))
                return true;
            else
                return false;
        }
        public bool deleteDoiTuong(String code)
        {
            string sql = "DELETE DoiTuong WHERE Code = '" + code + "'";
            if (data.ExecuteNonQuery(sql))
                return true;
            else
                return false;
        }
    }
}
