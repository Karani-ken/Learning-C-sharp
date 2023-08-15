using System.IO;

namespace Word_Count
{
    public class wordCount
    {
        public void readFileWords()
        {
            string line;
            int count = 0;

            //Open the file in reader mode
            StreamReader file = new StreamReader(@"C:\sample\data.txt");

            while((line = file.ReadLine()) != null)
            {
                //Splits each line into words
                String[] words = line.Split(' ');
                //Counts each word
                count=count + words.Length;
            }
            Console.WriteLine("Number of words is:" + count);

            file.Close();
        }
        public int longestWord()
        {
            string line;
            int n, res=0, curr_len=0;
            //Open the file in reader mode
            StreamReader file = new StreamReader(@"C:\sample\data.txt");
            while ((line = file.ReadLine()) != null)
            {
                //Splits each line into words
                String[] words = line.Split(' ');
                int number_of_words = words.Length;
                //if current character is not the end of word
                for(int i = 0;i < number_of_words; i++)
                {
                    if (words[i].Length != ' ')
                    {
                        curr_len++;
                    }
                    else
                    {
                        //if the last word is found
                        res = Math.Max(res, curr_len);
                        curr_len = 0;
                    }
                }
                //do max one more time to consider last word as there won't be any space after lastword
               
            }
            return Math.Max(res, curr_len);

        }
    }
}
