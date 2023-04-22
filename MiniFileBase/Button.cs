namespace MiniFileBase
{
    abstract public class Button : IRunnable, IButton
    {
        public char Id { get; set; }

        public string Caption { get; set; }

        abstract public void Run();
    }
}
