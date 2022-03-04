using NewBlazorProject.Shared.Models.HR_Data;

namespace NewBlazorProject.Server.InterFaces
{
    public interface IHRInterface
    {
        HR_Posting AddPosting(HR_Posting hR_Posting);
        HR_Designation AddDesignation(HR_Designation hR_Designation);
        HR_Clearance AddClearance(HR_Clearance hR_Clearance);
        HR_Catagory hR_Catagory(HR_Catagory hR_Catagory);

        Task<IEnumerable<HR_Posting>> GetAllPostings();
        Task<IEnumerable<HR_Designation>> GetAllDesignation();
        Task<IEnumerable<HR_Clearance>> GetAllClearacne();
        Task<IEnumerable<HR_Catagory>> GetAllCatagory();

        Task<HR_Posting> GetPostingsById(int Id);
        Task<HR_Designation> GetDesignationById(int Id);
        Task<HR_Clearance> GetClearanceById(int Id);
        Task<HR_Catagory> GetCatagoryById(int Id);

        void UpdatePosting(HR_Posting hR_Posting);
        void UpdateDesignation(HR_Designation hR_Designation);
        void UpdateClearance(HR_Clearance hR_Clearance);
        void UpdateCatagory(HR_Catagory hR_Catagory);

        void DeletePostingsById(int Id);
        void DeleteDesignation(int Id);
        void DeleteClearance(int Id);
        void DeleteCatagory(int Id);
    }
}
