﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Core.Entities;
using Zoo.Core.Interfaces;

namespace Zoo.Service.Services
{
    public class VisitorsService:IService<Visitor>
    {
        readonly IRepository<Visitor> _iRepository;
        public VisitorsService(IRepository<Visitor> iRepository)
        {
            _iRepository = iRepository;
        }
        public List<Visitor> Get()
        {
            return _iRepository.Get();
        }
        public Visitor GetById(int id)
        {
            return _iRepository.GetById(id);
        }
        public bool IsValidTz(string tz)
        {
            if (tz.Length != 9)
                return false;
            int sum = 0, i = 0, plus;
            while (i < tz.Length - 1)
            {
                if (tz[i] < '0' || tz[i] > '9')
                    return false;
                plus = tz[i] - '0';
                if (i % 2 == 1)
                    plus *= 2;
                if (plus > 9)
                    plus = plus / 10 + plus % 10;
                sum += plus;
                i++;
            }
            sum %= 10;
            if (10 - sum == tz[tz.Length - 1] - '0')
                return true;
            return false;
        }
        public bool Add(Visitor item)
        {
            if (IsValidTz(item.TZ))
                return _iRepository.Add(item);
            return false;
        }
        public bool Update(int id, Visitor item)
        {
            if (IsValidTz(item.TZ))
                return _iRepository.Update(id, item);
            return false;
        }
        public bool DeleteById(int id)
        {
            return _iRepository.DeleteById(id);
        }
    }
}
