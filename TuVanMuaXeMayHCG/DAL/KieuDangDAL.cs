using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuVanMuaXeMayHCG.DTO;

namespace TuVanMuaXeMayHCG.DAL
{
    class KieuDangDAL
    {
        private dbDataContext db = new dbDataContext();
        public List<KieuDangDTO> FindAll()
        {
            var query = db.KieuDangs.Select(x =>
                new KieuDangDTO
                {
                    Code = x.Code.Trim(),
                    Name = x.Name
                }
            ).ToList();
            return query;
        }
    }
}
