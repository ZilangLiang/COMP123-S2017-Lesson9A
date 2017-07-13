using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_S2017_Lesson9A
{
    public class SuperVillain : SuperHuman,IHasMalice
    {
        private int _malice;
        public int Malice
        {
            get
            {
                return this._malice;
            }

            set
            {
                this._malice = value;
            }
        }

        public SuperVillain(string name, int malice)
            : base(name)
        {
            this.Malice = malice;
        }
    }
}