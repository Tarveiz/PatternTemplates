using Builder.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Service
{
    public class WindowsDeveloper : IDeveloper
    {
        private Phone phone;
        public WindowsDeveloper() => phone = new Phone();
        public void CreateDisplay() => phone.AppendData("Произведен дисплей Microsoft; ");

        public void CreateBox() => phone.AppendData("Произведен корпус Microsoft; ");
        public void SystemInstall() => phone.AppendData("Установлена ОС Windows; ");
        public Phone GetPhone() => phone;
    }
}
