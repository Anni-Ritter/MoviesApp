using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Globalization;

namespace MoviesApp.Filters
{
    public class CheckAgeActor : Attribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            var formDate = DateTime.Parse(context.HttpContext.Request.Form["BirthDate"]);
            var age = DateTime.Now.Year - formDate.Year;
            if (DateTime.Now.DayOfYear < formDate.DayOfYear) { age++; }
            if (age > 99 || 7 > age)
            {
                context.Result = new BadRequestResult();
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {

        }
    }
}