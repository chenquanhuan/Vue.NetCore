using Epoch.Core.BaseProvider;
using Epoch.Core.Extensions.AutofacManager;
using Epoch.Entity.DomainModels;
using System.Linq;
using Epoch.Core.Extensions;
using System.Collections.Generic;
using Epoch.Core.Enums;

namespace Epoch.System.Services
{
    public partial class Sys_DictionaryListService
    {

        public override PageGridData<Sys_DictionaryList> GetPageData(PageDataOptions pageData)
        {
            base.OrderByExpression = x => new Dictionary<object, QueryOrderBy>() { {
                    x.OrderNo,QueryOrderBy.Desc
                },
                {
                    x.DicList_ID,QueryOrderBy.Asc
                }
            };
            return base.GetPageData(pageData);
        }
    }
}

