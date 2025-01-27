﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class category
    {
        [Key]
        public int categoryID { get; set; }
        [StringLength(50)]
        public string categoryname { get; set; }
        [StringLength(200)]
        public string categorydescription { get; set; }
        public bool categorystatus { get; set; }


        public ICollection<Heading> Headings { get; set; }
    }
}
