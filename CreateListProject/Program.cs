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

            attrubutesOne.Add(1);
            attrubutesOne.Add(2);
            attrubutesOne.Add(3);
            attrubutesOne.Add(4);
            attrubutesOne.Add(5);
            attrubutesOne.Add(6);
            attrubutesOne.Add(7);
            attrubutesOne.Add(8);
            attrubutesOne.Add(9);
            attrubutesOne.Add(10);

        }
    }
}
