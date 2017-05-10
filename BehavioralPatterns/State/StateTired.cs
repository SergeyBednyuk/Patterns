using System;

namespace State
{
    class StateTired : StateBase
    {
        public static readonly StateTired Instance = new StateTired();

        public override void HandleKid(Parent parent)
        {
            Console.WriteLine("Дать ремня");
            parent.State = StateHappy.Instance;
        }

        public override void HandleOlder(Parent parent)
        {
            Console.WriteLine("Лишить карманных денег");
            parent.State = StateHappy.Instance;
        }
    }
}
