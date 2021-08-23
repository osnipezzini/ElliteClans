using BepInEx;
using BepInEx.Configuration;
using UnityEngine;

namespace ElliteClans
{
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
    [BepInDependency(Jotunn.Main.ModGuid)]
    //[NetworkCompatibility(CompatibilityLevel.EveryoneMustHaveMod, VersionStrictness.Minor)]
    internal class JotunnModStub : BaseUnityPlugin
    {
        public const string PluginGUID = "com.ellitedev.elliteclans";
        public const string PluginName = "ElliteClans";
        public const string PluginVersion = "1.0.0";

        private void Awake()
        {
            // Do all your init stuff here

            // Acceptable value ranges can be defined to allow configuration via a slider in the BepInEx ConfigurationManager:
            // https://github.com/BepInEx/BepInEx.ConfigurationManager
            Config.Bind<bool>("General Settings", "Is running on server-side ?", false, 
                new ConfigDescription("Set this if mod is running on server-side."));

            // Jotunn comes with its own Logger class to provide a consistent Log style for all mods using it
            Jotunn.Logger.LogInfo("ModStub has landed");
        }

#if DEBUG
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.F6))
            { // Set a breakpoint here to break on F6 key press
            }
        }
#endif
    }
}