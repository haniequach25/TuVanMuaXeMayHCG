using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuVanMuaXeMayHCG.DTO;

namespace TuVanMuaXeMayHCG.DAL
{
    class GiaTienDAL
    {
        private dbDataContext db = new dbDataContext();
        public List<GiaTienDTO> FindAll()
        {
            var query = db.GiaTiens.Select(x =>
                new GiaTienDTO
                {
                    Code = x.Code.Trim(),
                    Name = x.Name
                }
            ).ToList();
            return query;
        }
    }
}
