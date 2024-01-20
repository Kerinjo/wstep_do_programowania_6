using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wstep_do_programowania_6
{
    internal class Node
    {
        public Node parent;    
        List<Node> children = new List<Node>();


        // metody:


        // dodaj dziecko
        public void addChild(Node node)
        {
            children.Add(node);
            node.parent = this;
        }

        // ile dzieci
        public int childrenCount() { return children.Count; }

        // ile potomstwa -> traversal
        // dobrze by bylo znac traversala


        public int ancestorCount()
        {
            // funkcja liczy wszystkich przodkow i samego siebie
            int count = 1;
            foreach (Node child in children)
            {
                count += child.ancestorCount();
            }
                      
            return count;
        }
        
        

    }
}
