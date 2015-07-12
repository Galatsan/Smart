using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSmartHouse
{
    public struct TVSettings
    {
        private byte volume;
        private byte contrast;
        private byte abruptness;

        public byte Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value >= 0 && value <= 50)
                {
                    volume = value;
                }
            }
        }
        public byte Contrast
        {
            get
            {
                return contrast;
            }
            set
            {
                if (value >= 0 && value <= 50)
                {
                    contrast = value;
                }
            }
        }
        public byte Abruptness
        {
            get
            {
                return abruptness;
            }
            set
            {
                if (value >= 0 && value <= 50)
                {
                    abruptness = value;
                }
            }
        }

        
    }
}