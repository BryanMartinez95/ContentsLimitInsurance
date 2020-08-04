using System;
using System.ComponentModel.DataAnnotations;

namespace ContentsLimitInsurance.Infrastructure.Annotations
{
    //Guid? cannot be Guid.Empty or null
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
    public class NotEmptyGuidAttribute : ValidationAttribute
    {
        public const string ErrorMessage = "The {0} field must not be empty or null";

        public NotEmptyGuidAttribute() : base(ErrorMessage)
        {
        }

        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return false;
            }
            switch (value)
            {
                case Guid guid:
                    return guid != Guid.Empty;
            }

            return true;
        }
    }
}