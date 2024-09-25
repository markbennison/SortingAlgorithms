/* *************************************************************************** *
 * *************************************************************************** *
 *       __  ___           __       ____                   _                   *
 *      /  |/  /___ ______/ /__    / __ )___  ____  ____  (_)________  ____    *
 *     / /|_/ / __ `/ ___/ //_/   / __  / _ \/ __ \/ __ \/ / ___/ __ \/ __ \   *
 *    / /  / / /_/ / /  / ,<     / /_/ /  __/ / / / / / / (__  ) /_/ / / / /   *
 *   /_/  /_/\__,_/_/  /_/|_|   /_____/\___/_/ /_/_/ /_/_/____/\____/_/ /_/    *
 *                                                                             *
 * *************************************************************************** *
 * *************************************************************************** */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    internal class BubbleSort
    {
        public static void Perform(List<double> listToSort)
        {
            bool swapped = true;
            double temp;

            while (swapped)
            {
                swapped = false;
                for (int i = 0; i < listToSort.Count - 1; i++)
                {
                    if (listToSort[i] > listToSort[i + 1])
                    {
                        temp = listToSort[i];
                        listToSort[i] = listToSort[i + 1];
                        listToSort[i+1] = temp;
                        swapped = true; 
                    }
                }
            }
        }
    }
}
