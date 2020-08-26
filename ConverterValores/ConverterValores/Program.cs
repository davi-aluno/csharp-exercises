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
            string ago1     = "11";
            string ago2     = "19";
            string ago3     = "13";
            string ago4     = "14";
            byte   ago5     = 19;
            ushort ago6     = 10;
            string ago7     = "22";
            string ago8     = "22";
            string ago9     = "23";
            char   palavra1 = 'D';

            double convertNum1     = num1;
            int    convertNum2     = (int)num2;
            string num3ToString    = num3.ToString();
            string convertNum3     = num4.ToString();
            string convertNum4     = num5.ToString();
            string convertNum5     = num6.ToString();
            Int16  convertAgo1     = Int16.Parse(ago1);
            Int32  convertAgo2     = Int32.Parse(ago2);
            Int64  convertAgo3     = Int64.Parse(ago3);
            sbyte  convertAgo4     = Convert.ToSByte(ago4);
            string convertAgo5     = ago5.ToString();
            string convertAgo6     = ago6.ToString();
            ushort convertAgo7     = Convert.ToUInt16(ago7);
            short  convertAgo8     = Convert.ToInt16(ago8);
            long   convertago9     = Convert.ToInt64(ago9);
            string convertago10    = Convert.ToString(num1); 
            string convertPalavra1 = palavra1.ToString();

            Console.WriteLine
            (
                $"convertNum1    : {convertNum1}     tipo: {convertNum1.GetType()}    \n" +
                $"convertNum2    : {convertNum2}     tipo: {convertNum2.GetType()}    \n" +
                $"num3ToString   : {num3ToString}    tipo: {num3ToString.GetType()}   \n" +
                $"convertNum3    : {convertNum3}     tipo: {convertNum3.GetType()}    \n" +
                $"convertNum4    : {convertNum4}     tipo: {convertNum4.GetType()}    \n" +
                $"convertNum5    : {convertNum5}     tipo: {convertNum5.GetType()}    \n" +
                $"convertAgo1    : {convertAgo1}     tipo: {convertAgo1.GetType()}    \n" +
                $"convertAgo2    : {convertAgo2}     tipo: {convertAgo2.GetType()}    \n" +
                $"convertAgo3    : {convertAgo3}     tipo: {convertAgo3.GetType()}    \n" +
                $"convertAgo4    : {convertAgo4}     tipo: {convertAgo4.GetType()}    \n" +
                $"convertAgo5    : {convertAgo5}     tipo: {convertAgo5.GetType()}    \n" +
                $"convertAgo6    : {convertAgo6}     tipo: {convertAgo6.GetType()}    \n" +
                $"convertAgo7    : {convertAgo7}     tipo: {convertAgo7.GetType()}    \n" +
                $"convertAgo8    : {convertAgo8}     tipo: {convertAgo8.GetType()}    \n" +
                $"convertago9    : {convertago9}     tipo: {convertago9.GetType()}    \n" +
                $"convertago10   : {convertago10}    tipo: {convertago10.GetType()}   \n" +
                $"convertPalavra1: {convertPalavra1} tipo: {convertPalavra1.GetType()}\n"
            );
        }
    }
}