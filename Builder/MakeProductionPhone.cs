using Builder.Contracts;
using Builder.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    ///     Входной класс для паттерна
    /// </summary>
    public class MakeProductionPhone
    {
        StringBuilder sb = new StringBuilder();
        //private Director _director;
        //private Phone _phone;
        //private IDeveloper _androidDeveloper;
        //private IDeveloper _iosDeveloper;
        private IDeveloper _developer;

        public MakeProductionPhone(IDeveloper developer)
        {
            _developer = developer;
        }

        /// <summary>
        ///     Метод создания объекта
        /// </summary>
        /// <param name="osType">Принимаемые значение: "Android", "IOs", "Android->IOs"</param>
        /// <returns>Строку с созданным телефоном</returns>
        /// <exception cref="NotImplementedException"></exception>
        public string MakePhone()
        {
            if (_developer == null)
                throw new ArgumentNullException(nameof(_developer));
            try
            {
                switch (_developer)
                {
                    case AndroidDeveloper:
                        IDeveloper androidDeveloper = new AndroidDeveloper();

                        Director director = new Director(androidDeveloper);

                        Phone phone = director.MountFullPhone();

                        return phone.AboutPhone();

                    case IOSDeveloper:

                        IDeveloper iosDeveloper = new IOSDeveloper();

                        Director iosDirector = new Director(iosDeveloper);

                        Phone iPhone = iosDirector.MountOnlyPhone();

                        return iPhone.AboutPhone();

                    default:
                        throw new ArgumentException("Такой мобильной операционной системы не существует");
                }
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.Message, ex);
            }
        }
    }
}
