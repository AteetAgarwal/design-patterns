using System;
using System.Collections.Generic;
using System.Text;

namespace SP.Bridge
{
    class ConcreteImplementationB : IImplementation
    {
        public string OperationImplementation()
        {
            return "ConcreteImplementationA: The result in platform B.\n";
        }
    }
}
