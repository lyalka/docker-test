namespace tst.Commands
{
    using Boilerplate.AspNetCore;
    using tst.ViewModels;

    public interface IGetCarPageCommand : IAsyncCommand<PageOptions>
    {
    }
}
