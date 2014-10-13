using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestDotNetWebApp.Models
{
    public partial class Category : BaseEntity
    {
        public string Name { get; set; }
        public int OrderIndex { get; set; }
    }
}