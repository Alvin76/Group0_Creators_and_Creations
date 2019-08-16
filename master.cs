using System;

namespace Project0
{
    public class Novel
    {
            private int pages;
            public int Pages
            {
                get
                {
                    return pages;
                }
                set
                {
                    pages = value;
                }

            }
            // properities was added at a later time where we can do somthing?
            //
            public Novel()
            {
                this.pages = 0;
            }
            public Novel(int pages ) //: this(ID1,lastName1, firstName1)
            {
                this.pages = pages;
                //
            }
    }
} // out of date
