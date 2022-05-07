/**************************************************************************
 *                                                                        *
 *  File:        MainForm.cs                                              *
 *  Copyright:   (c) 2008-2019, Florin Leon                               *
 *  E-mail:      florin.leon@tuiasi.ro                                    *
 *  Website:     http://florinleon.byethost24.com/lab_ip.htm              *
 *  Description: Spreadsheet application with Command pattern.            *
 *               Extended textbox to include information about the        *
 *               previous state of its Text and an align operation        *
 *               (Software Engineering lab 10)                            *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

using System.Windows.Forms;

namespace Spreadsheet
{
    public class ExtendedTextBox : TextBox
    {
        public string PreviousText { get; set; }

        public ExtendedTextBox()
            : base()
        {
            PreviousText = "";
        }
    }
}