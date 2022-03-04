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
        MD_CreatedBy AddCreatedBy(MD_CreatedBy mD_CreatedBy);
        MD_Directory AddDirectory(MD_Directory mD_Directory);
        MD_Education AddEducation(MD_Education mD_Education);

        Task<IEnumerable<MD_Address>> GetAllAddress();
        Task<IEnumerable<MD_CreatedBy>> GetAllCreatedBy();
        Task<IEnumerable<MD_Directory>> GetAllDirectory();
        Task<IEnumerable<MD_Education>> GetAllEducation();


        Task<MD_Address> GetAddressById(int Id);
        Task<MD_CreatedBy> GetCreatedById(int Id);
        Task<MD_Directory> GetDirectoryById(int Id);
        Task<MD_Education> GetEducationById(int Id);

        void UpdateAddress(MD_Address mD_Address);
        void UpdateCreatedBy(MD_CreatedBy mD_CreatedBy);
        void UpdateDirectory(MD_Directory mD_Directory);
        void UpdateEducation(MD_Education mD_Education);

        void DeleteAddress(int Id);
        void DeleteCreatedBy(int Id);
        void DeleteDirectory(int Id);
        void DeleteEducation(int Id);
        
    }
}
