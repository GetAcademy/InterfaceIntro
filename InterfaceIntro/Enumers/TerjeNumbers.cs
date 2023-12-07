using System.Collections;

namespace InterfaceIntro.Enumers
{
    internal class TerjeNumbers : IEnumerable<int>, IEnumerator<int>
    {
        public int Current { get; private set; } = 1;

        public bool MoveNext()
        {
            Current *= 2;
            return Current < 500;
        }

        // 1 2 4 8 16 32 64 128 256
        public IEnumerator<int> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }



        public void Reset()
        {
        }


        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }
    }

}
