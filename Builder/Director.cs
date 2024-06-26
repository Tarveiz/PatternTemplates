﻿using Builder.Contracts;

namespace Builder
{
    internal class Director
    {
        private IDeveloper _developer;

        internal Director(IDeveloper developer)
        {
            _developer = developer;
        }
        public void SetDeveloper(IDeveloper developer) => _developer = developer;

        public Phone MountOnlyPhone()
        {
            _developer.CreateBox();
            _developer.CreateDisplay();
            return _developer.GetPhone();
        }

        public Phone MountFullPhone()
        {
            _developer.CreateBox();
            _developer.CreateDisplay();
            _developer.SystemInstall();
            return _developer.GetPhone();
        }
    }
}
