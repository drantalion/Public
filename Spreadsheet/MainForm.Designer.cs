namespace Spreadsheet
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonBold = new System.Windows.Forms.Button();
            this.buttonItalic = new System.Windows.Forms.Button();
            this.buttonColor = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.buttonNormal = new System.Windows.Forms.Button();
            this.comboBoxUndo = new System.Windows.Forms.ComboBox();
            this.buttonUndo = new System.Windows.Forms.Button();
            this.buttonRedo = new System.Windows.Forms.Button();
            this.comboBoxRedo = new System.Windows.Forms.ComboBox();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBold
            // 
            this.buttonBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBold.Location = new System.Drawing.Point(145, 15);
            this.buttonBold.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBold.Name = "buttonBold";
            this.buttonBold.Size = new System.Drawing.Size(88, 28);
            this.buttonBold.TabIndex = 1;
            this.buttonBold.Text = "Bold";
            this.buttonBold.UseVisualStyleBackColor = true;
            this.buttonBold.Click += new System.EventHandler(this.buttonBold_Click);
            // 
            // buttonItalic
            // 
            this.buttonItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonItalic.Location = new System.Drawing.Point(253, 15);
            this.buttonItalic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonItalic.Name = "buttonItalic";
            this.buttonItalic.Size = new System.Drawing.Size(88, 28);
            this.buttonItalic.TabIndex = 2;
            this.buttonItalic.Text = "Italic";
            this.buttonItalic.UseVisualStyleBackColor = true;
            this.buttonItalic.Click += new System.EventHandler(this.buttonItalic_Click);
            // 
            // buttonColor
            // 
            this.buttonColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonColor.ForeColor = System.Drawing.Color.Red;
            this.buttonColor.Location = new System.Drawing.Point(361, 15);
            this.buttonColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(88, 28);
            this.buttonColor.TabIndex = 3;
            this.buttonColor.Text = "Color";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonNormal
            // 
            this.buttonNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNormal.Location = new System.Drawing.Point(37, 15);
            this.buttonNormal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonNormal.Name = "buttonNormal";
            this.buttonNormal.Size = new System.Drawing.Size(88, 28);
            this.buttonNormal.TabIndex = 4;
            this.buttonNormal.Text = "Regular";
            this.buttonNormal.UseVisualStyleBackColor = true;
            this.buttonNormal.Click += new System.EventHandler(this.buttonNormal_Click);
            // 
            // comboBoxUndo
            // 
            this.comboBoxUndo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUndo.FormattingEnabled = true;
            this.comboBoxUndo.Location = new System.Drawing.Point(37, 50);
            this.comboBoxUndo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxUndo.Name = "comboBoxUndo";
            this.comboBoxUndo.Size = new System.Drawing.Size(412, 24);
            this.comboBoxUndo.TabIndex = 5;
            // 
            // buttonUndo
            // 
            this.buttonUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUndo.Location = new System.Drawing.Point(471, 50);
            this.buttonUndo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(88, 28);
            this.buttonUndo.TabIndex = 6;
            this.buttonUndo.Text = "Undo";
            this.buttonUndo.UseVisualStyleBackColor = true;
            this.buttonUndo.Click += new System.EventHandler(this.buttonUndo_Click);
            // 
            // buttonRedo
            // 
            this.buttonRedo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRedo.Location = new System.Drawing.Point(471, 86);
            this.buttonRedo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRedo.Name = "buttonRedo";
            this.buttonRedo.Size = new System.Drawing.Size(88, 28);
            this.buttonRedo.TabIndex = 8;
            this.buttonRedo.Text = "Redo";
            this.buttonRedo.UseVisualStyleBackColor = true;
            this.buttonRedo.Click += new System.EventHandler(this.buttonRedo_Click);
            // 
            // comboBoxRedo
            // 
            this.comboBoxRedo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRedo.FormattingEnabled = true;
            this.comboBoxRedo.Location = new System.Drawing.Point(37, 84);
            this.comboBoxRedo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxRedo.Name = "comboBoxRedo";
            this.comboBoxRedo.Size = new System.Drawing.Size(413, 24);
            this.comboBoxRedo.TabIndex = 7;
            // 
            // buttonAbout
            // 
            this.buttonAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbout.Location = new System.Drawing.Point(619, 50);
            this.buttonAbout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(88, 28);
            this.buttonAbout.TabIndex = 9;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(619, 86);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(88, 28);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(471, 15);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(88, 28);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(728, 303);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonRedo);
            this.Controls.Add(this.comboBoxRedo);
            this.Controls.Add(this.buttonUndo);
            this.Controls.Add(this.comboBoxUndo);
            this.Controls.Add(this.buttonNormal);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.buttonItalic);
            this.Controls.Add(this.buttonBold);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Spreadsheet";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBold;
        private System.Windows.Forms.Button buttonItalic;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button buttonNormal;
        private System.Windows.Forms.ComboBox comboBoxUndo;
        private System.Windows.Forms.Button buttonUndo;
        private System.Windows.Forms.Button buttonRedo;
        private System.Windows.Forms.ComboBox comboBoxRedo;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonClear;

    }
}

