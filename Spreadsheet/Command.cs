/*************************************************************************
 *                                                                        *
 *  File:        ICommand.cs                                              *
 *  Copyright:   (c) 2008-2019, Florin Leon                               *
 *  E-mail:      florin.leon@tuiasi.ro                                    *
 *  Website:     http://florinleon.byethost24.com/lab_ip.htm              *
 *  Description: Spreadsheet application with Command pattern.            *
 *               ICommand interface (Software Engineering lab 10)         *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

namespace Spreadsheet
{
    public abstract class Command
    {
        public abstract bool MakesChanges();

        public abstract void Execute();

        public abstract void Undo();

        public abstract void Redo();

        public string Description { get; protected set; }
    }
}