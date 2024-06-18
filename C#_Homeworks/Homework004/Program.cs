class Program
{
    /*Реализуйте операторы неявного приведения из long,int,byt в Bits.*/
    public class Bits
    {
        public Bits(byte b)
        {
            this.ByteValue = b;
        }
        public Bits(long l)
        {
            this.LongValue = l;
        }
        public Bits(int l)
        {
            this.IntValue = l;
        }
        public byte ByteValue { get; private set; } = 0;
        public long LongValue { get; private set; } = 0;
        public int IntValue { get; private set; } = 0;

        public bool this[int index]
        {
            get
            {
                if (index > 7 || index < 0)
                    return false;
                return ((ByteValue >> index) & 1) == 1;
            }
            set
            {
                if (index > 7 || index < 0) return;
                if (value == true)
                    ByteValue = (byte)(ByteValue | (1 << index));
                else
                {
                    var mask = (byte)(1 << index);
                    mask |= (byte)(0xff * mask);
                    ByteValue = (byte)(ByteValue & mask);
                }
            }
        }

        public static implicit operator byte(Bits b) => b.ByteValue;
        public static explicit operator Bits(byte b) => new Bits(b);

        public static implicit operator long(Bits bits) => bits.LongValue;
        public static explicit operator Bits(long l) => new Bits(l);

        public static implicit operator int(Bits bits) => bits.IntValue;
        public static explicit operator Bits(int i) => new Bits(i);
    }

    static void Main(string[] args)
    {
        var bits = new Bits(10);
        byte b = bits.ByteValue;
        b = 20;
        bits = (Bits)b;

        var bits1 = new Bits(10);
        long l = bits1.LongValue;
        l = 20;
        bits1 = (Bits)l;

        var bits2 = new Bits(10);
        int i = bits1.IntValue;
        i = 20;
        bits2 = (Bits)i;
    }
}
