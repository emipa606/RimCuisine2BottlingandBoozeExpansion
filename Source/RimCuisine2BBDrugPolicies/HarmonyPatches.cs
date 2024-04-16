using HarmonyLib;
using RimWorld;
using Verse;

namespace RimCuisineBBDrugPolicies;

[StaticConstructorOnStartup]
public static class HarmonyPatches
{
    static HarmonyPatches()
    {
        var harmonyInstance = new Harmony("mehni.rimworld.rimCuisine.main");
        harmonyInstance.Patch(AccessTools.Method(typeof(Scenario), nameof(Scenario.PostGameStart)), null,
            new HarmonyMethod(typeof(HarmonyPatches), nameof(GenerateStartingDrugPolicies_PostFix)));
    }

    private static void GenerateStartingDrugPolicies_PostFix()
    {
        foreach (var drugPolicy in Current.Game.drugPolicyDatabase.AllPolicies)
        {
            if (drugPolicy.label != "SocialDrugs".Translate())
            {
                continue;
            }

            drugPolicy[RCBBDefOf.RC2_Ale].allowedForJoy = true;
            drugPolicy[RCBBDefOf.RC2_Cider].allowedForJoy = true;
            drugPolicy[RCBBDefOf.RC2_FruitWine].allowedForJoy = true;
            drugPolicy[RCBBDefOf.RC2_Mead].allowedForJoy = true;
            drugPolicy[RCBBDefOf.RC2_Sake].allowedForJoy = true;
            drugPolicy[RCBBDefOf.RC2_Stout].allowedForJoy = true;
            drugPolicy[RCBBDefOf.RC2_Wine].allowedForJoy = true;
            drugPolicy[RCBBDefOf.RC2_Grog].allowedForJoy = true;
            drugPolicy[RCBBDefOf.RC2_Kumis].allowedForJoy = true;
        }
    }
}