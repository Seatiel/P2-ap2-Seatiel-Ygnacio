using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace DAL
{
    public class Parcial2Ap2Db : DbContext  
    {
        public Parcial2Ap2Db() : base ("ConStr")
        {

        }


    }
}
