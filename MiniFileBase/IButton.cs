namespace MiniFileBase
{
    public interface IButton : IRunnable
    {

        char Id { get; set; }

        string Caption { get; set; }
    }
}
