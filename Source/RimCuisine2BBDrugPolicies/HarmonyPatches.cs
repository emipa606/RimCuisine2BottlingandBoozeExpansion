using System;
using HarmonyLib;
using RimWorld;
using Verse;

namespace RimCuisineBBDrugPolicies
{
	// Token: 0x02000002 RID: 2
	[StaticConstructorOnStartup]
	public static class HarmonyPatches
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		static HarmonyPatches()
		{
			var harmonyInstance = new Harmony("mehni.rimworld.rimCuisine.main");
			harmonyInstance.Patch(AccessTools.Method(typeof(Scenario), "PostGameStart", null, null), null, new HarmonyMethod(typeof(HarmonyPatches), "GenerateStartingDrugPolicies_PostFix", null), null);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000020A0 File Offset: 0x000002A0
		private static void GenerateStartingDrugPolicies_PostFix()
		{
			foreach (DrugPolicy drugPolicy in Current.Game.drugPolicyDatabase.AllPolicies)
			{
				bool flag = drugPolicy.label == Translator.Translate("SocialDrugs");
				if (flag)
				{
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
	}
}
