using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftManagementApp.Application;

public interface IMapper<TDTO, TOutput>
{
    public TOutput ToEntity(TDTO dto);   
}
