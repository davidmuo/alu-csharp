using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        HashSet<int> set1 = new HashSet<int>(list1);
        HashSet<int> set2 = new HashSet<int>(list2);
        HashSet<int> different = new HashSet<int>();

        foreach (int n in set1)
        {
            if (!set2.Contains(n))
                different.Add(n);
        }

        foreach (int n in set2)
        {
            if (!set1.Contains(n))
                different.Add(n);
        }

        List<int> result = new List<int>(different);
        Sort(result);

        return result;
    }

    private static void Sort(List<int> list)
    {
        for (int i = 1; i < list.Count; i++)
        {
            int key = list[i];
            int j = i - 1;

            while (j >= 0 && list[j] > key)
            {
                list[j + 1] = list[j];
                j--;
            }

            list[j + 1] = key;
        }
    }
}
