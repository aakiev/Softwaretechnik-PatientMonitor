﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMonitor
{
    internal static class MonitorConstants
    {
        public enum Parameter
        {
            ECG = 0,
            EEG = 1,
            EMG = 2,
            Respiration = 3
        }

        public enum clinic
        {
            Cardiology = 0,
            Neurology = 1,
            Orthopedics = 2,
            Surgery = 3,
            Dermatology = 4,
            Radiology = 5,
            Oftalmology = 6,
            Pediatrics = 7,
        }
        public enum compareAfter
        {
            Name = 0,
            Age = 1,
            Clinic = 2,
            Ambulatory = 3,
            Stationary = 4,
        }
    }
}
