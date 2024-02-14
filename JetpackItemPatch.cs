using HarmonyLib;

namespace Uninvertible_Jetpack
{
    [HarmonyPatch(typeof(JetpackItem))]
    internal class JetpackItemPatch
    {
        [HarmonyPostfix]
        [HarmonyPatch(nameof(JetpackItem.DiscardItem))]
        public static void DiscardItem(ref JetpackItem __instance)
        {
            __instance.isBeingUsed = false;
        }

        [HarmonyPrefix]
        [HarmonyPatch(nameof(JetpackItem.ItemActivate))]
        public static void ItemActivate(ref JetpackItem __instance, bool __0, bool __1, ref bool ___jetpackActivatedPreviousFrame)
        {
            __instance.isBeingUsed = __1;
            ___jetpackActivatedPreviousFrame = ~(__0&__1);
        }
    }
}
