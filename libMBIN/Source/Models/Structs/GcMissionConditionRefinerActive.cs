namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x88)]
    public class GcMissionConditionRefinerActive : NMSTemplate
    {
        public bool HasFuel;
        [NMS(Size = 0x80)]
        public string ActiveRecipe;
        public int AmountToMake;
    }
}
