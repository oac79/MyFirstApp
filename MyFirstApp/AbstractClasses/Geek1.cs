using System;

namespace MyFirstApp.AbstractClasses
{
    //Abstract Class
    public class Geek1 : GeeksForGeeks
    {
        public override object Clone()
        {
            throw new NotImplementedException();
        }

        public override void gfg()
        {
            throw new NotImplementedException();
        }
    }
}
