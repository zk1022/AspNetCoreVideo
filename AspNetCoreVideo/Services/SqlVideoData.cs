﻿using AspNetCoreVideo.Data;
using AspNetCoreVideo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreVideo.Services
{
    public class SqlVideoData : IVideoData
    {
        private VideoDbContext _db;

        public SqlVideoData(VideoDbContext db)
        {
            _db = db;
        }

        public void Add(Video newVideo)
        {
            _db.Add(newVideo);
        }
        public int Commit()
        {
            return _db.SaveChanges();
        }


        public Video Get(int id)
        {
            return _db.Find<Video>(id);
        }

        public IEnumerable<Video> GetAll()
        {
            return _db.Videos;
        }
    }
}
