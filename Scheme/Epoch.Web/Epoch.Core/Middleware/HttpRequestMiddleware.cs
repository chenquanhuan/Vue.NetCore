using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Epoch.Core.Middleware
{
    public class HttpRequestMiddleware
    {
        public static Func<RequestDelegate, RequestDelegate> Context
        {
            get
            {
                return next => async context =>
                {
                    //动态标识刷新token(2021.05.01)
                    context.Response.Headers.Add("Access-Control-Expose-Headers", "Epoch_exp");
                    await next(context);
                };

            }
        }
    }
   
}
