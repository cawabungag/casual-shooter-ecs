using Entitas;
using Entitas.Unity;
using UnityEngine;

namespace Ecs.Impls
{
    public abstract class LinkableView : MonoBehaviour, ILinkableView
    {
        private IEntity _entity;
        private bool _destroyed;

        public void Link(IEntity entity, IContext context)
        {
            gameObject.Link(entity, context);
            _entity = entity;
            _entity.OnDestroyEntity += OnDestroyEntity;
            Listen(_entity);
        }

        private void OnDestroyEntity(IEntity entity)
        {
            gameObject.Unlink();
            if (!_destroyed)
                Clear();
            if (entity.isEnabled)
            {
                Unlisten(_entity);
                _entity.OnDestroyEntity -= OnDestroyEntity;
            }

            _entity = default;
        }

        public abstract void Listen(IEntity entity);
        public abstract void Unlisten(IEntity entity);
        public abstract void Clear();

        private void OnDestroy()
        {
            _destroyed = true;
            if (_entity != null)
                OnDestroyEntity(_entity);
        }
    }
}