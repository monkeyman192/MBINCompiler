namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x28)]
    public class GcSavedInteractionDialogData : NMSTemplate
    {
        public ulong Hash;
        [NMS(Size = 0x20)]
        public string Dialog;
    }
}
