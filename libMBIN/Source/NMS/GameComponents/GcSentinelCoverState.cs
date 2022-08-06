using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xECF98C337CC9F928, NameHash = 0x9AFBFA1C253ADF63)]
    public class GcSentinelCoverState : NMSTemplate
    {
        // size: 0x4
        public enum SentinelCoverStateEnum { Deploying, Deployed, ShuttingDown, ShutDown }
        /* 0x0 */ public SentinelCoverStateEnum SentinelCoverState;
    }
}
