﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CFX.ResourcePerformance.SolderPastePrinting
{
    public class CleanStencilResponse : CFXMessage
    {
        public CleanStencilResponse()
        {
            Result = new RequestResult();
        }

        public RequestResult Result
        {
            get;
            set;
        }
    }
}
