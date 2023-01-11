 static int Stepen(int a, int b)
        {
            int c = a;
            int d = b;

            int per = a;

            for (int i = 1; i < b; i++)
            {
                a *= per;
            }
            return a;
        }