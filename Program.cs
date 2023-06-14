

// Console.WriteLine("Hello, World!");


// using System;

// namespace SampleProgram{
//     class Program{
//         static void Main(string[] args){
//             Console.WriteLine("This is sample program");
//         }
//     }
// }


// namespace DataAndValueType{
//     class Program{
//         static void Method(int x){
//             x = 300;
//             Console.WriteLine(x);
//         }
//         static void Main(string[] args){
//             int x = 500;
//             Console.WriteLine(x);
//             Method(x);
//             Console.WriteLine(x);
//         }
//     }
// }

// namespace Array{
//     class Program{
//         static void Main(string[] args){
//             char[] vowels = {'a','e','i','o','u'};
//             foreach (char c in vowels){
//                 Console.WriteLine(c);
//             }

//             // multidimentional array
//             int[ , ] multidimArray = new int[2,2]{
//                 {1,2},
//                 {3,4}
//             };
//             Console.Write(multidimArray[1,1]);

//             // jagged array
//             int[][] matrix = new int[2][]{
//                 new int[3]{1,2,3},
//                 new int[2]{5,6}
//             };
//             for(int i=0;i<matrix.Length;i++){
//                 for(int j=0;j<(matrix[i]).Length;j++){
//                     Console.WriteLine(matrix[i][j]);
//                 }
//             }

//         }
//     }
// }

// namespace SwitchCase{
//     class Program{
//         static void Main(string[] args){
//             Console.WriteLine("C or C#?");
//             Console.Write("Please pick your choice: ");
//             string LangChoice = Console.ReadLine();
            // switch(LangChoice){
            //     case "C":
            //     Console.WriteLine("C? Really?");
            //     break;

            //     case "C#":
            //     Console.WriteLine("C#? Really?");
            //     break;

            //     default:
            //     Console.WriteLine("Something else?");
            //     break;
            // }

//             var result = LangChoice switch{
//                 "C" => "HEh",
//                 "C#" => "hehe",
//                 _ => "Something else?"
//             };
//             Console.Write(result);
            
//         }
//     }
// }


