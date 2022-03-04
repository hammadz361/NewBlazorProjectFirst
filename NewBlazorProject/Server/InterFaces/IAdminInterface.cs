using NewBlazorProject.Shared.Models.MasterData;

namespace NewBlazorProject.Server.InterFaces
{
    /*1- Create Methods
    2- Get All Methods
    3- Get By Id Methods
    4- Update Methods
    5- Delete Methods*/
    public interface IAdminInterface
    {
        MD_Address AddAddress(MD_Address mD_Address);

        Task<IEnumerable<MD_Address>> GetAllAddress();

        Task<MD_Address> GetAddressById(int Id);

        void UpdateAddress(MD_Address mD_Address);

        void DeleteAddress(int Id);
    }
}
