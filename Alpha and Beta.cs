 public static int alphaBeta(List<int> pile)
        {

            int max = 0, second = 0;

            for (int i = 0; i < pile.Count; i++)
            {
                if (pile[i] > max)
                {
                    second = max;
                    max = pile[i];
                }
                if (pile[i] < max && pile[i] > second)
                {
                    second = pile[i];
                } 

            }
            return second;
        }