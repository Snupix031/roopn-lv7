using System;
using System.Collections.Generic;
using System.Text;

namespace lv7
{
    class SystemDataProvider : SimpleSystemDataProvider
    {
        //private float previousCPULoad;
        //private float previousRAMAvailable;
        //public SystemDataProvider() : base()
        //{
        //    this.previousCPULoad = this.CPULoad;
        //    this.previousRAMAvailable = this.AvailableRAM;
        //}
        //public float GetCPULoad()
        //{
        //    float currentLoad = this.CPULoad;
        //    if (currentLoad != this.previousCPULoad)
        //    {
        //        this.Notify();
        //    }
        //    this.previousCPULoad = currentLoad;
        //    return currentLoad;
        //}
        //public float GetAvailableRAM()
        //{
        //    float currentram = this.AvailableRAM;
        //    return currentram;
        //}
        private float previousCPULoad;
        private float previousRAMAvailable;
        public SystemDataProvider() : base()
        {
            this.previousCPULoad = this.CPULoad;
            this.previousRAMAvailable = this.AvailableRAM;
        }
        public float GetCPULoad()
        {
            float currentLoad = this.CPULoad;
            if (currentLoad > previousCPULoad * 1.1 || currentLoad < previousCPULoad * 0.9)
            {
                this.Notify();
            }
            this.previousCPULoad = currentLoad;
            return currentLoad;
        }
        public float GetAvailableRAM()
        {
            float currentram = this.AvailableRAM;
            if (currentram > previousRAMAvailable * 1.1 || currentram < previousRAMAvailable * 0.9)
            {
                this.Notify();
            }
            this.previousRAMAvailable = currentram;
            return currentram;
        }
    }
}
