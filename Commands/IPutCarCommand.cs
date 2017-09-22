namespace tst.Commands
{
    using Boilerplate.AspNetCore;
    using tst.ViewModels;

    public interface IPutCarCommand : IAsyncCommand<int, SaveCar>
    {
    }
}
