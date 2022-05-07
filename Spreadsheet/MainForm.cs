/**************************************************************************
 *                                                                        *
 *  File:        MainForm.cs                                              *
 *  Copyright:   (c) 2008-2019, Florin Leon                               *
 *  E-mail:      florin.leon@tuiasi.ro                                    *
 *  Website:     http://florinleon.byethost24.com/lab_ip.htm              *
 *  Description: Spreadsheet application with Command pattern.            *
 *               Main form (Software Engineering lab 10)                  *
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
    public partial class MainForm : Form
    {
        private TextBoxGrid _grid;
        private Invoker _invoker;
        private int _selected; // numarul celulei in care se efectueaza o actiune; _grid.GetCell(_selected) intoarce obiectul ExtendedTextBox corespunzator

        public MainForm()
        {
            InitializeComponent();

            _grid = new TextBoxGrid(Controls, 27, 140, new EventHandler(textBox_Enter), new EventHandler(textBox_Leave), new KeyEventHandler(textBox_KeyDown));
            _invoker = new Invoker(_grid);

            UpdateUndoRedoCombos();
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            // acest eveniment se apeleaza cand o celula devine controlul selectat activ din fereastra

            Control ac = this.ActiveControl;
            ExtendedTextBox tb = (ExtendedTextBox)sender;
            tb.PreviousText = tb.Text;
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            // acest eveniment se apeleaza cand o celula nu mai este controlul selectat activ din fereastra

            Control ac = this.ActiveControl;
            ExtendedTextBox tb = (ExtendedTextBox)sender;
            _selected = Convert.ToInt32(tb.Name.Substring(2));

            // se creeaza o comanda de schimbare a textului daca este o comanda valida (care provoaca o schimbare), 
            // se introduce in _invoker si apoi se includ urmatoarele instructiuni:
            // this.ActiveControl = ac;
            // UpdateUndoRedoCombos();
            ChangeTextCommand changeTextCommand = new ChangeTextCommand(_grid.GetCell(_selected), "Am schimbat textul");
            if (changeTextCommand.MakesChanges())
            {
                _invoker.SetAndExecute(changeTextCommand);
                //_invoker = new Invoker(_grid);
                this.ActiveControl = ac;
                UpdateUndoRedoCombos();
            }
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // cand se apasa ENTER intr-o celula
            {
                ExtendedTextBox tb = (ExtendedTextBox)sender;
                _selected = Convert.ToInt32(tb.Name.Substring(2));
                this.ActiveControl = _grid.GetSuccessor(_selected);
            }
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() != DialogResult.OK)
                return;

            Color c = colorDialog.Color;
            buttonColor.ForeColor = c;
            buttonColor.BackColor = Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B);
            ChangeColorCommand changeColor = new ChangeColorCommand(_grid.GetCell(_selected), c, "Am schimbat culoarea");
            if (changeColor.MakesChanges())
            {
                _invoker.SetAndExecute(changeColor);
                UpdateUndoRedoCombos();
            }

            // se creeaza o comanda de schimbare a culorii
            // daca este o comanda valida (care provoaca o schimbare), se introduce in _invoker si apoi se apeleaza metoda UpdateUndoRedoCombos
        }

        private void buttonNormal_Click(object sender, EventArgs e)
        {
            // se creeaza o comanda de schimbare a formatului
            // daca este o comanda valida (care provoaca o schimbare), se introduce in _invoker si apoi se apeleaza metoda UpdateUndoRedoCombos
            ChangeFormatCommand regular = new ChangeFormatCommand(_grid.GetCell(_selected), FontStyle.Regular, "Am schimbat in regular");
            if (regular.MakesChanges())
            {
                _invoker.SetAndExecute(regular);
                UpdateUndoRedoCombos();
            }
        }

        private void buttonBold_Click(object sender, EventArgs e)
        {
            // se creeaza o comanda de schimbare a formatului
            // daca este o comanda valida (care provoaca o schimbare), se introduce in _invoker si apoi se apeleaza metoda UpdateUndoRedoCombos
            ChangeFormatCommand bold = new ChangeFormatCommand(_grid.GetCell(_selected), FontStyle.Bold, "Am schimbat in bold");
            if (bold.MakesChanges())
            {
                _invoker.SetAndExecute(bold);
                UpdateUndoRedoCombos();
            }
        }

        private void buttonItalic_Click(object sender, EventArgs e)
        {
            // se creeaza o comanda de schimbare a formatului
            // daca este o comanda valida (care provoaca o schimbare), se introduce in _invoker si apoi se apeleaza metoda UpdateUndoRedoCombos
            ChangeFormatCommand italic = new ChangeFormatCommand(_grid.GetCell(_selected), FontStyle.Italic, "Am schimbat in italic");
            if (italic.MakesChanges())
            {
                _invoker.SetAndExecute(italic);
                UpdateUndoRedoCombos();
            }
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            // dupa undo se apeleaza metoda UpdateUndoRedoCombos
            _invoker.Undo();
            UpdateUndoRedoCombos();
        }

        private void buttonRedo_Click(object sender, EventArgs e)
        {
            // dupa redo se apeleaza metoda UpdateUndoRedoCombos
            _invoker.Redo();
            UpdateUndoRedoCombos();
        }

        private void UpdateUndoRedoCombos()
        {
            comboBoxUndo.Items.Clear();
            foreach (string s in _invoker.UndoDescriptions)
                comboBoxUndo.Items.Add(s);

            if (comboBoxUndo.Items.Count > 0)
            {
                comboBoxUndo.SelectedIndex = 0;
                buttonUndo.Enabled = true;
            }
            else
            {
                buttonUndo.Enabled = false;
            }

            comboBoxRedo.Items.Clear();
            foreach (string s in _invoker.RedoDescriptions)
                comboBoxRedo.Items.Add(s);

            if (comboBoxRedo.Items.Count > 0)
            {
                comboBoxRedo.SelectedIndex = 0;
                buttonRedo.Enabled = true;
            }
            else
            {
                buttonRedo.Enabled = false;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            _grid.Clear();
            _invoker.Clear();
            UpdateUndoRedoCombos();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            const string copyright =
               "Sablonul de proiectare Comanda\r\n" +
               "Ingineria programarii, Laboratorul 10\r\n" +
               "(c)Adaptare cod: Dumitrascu Dragos-Teodor 1308A\r\n" +
               "(c)Cod sursa: Florin Leon\r\n" +
               "http://florinleon.byethost24.com/lab_ip.htm";

            MessageBox.Show(copyright, "Despre Foaia de calcul");
        }
    }
}