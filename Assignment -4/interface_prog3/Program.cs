using System;

namespace interface_prog3
{
    public interface sport{
        public void team();
    }
    public class Cricket:sport
    {
        public void team(){
            Console.WriteLine("no of team player required : "+11);
        }
    }
    class Program:Cricket
    {
        static void Main(string[] args)
        {
            var t=new Program();
            t.team();

        }
    }
}
