using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal interface IBitGetable
    {
        bool GetBitByIndex(byte index);
        void SetBitByIndex(byte index, bool value);
    }

    internal class Bits : IBitGetable
    {

        public byte Value { get; private set; }

        public Bits(byte value)
        {
            Value = value;
        }

        public Bits(int value)
        {
            this.Value = (byte)value;
        }

        public Bits(long value)
        {
            this.Value = (byte)value;
        }

        public Bits(double value)
        {
            this.Value = (byte)value;
        }

        public bool GetBitByIndex(byte index)
        {
            return (Value & (1 << index)) != 0;
        }

        public void SetBitByIndex(byte index, bool value)
        {
            if (value)
            {
                Value |= (byte)(1 << index);
            }
            else
            {
                Value &= (byte)~(1 << index);
            }
        }

        public bool this[byte index]
        {
            get => GetBitByIndex(index);
            set => SetBitByIndex(index, value);
        }

        public static implicit operator byte(Bits bits) => bits.Value;
        public static explicit operator Bits(byte value) => new(value);

        public static implicit operator long(Bits bits) => bits.Value;
        public static explicit operator Bits(long value) => new(value);

        public static implicit operator int(Bits bits) => bits.Value;
        public static explicit operator Bits(int value) => new(value);

        public static implicit operator double(Bits bits) => bits.Value;
        public static explicit operator Bits(double value) => new(value);

    }
}
