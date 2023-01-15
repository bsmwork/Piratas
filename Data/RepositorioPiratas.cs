


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class RepositorioPiratas
    {
        protected string pathDbLite { get; set; }
        public RepositorioPiratas()
        {
            this.pathDbLite = @"C:\data\dblite\piratas.db";
        }
       
    }

}
