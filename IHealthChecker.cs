namespace tst
{
    using System.Threading.Tasks;

    public interface IHealthChecker
    {
        Task CheckHealth();
    }
}
