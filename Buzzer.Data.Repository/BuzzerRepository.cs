using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buzzer.Data;
using Buzzer.Data.Repository;

namespace Buzzer.Data.Test
{
  public  class BuzzerRepository :IRepository
    {
      private readonly BuzzerEntityContext _context;

      public BuzzerRepository()
      {
          _context = new BuzzerEntityContext();

      }
      
      public IQueryable<T1> All<T1>() where T1 :class
        {
            return _context.Set<T1>();
        }
    }
}
