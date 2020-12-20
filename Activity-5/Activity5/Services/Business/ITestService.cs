using Activit5.Services.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activit5.Services.Business {
    public interface ITestService {
        void Initialize(ILogger logger);

        void TestLogger();
    }
}
