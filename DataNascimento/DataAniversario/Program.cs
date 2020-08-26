using System;

namespace DataNascimento
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2001, 12, 8, 12, 30, 30);
            
            Console.WriteLine
            (
                $"{date.ToString("dd/MM/yyyy HH:mm:ss")}\n" +
                //dd = dia
                //mm = mês
                //yyyy = year (ano)
                //hh = hora
                //mm = minutos
                //ss = segundos
                //08/12/2001 12:30:30
                $"{date.ToString("t")}\n" +
                //12:30
                $"{date.ToString("d")}\n" +
                //08/12/2001
                $"{date.ToString("T")}\n" +
                //12:30:30
                $"{date.ToString("D")}\n" +
                //sábado, 8 de dezembro de 2001
                $"{date.ToString("f")}\n" +
                //sábado, 8 de dezembro de 2001 12:30
                $"{date.ToString("F")}\n" +
                //sábado, 8 de dezembro de 2001 12:30:30
                $"{date.ToString("g")}\n" +
                //08/12/2001 12:30
                $"{date.ToString("G")}\n" +
                //08/12/2001 12:30:30
                $"{date.ToString("m")}\n" +
                //8 de dezembro
                $"{date.ToString("y")}\n" +
                //dezembro de 2001
                $"{date.ToString("r")}\n" +
                //Sat, 08 Dec 2001 12:30:30 GMT
                $"{date.ToString("s")}\n" +
                //2001-12-08T12:30:30
                $"{date.ToString("u")}\n"
                //2001-12-08 12:30:30Z
            );
        }
    }
}
