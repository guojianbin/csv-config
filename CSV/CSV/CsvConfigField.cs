﻿using System;

namespace Com.Alking.CSV
{
    public class CsvConfigField
    {
        public int Index { get; private set; }

        /// <summary>
        /// 是否是关键字
        /// </summary>
        public bool IsKey { get; private set; }
        /// <summary>
        /// 属性名称
        /// </summary>
        public string Name {get; private set; }
        
        public CsvValue Value { get; private set; }

        public CsvConfigField(int index, bool isKey, string name, CsvValue value)
        {
            Index = index;
            IsKey = isKey;
            Name = name;
            Value = value;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="CsvException">this is not int value</exception>
        public static implicit operator int(CsvConfigField field)
        {
            return field.Value;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="CsvException">this is not long value</exception>
        public static implicit operator long(CsvConfigField field)
        {
            return field.Value;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="CsvException">this is not float value</exception>
        public static implicit operator float(CsvConfigField field)
        {
            return field.Value;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="CsvException">this is not double value</exception>
        public static implicit operator double(CsvConfigField field)
        {
            return field.Value;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="CsvException">this is not bool value</exception>
        public static implicit operator bool(CsvConfigField field)
        {
            return field.Value;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="CsvException">this is not string value</exception>
        public static implicit operator string(CsvConfigField field)
        {
            return field.Value;
        }
    }
}
