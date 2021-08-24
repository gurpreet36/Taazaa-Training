using System.Collections;
using System.Collections.Generic;
using Day5A.Models;
namespace Day5A.Recipe
{
    public class Recipe2cs //pascal case
    {
        public ArrayList mangoShake()//camel case
        {
            ArrayList arrayList=new ArrayList();//camel case
            arrayList.Add("Mango");
            arrayList.Add("Ice Cubes");
            arrayList.Add("Milk");
            arrayList.Add("Sugar");
            return arrayList;
            
        }

        public List<Recipe1> bananaShake()//camel case
        {
            List<Recipe1> Obj=new List<Recipe1>();
            Obj.Add(new Recipe1{
                step=1,//camel case
                rName="Banana"//camel case
            });
            Obj.Add(new Recipe1{
                step=2,//camel case
                rName="Milk"//camel case
            });
            Obj.Add(new Recipe1{
                step=3,//camel case
                rName="Sugar"//camel case
            });
            Obj.Add(new Recipe1{
                step=4,//camel case
                rName="Ice Cubes"//camel case
            });
            
            return Obj;
        }

    }
}