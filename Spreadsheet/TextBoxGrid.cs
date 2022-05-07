/**************************************************************************
 *                                                                        *
 *  File:        TextBoxGrid.cs                                           *
 *  Copyright:   (c) 2008-2019, Florin Leon                               *
 *  E-mail:      florin.leon@tuiasi.ro                                    *
 *  Website:     http://florinleon.byethost24.com/lab_ip.htm              *
 *  Description: Spreadsheet application with Command pattern. Grid       *
 *               composed of textboxes (Software Engineering lab 10)      *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Spreadsheet
{
    public class TextBoxGrid
    {
        private ExtendedTextBox[] _textBoxes;
        public const int Size = 5;

        public TextBoxGrid(Control.ControlCollection controlCollection, int left, int top, EventHandler enterEvent, EventHandler leaveEvent, KeyEventHandler keyDownEvent)
        {
            _textBoxes = new ExtendedTextBox[Size * Size];

            float scaleX = 1.34f; float scaleY = 1.15f;

            for (int i = 0; i < Size * Size; i++)
            {
                int x = i % Size;
                int y = i / Size;

                _textBoxes[i] = new ExtendedTextBox();
                _textBoxes[i].Width = 100;
                _textBoxes[i].Height = 20;
                _textBoxes[i].Left = left + x * 100;
                _textBoxes[i].Top = top + y * 20;
                _textBoxes[i].Scale(new SizeF(scaleX, scaleY));
                _textBoxes[i].Text = "";
                _textBoxes[i].Name = "Tb" + i;
                _textBoxes[i].Enter += enterEvent;
                _textBoxes[i].Leave += leaveEvent;
                _textBoxes[i].KeyDown += keyDownEvent;

                controlCollection.Add(_textBoxes[i]);
            }

            for (int i = 0; i < Size * Size; i++)
                _textBoxes[i].PreviousText = _textBoxes[i].Text;

            Label[] labelsX = new Label[Size];
            for (int i = 0; i < Size; i++)
            {
                labelsX[i] = new Label();
                labelsX[i].Text = ((char)(i + 'A')).ToString();
                labelsX[i].Left = left + i * 100 + 48;
                labelsX[i].Top = top - 18;
                labelsX[i].Scale(new SizeF(scaleX, scaleY));
                controlCollection.Add(labelsX[i]);
            }

            Label[] labelsY = new Label[Size];
            for (int i = 0; i < Size; i++)
            {
                labelsY[i] = new Label();
                labelsY[i].Text = (i + 1).ToString();
                labelsY[i].Left = left - 15;
                labelsY[i].Height = 20;
                labelsY[i].Top = top + i * 20 + 3;
                labelsY[i].Scale(new SizeF(scaleX, scaleY));
                controlCollection.Add(labelsY[i]);
            }
        }

        public void Clear()
        {
            for (int i = 0; i < Size * Size; i++)
            {
                _textBoxes[i].Clear();
                _textBoxes[i].Font = new Font(_textBoxes[i].Font, FontStyle.Regular);
                _textBoxes[i].ForeColor = Color.Black;
                _textBoxes[i].PreviousText = _textBoxes[i].Text;
            }
        }

        public ExtendedTextBox GetSuccessor(int cellNumber)
        {
            cellNumber = (cellNumber + 1) % (Size * Size);
            return _textBoxes[cellNumber];
        }

        public string GetCoords(int cellNumber)
        {
            char tbx = (char)((cellNumber % Size) + 'A');
            int tby = cellNumber / Size + 1;
            return tbx.ToString() + tby;
        }

        public ExtendedTextBox GetCell(int cellNumber)
        {
            return _textBoxes[cellNumber];
        }
    }
}