using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseTreeDesignPattern
{
    public interface IReverseTree
    {
        public void BuildTree(int num);
        public int CountNodes();

    }
}
