﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs.Lib.Abstract
{
    public interface ISarjorlu
    {
        int SarjorKapatisesi { get; }
        int KalanFisek { get; }
        int YenidenDoldur();
    }
}
