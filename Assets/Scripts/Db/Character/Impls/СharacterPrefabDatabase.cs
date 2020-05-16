using System;
using Extensions.Utils;
using UnityEngine;
using View.Game;

namespace Db.Character.Impls
{
    [CreateAssetMenu(fileName = "СharacterPrefabDatabase", menuName = "Databases/СharacterPrefabDatabase")]
    public class СharacterPrefabDatabase : ScriptableObject, ICharacterPrefabDatabase
    {
        [KeyValue("characterType")] [SerializeField]
        private CharacterPrefabVo[] characterPrefabVo;

        public CharacterView GetCharacterView(string characterType)
        {
            for (int i = 0; i < characterPrefabVo.Length; i++)
            {
                var characterView = characterPrefabVo[i];
                if (characterView.AttackType == characterType)
                {
                    return characterView.View;
                }
            }

            throw new Exception(
                $"[{nameof(СharacterPrefabDatabase)}] No character prefab with characterType {characterType}");
        }
    }
}