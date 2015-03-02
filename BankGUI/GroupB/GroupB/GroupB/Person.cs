using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupB
{
    class Person
    {
        #region Fields

        //Fields
        private int iD;
        private string first;
        private string last;
        private string password;
        
        #endregion

        #region Properties

        //Properties
        public int ID
        {
            get { return iD; }
        }
        public String First
        {
            get { return first; }
        }
        public String Last
        {
            get { return last; }
        }

        #endregion

        #region Constructors

        //Constructors
        public Person(int passedId, String passedFirst, String passedLast, String passedPassword)
        {

        }

        #endregion

        #region Methods

        //Methods

        #endregion
    }
}
