using Builder.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Service
{
    public class AndroidDeveloper : IDeveloper
    {
        private Phone phone;
        public AndroidDeveloper() => phone = new Phone();
        public void CreateDisplay() => phone.AppendData("Произведен дисплей Samsung; ");

        public void CreateBox() => phone.AppendData("Произведен корпус Samsung; ");
        public void SystemInstall() => phone.AppendData("Установлена ОС Android; ");
        public Phone GetPhone() => phone;
    }
}
