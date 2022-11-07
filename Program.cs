namespace MyStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*сделал 2 реализации interface IMyStack
            StackLinked связанній список
            Stackmas -на массиве*/

            /*сделал IEnumerator для foreach на Stackmas через yield*/


            IMyStack<int> st = new Stackmas<int>();
            st.Push(10);
            st.Push(20);
            st.Push(30);
            st.Push(40);
            st.Push(50);

            Console.WriteLine(st.Pop);

           


            foreach (var item in (IEnumerable<int>)st)
            {
                Console.WriteLine(item);
            }
 Console.WriteLine(st.Count());
            Console.WriteLine(" ");
           

             st = new StackLinked <int>();
           
            st.Push(10);   
            st.Push(20);
            st.Push(30);
            st.Push(40);
            Console.WriteLine(st.Pop()); 

           /*Сохраняем в массив*/
            int[] mas1 = new int[20];
            st.CopyTo(mas1);
            st.Push(5000);


           /* Добавил метод принт в StackLinked,делаем приведение к классу,т.к.st от интерфейса*/
            StackLinked <int>st1 = (StackLinked<int>)st;

            st1.Print();


        }
    }
   

}