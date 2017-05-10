namespace Decorator
{
    internal abstract class ComponentDecorator:IComponent
    {
        private readonly IComponent component;

        public ComponentDecorator(IComponent component)
        {
            this.component = component;
        }
        public virtual string Text { get; set; }
        public virtual void Print()
        {
           component.Print();
        }
    }
}
