using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
* Name: Tom Tsiliopoulos
* Date: July 13, 2017
* Description: This is the SuperHero class which inherits from the SuperHuman class
* and implements the IHasKarma interface
* Version: 0.1 - Created the SuperHero class.
*/
namespace COMP123_S2017_Lesson9A
{
    /// <summary>
    /// This is SuperHero class
    /// </summary>
    public class SuperHero : SuperHuman, IHasKarma
    {
        //private instance variables
        private int _karma;


        //public properties
        public int Karma
        {
            get
            {
                return this._karma;
            }

            set
            {
                this._karma = value;
            }
        }

        //constructors

        

        //private methods

        //public methods
        public SuperHero(string name, int karma)
            : base(name)
        {
            this.Karma = karma;
        }

    }
}