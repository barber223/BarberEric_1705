using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberEric_CE01
{
    class Headers
    {
        string a = "";
        string b = "";
        string c = "";
        string d = "";
        string e = "";
        string f = "";
        string g = "";



        private void PopulateNeedHeader ( )
        {
            FullArray.Clear ( );
            a = ">==>    >=>                         >=>       >=>   >=>                                   ";
            b = ">> >=>  >=>                         >=>       >=>   >=>                                   ";
            c = ">=> >=> >=>   >==>      >==>        >=>       >=> >=>>==>   >==>    >===>>=>>==>   >===>  ";
            d = ">=>  >=>>=> >>   >=>  >>   >=>   >=>>=>       >=>   >=>   >>   >=>   >=>  >>  >=> >=>     ";
            e = ">=>   > >=> >>===>>=> >>===>>=> >>  >=>       >=>   >=>   >>===>>=>  >=>  >>  >=>   >==>  ";
            f = ">=>    >>=> >>        >>        >>  >=>       >=>   >=>   >>         >=>  >>  >=>     >=> ";
            g = ">=>     >=>  >====>    >====>    >=>>=>       >=>    >=>   >====>   >==>  >>  >=> >=> >=> ";
        }
        List<string> fullArray = new List<string>( );
       private void populateHaveHeader ( )
        {
            FullArray.Clear ( );

            a = ">=>    >=>                                         >=>   >=>                                   ";
            b = ">=>    >=>                                         >=>   >=>                                   ";
            c = ">=>    >=>    >=> >=>  >=>     >=>   >==>          >=> >=>>==>   >==>    >===>>=>>==>   >===>  ";
            d = ">=====>>=>  >=>   >=>   >=>   >=>  >>   >=>        >=>   >=>   >>   >=>   >=>  >>  >=> >=>     ";
            e = ">=>    >=> >=>    >=>    >=> >=>   >>===>>=>       >=>   >=>   >>===>>=>  >=>  >>  >=>   >==>  ";
            f = ">=>    >=>  >=>   >=>     >=>=>    >>              >=>   >=>   >>         >=>  >>  >=>     >=> ";
            g = ">=>    >=>   >==>>>==>     >=>      >====>         >=>    >=>   >====>   >==>  >>  >=> >=> >=> ";
        }

        public List<string> FullArray
        {
            get
            {
                return fullArray;
            }
            set
            {
                fullArray = value;
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

        public void AssignstringToBeCalled (string whichHeader )
        {
            if (whichHeader == "have")
            {
                populateHaveHeader ( );
            }
            else if (whichHeader == "need")
            {
                PopulateNeedHeader ( );
            }
            FullArray.Add ( A );
            FullArray.Add ( B );
            FullArray.Add ( C );
            FullArray.Add ( D );
            FullArray.Add ( E );
            FullArray.Add ( F );
            FullArray.Add ( G );   
        }
    }
}

