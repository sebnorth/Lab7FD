using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapLab7
{
    public class BinaryHeap
    {
        int[] arr;
        int sizeOfHeap;

        public BinaryHeap(int rozmiar) {

            this.arr = new int[rozmiar + 1];
            this.sizeOfHeap = 0;

        }

        public int SizeOfHeap() {

            return sizeOfHeap;
        }

        public int PeekOfHeap() {

            return arr[1];
        }


        public int Parent(int i) {

            return i / 2;
        }

        public int Left(int i) {

            return 2 * i;
        }
        public int Right(int i) {

            return 2 * i + 1;
        }



        // x,y - indeksy
        public void Swap(int x, int y) {

            int kopia = arr[x];
            arr[x] = arr[y];
            arr[y] = kopia;
        }


        public void moveUp(int i) {

            while (Parent(i) >= 1 && arr[i] > arr[Parent(i)])
            {

                Swap(i, Parent(i));

                i = Parent(i);
            }
            
        }


        public void AddToHeap(int item) {

            // dodawanie elementu do kopca (czyli ewentualna naprawa właśności kopca)
            sizeOfHeap++;
            arr[sizeOfHeap] = item;
            moveUp(sizeOfHeap);

        }

        public void Add(int item)
        {

            // dodawanie elementu do kopca (bez naprawy właśności kopca)
            sizeOfHeap++;
            arr[sizeOfHeap] = item;
            // moveUp(sizeOfHeap);

        }

        public void BuildMaxHeap() {

            for (int i = sizeOfHeap/2; i >= 1; i--)
            {
                // TODO patrz pliki bheap.jpg i heapify.jpg
            }

        }

        public void WypiszKopiec() {

            for (int i = 1; i <= sizeOfHeap; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
        }






    }
}
