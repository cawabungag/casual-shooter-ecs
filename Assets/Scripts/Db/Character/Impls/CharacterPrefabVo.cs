using System;
using UnityEngine;
using View.Game;

namespace Db.Character.Impls
{
    [Serializable]
    public class CharacterPrefabVo
    {
        [SerializeField] private string characterType;
        [SerializeField] private CharacterView view;

        public string AttackType
        {
            get => characterType;
            set => characterType = value;
        }


        public CharacterView View
        {
            get => view;
            set => view = value;
        }
    }
}