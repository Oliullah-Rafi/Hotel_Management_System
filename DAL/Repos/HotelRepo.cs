using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    class HotelRepo : Repo, IRepo<Hotel, string, Hotel>
    {
        public Hotel Create(Type obj)
        {
            db.Hotels.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;

            
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Type> Read()
        {
            throw new NotImplementedException();
        }

        public Type Read(string id)
        {
            throw new NotImplementedException();
        }

        public Hotel Update(Hotel obj)
        {
            throw new NotImplementedException();
        }
    }
}
