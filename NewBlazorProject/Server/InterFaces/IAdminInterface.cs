using NewBlazorProject.Shared.Models.MasterData;

namespace NewBlazorProject.Server.InterFaces
{
    public interface IAdminInterface
    {
        MD_Address AddAddress(MD_Address mD_Address);
        Task<MD_Address> GetAddressById(int Id);
        Task<IEnumerable<MD_Address>> GetAllAddress();
        void UpdateAddress(MD_Address mD_Address);
        void DeleteAddress(int Id);
    }
}
