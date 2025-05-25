using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCode
{
    public class IntImaxCompare : IComparer<int>
    {
        public int Compare(int x, int y) => y.CompareTo(x);
    }
    public class CalculateHighScore
    {

        public static string CalculateHighScoreData(int countOfHighScores, int rowLength, List<int> array)
        {
            string returnString = string.Empty;
            int rowHeight = array.Count() / rowLength;
            int[,] arrayData = new int[rowHeight, rowLength];
           
            string structureData = string.Empty;

            for (int i = 0; i < rowHeight; i++) { 
                for(int j = 0; j < rowLength; j++)
                {
                    //int val = i * rowLength + j;
                    //Console.WriteLine(val);                   
                    arrayData[i, j] = array[i * rowLength + j];

                    structureData = structureData + " " + arrayData[i, j].ToString();
                }
                structureData = structureData + Environment.NewLine;
            }

            Console.WriteLine(structureData);

            int[,] totalWithNeighbor = new int[rowHeight, rowHeight];

            PriorityQueue<string, int> priorityQueue = new(new IntImaxCompare());

            structureData = string.Empty;

            for (int i = 0; i < rowHeight;i++)
            {
                for(int j=0; j < rowLength; j++)
                {
                    totalWithNeighbor[i,j] = arrayData[i,j] + GetNeighborTotal(arrayData, i, j, rowHeight - 1, rowLength - 1);
                    string index = i.ToString() + ", " + j.ToString();
                    priorityQueue.Enqueue(index, totalWithNeighbor[i,j]);
                    structureData = structureData + " " + totalWithNeighbor[i, j].ToString();
                }
                structureData = structureData + Environment.NewLine;
            }

            Console.WriteLine(structureData);

            for (int i = 0; i < countOfHighScores; i++)
            {
                priorityQueue.TryDequeue(out var item, out var priority);
                returnString += "(" + item + "," + priority + ")";
            }
            return returnString;
        }

        public static int GetNeighborTotal(int[,] array, int rowHeight, int rowLength, int maxHeight, int maxWidth)
        {
            int returnValue = 0;
            int rowMin = rowHeight - 1 < 0 ? rowHeight : rowHeight - 1;
            int rowMax = rowHeight + 1 > maxHeight ? rowHeight : rowHeight + 1;
            int colMin = rowLength - 1 < 0 ? rowLength : rowLength - 1;
            int colMax = rowLength + 1 > maxWidth ? rowLength : rowLength + 1;

            for(int i = rowMin; i <= rowMax; i++)
            {
                for(int j = colMin; j <= colMax; j++)
                {
                   if(i != rowHeight ||  j != rowLength)
                    {
                        returnValue += array[i, j];
                    }
                }
            }

            return returnValue;
        }
    }
}
