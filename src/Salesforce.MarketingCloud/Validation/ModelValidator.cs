﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Salesforce.MarketingCloud.Validation
{
    public class ModelValidator
    {
        public bool TryValidate(object @object, out ICollection<ValidationResult> results)
        {
            var context = new ValidationContext(@object, serviceProvider: null, items: null);
            results = new List<ValidationResult>();

            return Validator.TryValidateObject(
                @object, context, results,
                validateAllProperties: true
            );
        }
    }
}