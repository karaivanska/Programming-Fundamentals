using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class socialMediaPosts
{
    static Dictionary<string, Dictionary<string, string>> postsDict;
    static Dictionary<string, int> postLikes;
    static Dictionary<string, int> postDislikes;

    static void Main()
    {
        postsDict = new Dictionary<string, Dictionary<string, string>>();
        postLikes = new Dictionary<string, int>();
        postDislikes = new Dictionary<string, int>();

        string[] inputTokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        while (!IsDrop(inputTokens[0]))
        {
            string command = inputTokens[0];
            string postName = inputTokens[1];

            switch (command)
            {
                case "post":
                    {
                        CreatePost(postName);
                        break;
                    }
                case "like":
                    {
                        LikePost(postName);
                        break;
                    }
                case "dislike":
                    {
                        DislikePost(postName);
                        break;
                    }
                case "comment":
                    {
                        string commentatorName = inputTokens[2];
                        string commentContent = string.Join(" ", inputTokens.Skip(3));

                        CommentPost(postName, commentatorName, commentContent);
                        break;
                    }
            }

            inputTokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }

        foreach (var item in postsDict)
        {
            string postName = item.Key;
            Dictionary<string, string> comments = item.Value;

            Console.WriteLine("Post: {0} | Likes: {1} | Dislikes: {2}", postName, postLikes[postName], postDislikes[postName]);

            Console.WriteLine("Comments:");

            if (comments.Count == 0)
            {
                Console.WriteLine("None");
            }

            foreach (var kvp in comments)
            {
                string comentator = kvp.Key;
                string content = kvp.Value;

                Console.WriteLine("*  {0}: {1}", comentator, content);
            }
        }
    }

    static void CommentPost(string postName, string commentatorName, string commentContent)
    {
        postsDict[postName].Add(commentatorName, commentContent);
    }

    static void DislikePost(string postName)
    {
        postDislikes[postName]++;
    }

    static void LikePost(string postName)
    {
        postLikes[postName]++;
    }

    static void CreatePost(string postName)
    {
        postsDict.Add(postName, new Dictionary<string, string>());
        postLikes.Add(postName, 0);
        postDislikes.Add(postName, 0);
    }

    static bool IsDrop(string inputToken)
    {
        return inputToken == "drop";
    }
}

