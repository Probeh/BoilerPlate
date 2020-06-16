using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Data
{
    public class RequestDTO<TModel> : BaseDTO<RequestDTO<TModel>> where TModel : RequestDTO<TModel>
    {
    }
}
