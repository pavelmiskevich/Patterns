using System;

namespace Decorator.OnInterface
{
    abstract class DecoratorI : IComponent
    {        
        protected IComponent component;

        public void SetComponent(IComponent component)
        {
            this.component = component;
        }

        public virtual void Operation()
        {
            if (component != null)
            {
                component.Operation();
            }
        }
    }
}
