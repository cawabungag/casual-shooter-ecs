using System;
using UnityEngine;

namespace Db.Character.Impls
{
    [Serializable]
    public class CharacterParametersVo
    {
        [SerializeField] private string characterType;
        [SerializeField] private int damage;
        [SerializeField] private int health;
        [SerializeField] private int reloadingTime;
        [SerializeField] private int rangeAttack;
        [SerializeField] private ECharacterAttackType attackType;

        public string CharacterType
        {
            get => characterType;
            set => characterType = value;
        }

        public int Damage
        {
            get => damage;
            set => damage = value;
        }

        public int Health
        {
            get => health;
            set => health = value;
        }

        public int ReloadingTime
        {
            get => reloadingTime;
            set => reloadingTime = value;
        }

        public int RangeAttack
        {
            get => rangeAttack;
            set => rangeAttack = value;
        }

        public ECharacterAttackType AttackType
        {
            get => attackType;
            set => attackType = value;
        }
    }
}