using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Linq;
using Epoch.Core.Enums;
using Epoch.Core.Extensions;
using Epoch.Core.ObjectActionValidator;
using Epoch.Core.Services;
using Epoch.Core.Utilities;

namespace Epoch.Core.Filters
{
    public class ActionExecuteFilter : IActionFilter
    {

        public void OnActionExecuting(ActionExecutingContext context)
        {
            //验证方法参数
            context.ActionParamsValidator();
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {

        }
    }
}