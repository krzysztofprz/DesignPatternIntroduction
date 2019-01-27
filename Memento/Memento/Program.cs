using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator<StateObject> current = new Originator<StateObject>();
            current.SetState(new StateObject { Id = 1, Name = "Version 1" });
            CareTaker<StateObject>.SaveState(current);
            current.ShowState();

            current.SetState(new StateObject { Id = 2, Name = "Version 2" });
            CareTaker<StateObject>.SaveState(current);
            current.ShowState();

            current.SetState(new StateObject { Id = 3, Name = "Version 3" });
            CareTaker<StateObject>.SaveState(current);
            current.ShowState();

            CareTaker<StateObject>.RestoreState(current, 1);
            current.ShowState();

            Console.ReadKey();
        }
    }
}
