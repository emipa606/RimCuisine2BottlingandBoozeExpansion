using HarmonyLib;
using RimWorld;
using Verse;

namespace RimCuisineBBDrugPolicies;

[HarmonyPatch(typeof(Scenario), nameof(Scenario.PostGameStart))]
public static class Scenario_PostGameStart_Patch
{
    public static void Postfix()
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