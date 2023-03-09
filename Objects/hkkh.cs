using System;

public class Intervals
{
    SumIntervals([][]{[1,2],[6,10],[11,15]})

    public static int SumIntervals((int, int)[] intervals)
    {
      //COPY
      int[][] sortedIntervals = new int[intervals.Length][2];
      
      for(int i=0; i<intervals.Length; i++)
      {
        sortedIntervals[i][0] = intervals[i][0];
        sortedIntervals[i][1] = intervals[i][1];
      }
      
      //SORT
      for(int i=0; i<sortedIntervals.Length-1; i++)
      {
        for(int j=0; j<sortedIntervals.Length-1-i; j++)
        {
          if (sortedIntervals[j][0] > sortedIntervals[j+1][0])
          {
            int temp[] = sortedIntervals[j];
            sortedIntervals[j] = sortedIntervals[j+1];
            sortedIntervals[j+1] = temp;
          }
        }
      }
      
      //PRINT
      for (int i=0; i<sortedIntervals.Length-1; i++)
      {
        for(int j=0; j<sortedIntervals.Length-1-i; j++)
        {
          Console.Write(sortedIntervals[i][j] );
        }
        Console.WriteLine();
      }


    }
}