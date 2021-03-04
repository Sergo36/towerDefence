using System;

namespace towerDefense
{
    class Units
    {
        byte _health;
        byte _protection;
        public Units(byte health, byte protection) 
        {
            _health = health;
            _protection = protection;
        }
    }
}