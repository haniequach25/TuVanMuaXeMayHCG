using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuVanMuaXeMayHCG.DTO;

namespace TuVanMuaXeMayHCG.DAL
{
    class DacDiemDAL
    {
        private dbDataContext db = new dbDataContext();
        public List<DacDiemDTO> FindAll()
        {
            var query = db.DacDiems.Select(x =>
                new DacDiemDTO
                {
                    Code = x.Code.Trim(),
                    Name = x.Name
                }
            ).ToList();
            return query;
        }
    }
}
