using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Salesforce.MarketingCloud.Validation
{
    public class ModelValidationException : Exception
    {
        public ModelValidationException(string modelType, ICollection<ValidationResult> validationResults) 
            : base(GetExceptionMessage(modelType, validationResults))
        {
            this.ModelType = modelType;
            this.ValidationResults = validationResults;
        }

        public string ModelType { get; private set; }

        public ICollection<ValidationResult> ValidationResults { get; private set; }

        private static string GetExceptionMessage(string modelType, ICollection<ValidationResult> validationResults)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Invalid {modelType}");
            foreach (var validationResult in validationResults)
            {
                sb.AppendLine(validationResult.ErrorMessage);
            }

            return sb.ToString();
        }
    }
}