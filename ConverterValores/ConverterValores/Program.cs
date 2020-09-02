using System;

namespace ConverterValores
{
    class Program
    {
        static void Main(string[] args)
        {
            int    num1     = 5;
            double num2     = 1.5;
            int    num3     = 7;
            UInt16 num4     = 3;
            UInt32 num5     = 9;
            UInt64 num6     = 15;
            string age1     = "11";
            string age2     = "19";
            string age3     = "13";
            string age4     = "14";
            byte   age5     = 19;
            ushort age6     = 10;
            string age7     = "22";
            string age8     = "22";
            string age9     = "23";
            char   palavra1 = 'D';

            double convertNum1     = num1;
            int    convertNum2     = (int)num2;
            string num3ToString    = num3.ToString();
            string convertNum3     = num4.ToString();
            string convertNum4     = num5.ToString();
            string convertNum5     = num6.ToString();
            Int16  convertage1     = Int16.Parse(age1);
            Int32  convertage2     = Int32.Parse(age2);
            Int64  convertage3     = Int64.Parse(age3);
            sbyte  convertage4     = Convert.ToSByte(age4);
            string convertage5     = age5.ToString();
            string convertage6     = age6.ToString();
            ushort convertage7     = Convert.ToUInt16(age7);
            short  convertage8     = Convert.ToInt16(age8);
            long   convertage9     = Convert.ToInt64(age9);
            string convertage10    = Convert.ToString(num1); 
            string convertPalavra1 = palavra1.ToString();

            Console.WriteLine
            (
                $"convertNum1    : {convertNum1}     tipo: {convertNum1.GetType()}    \n" +
                $"convertNum2    : {convertNum2}     tipo: {convertNum2.GetType()}    \n" +
                $"num3ToString   : {num3ToString}    tipo: {num3ToString.GetType()}   \n" +
                $"convertNum3    : {convertNum3}     tipo: {convertNum3.GetType()}    \n" +
                $"convertNum4    : {convertNum4}     tipo: {convertNum4.GetType()}    \n" +
                $"convertNum5    : {convertNum5}     tipo: {convertNum5.GetType()}    \n" +
                $"convertage1    : {convertage1}     tipo: {convertage1.GetType()}    \n" +
                $"convertage2    : {convertage2}     tipo: {convertage2.GetType()}    \n" +
                $"convertage3    : {convertage3}     tipo: {convertage3.GetType()}    \n" +
                $"convertage4    : {convertage4}     tipo: {convertage4.GetType()}    \n" +
                $"convertage5    : {convertage5}     tipo: {convertage5.GetType()}    \n" +
                $"convertage6    : {convertage6}     tipo: {convertage6.GetType()}    \n" +
                $"convertage7    : {convertage7}     tipo: {convertage7.GetType()}    \n" +
                $"convertage8    : {convertage8}     tipo: {convertage8.GetType()}    \n" +
                $"convertage9    : {convertage9}     tipo: {convertage9.GetType()}    \n" +
                $"convertage10   : {convertage10}    tipo: {convertage10.GetType()}   \n" +
                $"convertPalavra1: {convertPalavra1} tipo: {convertPalavra1.GetType()}\n"
            );
        }
    }
}
