namespace Orc.Algorithms.Sort.NSort
{
    using System.Collections;

    using Orc.Algorithms.Sort.Interfaces;

    public class SelectionSort : SwapSorter
	{
		public SelectionSort() : base() {}

		public SelectionSort(IComparer comparer, ISwap swapper)
			:base(comparer,swapper)
		{
		}

		public override void Sort(IList list) 
		{
			int i;
			int j;
			int min;

			for (i=0;i<list.Count;i++) 
			{
				min = i;
				for (j=i+1;j<list.Count;j++) 
				{
					if (this.Comparer.Compare(list[j], list[min])<0) 
					{
						min = j;
					}
				}
				this.Swapper.Swap(list, min, i);
			}
		}
	}
}
