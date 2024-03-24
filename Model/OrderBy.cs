using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldApp.Model
{
    internal enum OrderBy
    {
        OrderByIdAsc,
        OrderByIdDesc,
        OrderByShortNameAsc,
        OrderByShortNameDesc,
        OrderByFullNameAsc,
        OrderByFullNameDesc,
        OrderByAlpha2CodeAsc,
        OrderByAlpha2CodeDesc,
        OrderByAlpha3CodeAsc,
        OrderByAlpha3CodeDesc,
        OrderByNumericCodeAsc,
        OrderByNumericCodeDesc,
        OrderByPopulationAsc,
        OrderByPopulationDesc,
        OrderByAreaAsc,
        OrderByAreaDesc,
    }
}
