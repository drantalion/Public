/**************************************************************************
 *                                                                        *
 *  File:        Invoker.cs                                               *
 *  Copyright:   (c) 2008-2019, Florin Leon                               *
 *  E-mail:      florin.leon@tuiasi.ro                                    *
 *  Website:     http://florinleon.byethost24.com/lab_ip.htm              *
 *  Description: Spreadsheet application with Command pattern.            *
 *               Invoker class (Software Engineering lab 10)              *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

using System;
using System.Collections.Generic;

namespace Spreadsheet
{
    public class Invoker
    {
        private TextBoxGrid _grid;
        private Stack<Command> _commands;
        private Stack<Command> _redoCommands;

        public Invoker(TextBoxGrid grid)
        {
            _grid = grid;
            _commands = new Stack<Command>();
            _redoCommands = new Stack<Command>();
        }

        public List<string> UndoDescriptions
        {
            get
            {
                List<string> descriptions = new List<string>();
                foreach (Command cmd in _commands)
                    descriptions.Add(cmd.Description);
                return descriptions;
            }
        }

        public List<string> RedoDescriptions
        {
            get
            {
                List<string> descriptions = new List<string>();
                foreach (Command cmd in _redoCommands)
                    descriptions.Add(cmd.Description);
                return descriptions;
            }
        }

        public void SetAndExecute(Command command)
        {
            //executa comanda primita ca parametru si o adauga in stiva de comenzi
            try
            {
                command.Execute();
                _commands.Push(command);
                _redoCommands.Clear();
            }
            catch
            {
                throw new Exception("SetAndExecute invoker error");
            }
        }

        public void Undo() // (int level)
        {
            try
            {
                Command command = _commands.Pop();
                command.Undo();
                _redoCommands.Push(command);
            }
            catch
            {
                throw new Exception("Undo invoker error");
            }
        }

        public void Redo() // (int level)
        {
            try
            {
                Command command = _redoCommands.Pop();
                command.Redo();
                _commands.Push(command);
            }
            catch
            {
                throw new Exception("Redo invoker error");
            }
        }

        public void Clear()
        {
            try
            {
                _commands.Clear();
                _redoCommands.Clear();
            }
            catch
            {
                throw new Exception("Clear invoker error");
            }
        }
    }
}