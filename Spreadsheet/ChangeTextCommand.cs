/**************************************************************************
 *                                                                        *
 *  File:        ChangeTextCommand.cs                                     *
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

namespace Spreadsheet
{
    public class ChangeTextCommand : Command
    {
        private ExtendedTextBox _cell;
        // alte campuri
        private string _curentt;
        private string _anteriorr;
        public ChangeTextCommand(ExtendedTextBox cell, string description)
        {
            // se seteaza valorile campurilor
            // pentru descriere, se foloseste proprietatea Description definita in clasa de baza Command

            // atentie! aici textul nou deja exista in cell.Text
            // se poate folosi proprietatea cell.PreviousText pentru a implementa comanda
            // cell.PreviousText nu este asignata in mod automat in scheletul de program dat, codul corespunzator trebuie scris
            try
            {
                _cell = cell;
                _anteriorr = cell.Text;
                _curentt = cell.PreviousText;
                base.Description = description;
            }
            catch
            {
                throw new Exception("Constructor ChangeTextCommand error");
            }
        }

        public override bool MakesChanges()
        {
            // returneaza true daca se modifica ceva in celula de tip ExtendedTextBox
            // returneaza false daca nu se modifica nimic
            try
            {
                if (!(_curentt != _anteriorr))
                {
                    return false;
                }
                return true;
            }
            catch
            {
                throw new Exception("MakesChanges ChangeTextCommand error");
            }
        }

        public override void Execute()
        {
            try
            {
                _cell.Text = _curentt;
            }
            catch
            {
                throw new Exception("Execute ChangeTextCommand error");
            }
        }

        public override void Undo()
        {
            try
            {
                _cell.Text = _anteriorr;
            }
            catch
            {
                throw new Exception("Undo ChangeTextCommand error");
            }
        }

        public override void Redo()
        {
            try
            {
                _cell.Text = _curentt;
            }
            catch
            {
                throw new Exception("Redo ChangeTextCommand error");
            }
        }
    }
}