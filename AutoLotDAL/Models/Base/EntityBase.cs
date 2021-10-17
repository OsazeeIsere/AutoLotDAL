﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace AutoLotDAL.Models.Base
{
  public class EntityBase
    {
     [Key]
     public int Id { get; set; }
        [Timestamp]
        public byte[] Timestamp { get; set; }
    }
}
