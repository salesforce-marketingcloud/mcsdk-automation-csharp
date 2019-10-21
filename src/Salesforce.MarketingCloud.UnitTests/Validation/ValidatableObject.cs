using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Salesforce.MarketingCloud.UnitTests.Validation
{
    public class ValidatableObject : IValidatableObject
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 20.", new[] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 2.", new[] { "Name" });
            }

            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 30.", new[] { "Description" });
            }

            // Description (string) minLength
            if (this.Description != null && this.Description.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be greater than 3.", new[] { "Description" });
            }

            yield break;
        }
    }
}