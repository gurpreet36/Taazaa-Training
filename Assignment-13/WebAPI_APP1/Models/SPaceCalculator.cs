namespace WebAPI_APP1.Models
{
    public class sp
    {
        public static string total_Count(string s,int l)// l is the maimum size of string data present in list
        {
            int length=s.Length;
            length=l-length;
            string st="";
            while(length>0)
            {
                st+=" ";
                length--;
            }
            return st;
        }
    }
}