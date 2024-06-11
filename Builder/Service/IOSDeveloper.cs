using Builder.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Service
{
    public class IOSDeveloper : IDeveloper
    {
        private Phone phone;
        public IOSDeveloper() => phone = new Phone();
        public void CreateBox() => phone.AppendData("Произведен корпус IPhone; ");
        public void CreateDisplay() => phone.AppendData("Произведен дисплей IPhone; ");
        public void SystemInstall() => phone.AppendData("Установлена ОС IOS; ");
        public Phone GetPhone() => phone;
    }
}
