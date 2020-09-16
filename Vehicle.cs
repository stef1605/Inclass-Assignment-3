using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stefan_Inclass_Assignment_3
{
    public class Vehicle
    {
            private float registration_number;
            private string color;
            private Person owner;
            public Vehicle()
            {
                registration_number = 0;
                color = "unknown";
            }

            public void v_dets(float rn, string col)
            {
                registration_number = rn;
                color = col;
            }

            public float reg_num()
            {
                return registration_number;
            }

            public string get_color()
            {
                return color;
            }

            public void change_of_owner()
        {
            owner = p;
        }
        }

    

}
