using HarmonyLib;
using Nunppong;
using UnityEngine;

namespace LostRuinsHealthCheckpoint
{
    [HarmonyPatch]
    class RestorePlayerHPMPCheckpoint
    {

        [HarmonyPostfix]
        [HarmonyPatch(typeof(AutoSave), "OnTriggerEnter2D")]

        public static void HealOnAutoSaveCheckpoint(Collider2D collision)
        {
            if (collision.GetComponent<PlayableCharacter>() != null)
            {
                collision.GetComponent<PlayableCharacter>().Health.ResetHp();
                collision.GetComponent<PlayableCharacter>().Health.ResetMp();
            }
        }
    }
}
