using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
