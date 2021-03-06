﻿using System;
using System.Collections.Generic;
using System.Text;
using CFX.Structures;

namespace CFX.InformationSystem.WorkOrderManagement
{
    /// <summary>
    /// Sent when the status of a Work Order (or Work Order sub-batch) has been updated.
    /// <code language="none">
    /// {
    ///   "WorkOrderIdentifier": {
    ///     "WorkOrderId": "WO1122334455",
    ///     "Batch": null
    ///   },
    ///   "NewStatus": "Scheduled",
    ///   "PreviousStatus": "ApprovedAndPending"
    /// }
    /// </code>
    /// </summary>
    public class WorkOrderStatusUpdated : CFXMessage
    {
        /// <summary>
        /// The Identifier of the relevant Work Order or Work Order sub-batch
        /// </summary>
        public WorkOrderIdentifier WorkOrderIdentifier
        {
            get;
            set;
        }

        /// <summary>
        /// The new current status of the Work Order (or Work Order sub-batch)
        /// </summary>
        public WorkOrderStatus NewStatus
        {
            get;
            set;
        }

        /// <summary>
        /// The previous status of the Work Order (or Work Order sub-batch)
        /// </summary>
        public WorkOrderStatus PreviousStatus
        {
            get;
            set;
        }
    }
}
