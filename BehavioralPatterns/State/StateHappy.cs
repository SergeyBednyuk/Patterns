using System;


namespace State
{
    class StateHappy : StateBase
    {
        public static readonly StateHappy Instance = 
            new StateHappy();

        public override void HandleKid(Parent parent)
        {
            Console.WriteLine("Поиграть");
            parent.State = StateTired.Instance;
        }

        public override void HandleOlder(Parent parent)
        {
            Console.WriteLine("Спросить как дела в школе?");
            parent.State = StateTired.Instance;
        }
    }
}
