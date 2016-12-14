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
            ListAttrubutes<int> attrubutes = new ListAttrubutes<int>();
            attrubutes.CreateLargerArray();
        }
    }
}
