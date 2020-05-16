using Entitas;

namespace Ecs
{
    public interface ILinkableView
    {
        void Link(IEntity entity, IContext context);
    }
}