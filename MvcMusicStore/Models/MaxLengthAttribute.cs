using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcMusicStore.InfraStructure
{
    public class MusicStoreMaxLengthAttribute:ValidationAttribute
    {
        private int _maxLength;
        public MusicStoreMaxLengthAttribute(int maxlength):base("Your {0} is too long .")
        {
            _maxLength = maxlength;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value!=null)
            {
                var valueLength = Convert.ToString(value).Length;
                if (valueLength > _maxLength)
                {
                    var errorMessage = FormatErrorMessage(validationContext.DisplayName);
                    return new ValidationResult(errorMessage);
                }
                
            }
            return ValidationResult.Success;
        }
    }
}