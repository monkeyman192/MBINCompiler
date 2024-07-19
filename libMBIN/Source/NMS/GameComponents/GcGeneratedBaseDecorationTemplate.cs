using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x16B3E94B19E24792, NameHash = 0x6A92D05C)]
    public class GcGeneratedBaseDecorationTemplate : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public TkModelResource TemplateScene;
        [NMS(Index = 0)]
        /* 0x18 */ public NMSString0x10 Id;
        [NMS(Index = 5)]
        /* 0x28 */ public List<int> InvalidRoomIndexes;
        // size: 0x8
        public enum DecorationLayerEnum : uint {
            Stairs,
            Corridor,
            Room,
            Door,
            Decoration1,
            Decoration2,
            Decoration3,
            DecorationCorridor,
        }
        [NMS(Index = 4)]
        /* 0x38 */ public DecorationLayerEnum DecorationLayer;
        [NMS(Index = 3)]
        /* 0x3C */ public int MaxPerRoom;
        [NMS(Index = 2)]
        /* 0x40 */ public float Probability;
    }
}
