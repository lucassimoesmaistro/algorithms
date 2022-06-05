using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgoExpert.MinHeapConstruction
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] heap = new int[14] { 48, 12, 24, 7, 8, -5, 24, 391, 24, 56, 2, 6, 8, 41 };
			var minHeap = new MinHeap(heap.ToList());
			Console.WriteLine("FIM");
		}

		public class MinHeap
		{
			public List<int> heap = new List<int>();

			public MinHeap(List<int> array)
			{
				heap = buildHeap(array);
			}

			public List<int> buildHeap(List<int> array)
			{
				int firstParentIdx = (array.Count - 2) / 2;
				for (int currentIdx = firstParentIdx; currentIdx >= 0; currentIdx--)
				{
					siftDown(currentIdx, array.Count - 1, array);
				}
				return array;
			}

			public void siftDown(int currentIdx, int endIdx, List<int> heap)
			{
				int childOneIdx = currentIdx * 2 + 1;
                while (childOneIdx <= endIdx)
                {
					int idxToSwap;
					int childTwoIdx = currentIdx * 2 + 2 <= endIdx ? currentIdx * 2 + 2 : -1;
					if (childTwoIdx != -1 && heap[childTwoIdx] < heap[childOneIdx])
						idxToSwap = childTwoIdx;
					else
						idxToSwap = childOneIdx;
					if (heap[idxToSwap] < heap[currentIdx])
					{
						Swap(currentIdx, idxToSwap, heap);
						currentIdx = idxToSwap;
						childOneIdx = currentIdx * 2 + 1;
					}
					else
						break;
				}
			}

			public void siftUp(int currentIdx, List<int> heap)
			{
				int parentIdx = (currentIdx - 1) / 2;
				while (currentIdx > 0 && heap[parentIdx] > heap[currentIdx])
                {
					Swap(currentIdx, parentIdx, heap);
					currentIdx = parentIdx;
					parentIdx = (currentIdx - 1) / 2;
				}
			}

			public int Peek()
			{
				return heap[0];
			}

			public int Remove()
            {
                Swap(0, heap.Count - 1, heap);
				int valueToRemove = heap[heap.Count - 1];
				heap.RemoveAt(heap.Count - 1);
				siftDown(0, heap.Count - 1, heap);
				return valueToRemove;

            }

            private void Swap(int p1, int p2, List<int> heap)
            {
                int p2Value = heap[p2];
                heap[p2] = heap[p1];
                heap[p1] = p2Value;
            }

            public void Insert(int value)
			{
				heap.Add(value);
				siftUp(heap.Count - 1, heap);
			}
		}
	}
}
