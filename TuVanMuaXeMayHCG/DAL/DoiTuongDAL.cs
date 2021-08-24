using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuVanMuaXeMayHCG.DTO;

namespace TuVanMuaXeMayHCG.DAL
{
    class DoiTuongDAL
    {
        private dbDataContext db = new dbDataContext();
        public List<DoiTuongDTO> FindAll()
        {
            var query = db.DoiTuongs.Select(x =>
                new DoiTuongDTO
                {
                    Code = x.Code.Trim(),
                    Name = x.Name
                }
            ).ToList();
            return query;
        }
    }
}
