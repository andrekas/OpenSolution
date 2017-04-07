﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.PartyClasses
{
    public class Address : UniqueEntity

    {

        public static Address Random()
        {
            var e = new Address();
            e.SetRandomValues();
            return e;
        }

    }
}
