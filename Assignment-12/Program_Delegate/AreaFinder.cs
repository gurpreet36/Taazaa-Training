using System;
using Program_Delegate.DelegateClasses;
delegate int delegater(int a);
delegate int delegaterRec(int a,int b);

namespace Program_Delegate
{
    class AreaFinder
    { 
        public static void Main()
        {
            var delegateClass=new DelegateClass();
            var objSqr=new delegater(delegateClass.areaSq);
            var p1=objSqr.Invoke(25);
            var objRec=new delegaterRec(delegateClass.areaRec);
            var p2=objRec.Invoke(25,35);
            objSqr+=delegateClass.areaCir;
            var p3=objSqr.Invoke(35);
            Console.WriteLine(p1+" "+p2+" "+p3);



        }
    }
}
