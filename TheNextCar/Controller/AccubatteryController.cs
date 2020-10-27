using System;
using System.Collections.Generic;
using System.Text;
using TheNextCar.Model;

namespace TheNextCar.Controller
{
    class AccubatteryController
    {
        private Accubattery accubattery;
        private OnPowerChanged callBackOnPowerChanged;

        public AccubatteryController(OnPowerChanged callbackOnPowerChanged)
        {
            this.callBackOnPowerChanged = callbackOnPowerChanged;
            this.accubattery = new Accubattery(12);
        }
        public void turnOn()
        {
            this.accubattery.turnOn();
            this.callBackOnPowerChanged.onPowerChangedStatus("ON", "power is on");
        }
        public void turnOff()
        {
            this.accubattery.turnOff();
            this.callBackOnPowerChanged.onPowerChangedStatus("OFF", "power is off"); 
        }
        public bool accubatteryIsOn()
        {
            return this.accubattery.isOn();
        }
    }
    interface OnPowerChanged
    {
        void onPowerChangedStatus(string value, string message);
    }
}
