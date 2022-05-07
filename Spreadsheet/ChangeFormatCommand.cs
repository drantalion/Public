/**************************************************************************
 *                                                                        *
 *  File:        ChangeFormatCommand.cs                                   *
 *  Copyright:   (c) 2008-2019, Florin Leon                               *
 *  E-mail:      florin.leon@tuiasi.ro                                    *
 *  Website:     http://florinleon.byethost24.com/lab_ip.htm              *
 *  Description: Spreadsheet application with Command pattern.            *
 *               Concrete command class (Software Engineering lab 10)     *
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
    public class ChangeFormatCommand : Command
    {
        private ExtendedTextBox _cell;
        // alte campuri
        private FontStyle _curent;
        private FontStyle _anterior;

        public ChangeFormatCommand(ExtendedTextBox cell, FontStyle format, string description)
        {
            // se seteaza valorile campurilor
            // pentru descriere, se foloseste proprietatea Description definita in clasa de baza Command
            try
            {
                _cell = cell;
                //_curent = _cell.Font;
                //_curent = format;
                _anterior = format;
                base.Description = description;
            }
            catch
            {
                throw new Exception("Constructor ChangeFormatCommand error");
            }
        }

        public override bool MakesChanges()
        {
            // returneaza true daca se modifica ceva in celula de tip ExtendedTextBox
            // returneaza false daca nu se modifica nimic
            try
            {
                if (_curent == _anterior)
                {
                    return false;
                }
                return true;
            }
            catch
            {
                throw new Exception("MakesChanges ChangeFormatCommand error");
            }
        }

        public override void Execute()
        {
            // exemplu de schimbare a corpului de litera: _cell.Font = new Font(_cell.Font, _newStyle);
            try
            {
                _cell.Font = new Font(_cell.Font, _anterior);
            }
            catch
            {
                throw new Exception("Execute ChangeFormatCommand error");
            }
        }

        public override void Undo()
        {
            try
            {
                _cell.Font = new Font(_cell.Font, _anterior);
            }
            catch
            {
                throw new Exception("Undo ChangeFormatCommand error");
            }
        }

        public override void Redo()
        {
            try
            {
                _cell.Font = new Font(_cell.Font, _curent);
            }
            catch
            {
                throw new Exception("Redo ChangeFormatCommand error");
            }
        }
    }
}