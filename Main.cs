using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface Creation {
  string author {
    get{return "Author: " + firstName + " " + lastName;}
    }
  string type{
    get{
      if (type = "novel") {return "Novel with " + this.numOfPages + "pages.";}
        return type;}
    }
   string title{
    get{return "Title: " + title;}
    }
}

namespace Group_Assignment_0
{
    
    class Creator
    {
        private String firstName;
        public String FirstName;
        
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        private String lastName;
        public String LastName;
        {
        get
        {    
                return lastName;
        }   
            set
        {
                lastName = value;
        }
        } 
    
//using System;

//namespace Project0
//{
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
//}
  


   class Painting : Creation
    {
        private int width;
        private int height;

        public Painting(int Width, int Height)
        {
            this.width = Width;
            this.height = Height;
        }
        
        public int width()
        {   
               get 
               {
               return width;
               }
               set 
               {
               width = value;
               }
        }

        public int height()
        {
            get 
            {
            return height;
            }
            set
            {
            height = value;
            }
        }
    }
}
