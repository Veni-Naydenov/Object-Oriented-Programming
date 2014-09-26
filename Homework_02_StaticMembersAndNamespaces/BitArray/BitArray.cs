namespace BitArray
{
    using System;
    using System.Text;
    using System.Numerics;

    public class BitArray
    {
        private uint bitCount = 0;
        private BigInteger numberResult = 0;
        private byte[] bits;

        public BitArray(uint bitsLength)
        {
            this.BitCount = bitsLength;
            this.bits = new byte[BitCount];
        }

        private uint BitCount
        {
            get
            {
                return this.bitCount;
            }
            set
            {
                if (value > 100000 || value < 0)
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "count of Bits {0} is invalid!", value));
                }
                this.bitCount = value;
            }
        }

        public byte this[int index]
        {
            get
            {
                if ((index >= 0) && (index < BitCount))
                {
                    // Check the bit at position index
                    if (bits[index] == 0)
                        return 0;
                    else
                        return 1;
                }
                else
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Index {0} is invalid!", index));
                }
            }

            set
            {
                if ((index < 0) || (index > BitCount - 1))
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Index {0} is invalid!", index));
                }
                if ((value < 0) || (value > 1))
                {
                    throw new ArgumentException(String.Format(
                        "Value {0} is invalid!", value));
                }
                // Clear the bit at position index
                bits[index] = 0;
                // Set the bit at position index to value
                bits[index] = value;
            }
        }

        public override string ToString()
        {
            for (int index = 0; index < BitCount; index++)
            {
                int bit = bits[index];
                if (bit != 0)
                {
                    this.numberResult += Power(bit, index);
                }

            }

            return this.numberResult.ToString();
        }

        private static BigInteger Power(int bit, int pow)
        {
            if (bit == 0)
            {
                return 0;
            }

            BigInteger result = 1;

            for (int i = 0; i < pow; i++)
            {
                result *= 2;
            }

            return result;
        }

        public string GetBits()
        {
            StringBuilder bitsBuilder = new StringBuilder();

            for (int i = this.bits.Length - 1; i >= 0; i--)
            {
                bitsBuilder.Append(this.bits[i]);
            }

            return bitsBuilder.ToString();
        }
    }
}
