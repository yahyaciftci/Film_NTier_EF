﻿using DAL;
using DTO.FilmBoxDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class SeriesCategoryDetailRepository : IFilmBox<SeriesCategoryDetailCs>
    {
        FilmBox_DbEntities db = Db_Tools.DbInstance;
        public void Delete(int id)
        {
            SeriesCategoryDetail gelen = db.SeriesCategoryDetails.Find(id);
            db.SeriesCategoryDetails.Remove(gelen);
            db.SaveChanges();
        }

        public List<SeriesCategoryDetailCs> GetAll()
        {
            return db.SeriesCategoryDetails.Select(c => new SeriesCategoryDetailCs {SeriesCategoryDetailID=c.SeriesCategoryDetailID,SeriesId=c.SeriesId,CategoryId=c.CategoryId }).ToList();
        }

        public SeriesCategoryDetailCs GetByID(int ID)
        {
           SeriesCategoryDetail gelen= db.SeriesCategoryDetails.Find(ID);
            return new SeriesCategoryDetailCs { SeriesCategoryDetailID = gelen.SeriesCategoryDetailID, SeriesId = gelen.SeriesId, CategoryId = gelen.CategoryId };
        }

        public void Insert(SeriesCategoryDetailCs item)
        {
            db.SeriesCategoryDetails.Add(new SeriesCategoryDetail { SeriesCategoryDetailID = item.SeriesCategoryDetailID, SeriesId = item.SeriesId, CategoryId = item.CategoryId });
            db.SaveChanges();
        }

        public void Update(SeriesCategoryDetailCs item)
        {
           SeriesCategoryDetail gelen= db.SeriesCategoryDetails.Find(item.SeriesCategoryDetailID);
            gelen.SeriesId = item.SeriesId;
            gelen.CategoryId = item.CategoryId;
            db.SaveChanges();
        }
    }
}
