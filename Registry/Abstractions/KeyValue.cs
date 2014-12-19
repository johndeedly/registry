﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registry.Cells;

namespace Registry.Abstractions
{
    /// <summary>
    /// Represents a value that is associated with a RegistryKey
    /// <remarks>Also contains references to low level structures related to a given value</remarks>
    /// </summary>
    public class KeyValue
    {
        public VKCellRecord VKRecord { get; private set; }
        public string ValueName { get; private set; }
        public string ValueType { get; private set; }
        public string ValueData { get; private set; }
        public string ValueSlack { get; private set; }
        public byte[] ValueSlackRaw { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KeyValue"/> class.
        /// </summary>
        /// <param name="valueName"></param>
        /// <param name="valueType"></param>
        /// <param name="valueData"></param>
        /// <param name="valueSlack"></param>
        /// <param name="valueSlackRaw"></param>
        public KeyValue(string valueName, string valueType, string valueData, string valueSlack, byte[] valueSlackRaw, VKCellRecord vk)
        {
            VKRecord = vk;
            ValueName = valueName;
            ValueType = valueType;
            ValueData = valueData;
            ValueSlack = valueSlack;
            ValueSlackRaw = valueSlackRaw;
        }
    }
}
