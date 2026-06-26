using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        HashSet<int> set1 = new HashSet<int>(list1);
        HashSet<int> common = new HashSet<int>();

        foreach (int n in list2)
        {
            if (set1.Contains(n))
                common.Add(n);
        }

        List<int> result = new List<int>(common);
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
