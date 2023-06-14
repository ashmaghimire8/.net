//multiple inheritence
// namespace MultipleInherit{
//     interface IA{
//         void AMethod();
//     }
//     class A : IA{
//         public void AMethod(){
//             Console.WriteLine("This is A");
//         }
//     }
//     interface IB{
//         void BMethod();
//     }
//     class B : IB{
//         public void BMethod(){
//             Console.WriteLine("This is B");
//         }
//     }
//     class C:IA,IB{
//         A a = new A();
//         B b = new B();
//         public void AMethod(){
//             a.AMethod();
//         }
//         public void BMethod(){
//             b.BMethod();
//         }
//     }
//     class Program{
//         static void Main(string[] args){
//             C c = new C();
//             c.AMethod();
//             c.BMethod();
//         }
//     }

// }