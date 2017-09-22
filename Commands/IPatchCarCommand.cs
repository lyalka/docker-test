namespace tst.Commands
{
    using Boilerplate.AspNetCore;
    using Microsoft.AspNetCore.JsonPatch;
    using tst.ViewModels;

    public interface IPatchCarCommand : IAsyncCommand<int, JsonPatchDocument<SaveCar>>
    {
    }
}
