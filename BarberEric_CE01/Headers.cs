using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberEric_CE01
{
    class Headers
    {
        
        string a = ">==>    >=>                         >=>       >=>   >=>                                   ";
        string b = ">> >=>  >=>                         >=>       >=>   >=>                                   ";
        string c = ">=> >=> >=>   >==>      >==>        >=>       >=> >=>>==>   >==>    >===>>=>>==>   >===>  ";
        string d = ">=>  >=>>=> >>   >=>  >>   >=>   >=>>=>       >=>   >=>   >>   >=>   >=>  >>  >=> >=>     ";
        string e = ">=>   > >=> >>===>>=> >>===>>=> >>  >=>       >=>   >=>   >>===>>=>  >=>  >>  >=>   >==>  ";
        string f = ">=>    >>=> >>        >>        >>  >=>       >=>   >=>   >>         >=>  >>  >=>     >=> ";
        string g = ">=>     >=>  >====>    >====>    >=>>=>       >=>    >=>   >====>   >==>  >>  >=> >=> >=> ";

        List<string> needArray = new List<string>( );
        
        public List<string> Need
        {
            get
            {
                return needArray;
            }
            set
            {
                needArray = value;
            }
        }

        public string A
        {
            get
            {
                return a;
            }
        }

        public string B
        {
            get
            {
                return b;
            }
        }

        public string C
        {
            get
            {
                return c;
            }
        }

        public string D
        {
            get
            {
                return d;
            }
        }

        public string E
        {
            get
            {
                return e;
            }
           
        }

        public string F
        {
            get
            {
                return f;
            }
        }

        public string G
        {
            get
            {
                return g;
            }
        }

        public void AssignstringToBeCalled ( )
        {
            Need.Add ( A );
            Need.Add ( B );
            Need.Add ( C );
            Need.Add ( D );
            Need.Add ( E );
            Need.Add ( F );
            Need.Add ( G );   
        }
    }
}

