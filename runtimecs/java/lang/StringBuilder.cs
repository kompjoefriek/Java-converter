namespace java.lang 
{
    public class StringBuilder
    {        
        private readonly System.Text.StringBuilder content;

        public StringBuilder() 
        {   
            content = new System.Text.StringBuilder();
        }

        public StringBuilder(string startValue)
        {   
            content = new System.Text.StringBuilder(startValue);
        }

        public StringBuilder append(object o)
        {   
            content.Append(SYSTEM.str(o));
            return this;
        }
            
        public StringBuilder append(bool b)
        {   
            content.Append(SYSTEM.str(b));
            return this;
        }

        public StringBuilder append(char c)
        {   
            content.Append(c);
            return this;
        }

        public StringBuilder append(int i)
        {   
            content.Append(i);
            return this;
        }
            
        public StringBuilder append(double d)
        {   
            content.Append(SYSTEM.str(d));
            return this;
        }
        
        public StringBuilder append(char[] ca)
        {   
            content.Append(ca);
            return this;
        }
        
        public StringBuilder delete(int start, int end)
        {
            int cl = content.Length;
            if (start<0 || start>cl || start>end) 
            {
                throw new IndexOutOfBoundsException();
            }
            content.Remove(start, (end<cl?end:cl) - start);
            return this;
        }
        
        public int length()
        {   
            return content.Length;
        }
        
        public void setLength(int l)
        {
        	if (l<0) { throw new IndexOutOfBoundsException(); }
        	content.Length = l;
        }

        public override string ToString()
        {   
            return content.ToString();
        }
    }
}
