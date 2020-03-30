using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_GreedyTimes
{

    public class Potato
    {
        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());
            string[] line = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var bag = new Dictionary<string, Dictionary<string, long>>();
            long gold = 0;
            long stones = 0;
            long money = 0;

            for (int i = 0; i < line.Length; i += 2)
            {
                string name = line[i];
                long quantity = long.Parse(line[i + 1]);

                string items = string.Empty;

                if (name.Length == 3)
                {
                    items = "Cash";
                }
                else if (name.ToLower().EndsWith("gem"))
                {
                    items = "Gem";
                }
                else if (name.ToLower() == "gold")
                {
                    items = "Gold";
                }

                if (items == "")
                {
                    continue;
                }
                else if (input < bag.Values.Select(x => x.Values.Sum()).Sum() + quantity)
                {
                    continue;
                }

                switch (items)
                {
                    case "Gem":
                        if (!bag.ContainsKey(items))
                        {
                            if (bag.ContainsKey("Gold"))
                            {
                                if (quantity > bag["Gold"].Values.Sum())
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (bag[items].Values.Sum() + quantity > bag["Gold"].Values.Sum())
                        {
                            continue;
                        }
                        break;
                    case "Cash":
                        if (!bag.ContainsKey(items))
                        {
                            if (bag.ContainsKey("Gem"))
                            {
                                if (quantity > bag["Gem"].Values.Sum())
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (bag[items].Values.Sum() + quantity > bag["Gem"].Values.Sum())
                        {
                            continue;
                        }
                        break;
                }

                if (!bag.ContainsKey(items))
                {
                    bag[items] = new Dictionary<string, long>();
                }

                if (!bag[items].ContainsKey(name))
                {
                    bag[items][name] = 0;
                }

                bag[items][name] += quantity;
                if (items == "Gold")
                {
                    gold += quantity;
                }
                else if (items == "Gem")
                {
                    stones += quantity;
                }
                else if (items == "Cash")
                {
                    money += quantity;
                }
            }

            foreach (var x in bag)
            {
                Console.WriteLine($"<{x.Key}> ${x.Value.Values.Sum()}");
                foreach (var item2 in x.Value.OrderByDescending(y => y.Key).ThenBy(y => y.Value))
                {
                    Console.WriteLine($"##{item2.Key} - {item2.Value}");
                }
            }
        }
    }
}