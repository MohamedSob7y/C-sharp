using C_.Data_Types;
using System.Collections.Specialized;
using System.Globalization;

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
        //=============================================
        #region Fraction and Discard
        //1: Float [Single Precision Floating Piont] => has 4 byte 32 bits 
        //approximatly 7 Digit overall قبل وبعد العلامة ولو زودت عن كدة بيعمل Round لاخر رقم فقط 
        //Float is Low Memory + high Losting Data
        //2: Double [double Precion Floating Piont ]=> 8byte 64 bits approximately 15-16 Digit overall ولو زودت عن كدة بيعمل Round لاخر رقمين 
        //Double Is More memory + Lost Data قليلة
        //3: Decimal [ High Presnio floating piont]=> 16 byte 128 bits approximatly 28-29 Digit overall قبل وبعد العلامة 
        //decimal is high Memory + No Losting For Data
        //long Number = 10055165955;
        //Console.WriteLine($"Money is: {Number:c}");//Formating Currency عملة => Currency Formating soecifier=>Money is: $10,055,165,955.00
        #endregion
        //=============================================
        #region Convert_Parse_TryParse
        //Convert =>Convert From Any Datatype to anthore handle null = zero  and thorw exception when is Formating يعنى مش عارف يحول
        //Parse=>Convert From string to Numberic datatype will Throw when Null [ctr+z] [NullArgumentException] or in Formating [InFormatingException]
        //TryPrase=>Convert from String to numberic datatype Nu Exception handle null = Zero  and Formating =Zero لو مش عارفة تحول and this return bool 
        //string? Name=Console.ReadLine();//Read string From User
        //Datatype?  Nullable Datatype allow null
        //?? "NoName" NullColaseing Operator
        //int Age=Convert.ToInt32(Console.ReadLine());
        //int Age = int.Parse(Console.ReadLine()??"0");//To handle Null
        //bool result=int.TryParse(Console.ReadLine(), out int age);
        //Console.Clear();
        //Console.WriteLine(Name);

        #endregion
        //=============================================
        #region Implcicit_Explcicit_Catsing
        //long x = 1022664;
        //int y =(int) x;//this Explicit Catsing Manual
        //int a = 1526;
        //long b = a;//Implcicit Catsing Automatic
        //float y = 15.55f;
        //int x =(int) y; //this Explicit Catsing Manual
        //int y = 15;
        //float x = y;//Implcicit Catsing Automatic

        //long y = 10000000000000000;
        //int x = (int)y;//معدى الMax int فهيدى قيمة عشوائية  
        //To handle This Error 


        //long a = 1500000000000;
        //checked
        //{
        //    int b = (int)a;
        //    unchecked
        //    {
        //        Console.WriteLine(b);//Will Throw Exception  لو هيدى قيمة عشوائية 
        //    }
        //}
        //Or 
        //long a = 150000000;
        //if(int.MaxValue<a||a<int.MinValue)
        //{
        //    Console.WriteLine("Error Message");
        //}
        //else
        //{
        //    int b = (int)a;
        //    Console.WriteLine(b);
        //}



        #endregion
        //=============================================
        #region String Formating
        //int x = 5, y = 10;
        //int Result = x + y;
        //Console.WriteLine($"{x}+{y}={Result}");//string Interpolation
        //string message = string.Format("{0}+{1}={2}",x,y,Result);//Formating String
        //Console.WriteLine("{0}+{1}={2}",x,y,Result);//Composit Formating

        ////string Concatination
        //string message02 = "Mohamed";
        //message02 += " Sobhy";
        //Console.WriteLine(message02);//Mohamed Sobhy الطريقة دى More Memory محتاجه وقت وحجم كبير لانى كل شوية بيحصل unreachable object in heap
        #endregion
        //=============================================
        #region Operators
        //1: Unary ++ -- Prefix Postfoix
        //x++ is postfix
        //++x is prefix
        //2: Binary  +  - * / % 
        //3: Assignment : +=   -=   *=   /=   %=
        //4: Relational :  ==  !=   >=   <=    
        //5: Logical : &&   ||    !
        //6: Bitwise: & ^ ! & |
        //7: Ternary: ?:
        //Periority :   
        #endregion
        //=============================================
        #region Control Statment 
        //1: Selection / Conditional Statment=> If els /Elseif   / Switch  
        //2: Loop / Iteration statment=> While /DoWhile/ For/ Foreach
        //3: Jump Statment=> Break Exite of Condition + Loop [Goto] [Continue]
        //Example
        //Console.WriteLine("Please enter Number of Month : ");
        //int Day;
        //bool Result=int.TryParse(Console.ReadLine(), out  Day);

        //if(Day==1)
        //{
        //    Console.WriteLine("Hello January");
        //}
        //else if(Day==2)
        //{
        //    Console.WriteLine("Hello Feb");
        //}
        //else
        //{
        //Console.WriteLine("Error ");
        //}


        //using Switch
        //switch (Day)
        //{
        //    case 1:
        //        Console.WriteLine("Hello January");
        //        break;
        //    case 2:
        //        Console.WriteLine("Hello Feb");
        //        break;
        //    default:
        //        Console.WriteLine("Error");
        //        break;
        //}


        #endregion
        //=============================================

        #region Example Using Switch With Goto

        //Retry:
        //    Console.WriteLine("No Number");


        //    Console.WriteLine("Enter Your Number");
        //    int Number;
        //    int.TryParse(Console.ReadLine(), out Number);
        //    switch (Number)
        //    {
        //        case 1000:
        //            Console.WriteLine("Option 01");
        //            break;
        //        case 2000:
        //            Console.WriteLine("Option02");
        //            goto case 1000;
        //        case 3000:
        //            Console.WriteLine("Option03");
        //            goto case 2000;
        //        default:
        //            goto Retry;
        //    }


            #endregion
        //=============================================
        #region Question 14 on Assignment Session03
        /*
             - Write a program that takes 3 integers from the user then prints the max element and the min element.
               Example (1)
               Input:7,8,5
               Output:
               max element = 8
               min element = 5
               —--------------------------------
               Example (2)
               Input: 3 6 9
               Outputs:
               Max element = 9
               Min element = 3
             */

        #endregion
        //===============================================
        #region Question 17 On Assignment Session03
        /*
             Write a program to input the month number and print the number of days in that month.
             Example
             Input: Month Number: 1
             Output: Days in Month: 31

             */

        #endregion
        }
    }
}
