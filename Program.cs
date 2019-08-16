using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork
{
    interface Creation {
        string author {
            get{
                return "Author: " + firstName + " " + lastName;
            }
        }

        string type{
            get{
                if (type = "novel") {
                    return "Novel with " + this.numOfPages + "pages.";
                }

                return type;
                }
        }
        string title{
            get{
                return "Title: " + title;
                }
            }

}
}
