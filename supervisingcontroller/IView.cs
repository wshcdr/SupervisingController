using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace supervisingcontroller
{
    public interface IView
    {
        event Action UpdateId;
        event Action UpdateName;
    }
}
