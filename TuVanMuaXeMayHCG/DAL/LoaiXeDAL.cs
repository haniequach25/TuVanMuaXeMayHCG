using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuVanMuaXeMayHCG.DTO;

namespace TuVanMuaXeMayHCG.DAL
{
    class LoaiXeDAL
    {
        private dbDataContext db = new dbDataContext();
        public List<LoaiXeDTO> FindAll()
        {
            var query = db.LoaiXes.Select(x =>
                new LoaiXeDTO
                {
                    Code = x.Code.Trim(),
                    Name = x.Name
                }
            ).ToList();
            return query;
        }
    }
}
