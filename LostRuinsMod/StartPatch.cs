using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace LostRuinsHealthCheckpoint
{
    [BepInPlugin("org.thyraxx.lostruinshealcheckpoint", "Lost Ruins Heal Checkpoint", "0.0.1")]
    public class StartPatch : BaseUnityPlugin
    {
        public const string pluginGuid = "org.thyraxx.lostruinshealcheckpoint";
        Harmony harmony = new Harmony(pluginGuid);

        public new static ManualLogSource Logger;
        public void Awake()
        {
            Logger = base.Logger;
            Logger.LogInfo("Lostruinshealcheckpoint Loaded!");

            harmony.PatchAll();
        }

        private void OnDestroy()
        {
            Logger.LogInfo("Lostruinshealcheckpoint Unloaded!");

            // For hot-reload scriptEngine
            harmony.UnpatchSelf();
        }
    }
}
