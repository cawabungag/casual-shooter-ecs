using Db.Character;
using Db.Character.Impls;
using UnityEngine;
using Zenject;

namespace Installers.Game
{
    [CreateAssetMenu(menuName = "Installers/DatabasesInstaller", fileName = "DatabasesInstaller")]
    public class DatabasesInstaller : ScriptableObjectInstaller
    {
        [SerializeField] private CharacterParametersDatabase characterParametersDatabase;
        [SerializeField] private СharacterPrefabDatabase сharacterPrefabDatabase;

        public override void InstallBindings()
        {
            Container.Bind<ICharacterParametersDatabase>().FromInstance(characterParametersDatabase).AsSingle();
            Container.Bind<ICharacterPrefabDatabase>().FromInstance(сharacterPrefabDatabase).AsSingle();
        }
    }
}