using System;

class AllVariable
{
    static void Main(string[] args)
    {
        //จำนวนเต็ม
        sbyte sb1 = 127; //8 bit
        sbyte sb2 = -128;

        short sh1 = 32767; //16 bit
        short sh2 = -32768;

        int i1 = 2147483647; //32 bit
        int i2 = -2147483648;

        long l1 = 922372036854775807; //64 bit
        long l2 = -922372036854775808;

        //จำนวนเต็มบวก
        byte by1 = 0; //8 bit
        byte by2 = 255;

        ushort us1 = 0; //16 bit
        ushort us2 = 65535;

        uint ui1 = 0;// 32 bit
        uint ui2 = 4294967295;

        ulong ul1 = 0; //64 bit
        ulong ul2 = 1844744073709551651;

        //ทศนิยม
        float f = 0.0f; //1.5x10^-45 ถึง 3.4x10^38 แม่นยำ 7 ตำแหน่ง ขนาด 32 bit
        double d = 0.0; //5.0x10^-324 ถึง 1.7x10^308 แม่นยำ 16 ตำแหน่ง ขนาด 64 bit - ช่วงกว้างที่สุด
        decimal dec = 0.0m; //1.0x10^-28 ถึง 7.9x10^28 แม่นยำ 28 ตำแหน่ง ขนาด 128 bit - ละเอียดสุด เหมาะกับคำนวนเงินๆ ทองๆ

        //อื่นๆ
        bool b1 = true;// ค่าความจริง
        bool b2 = false;

        char ch = 'a'; //อักษร 1 ตัว

        string str = "This is String"; //คำ

        var a = 7; //ไม่ระบุประเภทเป็นอะไรก็ได้
    }
}
