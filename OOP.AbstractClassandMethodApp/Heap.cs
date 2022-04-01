namespace OOP.AbstractClassandMethodApp
{
    public abstract class Heap
    {
        // field
        protected SortedSet<int> _list;

        public Heap()
        {
            _list = new SortedSet<int>();
        }

        public void Insert(int item)
        {
            _list.Add(item);
        }

        // abstract method
        public abstract int Extract(); // Eğer bir sınıf abstract olarak tanımlanır ise o sınıftan new anahtar sözcüğü ile nesne türetmek mümkün olmaz
                                       // anstract üye var ise sınıf da abstract olmalı

    }
}