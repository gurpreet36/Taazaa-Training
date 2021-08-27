
namespace Program_Delegate.DelegateClasses
{
    public class DelegateClass:IDelegateClass
    {
        public  int areaSq(int side){
            return side*side;
        }
        public  int areaRec(int l,int b){
            return l*b;
        }
        public  int areaCir(int a){
            return 22*a*a/7;
        }
    }
}