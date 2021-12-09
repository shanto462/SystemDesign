using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using SystemDesign.IteratorPattern;
using SystemDesign.Memento;

namespace Solve
{
    class Program
    {
        static IEnumerable<int> freqQuery(List<List<int>> queries)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            Dictionary<int, HashSet<int>> freqMap = new Dictionary<int, HashSet<int>>();
            foreach (var query in queries)
            {
                var val = query[1];
                if (query[0] == 1)
                {
                    var prevFreq = -1;
                    if (map.ContainsKey(val))
                    {
                        prevFreq = map[val];
                        map[val]++;
                    }
                    else map.Add(val, 1);
                    //if(prevFreq != -1)
                    {
                        if (freqMap.ContainsKey(prevFreq))
                        {
                            freqMap[prevFreq].Remove(val);
                        }
                        var freq = map[val];
                        if (freqMap.ContainsKey(freq)) freqMap[freq].Add(val);
                        else
                            freqMap.Add(freq, new HashSet<int> { val });
                    }
                }
                else if (query[0] == 2)
                {
                    if (map.ContainsKey(val))
                    {
                        var prevFreq = map[val];
                        map[val]--;
                        if (freqMap.ContainsKey(prevFreq))
                        {
                            freqMap[prevFreq].Remove(val);
                        }
                        var freq = map[val];
                        if (freqMap.ContainsKey(freq)) freqMap[freq].Add(val);
                        else
                            freqMap.Add(freq, new HashSet<int> { val });
                    }
                }
                else
                {
                    if (freqMap.ContainsKey(val))
                    {
                        if (freqMap[val].Count > 0)
                            yield return 1;
                        else
                            yield return 0;
                    }
                    else
                        yield return 0;
                }
            }
        }

        static void Main(string[] args)
        {

            TextWriter textWriter = new StreamWriter(@"D:\3d\temp.txt", true);

            int q = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> queries = new List<List<int>>();

            for (int i = 0; i < q; i++)
            {
                queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
            }

            var finds = queries.Where(q => q[0] == 3).ToList();

            List<int> ans = freqQuery(queries).ToList();

            textWriter.WriteLine(String.Join("\n", ans));

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
