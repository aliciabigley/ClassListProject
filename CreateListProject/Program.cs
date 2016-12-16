using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CreateListProject
{
    public class Program 
    {
       
        static void Main(string[] args)
        {
            ListAttrubutes<int> attrubutesOne = new ListAttrubutes<int>();
            ListAttrubutes<int> attrubutesTwo = new ListAttrubutes<int>();
            ListAttrubutes<string> attrubutesThree = new ListAttrubutes<string>();


            foreach (int x in attrubutesOne)
            {
                Console.WriteLine(x);
            }
        }
    }
}
