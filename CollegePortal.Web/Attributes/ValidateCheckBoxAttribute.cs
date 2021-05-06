using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace CollegePortal.Web.Attributes
{
    public class ValidateCheckBoxAttribute : ValidationAttribute, IClientModelValidator
    {
     
        #region Methods

        public override bool IsValid(object value)
        {
            return (bool)value;
        }

        public void AddValidation(ClientModelValidationContext context)
        {
            
            context.Attributes.Add("data-val-validatecheckbox", ErrorMessage);
        }

        #endregion

    }
}
