using System;
using UnityEngine;
using View.Game;

namespace Db.Character.Impls
{
    [Serializable]
    public class CharacterPrefabVo
    {
        [SerializeField] private ECharacterType type;
        [SerializeField] private CharacterView view;

        public ECharacterType Type
        {
            get => type;
            set => type = value;
        }


        public CharacterView View
        {
            get => view;
            set => view = value;
        }
    }
}