using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buzzer.Data
{
    public interface IRepository
    {

        IQueryable<T1> All<T1>() where T1 : class;
    }
}
