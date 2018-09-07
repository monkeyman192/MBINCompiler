namespace libMBIN.Models.Structs
{
    public class GcAlienSpeechEntry : NMSTemplate       // size: 0x40
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Id;

        [NMS(Size = 0x20)]
        /* 0x10 */ public string Text;

        public enum WordInteractEffectEnum { Pain, Heal };
        /* 0x30 */ public WordInteractEffectEnum WordInteractEffect;

        /* 0x34 */ public GcAlienRace AlienRace;
        /* 0x38 */ public int Level;
        [NMS(Ignore = true)]
        public int EndPadding;
    }
}
