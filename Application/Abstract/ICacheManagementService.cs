namespace Application.Abstract
{
    public interface ICacheManagementService
    {
        Task<bool> Clear();
    }
}
