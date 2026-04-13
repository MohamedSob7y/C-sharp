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
            //=============================================
            #region Object Methods
           // Piont P1 = new Piont() { x = 10, y = 20 };
            //object number = 12345;//This Boxing  as number from Reference type + 12345 is Value Type Store in Heap as Box
            //int x = 500;//This Value Type
            //object name = "Mohamed";//This Reference Type
            //Console.WriteLine(P1.ToString());// retrn Namespace this Default implementation of Tostring [C_.Data_Types.Piont]
            //Console.WriteLine(number.ToString());//12345  Default implementation of Value Type return Value Not Namespace
            //Console.WriteLine(name.ToString());//Mohamed   return value 
            //Console.WriteLine(x.ToString());//500
            //int+String Make Override For Tostring اللى ورثوها من Object 
            //انما Class Piont معملشى Override For Tostring take Default implementation that return namepsace 
            //int + string make override For tostring مخدوش الDefault implementation From Object هما عدلوا عليها 
            //===========================================================================================================================
            //Equals
            //Piont P2 = new Piont() { x = 10, y = 20 };
            //Console.WriteLine(P1.Equals(P2));// Equals in class يقارن Two address ببعض مش Values يعنى يخرج True لو الاتنين بيشاوروا عى نفس الObject =>False مع انهم نفس القيم بس مش نفس الAddress 
            //P1 refere To Object  and P2 refere To Anthore Object
            //But with int + double and so on make override For Equeal تقارن بالقيم وليس الAddress عشان اعمل Override For Implementation اللى ورثته من  Object
            //P1 = P2;
            //Console.WriteLine(P1.Equals(P2));//true لان الاتنين بيشاوروا على نفس ال Object has the Same address 
            //Console.WriteLine(name.GetHashCode());//2048162114 this address Not value as string Not make override For GethashCode ورثت على طول بتاعت Object
            //But int and Other Type make Override For Gethashcode and change implementation of Gethashcode of Object
            //Console.WriteLine(number.GetHashCode());//12345
            //Console.WriteLine(P1.GetType());//C_.Data_Types.Piont
            //Console.WriteLine(x.GetType());//System.Int32

            //GetType => return namspace of Any Type لان كله بيورثها زى ماهى من غير تعديل 
            //GetType بتستخدمها Tostring 
            //Equal internally مستخدمة Gethashcode 

            //object obj = new object();
            //If Size of reference is 32 Bit 
            //Reference 4 Byte in stack  => 8 Byte in heap
            //If Size of refrence is 64 Bits 
            //refrence 8 byte in stack => 16 byte in heap


            // object x = new string("Route");
            //Clr Will Allocate 4 Byte in stack with default value null and 0 byte in heap
            //Clr will Allocate 10 Byte in heap 
            //Intialize allocated Byte with default value of Type
            //Call User defined Constrcuotr is exsist
            //Assign refreence in stack will refre Object in heap


             // object name = 15.6;//this Boxig هخزن الreference in stack والقيمة  in Boxing in heap 
            //int number = (int)name;//this unBosing هاخد القيمة ممن Boxing in heap واخزنها فى stack  وبقى unreachable object => فيجى Garage Collector يمسحه لانه Manganed By Clr  
            //So عملية Boxing and UnBoxing => Low Performance and Need More Memory
            #endregion

        }
    }
}
