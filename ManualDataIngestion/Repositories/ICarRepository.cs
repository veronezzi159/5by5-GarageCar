﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Repositories
{
    public interface ICarRepository
    {
        public string Insert(Car car);

        public List<Car> GetAll();
    }
}
