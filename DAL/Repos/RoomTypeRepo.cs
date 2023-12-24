using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class RoomTypeRepo : Repo, IRepo<RoomType, int, RoomType>
    {
        public RoomType Create(RoomType obj)
        {
            db.RoomTypes.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.RoomTypes.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<RoomType> Read()
        {
            return db.RoomTypes.ToList();
        }

        public RoomType Read(int id)
        {
            return db.RoomTypes.Find(id);
        }

        public RoomType Update(RoomType obj)
        {
            var ex = Read(obj.TypeID);// Update 
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
