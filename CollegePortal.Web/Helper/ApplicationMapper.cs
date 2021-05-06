using AutoMapper;
using CollegePortal.Entity.Models;
using CollegePortal.Web.ViewModels;


namespace CollegePortal.Web.Helper
{
    public class ApplicationMapper : Profile
    {
        #region Constructors
        public ApplicationMapper()
        {            
            CreateMap<SignUpViewModel, User>().ReverseMap();
            CreateMap<LoginViewModel, User>().ReverseMap();            
        }
        #endregion
    }
}
