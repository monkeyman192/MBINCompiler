using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA0654B4BB77E9B17, NameHash = 0x1E4EF302)]
    public class GcGravityVolumesComponentData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcGravityVolumeType> GravityVolumeTypes;
        // size: 0x3
        public enum SearchNodeTypeEnum : uint {
            Attachment,
            Model,
            Master,
        }
        [NMS(Index = 0)]
        /* 0x10 */ public SearchNodeTypeEnum SearchNodeType;
        [NMS(Index = 2)]
        /* 0x14 */ public bool DeactivateOnModelHide;
    }
}
