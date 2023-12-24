using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class StaffRepo : Repo, IRepo<Staff, int, Staff>
    {
        public Staff Create(Staff obj)
        {
            db.Staffs.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.Staffs.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Staff> Read()
        {
            return db.Staffs.ToList();
        }

        public Staff Read(int id)
        {
            return db.Staffs.Find(id);
        }

        public Staff Update(Staff obj)
        {
            var ex = Read(obj.StaffID);// Update 
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
   
}
