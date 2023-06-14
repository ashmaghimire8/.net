//only declaring delegate type
// delegate void Procedure(); 

// class DemoDelegate{
//     public static void Method1(){
//         Console.WriteLine("Method 1");
//     }

//     public static void Method2(){
//         Console.WriteLine("Method 2");
//     }

//     public static void Method3(){
//         Console.WriteLine("Method 3");
//     }

//     public static void Main(string[] args){
//         //instatnties delegate
//         Procedure someProcs = null;
//         //adding two static method to delegate instance
//         someProcs += new Procedure(Method1);
//         someProcs += new Procedure(Method2);
//         DemoDelegate demo = new DemoDelegate();
//         //adding non static method
//         someProcs += new Procedure(Method3);
//         someProcs();

//     }
// }