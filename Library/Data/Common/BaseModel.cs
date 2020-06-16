using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Data
{
    public abstract class BaseDTO<TModel> where TModel : BaseDTO<TModel>
    {
    }
}
