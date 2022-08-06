using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD488F83279CACB83, NameHash = 0x093D7C024B58A671)]
    public class GcMissionConditionUsingPortal : NMSTemplate
    {
        public enum PortalTypeEnum { Any, Story, NotStory }
        public PortalTypeEnum PortalType;
    }
}
