using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC_BuilderBox
{
    public class Page
    {
        public string[] strokes;

        public Page()
        {
            strokes = new string[14];
            for (int i = 0; i < 14; i++) strokes[i] = "";
        }

        public string GetText()
        {
            string result = "";

            for (int i = 0; i < strokes.Length; i++)
            {
                result += strokes[i];
                if(i < strokes.Length - 1) result += "\n";
            }

            return result;
        }
    }
}
