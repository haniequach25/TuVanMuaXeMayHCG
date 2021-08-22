using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuVanMuaXeMayHCG.DTO;

namespace TuVanMuaXeMayHCG.DAL
{
    class XeDAL
    {
        dbDataContext db = new dbDataContext();
        public List<XeDTO> FindAll()
        {
            var query = db.Xes.Select(x =>
                new XeDTO
                {
                    Code = x.Code.Trim(),
                    Name = x.Name,
                    Price = (int)x.Price,
                    Brand = x.Brand,
                    Type = x.Type,
                    Capacity = x.Capacity,
                }
            ).ToList();
            return query;
        }
    }
}
