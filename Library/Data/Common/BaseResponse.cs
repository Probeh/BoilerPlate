using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Data
{
    public class ResponseDTO<TModel> : BaseDTO<ResponseDTO<TModel>> where TModel : ResponseDTO<TModel>
    {
    }
}
