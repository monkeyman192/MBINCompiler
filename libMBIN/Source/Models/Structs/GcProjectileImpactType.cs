namespace libMBIN.Models.Structs
{
    public class GcProjectileImpactType : NMSTemplate
    {
        /* 0x000 */ public int Impact;
        public string[] ImpactValues()
        {
            return new[] { "Default", "Terrain", "Substance", "Rock", "Asteroid", "Shield", "Creature", "Robot", "Freighter", "Cargo", "Ship", "Plant",
                           "NeedsTech", "Player", "OtherPlayer"};
        }
    }
}
