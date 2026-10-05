using C_.Data_Types;
using System.Collections.Specialized;
using System.Globalization;
using System.Net.Http.Headers;
using System.Text;

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
            #region Evolation Switch in C#7_C#8_C#9
            //in C# 7 Pattern Match + Cause Guard
            //in Before C# 7 مكنتش اعرف اعمل Switch for Relationl or string or char
            //With C#7 اقدرت اعمل Case "string"   case Const    case relation=>case >10 && <20
            //object number = 15.5;//Boxing
            //switch (number)
            //{
            //    case 10://Create Jumb Table 
            //        Console.WriteLine("Constant Checking");
            //        break;
            //        case >15 and <20://Not Create Jumb Table
            //        Console.WriteLine("Relational Cheking");
            //        break;
            //    case "Mohamed"://Not Create Jumb Table
            //        Console.WriteLine("String Checkeing");
            //        break;
            //    case 'A'://Not Create Jumb Table
            //        Console.WriteLine("Char Chekcing");
            //        break;
            //    case float value when value > 20://UnBoxing
            //        Console.WriteLine("Pattern Matching With Cause guard");
            //        break;
            //    case int value://UnBoxing
            //        Console.WriteLine("Pattern Mathcing");
            //        break;
            //        default:
            //        Console.WriteLine("Not Version");
            //        break;
            //}
            //in C#8 enhance in Pattern Matching wihtout aliase name 
            //object number = 15.5;//Boxing
            //switch (number)
            //{
            //    case float value when value > 20://UnBoxing
            //        Console.WriteLine("Pattern Matching With Cause guard");
            //        break;
            //    case int value://UnBoxing
            //        Console.WriteLine("Pattern Mathcing");
            //        break;
            //    case double:
            //        Console.WriteLine("Enhance in C#8 without aliase name");
            //        break;
            //    case double when (double)number > 15&& (double)number<30:
            //        Console.WriteLine("Enhance with Cause Guard");
            //        break;
            //    default:
            //        Console.WriteLine("Not Version");
            //        break;
            //}
            //Switch Expression=>will return Values لان الswitch القديمة مش بتعمل return 
            //Before Switch Expression
            //string options=Console.ReadLine()??"0";
            //string Message;
            //switch (options)
            //{
            //    case "1":
            //        Message = "Option01";
            //        break;
            //    case "2":
            //        Message = "Option02";
            //        break;
            //    case "3":
            //        Message = "Option03";
            //        break;
            //    case "4":
            //        Message = "Option04";
            //        break;
            //   default:
            //        Message = "No Option";
            //        break;
            //}
            //Console.WriteLine(Message);

            //After Switch Expresssion 
            //string options = Console.ReadLine() ?? "0";
            //string Message = options switch
            //{
            //    "1"=>"Option01",//Constant Pattern
            //    "2"=>"Option02",
            //    _=>"No Options"//discard Pattern
            //};
            //Console.WriteLine(Message);

            //Switch Expression with Constant Pattern + Property Pattern + Relational Pattern +Discard Pattern
            //Person person = new Person()
            //{
            //    Id = 1,
            //    Name="Mohamed",
            //    Age=22
            //};
            //string Message = person switch
            //{
            //    { Id:10,Name:"Mohamed",Age:22}=>"Option01",//Property Pattern
            //    {Id:1,Name:"Mohamed",Age:22}=>"Option02",
            //    _=>"No Options"
            //};

            //Console.WriteLine(Message);

            //Nullable Datatype + Relational 
            // int? Number=15;
            //string Message = Number switch
            //{
            //    null=>"Is Null",
            //    int value when value>15=>"Is Greater than 15",
            //    int  when Number > 15 => "Without Aliase ",
            //    _ =>"Discard Patern Or Discard Operation"
            //};
            // Console.WriteLine(Message);


            //In C#9=> Ehnace Property Pattern in Switch Expression + Relational Fully اقدر دلؤقتى استخدم >= or <= لان فى C#8 مكنش عندى غير > and <  + Logical Pattern with Switch Expression
            //Person person = new Person()
            //{
            //    Id=10,
            //    Name="Mohamed",
            //    Age=22,
            //};
            //string Message = person switch
            //{
            //    { Id:10,Age:>=20 and <=30,Name:"Mohamed"}=>"Message is Correct",
            //    _=>"Not correct"
            //};
            //Console.WriteLine(Message);
            //===============================================================
            //int Number = 15;
            //string message = Number switch
            //{
            //    >20 and <30=>"Number is Greater than 20 and Smaller than 30", //Relational Pattern fully + Logical
            //};
            //Console.WriteLine(message);

            #endregion
            //=============================================
            #region Full Example With Evolation Switch With C#7 C#8 C#9 And Before C#7
            //object number = 15.5;//Boxing create Jumb Table ظهرت فى كل النسخ
            //switch(number)
            //{
            //    case 10:
            //        Console.WriteLine("Number is 10");
            //        break;
            //    case "Mohamed"://No Jumb table => بتعمل jumb ظاهرى  after C#7 يعنى قبل كدة مكنتش اعرف اعملها 
            //        Console.WriteLine("String Chekcing");
            //        break;
            //    case "A"://No Jumb table => بتعمل jumb ظاهرى  after C#7 يعنى قبل كدة مكنتش اعرف اعملها 
            //        Console.WriteLine("Char Chekcing");
            //        break;
            //    case float value://Pattern Matching with C#7 not create Jumb table 
            //        Console.WriteLine("Pattern Matching");
            //        break;
            //    case double value when value > 15://UnBoxking in C#7
            //        Console.WriteLine("Cause Gurad");
            //        break;
            //    case int://Enhance in C#8 wihtout aliase name with pattern matching + Cause guard
            //        Console.WriteLine("in C#8");
            //        break;
            //    //case int when (int)number > 15:
            //    //    //Enhance in C#8 wihtout aliase name with pattern matching + Cause guard
            //    //    Console.WriteLine();
            //    //    break;
            //    case >= 15 and <= 20://Relational + Logical enhance in C#9
            //        Console.WriteLine();
            //        break;
            //}
            ////Pattern Matching And cause Guard With User defined Data type in C#7
            //Person person = new Person()
            //{
            //    Id = 10,
            //    Name="Mohamed",
            //    Age=50
            //};
            //switch (person)
            //{
            //    case Person value when value.Age > 15 && value.Age< 20: //in C#7
            //        Console.WriteLine("Messge");
            //        break;
            //    case Person when person.Id > 15:
            //        //Enhance in C#8 wihtout aliase name with pattern matching + Cause guard
            //        Console.WriteLine("Enhance");
            //        break;
            //}
            //Before Switch Expression
            //string Option=Console.ReadLine()??"0";
            //string message;
            //switch(Option)
            //{
            //    case "1":
            //        message = "Option001";
            //        break;
            //}
            //Console.WriteLine(message);

            //Syntax Switch Expression in C#8

            //string Optiion=Console.ReadLine()??"0";
            //string message = Optiion switch
            //{
            //    "1"=>"Option01",//with Constant Pattern 
            //    //With Discard Pattern
            //};
            //Console.WriteLine(message);



            //Person person = new Person()
            //{
            //    Id=10,
            //    Name="mohamed",
            //    Age=30,
            //};
            //string message = person switch
            //{
            //    { Age:20,Name:"Mo"}=>"In C#8",
            //    { Name:"Ahmed"}=>"In C#8",
            //    { Name:"Mohamed",Age:>20 and <=30}=>"InC#9 logical  + Relational Fully",
            //    _=>"Discard Pattern"
            //};
            //Console.WriteLine(message);

            //int? Number = 15;
            //string message = Number switch
            //{
            //    null=>"Nullable in C#8",
            //    int value when value>15=>"in C#8",
            //    int when Number>15=>"in C#8",
            //    >20=>"in C#8 Relational ",
            //    >=20 =>"Relational Fully and ",
            //    _=>"discard Pattern"

            //};
            //Console.WriteLine(message);

            //inC#7=>Pattern Matching + Cause Gaurd
            //in C#8=> Enhance for Pattern Matching + Cause Gaurd wihout Aliase Name + Switch Expression with Constant/Relational > </ Proprty / nullable Pattern 
            //in C#9=>Enhance Switch Expression with Constant/Relational => <=/Proprty With Relational + logical 

            #endregion
            //=============================================
            #region Looping Statment
            //عايزه كل مايدخل value غلط يدخلها تانى يعنى اخليه يدخل القيم الصحيحة عشان ابدا اعمل Logic
            //int Value;
            //bool IsParsed;
            //do
            //{
            //    Console.WriteLine("Please Enter Valid Number");
            //    IsParsed=int.TryParse(Console.ReadLine(), out Value);
            //} while (!IsParsed);
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
            //===============================================
            #region String Builder in Session05 
            //string Builder is Built in Class [Reference Data type يعنى الRefernce Store in Stack + Object in Heap] muutable يعنى قابل للتعديل على نفس المكان فى الHeap مش بيحجز مكان جديد على عكس الString
            //string Builder internally represent Linked List Each Node Conatin Value+ Address of Next Node
            //string internally represent Fixed Array عشان كدة غير قابل للتعديل على نفس المكان 

            //StringBuilder Message   ;//Clr Declare Reference Type From StringBuilder and CLr Will Allocate 4 Byte in Stack With dEfault Value Null + 0 Byte in Heap
            ////Message = new StringBuilder();//كدة انا حجزت Only one Node Not Array of Node والمفروض الNode اللى انا عاملها فاضية 
            //Message = new StringBuilder("Mohamed"); 
            ////Reference From Type StringBuilder [Message] in Stack بيشاور على Object in heap المفروض الobject دا يحتوى على Array of Node Each Node has Value+ Address of Next Node 
            ////يعنى كدة الRefernce  بيشاور على First Node ودى تعتبر هى الHead Node اللى عن طريقها هوصل للباقى عادى يبقى كدة الReference شايل Address of First Node only 
            //Console.WriteLine(Message);
            //Console.WriteLine(Message.GetHashCode());
            ////Message.Clear();//كدة انا دخلت على كل Node مسحت كل الValues اللى موجودة جواه
            //                //يعنى مازال Nodes موجودة بس اللى جواها اتمسح
            //Console.WriteLine(Message);
            //Console.WriteLine(Message.GetHashCode());//هيطبع نفس الHashcode لانه مازال بيشاور على Node بس اللى جواه الNode هو اللى اتمسح مش بمسح اى Node موجودة 
            //Message.Append("Ahmed");
            //Console.WriteLine(Message);//MohamedAhmed بس انا كدة عدلت على انفس المكان ازاى By Adding New Node has "Ahmed " يعنى مع كل زيادة او نقص انا بزود عدد Node او بمسح من غير ماعدل على حاجة بس دا كله فى نفس المكان فى الHeap
            //Console.WriteLine(Message.GetHashCode());//نفس الHashcode لان Reference مازال ماسك او Node 
            //===================================================================================
            //Method String Builder
            //StringBuilder Message= new StringBuilder("Hello");
            //Message.Append(" Mohamed");//Append =>Add New Node in Linkedlist This node have New Value اللى ضيفتها الجديدة 
            //Console.WriteLine(Message);//Hello Mohamed
            //Message.AppendLine(" Welcome");//Append Then make New line يعنى بعد كدة لو عملت Append جديدة هتبقى فى Line لوحدها عن التانيه    
            //Message.Append("Ahmed");
            //Console.WriteLine(Message);
            //Message.Replace("Ahmed","Salah");
            //Console.WriteLine(Message);
            //Message.Remove(0,3);//this Take Start index then length يعنى هبدا منين وهمشى كام خطوة
            //Message.Insert(0, "Hi");//Insert فى اى حتة براحتك مش بتضييف node زى الAppend 

            //Console.WriteLine(Message);
            //int age = 20;
            //Message.AppendFormat("\nYour Age is {0}",age);
            //Console.WriteLine(Message);
            //Message.AppendJoin("_","Ahmed","Mohamed","Marien");
            //Console.WriteLine(Message);
            #endregion
            //===============================================
            #region Array
            //Array is Collection of Element with The Same Type
            //array is Fixed size Not Dynamic Size
            //Types of Array 1D Array  2D Array  Jugged Array يعنى array Contain Collection of Element Each Element has Collection of element يعنى array تحتوى على array   
            //Array is Reference Type Variable Store in Stack and Array of Values Store in Heap
            //Array is Zero Based index يعنى تحتوى على عناصر العنصر الاول بيبدا من Zero index 
            //Array Access EElement By index بتاعه 
            // int[] Arr;
            //Clr Will Allocate 4 Byte in Stack With Default Value Null + 0 Byte in heap
            //Clr Declare Refernce From Type int in Stack Will Be Assign or Refere To object Conatin Array in Heap
            // Arr = new int[3];
            //Clr Will Be Allocate 12 Byte in Heap
            //Intialize Allocate Bytes With dEfault Value of Data Type
            //Call Empty Parameter Less Constructor if Exsisit
            //Assign Reference in Stack Will Be Refere Object in Heap
            //Arr in Stack With 4 Byte => Refre object 12 Byte in Heap [0-0-0]
            //Console.WriteLine(Arr[0]);//0 لان دى الDefault Value اللى بتتعمل لما باجى اعمل الAllocation in Heap
            //Arr[0] = 15;//Replace 0 With 15 in First element in 0 index
            //Console.WriteLine(Arr[0]);//15
            //Console.WriteLine(Arr.GetHashCode());
            //Arr.Length => Get Size of Array
            //Arr.Rank=> Get Type of Array يعنى هو كام D is 1D or 2D or 3D
            //for (int i = 0; i < Arr.Length; i++)
            //{
            //    Console.WriteLine(Arr[i]);
            //}
            //foreach (var i in Arr)//Take Copy of Array Not Original Version
            //{
            //    Console.WriteLine(i);
            //}
            //======================================================
            //======================================================
            //This other Way For Creating Array
            //int[] Numbers = new int[3] { 10, 20, 30 };//using Object Initializer
            //int[] Numbers = { 10, 20, 30 };
            //int[] Numbers = new int[] { 10, 20, 30 };
            //Can Access Any Element of array using index in only one Step يعنى اقدر اوصل لاى عنصر داخل الarray  من خطوة واحدة فقط  using this Rule [baseAddress+Index of element اللى عايز اوصله]+ (size of each Element *2)
            //لان الrefrence بيكون مشاور على اول عنصر وشايل الaddress بتاعه مش شايل address الarray كلها عاملة زى الLinkedList in stringBuilder =>Base Address is Address First element اللى الrefrence مشاور عليه

            //runtime Exception => index out of Range انى بحاول اوصل لindex مش موجود زىمثلا انا عامل array With Size3 يعنى اخرى فى الindex 2   جيت وعملت index3 عشان اجيب العنصر اللى جواه وهو اصلا فاضى فدى تسبب index out of Range
            //======================================================
            //======================================================
            //2D Array
            //int[,] Arr = new int[3, 3];
            //Clr Will Be Allocate 4 Byte in Stack With Default Value Null + 0 Byte in Heap
            //Clr Will Declar Reference[Arr] from Type int
            //With New=> Clr Will Allocate Required Number of 3*3*4=36 Byte in Heap 
            //Intialize Allocate Bytes With Default Value of Data Types
            //Call Empty Parameterless Constructor if Exsist
            //Assign Reference in Stack will Refere To object in heap هيخليه بيشاور عليه
            //Arr[0, 0] = 10;
            //Arr[0, 1] = 20;
            //Arr[0, 2] = 30;
            //Arr[1, 0] = 40;
            //Arr[1, 1] = 50;
            //Arr[1, 2] = 60;
            //Arr[2, 0] = 70;
            //Arr[2, 1] = 80;
            //Arr[2, 2] = 90;
            //Using Object intializer
            //int[,] Arr = new int[3, 3] { {10,20,30 },{40,50,60 },{70,80,90 } };

            //Take Values From User
            //int[,] Arr = new int[3, 3];
            //for (int i = 0; i < Arr.GetLength(0); i++)//This Rows=> Numbers Of Student
            //{
            //    Console.WriteLine($"Student  {i + 1} : ");

            //    for (int j = 0; j < Arr.GetLength(1);/*j++*/)//This Columns=> Numbers of Grad
            //    {
            //        Console.Write($"Grad  {j + 1} : ");
            //        bool isParse = int.TryParse(Console.ReadLine(), out Arr[i, j]);
            //        if (isParse == true)
            //        {
            //            ++j;
            //        }
            //    }
            //    Console.WriteLine("========================================================================");

            //}
            //Console.WriteLine(Arr.Length);//9
            //for (int i = 0; i < Arr.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Student  {i + 1} : ");
            //    for (int j = 0; j < Arr.GetLength(1); j++)
            //    {
            //        Console.Write($"Grad  {j + 1} : ");
            //        Console.WriteLine(Arr[i, j]);
            //    }
            //    Console.WriteLine("========================================================================");
            //}

            //===========================================================
            //===========================================================
            //Jagged Array
            //int[][]JaggedArray=new int[3][];//this Size of Jagged Array Has 3 Array Each Array is Refrence of Element in Heap
            //JaggedArray[0] = new int[3];//او عنصر داخل الJagged Array يحتوى على Array of 3 Element 
            //JaggedArray[1]=new int[2];//تانى عنصر داخل الJaggedArray يحتوى على Array From 2 element 
            //JaggedArray[2]=new int[1];//تالت عنصر داخل الJaggedArray يحتوى على array of 1 Element 
            //===========================================================
            //===========================================================
            //Array Methods
            //تنقسم الى Class Member Method=>بنادى عليها using Class نفسه
            //Object Member Method=> بنادى عليها using object From Class
            //int[] Numbers = { 2, 3, 5, 4, 1, 6, 7 };
            //Sort this Array Ascending
            //Array.Sort(Numbers);//this Method is Class Member Method=> Use IComparable interface this Default Sorting يعنى DEfault بترتب  Ascending
            //this Function Internally use Bubble Sort تقارن كل رقمين مع بعض فى الIteration الواحدة 

            //Array.Reverse(Numbers);//بتعكس الoutput اللى خارج يعنى 

            //Array.Clear(Numbers);//Delete All Value From index بس مكان الindex  موجود وبيشيل القيمة صفر بس مكانها موجود عاملة زى Clear in StringBuilder using LinkedList بيخش على الNode وبيمسح القيمة اللى بداخلها بس هى مازالت موجودة بس قيمتها بصفر


            //Array.Clear(Numbers, 0, 4);//انا همسح القيم اللى موجودة بداية من index=0 وهمشى 4 خطوات بداية من index=0

            //Array.IndexOf(Numbers, 5);//ببعت الSearch Value in Array =>return index of this Element ولو القيمة اللى ببحث عنها مش موجود يبقى يرجع -1
            //Array.IndexOf(Numbers, 9);//this Value Not Exsist in Array => will return -1  
            //int[] Numbers02 = {10,20,30,10,40,50 };
            //Array.IndexOf(Numbers02, 10);//هنا بدور على قيمة موجودة مرتين فى الarray يبقى هيرجع  index بتاعت  اول ظهور ليها
            //Array.LastIndexOf(Numbers, 6);//بتجيب index بتاع اخر ظهور للقيمة اللى بدور عليها فى حالة انها موجودة اكتر من ميرة واحدة 

            //Array.CreateInstance(typeof(int), 5);//Create New Array جديدة من Type دا واسمها Numbers والSize بتاعها 5 دى زى دى بالظبط => int[]Numbers=new int[size]; بيعمل نفس الحاجة بيروح يحجز اماكن فى الHeap with Default Value لكل قيمة على حسب الsize بتاعها بقا 
            //Array.Resize(ref Numbers,10);//بجدد الSize بتاع الarray => هنا كدة بعمل تجديد للArray with New Size بس دا كدة عمل New object in Heap with New Size as Array is Fixed Size عشان كدة لما عدلت الsize اتعدل وعمل مكان جديد واللى قبلها اصبحت unReachable object
            //كدة انا نقلت الValues From old Array in New array وكمان الاماكن الباقية فى New array => تاخد الDefault Value
            //So New Array Has Address مختلف عن Array القديمة لان لما عملتلها resize كدة حجزت مكان جديد ونقلت القيم على طول 


            //int[] Numbers = { 1, 2, 3, 4, 5 };
            //int[] Numbers02 = new int[5];
            //Array.Copy(Numbers, Numbers02,4);//Take Source then Destination then انا هنقل قد اي من العناصر 
            //Old Numbers Before Copy=>0 0 0 0 0
            //New Numbers After Copy =>1 2 3 4 0
            //Array.ConstrainedCopy(Numbers,1,Numbers02,2,3);//بتحكم انا هنقل من فين لفين 

            //================================================================
            //================================================================
            //Object Member Method
            //int[] Numbers = [10, 20, 30];
            //int SizeofArray= Numbers.Length;
            //int TypeofArray= Numbers.Rank;
            //Numbers.SetValue(100, 0);
            //int Result=(int)Numbers.GetValue(0);//Need For Casting
            //foreach (int number in Numbers)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion
            //===========================================================
            #region Assignment Session05 Identity Matrix سؤال تانى 
            /*
             2- . Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
             */
            //int n;
            //Console.Write("Enter Size of Array : ");
            //int.TryParse(Console.ReadLine(),out n);
            //int[,]Arr = new int[n,n];
            //int cols=Arr.GetLength(1);
            //for (int i=0;i<Arr.Length;i++)
            //{
            //   int row=i/cols;
            //   int col=i%cols;
            //    if (row == col)
            //    {
            //        Console.Write("1 ");
            //    }
            //    else
            //    {
            //        Console.Write("0 ");
            //    }

            //    if (col == cols - 1)
            //    {
            //        Console.WriteLine();
            //    }
            //}
            #endregion
            //===========================================================
            #region Assignment Session 05 Merge Array
            /*
             4- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
             */

            //int[] Arr01 = [30, 20, 10, 40];
            //int[] Arr02 = [60, 50, 90, 70, 80];

            //int[] newArr = Arr01.Concat(Arr02).ToArray();
            //Array.Sort(newArr);
            //foreach (int i in newArr)
            //{
            //    Console.WriteLine(i);
            //} 

            #endregion
            //===========================================================
            #region Assignment Session 05 Count Frequency 
            /*
              Write a program in C# Sharp to count the frequency of each element of an array.
             */
            //int[] Arr = [10, 20, 30, 10, 40, 10, 50, 10];

            //for (int i = 0; i < Arr.Length; i++)
            //{
            //    int Count = 0;
            //    bool Repeated = false;

            //    // هل الرقم ظهر قبل كده؟
            //    for (int j = 0; j < i; j++)
            //    {
            //        if (Arr[i] == Arr[j])
            //        {
            //            Repeated = true;
            //            break;
            //        }
            //    }

            //    if (Repeated)
            //        continue;
            //    for (int j = 0; j < Arr.Length; j++)
            //    {
            //        if (Arr[i] == Arr[j])
            //        {
            //            Count++;
            //        }
            //    }

            //    Console.WriteLine($"{Arr[i]} = {Count}");
            //}

            #endregion
            //===========================================================
            #region Jagged Array Using one Loop
            //int[,] numbers = new int[3, 4];
            //int cols = numbers.GetLength(1);
            //for (int i = 0; i < numbers.Length;)
            //{
            //    int row = i / cols;
            //    int col = i % cols;
            //    Console.Write($"Enter Value [{row},{col}]: ");
            //    bool isParsed = int.TryParse(Console.ReadLine(), out numbers[row, col]);
            //    if (isParsed == true)
            //    {
            //        ++i;
            //    }
            //}
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    int row = i / cols;
            //    int col = i % cols;
            //    Console.WriteLine($"numbers[{row},{col}] = {numbers[row, col]}");
            //}

            #endregion
        }
    }
}
