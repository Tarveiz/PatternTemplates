using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Contracts
{
    public interface IDeveloper
    {
        void CreateDisplay();
        void CreateBox();
        void SystemInstall();
        Phone GetPhone();

    }
}
