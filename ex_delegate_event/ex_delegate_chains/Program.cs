using System;
using static System.Console;

namespace ex_delegate_chains
{
    delegate void Notify(string message);

    class Notifier
    {
        public Notify EventOccured;
    }

    class EventListener
    {
        private string name;
        public EventListener(string name)
        {
            this.name = name;
        }

        public void SomethingHappend(string message)
        {
            WriteLine($"{name}.SomethingHappend : {message}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Notifier notifier = new Notifier();
            EventListener eventListener1 = new EventListener("Listener1");
            EventListener eventListener2 = new EventListener("Listener2");
            EventListener eventListener3 = new EventListener("Listener3");
            EventListener eventListener4 = new EventListener("Listener4");

            notifier.EventOccured += eventListener1.SomethingHappend;
            notifier.EventOccured += eventListener2.SomethingHappend;
            notifier.EventOccured += eventListener3.SomethingHappend;
            notifier.EventOccured("you've got mail");
            WriteLine();

            notifier.EventOccured -= eventListener2.SomethingHappend;
            notifier.EventOccured("Download complete");
            WriteLine();

            notifier.EventOccured = new Notify(eventListener2.SomethingHappend) + new Notify(eventListener3.SomethingHappend);
            notifier.EventOccured("nuclear launch detected");
            WriteLine();

            Notify notify1 = new Notify(eventListener1.SomethingHappend);
            Notify notify2 = new Notify(eventListener2.SomethingHappend);

            notifier.EventOccured = (Notify)Delegate.Combine(notify1, notify2);
            notifier.EventOccured("Fire");
            WriteLine();

            notifier.EventOccured = (Notify)Delegate.Remove(notifier.EventOccured, notify2);
            notifier.EventOccured("RPG");
        }
    }
}
