﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CFX.ResourcePerformance.SolderPastePrinting
{
    public class CleanSqueegeeRequest : CFXMessage
    {
        public SMTCleanType CleanTypeRequested
        {
            get;
            set;
        }
    }
}
