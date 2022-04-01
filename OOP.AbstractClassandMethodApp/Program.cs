using System;

namespace OOP.AbstractClassandMethodApp
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 3,2,1,4,5 };
            // var heap = new Heap();  // ifade abstarct olduğu için bu satır hata verir
            var minheap = new MinHeap();  // abstract classı devralmış minheap ve maxheap üzerinden tanım gerçekleştirilebilir
            var maxheap = new MaxHeap();
            
            foreach (var item in arr)
            {
                minheap.Insert(item);
                maxheap.Insert(item);
            }

            Console.WriteLine(minheap.Extract()); // 1 döner 
            Console.WriteLine(maxheap.Extract()); // 5 döner
        }
    }
}