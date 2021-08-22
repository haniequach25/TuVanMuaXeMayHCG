using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuVanMuaXeMayHCG.DTO;

namespace TuVanMuaXeMayHCG.DAL
{
    class HangDAL
    {
        private dbDataContext db = new dbDataContext();
        public List<HangDTO> FindAll()
        {
            var query = db.Hangs.Select(x =>
                new HangDTO
                {
                    Code = x.Code.Trim(),
                    Name = x.Name
                }
            ).ToList();
            return query;
        }
    }
}
