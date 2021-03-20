using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MC_BuilderBox
{
    public partial class BookWriter : Form
    {
        BookWriterResult resultForm;

        public BookWriter()
        {
            InitializeComponent();
        }

        private void convert_Click(object sender, EventArgs e)
        {
            List<Page> pages = new List<Page>();

            string text = bookText.Text;
            if (text == "") { MessageBox.Show("You should type text in textbox!"); return; }
            if (bookName.Text == "") { MessageBox.Show("You should enter book name!"); return; }

            Page currentPage = new Page();
            int currentStroke = 0;

            string[] words = text.Split(' ');
            int spaceInStroke = 114;

            foreach (string w in words)
            {
                int wordLength = getCharacterWidth(' ') + 1;
                foreach (char c in w)
                {
                    // TODO: Add invalid character exception!
                    wordLength += getCharacterWidth(c) + 1;
                }

                spaceInStroke -= wordLength;

                if (spaceInStroke < 0)
                {
                    currentStroke++;

                    if(currentStroke >= 14)
                    {
                        currentStroke = 0;
                        pages.Add(currentPage);
                        currentPage = new Page();

                        if(pages.Count() >= 100)
                        {
                            MessageBox.Show("Your text is too big. There's 100 page limit in Book and Quill item!", "Error!");
                            return;
                        }
                    }
                    spaceInStroke = 114 - wordLength;
                }

                currentPage.strokes[currentStroke] += w + ' ';
            }

            pages.Add(currentPage);
            if (pages.Count() >= 100)
            {
                MessageBox.Show("Your text is too big. There's 100 page limit in Book and Quill item!", "Error!");
                return;
            }


            resultForm = new BookWriterResult(pages.ToArray());
            resultForm.ShowDialog(this);
        }

        private int getCharacterWidth(char c)
        {
            switch(c)
            {
                case 'A': return 5;
                case 'B': return 5;
                case 'C': return 5;
                case 'D': return 5;
                case 'E': return 5;
                case 'F': return 5;
                case 'G': return 5;
                case 'H': return 5;
                case 'I': return 3;
                case 'J': return 5;
                case 'K': return 5;
                case 'L': return 5;
                case 'M': return 5;

                case 'N': return 5;
                case 'O': return 5;
                case 'P': return 5;
                case 'Q': return 5;
                case 'R': return 5;
                case 'S': return 5;
                case 'T': return 5;
                case 'U': return 5;
                case 'V': return 5;
                case 'W': return 5;
                case 'X': return 5;
                case 'Y': return 5;
                case 'Z': return 5;

                case 'a': return 5;
                case 'b': return 5;
                case 'c': return 5;
                case 'd': return 5;
                case 'e': return 5;
                case 'f': return 4;
                case 'g': return 5;
                case 'h': return 5;
                case 'i': return 1;
                case 'j': return 5;
                case 'k': return 4;
                case 'l': return 2;
                case 'm': return 5;

                case 'n': return 5;
                case 'o': return 5;
                case 'p': return 5;
                case 'q': return 5;
                case 'r': return 5;
                case 's': return 5;
                case 't': return 3;
                case 'u': return 5;
                case 'v': return 5;
                case 'w': return 5;
                case 'x': return 5;
                case 'y': return 5;
                case 'z': return 5;

                case '1': return 5;
                case '2': return 5;
                case '3': return 5;
                case '4': return 5;
                case '5': return 5;
                case '6': return 5;
                case '7': return 5;
                case '8': return 5;
                case '9': return 5;
                case '0': return 5;

                case ',': return 1;
                case '.': return 1;
                case '!': return 1;
                case '?': return 5;
                case '(': return 4;
                case ')': return 4;
                case '`': return 2;
                case '"': return 3;
                case '/': return 5;
                case '|': return 1;
                case '\\': return 5;
                case ':': return 1;
                case ';': return 1;

                case 'А': return 5;
                case 'Б': return 5;
                case 'В': return 5;
                case 'Г': return 5;
                case 'Д': return 5;
                case 'Е': return 5;
                case 'Ё': return 5;
                case 'Ж': return 5;
                case 'З': return 5;
                case 'И': return 5;
                case 'Й': return 5;
                case 'К': return 5;
                case 'Л': return 5;

                case 'М': return 5;
                case 'Н': return 5;
                case 'О': return 5;
                case 'П': return 5;
                case 'Р': return 5;
                case 'С': return 5;
                case 'Т': return 5;
                case 'У': return 5;
                case 'Ф': return 5;
                case 'Х': return 5;
                case 'Ц': return 6;
                case 'Ч': return 5;
                case 'Ш': return 5;

                case 'Щ': return 6;
                case 'Ъ': return 5;
                case 'Ы': return 6;
                case 'Ь': return 5;
                case 'Э': return 5;
                case 'Ю': return 6;
                case 'Я': return 5;

                case 'а': return 5;
                case 'б': return 5;
                case 'в': return 5;
                case 'г': return 5;
                case 'д': return 5;
                case 'е': return 5;
                case 'ё': return 5;
                case 'ж': return 5;
                case 'з': return 5;
                case 'и': return 5;
                case 'й': return 5;
                case 'к': return 5;
                case 'л': return 5;

                case 'м': return 5;
                case 'н': return 5;
                case 'о': return 5;
                case 'п': return 5;
                case 'р': return 5;
                case 'с': return 5;
                case 'т': return 5;
                case 'у': return 5;
                case 'ф': return 5;
                case 'х': return 5;
                case 'ц': return 5;
                case 'ч': return 5;
                case 'ш': return 5;

                case 'щ': return 6;
                case 'ъ': return 6;
                case 'ы': return 6;
                case 'ь': return 5;
                case 'э': return 5;
                case 'ю': return 6;
                case 'я': return 5;

                case ' ': return 3;

                default: return -1;
            }
        }
    }
}
