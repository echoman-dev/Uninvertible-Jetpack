using System.Reflection;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace Uninvertible_Jetpack
{
    [BepInPlugin(modGUID, modName, modVersion)]
    [BepInProcess("Lethal Company.exe")]
    public class Plugin : BaseUnityPlugin
    {
        private const string modGUID = "io.github.echoman-dev.uninvertible-jetpack";
        private const string modName = "Lethal Company Uninvertible Jetpacks";
        private const string modVersion = "0.0.1";

        private readonly Harmony harmony = new Harmony(modGUID);
        internal static ManualLogSource log;

        void Awake()
        {
            log = Logger;

            log.LogInfo($"{modName} v{modVersion} loaded.");

            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
