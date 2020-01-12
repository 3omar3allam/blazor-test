using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApp.Server.Helpers
{
    public static class CustomValidator
    {
        public static bool Validate<T>(T model)
        {
            var context = new ValidationContext(model, null, null);
            var validationResults = new List<ValidationResult>();

            return Validator.TryValidateObject(model, context, validationResults, true);
        }
    }
}
