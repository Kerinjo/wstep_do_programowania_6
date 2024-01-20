using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wstep_do_programowania_6
{
    internal class Element
    {
        public Element nextElement;

        public Element previousElement;

        // add next
        public void addNext(Element element)
        {
            if (nextElement == null)
            {
                nextElement = element;
                element.previousElement = this;
            }
            else
            {
                element.previousElement = this;
                element.nextElement = this.nextElement;

                this.nextElement.previousElement = element;
                this.nextElement = element;
            }
            
        }

        public void removeNext()
        {
            if (this.nextElement != null)
            {
                if (this.nextElement.nextElement != null)
                {
                    this.nextElement = this.nextElement.nextElement;
                    this.nextElement.nextElement.previousElement = this;
                }
            }
        }

        public void removePrevious()
        {
            if (this.previousElement != null)
            {
                if (this.previousElement.previousElement != null)
                {
                    this.previousElement.previousElement.nextElement = this;
                    this.previousElement = this.previousElement.previousElement;
                }    
            }
        }

        // add prev
        public void addPrevious(Element element)
        {
            previousElement = element;
            element.nextElement = this;
        }


    }
}
