using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuVanMuaXeMayHCG.DTO;

namespace TuVanMuaXeMayHCG.DAL
{
    class DungTichDAL
    {
        private dbDataContext db = new dbDataContext();
        public List<DungTichDTO> FindAll()
        {
            var query = db.DungTiches.Select(x =>
                new DungTichDTO
                {
                    Code = x.Code.Trim(),
                    Name = x.Name
                }
            ).ToList();
            return query;
        }
    }
}
