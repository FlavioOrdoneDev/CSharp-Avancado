﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClownExample.Interfaces
{
    interface IScaryClown : IClown
    {
        string ScaryThingIHave { get; }

        void ScaryLittleChildren();
    }
}
