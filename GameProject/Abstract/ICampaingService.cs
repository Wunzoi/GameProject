﻿using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    public interface ICampaingService
    {
        void Add(Campaing campaing);
        void Delete(Campaing campaing);
        void Update(Campaing campaing);
    }
}
