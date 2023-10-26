using System;

public class Checker
{
    public bool Check(object o)
    {
        if (o is IFormattable)
        {
            IFormattable form = o as IFormattable;
            if (form != null)
            {
                return true;
            }
        }
        return false;
    }
}
