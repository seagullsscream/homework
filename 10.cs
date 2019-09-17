using System;

namespace ConsoleApplication1
{
  class Program
  {
    static int sum;
    static void Main (string[]args)
    {

      for (int i = 2; i <= 10; i++)
	{
	  if (isSimple (i))
	    {
	      sum += i;
	    }

	}

      Console.WriteLine (sum);
    }

    private static bool isSimple (int N)
    {
      for (int i = 2; i <= (int) (N / 2); i++)
	{
	  if (N % i == 0)
	    return false;
	}

      return true;
    }
  }
}
