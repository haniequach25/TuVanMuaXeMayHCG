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
    class LoaiXeBUS
    {
        DataProvider data = new DataProvider();
        private static LoaiXeDAL loaixeDAL = new LoaiXeDAL();
        public static List<LoaiXeDTO> FindAll()
        {
            var loaixeDTO = new LoaiXeDTO();
            loaixeDTO.Code = "C00";
            loaixeDTO.Name = "Không rõ";
            var result = loaixeDAL.FindAll();
            result.Add(loaixeDTO);
            return result;
        }
        public bool checkLoaiXe(String code)
        {
            string sql = "SELECT * FROM LoaiXe WHERE Code = '" + code + "'";
            DataTable check = data.GetTable(sql);
            if (check.Rows.Count == 0)
                return false;
            else
                return true;
        }
        public DataTable getLoaiXe()
        {
            string sql = "SELECT * FROM LoaiXe";
            return data.GetTable(sql);
        }
        public bool insertLoaiXe(String code, String name)
        {
            string sql = "INSERT INTO LoaiXe VALUES ('" + code + "', '" + name + "')";
            if (data.ExecuteNonQuery(sql))
                return true;
            else
                return false;
        }
        public bool updateLoaiXe(String code, String name)
        {
            string sql = "UPDATE LoaiXe SET Name = '" + name + "' WHERE Code = '" + code + "'";
            if (data.ExecuteNonQuery(sql))
                return true;
            else
                return false;
        }
        public bool deleteLoaiXe(String code)
        {
            string sql = "DELETE DungTich WHERE Code = '" + code + "'";
            if (data.ExecuteNonQuery(sql))
                return true;
            else
                return false;
        }
    }
}
