﻿using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class RoomRepo : Repo, IRepo<Room, int, Room>
    {
        public Room Create(Room obj)
        {
            db.Rooms.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.Guests.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Room> Read()
        {
            return db.Rooms.ToList();
        }

        public Room Read(int id)
        {
            return db.Rooms.Find(id);
        }

        public Room Update(Room obj)
        {
            var ex = Read(obj.RoomID);// Update 
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
