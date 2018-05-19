using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Sine
{
    [Serializable]
    public struct Range
    {
        public Range(float minValue, float maxValue)
        {
            min = minValue;
            max = maxValue;
        }

        public float min;
        public float max;
    }
}

