﻿using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.FlowerBouquetRepo
{
    public interface IFlowerBouquetRepository
    {
        public IEnumerable<FlowerBouquet> GetFlowerBouquetsList();

        public FlowerBouquet GetFlowerBouquetsById(int id);

        public void DeleteFlowerBouquet(int id);

        public void DeleteInOrder(int flowerBouquetId);
    }
}
