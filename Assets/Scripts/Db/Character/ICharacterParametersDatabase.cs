using Db.Character.Impls;

namespace Db.Character
{
    public interface ICharacterParametersDatabase
    {
        CharacterParametersVo GetParameters(string characterType);
    }
}