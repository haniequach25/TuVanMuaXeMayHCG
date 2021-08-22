using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuVanMuaXeMayHCG.DTO;

namespace TuVanMuaXeMayHCG.DAL
{
    class LuatDAL
    {
        private dbDataContext db = new dbDataContext();
        public List<LuatDTO> FindAll()
        {
            var query = db.Luats.Select(x => new LuatDTO
            {
                Code = x.Code,
                RLeft = x.RLeft.Trim().Split('^'),
                RRight = x.RRight.Trim()
            }
            ).ToList();
            return query;
        }

        public LuatDTO FindById(int code)
        {
            var query = db.Luats.Select(x => new LuatDTO
            {
                Code = x.Code,
                RLeft = x.RLeft.Trim().Split('^'),
                RRight = x.RRight.Trim()
            }
            ).Where(x => x.Code == code).SingleOrDefault();
            return query;
        }

        public bool Insert(string left, string right)
        {
            Luat luat = new Luat();

            luat.RLeft = left;
            luat.RRight = right;
            db.Luats.InsertOnSubmit(luat);
            db.SubmitChanges();
            return true;
        }
        public bool Update(int id, string left, string right)
        {
            Luat rule = new Luat();
            rule.Code = id;
            rule.RLeft = left;
            rule.RRight = right;
            db.Luats.InsertOnSubmit(rule);
            db.SubmitChanges();
            return true;
        }

        public bool Delete(int code)
        {
            Luat rule = db.Luats.Single(mb => mb.Code == code);
            db.Luats.DeleteOnSubmit(rule);
            db.SubmitChanges();
            return true;
        }
    }
}
