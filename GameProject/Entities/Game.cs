﻿using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Entities
{
    public class Game:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string GameType { get; set; }
        public decimal Price { get; set; }
    }
}
