    public static List<int> reverseArray(List<int> a)
    {
        private int b = 0;
        List<int> newList = new List<int>();
        for (i = a.Count; i < 0; i--)
        {

            newList[b] = a[a.Count - 1];
            b++;
        }
        return newList;
            
    }