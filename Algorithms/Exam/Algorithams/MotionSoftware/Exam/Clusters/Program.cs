using System;
using System.Linq;
using System.Text;

namespace Clusters
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] singleCluster = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] pairClusters = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            StringBuilder sb = new StringBuilder();

            int totalTime = 0;

            for (int i = 0; i < singleCluster.Length - 1; i++)
            {
                for (int j = i; j < pairClusters.Length; j++)
                {
                    if(singleCluster[i] + singleCluster[i + 1] < pairClusters[j])
                    {
                        sb.AppendLine($"Single {i + 1}");
                        totalTime += singleCluster[i];
                        break;
                    }
                    else
                    {
                        
                        if(i < singleCluster.Length - 2)
                        {
                            if(j < pairClusters.Length - 1)
                            {
                                if(pairClusters[j] > pairClusters[j + 1])
                                {
                                    if(singleCluster[i + 1] + singleCluster[i + 2] > pairClusters[j + 1])
                                    {
                                        sb.AppendLine($"Single {i + 1}");
                                        totalTime += singleCluster[i];
                                        sb.AppendLine($"Pair of {i + 2} and {i + 3}");
                                        totalTime += pairClusters[j + 1];
                                        i += 2;
                                        break;
                                    }
                                    else
                                    {
                                        sb.AppendLine($"Pair of {i + 1} and {i + 2}");
                                        totalTime += pairClusters[j];
                                        i++;
                                        break;
                                    }
                                }
                                else
                                {
                                    sb.AppendLine($"Pair of {i + 1} and {i + 2}");
                                    totalTime += pairClusters[j];
                                    i++;
                                    break;
                                }
                            }
                            else
                            {
                                sb.AppendLine($"Pair of {i + 1} and {i + 2}");
                                totalTime += pairClusters[j];
                                i++;
                                break;
                            }
                        }
                        else
                        {
                            sb.AppendLine($"Pair of {i + 1} and {i + 2}");
                            totalTime += pairClusters[j];
                            i++;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine($"Optimal Time: {totalTime}");
            Console.Write(sb.ToString());
        }
    }
}
