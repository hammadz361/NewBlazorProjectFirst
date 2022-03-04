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
        MD_UploadFile AddUploadFile(MD_UploadFile mD_UploadFile);
        MD_UpdatedBy AddUpdatedBy (MD_UpdatedBy mD_UpdatedBy);
        MD_Gender AddGender(MD_Gender mD_Gender);
        MD_EducationLevel AddEducationLevel(MD_EducationLevel mD_EducationLevel);

        Task<IEnumerable<MD_Address>> GetAllAddress();
        Task<IEnumerable<MD_UploadFile>> GetAllUploadFiles();
        Task<IEnumerable<MD_UpdatedBy>> GetAllUpdatedBy();
        Task<IEnumerable<MD_Gender>> GetAllGender();
        Task<IEnumerable<MD_EducationLevel>> GetAllEducationLevel();

        Task<MD_Address> GetAddressById(int Id);
        Task<MD_UploadFile> GetUploadFileById(int Id);
        Task<MD_UpdatedBy> GetUpdatedById(int Id);
        Task <MD_Gender> GetGenderById (int Id);
        Task<MD_EducationLevel> GetEducationLevelById(int Id);

        void UpdateAddress(MD_Address mD_Address);
        void UpdateUploadFile(MD_UploadFile mD_UploadFile);
        void UpdateUpdatedBy (MD_UpdatedBy mD_UpdateUpdatedBy);
        void UpdateGender(MD_Gender mD_Gender);
        void UpdateEducationLevel(MD_EducationLevel mD_EducationLevel);

        void DeleteAddress(int Id);
        void DeleteUploadFile(int Id);
        void DeleteUpdatedBy(int Id);
        void DeleteGender (int Id);
        void DeleteEducationLevel(int Id);
    }
}
