using System.Reflection;
using HarmonyLib;
using Verse;

namespace RimCuisineBBDrugPolicies;

[StaticConstructorOnStartup]
public static class HarmonyPatches
{
    static HarmonyPatches()
    {
        new Harmony("mehni.rimworld.rimCuisine.main").PatchAll(Assembly.GetExecutingAssembly());
    }
}