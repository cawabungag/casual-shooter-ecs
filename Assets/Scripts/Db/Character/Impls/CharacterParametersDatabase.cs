using System;
using Extensions.Utils;
using UnityEngine;

namespace Db.Character.Impls
{
    [CreateAssetMenu(fileName = "CharacterParametersDatabase", menuName = "Databases/CharacterParametersDatabase")]
    public class CharacterParametersDatabase : ScriptableObject, ICharacterParametersDatabase
    {
        [KeyValue("characterType")] [SerializeField]
        private CharacterParametersVo[] characterPrefabVos;

        public CharacterParametersVo GetParameters(string characterType)
        {
            for (int i = 0; i < characterPrefabVos.Length; i++)
            {
                var characterParameters = characterPrefabVos[i];
                if (characterParameters.CharacterType == characterType)
                {
                    return characterParameters;
                }
            }

            throw new Exception(
                $"[{nameof(СharacterPrefabDatabase)}] No character parameters with characterType {characterType}");
        }
    }
}