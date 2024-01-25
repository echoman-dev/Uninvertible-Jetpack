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
    }
}
