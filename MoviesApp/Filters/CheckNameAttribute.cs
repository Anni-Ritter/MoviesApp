using System;
using System.ComponentModel.DataAnnotations;
using MoviesApp.Models;

namespace MoviesApp.Filters
{
    public class CheckNameAttribute: ValidationAttribute
    {
        public CheckNameAttribute(int line)
        {
            Line = line;
        }
        public int Line { get; }
        public string GetErrorMessage() =>
           $"Length must be greater than {Line}.";

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var lengthLine = value.ToString().Length;

            if (lengthLine < Line)
            {
                return new ValidationResult(GetErrorMessage());
            }

            return ValidationResult.Success;
        }
    }
}
