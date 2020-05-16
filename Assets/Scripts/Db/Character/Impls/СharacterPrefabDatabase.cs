using System;
using Extensions.Utils;
using UnityEngine;
using View.Game;

namespace Db.Character.Impls
{
    [CreateAssetMenu(fileName = "СharacterPrefabDatabase", menuName = "Databases/СharacterPrefabDatabase")]
    public class СharacterPrefabDatabase : ScriptableObject, ICharacterPrefabDatabase
    {
        [KeyValue("type")] [SerializeField] private CharacterPrefabVo[] characterPrefabVo;

        public CharacterView GetCharacterView(ECharacterType type)
        {
            for (int i = 0; i < characterPrefabVo.Length; i++)
            {
                var characterView = characterPrefabVo[i];
                if (characterView.Type == type)
                {
                    return characterView.View;
                }
            }

            throw new Exception($"[{nameof(СharacterPrefabDatabase)}] No character prefab with type {type}");
        }
    }
}