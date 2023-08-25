using HarmonyLib;
using Verse;


namespace Faction40k
{
    public class Faction40kMod : Mod
    {
        public static Harmony harmony;
        public Faction40kMod(ModContentPack content) : base(content)
        {
            harmony = new Harmony("Faction40k.Mod");
            harmony.PatchAll();
        }
    }
}