namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.createDeckButton = new System.Windows.Forms.Button();
            this.deleteDeckButton = new System.Windows.Forms.Button();
            this.getDeckNamesButton = new System.Windows.Forms.Button();
            this.shuffleDeckButton = new System.Windows.Forms.Button();
            this.createText = new System.Windows.Forms.TextBox();
            this.deleteText = new System.Windows.Forms.TextBox();
            this.shuffleText = new System.Windows.Forms.TextBox();
            this.deckNames = new System.Windows.Forms.TextBox();
            this.GetDeckByNameButton = new System.Windows.Forms.Button();
            this.GetDeckText = new System.Windows.Forms.TextBox();
            this.isHand = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // createDeckButton
            // 
            this.createDeckButton.Location = new System.Drawing.Point(230, 335);
            this.createDeckButton.Name = "createDeckButton";
            this.createDeckButton.Size = new System.Drawing.Size(113, 37);
            this.createDeckButton.TabIndex = 0;
            this.createDeckButton.Text = "Create Deck";
            this.createDeckButton.UseVisualStyleBackColor = true;
            this.createDeckButton.Click += new System.EventHandler(this.createDeckButton_Click);
            // 
            // deleteDeckButton
            // 
            this.deleteDeckButton.Location = new System.Drawing.Point(38, 335);
            this.deleteDeckButton.Name = "deleteDeckButton";
            this.deleteDeckButton.Size = new System.Drawing.Size(113, 37);
            this.deleteDeckButton.TabIndex = 1;
            this.deleteDeckButton.Text = "Delete Deck";
            this.deleteDeckButton.UseVisualStyleBackColor = true;
            this.deleteDeckButton.Click += new System.EventHandler(this.deleteDeckButton_Click);
            // 
            // getDeckNamesButton
            // 
            this.getDeckNamesButton.Location = new System.Drawing.Point(728, 335);
            this.getDeckNamesButton.Name = "getDeckNamesButton";
            this.getDeckNamesButton.Size = new System.Drawing.Size(113, 37);
            this.getDeckNamesButton.TabIndex = 2;
            this.getDeckNamesButton.Text = "Get Names";
            this.getDeckNamesButton.UseVisualStyleBackColor = true;
            this.getDeckNamesButton.Click += new System.EventHandler(this.getDeckNamesButton_Click);
            // 
            // shuffleDeckButton
            // 
            this.shuffleDeckButton.Location = new System.Drawing.Point(558, 335);
            this.shuffleDeckButton.Name = "shuffleDeckButton";
            this.shuffleDeckButton.Size = new System.Drawing.Size(113, 37);
            this.shuffleDeckButton.TabIndex = 3;
            this.shuffleDeckButton.Text = "Shuffle deck";
            this.shuffleDeckButton.UseVisualStyleBackColor = true;
            this.shuffleDeckButton.Click += new System.EventHandler(this.shuffleDeckButton_Click);
            // 
            // createText
            // 
            this.createText.Location = new System.Drawing.Point(205, 271);
            this.createText.Name = "createText";
            this.createText.Size = new System.Drawing.Size(167, 23);
            this.createText.TabIndex = 5;
            // 
            // deleteText
            // 
            this.deleteText.Location = new System.Drawing.Point(12, 271);
            this.deleteText.Name = "deleteText";
            this.deleteText.Size = new System.Drawing.Size(167, 23);
            this.deleteText.TabIndex = 6;
            // 
            // shuffleText
            // 
            this.shuffleText.Location = new System.Drawing.Point(532, 271);
            this.shuffleText.Name = "shuffleText";
            this.shuffleText.Size = new System.Drawing.Size(167, 23);
            this.shuffleText.TabIndex = 7;
            // 
            // deckNames
            // 
            this.deckNames.Location = new System.Drawing.Point(38, 12);
            this.deckNames.Multiline = true;
            this.deckNames.Name = "deckNames";
            this.deckNames.ReadOnly = true;
            this.deckNames.Size = new System.Drawing.Size(803, 234);
            this.deckNames.TabIndex = 8;
            // 
            // GetDeckByNameButton
            // 
            this.GetDeckByNameButton.Location = new System.Drawing.Point(388, 335);
            this.GetDeckByNameButton.Name = "GetDeckByNameButton";
            this.GetDeckByNameButton.Size = new System.Drawing.Size(122, 36);
            this.GetDeckByNameButton.TabIndex = 9;
            this.GetDeckByNameButton.Text = "Get deck by name";
            this.GetDeckByNameButton.UseVisualStyleBackColor = true;
            this.GetDeckByNameButton.Click += new System.EventHandler(this.GetDeckByNameButton_Click);
            // 
            // GetDeckText
            // 
            this.GetDeckText.Location = new System.Drawing.Point(390, 270);
            this.GetDeckText.Name = "GetDeckText";
            this.GetDeckText.Size = new System.Drawing.Size(119, 23);
            this.GetDeckText.TabIndex = 10;
            // 
            // isHand
            // 
            this.isHand.Location = new System.Drawing.Point(570, 378);
            this.isHand.Name = "isHand";
            this.isHand.Size = new System.Drawing.Size(101, 23);
            this.isHand.TabIndex = 11;
            this.isHand.Text = "Hand shuffle";
            this.isHand.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 519);
            this.Controls.Add(this.isHand);
            this.Controls.Add(this.GetDeckText);
            this.Controls.Add(this.GetDeckByNameButton);
            this.Controls.Add(this.deckNames);
            this.Controls.Add(this.shuffleText);
            this.Controls.Add(this.deleteText);
            this.Controls.Add(this.createText);
            this.Controls.Add(this.shuffleDeckButton);
            this.Controls.Add(this.getDeckNamesButton);
            this.Controls.Add(this.deleteDeckButton);
            this.Controls.Add(this.createDeckButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox deleteText;
        private System.Windows.Forms.TextBox createText;
        private System.Windows.Forms.TextBox shuffleText;
        private System.Windows.Forms.Button shuffleDeckButton;
        private System.Windows.Forms.Button getDeckNamesButton;
        private System.Windows.Forms.Button deleteDeckButton;
        private System.Windows.Forms.Button createDeckButton;
        private System.Windows.Forms.TextBox deckNames;
        private System.Windows.Forms.TextBox GetDeckText;
        private System.Windows.Forms.Button GetDeckByNameButton;
        private System.Windows.Forms.CheckBox isHand;
    }
}