namespace Hworld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*var firsSentense = "";
            var secondSentense = "";
            Console.Write("gap kiriting :");
            firsSentense=Console.ReadLine();
            Console.Write("So'z kiriting :");
            secondSentense=Console.ReadLine();
            Console.WriteLine(DeleteFirstSentense(firsSentense,secondSentense));*/




            /*var firsSentense = "";
            Console.Write("gap kiriting :");
            firsSentense = Console.ReadLine();
            Console.WriteLine(delDigit(firsSentense));*/






            Main(args);

        }

        static string delDigit(string sentence)
        {
            for (var i = 0; i < sentence.Length; i++)
            {
                if (char.IsDigit(sentence[i]))
                {
                    sentence = sentence.Remove(i, 1);
                    i--;
                }
            }
            return sentence;
        }




        static string DeleteProbels(string sentence)
        {
            for (int i = 0; i < sentence.Length - 1; i++)
            {
                if (sentence[i] == ' ' && sentence[i + 1] == ' ')
                {
                    sentence = sentence.Remove(i, 1);
                    i--;
                }
            }
            if (sentence[0] == ' ')
            {
                sentence = sentence.Remove(0, 1);
            }
            if (sentence[sentence.Length - 1] == ' ')
            {
                sentence = sentence.Remove(sentence.Length - 1, 1);
            }
            return sentence;
        }
        static string DeleteFirstSentense(string firstSentence, string secondSentencce)
        {
            var empty = "";
            for (var i = 0; i < firstSentence.Length; i++)
            {
                empty = firstSentence.Substring(i, secondSentencce.Length);
                if (empty == secondSentencce)
                {
                    firstSentence = firstSentence.Remove(i, secondSentencce.Length);
                    break;
                }
            }
            return firstSentence;
        }

        static string MiddleOfDegree(string sentence)
        {
            var lengthOfSentense = sentence.Length / 2;
            var empty = "";
            for (var j = 0; j < lengthOfSentense; j++)
            {
                empty += sentence[j];
            }
            return empty;
        }

        static string ThreeOFMiddle(string sentence)
        {
            if (sentence.Length < 3)
            {
                return "Error";
            }
            for (var i = (sentence.Length / 2) - 1; true; i++)
            {
                return sentence.Substring(i, 3);
            }
        }




    }
}
