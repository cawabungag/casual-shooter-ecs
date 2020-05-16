using View.Game;

namespace Db.Character
{
    public interface ICharacterPrefabDatabase
    {
        CharacterView GetCharacterView(string characterType);
    }
}