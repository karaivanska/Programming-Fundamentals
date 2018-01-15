using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class forumTopics
{
    static void Main()
    {
        var forumDict = new Dictionary<string, HashSet<string>>();
        var input = Console.ReadLine();

        while (!IsFilter(input))
        {
            string[] tokens = input.Split(new string[] {" -> "}, StringSplitOptions.RemoveEmptyEntries);

            string topicName = tokens[0];
            string[] tagsNames = tokens[1].Split(new char[]{' ', ','}, StringSplitOptions.RemoveEmptyEntries);

            if (!forumDict.ContainsKey(topicName))
            {
                forumDict.Add(topicName, new HashSet<string>());
            }

            if (!IsTagsContainOneElement(tagsNames))
            {
                foreach (var tag in tagsNames)
                {
                    forumDict[topicName].Add(tag);
                }
            }
            else
            {
                forumDict[topicName].Add(tagsNames[0]);
            }

            input = Console.ReadLine();
        }

        string[] inputTokens = Console.ReadLine().Split(new char[]{' ', ','}, StringSplitOptions.RemoveEmptyEntries);

        foreach (var forumsData in forumDict)
        {
            string topic = forumsData.Key;
            HashSet<string> tags = forumsData.Value;

            if (IsDictContainsAllTokens(tags, inputTokens))
            {
                foreach (var item in tags)
                {
                    var hashtaggedTags = tags.Select(t => "#" + t);
                    Console.WriteLine("{0} | {1}",
                        topic,
                        string.Join(", ", hashtaggedTags));
                    break;
                }
            }
        }
    }

    static bool IsDictContainsAllTokens(HashSet<string> tags, string[] inputTokens)
    {
        bool isContained = false;
        foreach (var token in inputTokens)
        {
            if (tags.Contains(token))
            {
                isContained = true;
            }
            else
            {
                return false
            }
        }

        return isContained;
    }

    static bool IsTagsContainOneElement(string[] tagsNames)
    {
        for (int i = 0; i < tagsNames.Length; i++)
        {
            if (i > 0)
            {
                return false;
            }
        }

        return true;
    }

    static bool IsFilter(string input)
    {
        return input == "filter";
    }
}


