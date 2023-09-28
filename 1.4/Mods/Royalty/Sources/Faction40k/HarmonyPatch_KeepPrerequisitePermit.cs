using HarmonyLib;
using RimWorld;
using Verse;


namespace Faction40k
{
    [HarmonyPatch(typeof(Pawn_RoyaltyTracker), "AddPermit")]
    public class KeepPrerequisitePermit
    {
        public static void Postfix(RoyalTitlePermitDef permit, Faction faction, Pawn_RoyaltyTracker __instance)
        {
            if (!permit.HasModExtension<DefModExtension_KeepTitlePrerequisite>())
            {
                return;
            }

            if (permit.prerequisite == null)
            {
                return;
            }
            __instance.AllFactionPermits.Add(new FactionPermit(faction, __instance.GetCurrentTitle(faction), permit.prerequisite));
        }
    }
}