using C_.Data_Types;
using System.Collections.Specialized;

namespace C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Reference Type
            //Piont P1;
            //CLr will Allocate 4 byte in stack with default value null and 0 byte in heap
            //P1 = new Piont();
            //clr will allocate required number of 8 byte in heap
            //Inialze allocate byte in heap with default value 
            //Call user defiend Constructor if Exsist
            //Assign reference in stack will refere to object in heap

            //Piont P2=new Piont(){P2.x = 15,P2.y = 20};
            //P1 = P2;//Take Address Of P2  واخليه فى P1 
            //وكدة الP1 بيشاور على نفس اللى بيشاور عليه P2
            //واللى كان بيشاور عليه P1 اصبح  UnReachable Object
            //Garbge Collector هيجى يمسحه 
            //So P1.x=15    P1.y=20   


            #endregion
            //=============================================
            #region Value Type
            //double c;
            //clr will allocate  8 byte in stack with uninitialize value 
            //c = 15.5;
            //Clr Will assgin value 15.5 To Variable c in stack 
            //int g = 10;
            //c = g;
            //Take Copy of Data Not Actual Data 
            //So g=10 and c=10
            //c++;
            //So c=11  and g=10 is Const
            //For any Functions Will Create Stack Frame For This In Stack الحجم بتاعه على حسب Parameter in Function
            #endregion

        }
    }
}
