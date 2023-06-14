// concept to hide the methods of the base class from derived class, this concept is known as Method Hiding.
// also known as Method Shadowing. using the new keyword.

// public class myFamily{
//     public void memeber(){
//         Console.WriteLine("There are 5 members");
//     }
// }

// public class myMember : myFamily{
//     public void member(){
//         Console.WriteLine("Name:Ashma, Age:21 \nName:Sonya, Age:21 \nName:lwj, Age:21 \nName:wwx, Age:21 \nName:saiki, Age:21 \n");
//     }
// }

// class Program{
//     static public void Main(string[] args){
//         myMember obj = new myMember();
//         obj.member();
//     }
// }