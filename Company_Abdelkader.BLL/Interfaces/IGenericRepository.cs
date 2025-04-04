﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company_Abdelkader.DAL.Models;

namespace Company_Abdelkader.BLL.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T GetById(int id);

        int Add(T model);
        int Update(T model);
        int Delete(T model);
     
    }
}
