
namespace GuessingGame
{
    partial class Form1
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
            this.userGuessBox = new System.Windows.Forms.TextBox();
            this.equalsToButton = new System.Windows.Forms.Button();
            this.greaterThanButton = new System.Windows.Forms.Button();
            this.lessThanButton = new System.Windows.Forms.Button();
            this.userGuessLabel = new System.Windows.Forms.Label();
            this.answareTitleLabel = new System.Windows.Forms.Label();
            this.answareLabel = new System.Windows.Forms.Label();
            this.intervallLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rightIntervallBox = new System.Windows.Forms.TextBox();
            this.leftIntervallBox = new System.Windows.Forms.TextBox();
            this.hyphenLabel = new System.Windows.Forms.Label();
            this.startGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userGuessBox
            // 
            this.userGuessBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userGuessBox.Location = new System.Drawing.Point(458, 152);
            this.userGuessBox.Name = "userGuessBox";
            this.userGuessBox.Size = new System.Drawing.Size(383, 116);
            this.userGuessBox.TabIndex = 0;
            this.userGuessBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // equalsToButton
            // 
            this.equalsToButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.equalsToButton.Font = new System.Drawing.Font("MV Boli", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalsToButton.Location = new System.Drawing.Point(898, 349);
            this.equalsToButton.Name = "equalsToButton";
            this.equalsToButton.Size = new System.Drawing.Size(331, 260);
            this.equalsToButton.TabIndex = 3;
            this.equalsToButton.Text = "Is It Equals to...? ";
            this.equalsToButton.UseVisualStyleBackColor = false;
            this.equalsToButton.Click += new System.EventHandler(this.equalsToButton_Click);
            // 
            // greaterThanButton
            // 
            this.greaterThanButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.greaterThanButton.Font = new System.Drawing.Font("MV Boli", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greaterThanButton.Location = new System.Drawing.Point(484, 349);
            this.greaterThanButton.Name = "greaterThanButton";
            this.greaterThanButton.Size = new System.Drawing.Size(331, 260);
            this.greaterThanButton.TabIndex = 4;
            this.greaterThanButton.Text = "Is It Greater Than...?";
            this.greaterThanButton.UseVisualStyleBackColor = false;
            this.greaterThanButton.Click += new System.EventHandler(this.greaterThanButton_Click);
            // 
            // lessThanButton
            // 
            this.lessThanButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lessThanButton.Font = new System.Drawing.Font("MV Boli", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lessThanButton.Location = new System.Drawing.Point(50, 349);
            this.lessThanButton.Name = "lessThanButton";
            this.lessThanButton.Size = new System.Drawing.Size(331, 260);
            this.lessThanButton.TabIndex = 5;
            this.lessThanButton.Text = "Is It Less Than...?";
            this.lessThanButton.UseVisualStyleBackColor = false;
            this.lessThanButton.Click += new System.EventHandler(this.lessThanButton_Click);
            // 
            // userGuessLabel
            // 
            this.userGuessLabel.AutoSize = true;
            this.userGuessLabel.Font = new System.Drawing.Font("Segoe Print", 25.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userGuessLabel.Location = new System.Drawing.Point(431, 29);
            this.userGuessLabel.Name = "userGuessLabel";
            this.userGuessLabel.Size = new System.Drawing.Size(442, 120);
            this.userGuessLabel.TabIndex = 6;
            this.userGuessLabel.Text = "User Guess:";
            this.userGuessLabel.Click += new System.EventHandler(this.userGuessLabel_Click);
            // 
            // answareTitleLabel
            // 
            this.answareTitleLabel.AutoSize = true;
            this.answareTitleLabel.Font = new System.Drawing.Font("Segoe Script", 26F);
            this.answareTitleLabel.Location = new System.Drawing.Point(879, 38);
            this.answareTitleLabel.Name = "answareTitleLabel";
            this.answareTitleLabel.Size = new System.Drawing.Size(389, 111);
            this.answareTitleLabel.TabIndex = 7;
            this.answareTitleLabel.Text = "Answear:";
            // 
            // answareLabel
            // 
            this.answareLabel.AutoSize = true;
            this.answareLabel.Font = new System.Drawing.Font("MV Boli", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answareLabel.Location = new System.Drawing.Point(964, 166);
            this.answareLabel.Name = "answareLabel";
            this.answareLabel.Size = new System.Drawing.Size(195, 49);
            this.answareLabel.TabIndex = 8;
            this.answareLabel.Text = "Yes, it is!";
            // 
            // intervallLabel
            // 
            this.intervallLabel.AutoSize = true;
            this.intervallLabel.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intervallLabel.Location = new System.Drawing.Point(101, 61);
            this.intervallLabel.Name = "intervallLabel";
            this.intervallLabel.Size = new System.Drawing.Size(247, 76);
            this.intervallLabel.TabIndex = 9;
            this.intervallLabel.Text = "Intervall";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 10;
            // 
            // rightIntervallBox
            // 
            this.rightIntervallBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightIntervallBox.Location = new System.Drawing.Point(239, 152);
            this.rightIntervallBox.Name = "rightIntervallBox";
            this.rightIntervallBox.Size = new System.Drawing.Size(142, 62);
            this.rightIntervallBox.TabIndex = 11;
            // 
            // leftIntervallBox
            // 
            this.leftIntervallBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftIntervallBox.Location = new System.Drawing.Point(50, 152);
            this.leftIntervallBox.Name = "leftIntervallBox";
            this.leftIntervallBox.Size = new System.Drawing.Size(142, 62);
            this.leftIntervallBox.TabIndex = 12;
            // 
            // hyphenLabel
            // 
            this.hyphenLabel.AutoSize = true;
            this.hyphenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.hyphenLabel.Location = new System.Drawing.Point(198, 148);
            this.hyphenLabel.Name = "hyphenLabel";
            this.hyphenLabel.Size = new System.Drawing.Size(49, 67);
            this.hyphenLabel.TabIndex = 13;
            this.hyphenLabel.Text = "-";
            this.hyphenLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // startGameButton
            // 
            this.startGameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.startGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGameButton.Location = new System.Drawing.Point(97, 236);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(251, 66);
            this.startGameButton.TabIndex = 14;
            this.startGameButton.Text = "Start Game";
            this.startGameButton.UseVisualStyleBackColor = false;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1280, 726);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.hyphenLabel);
            this.Controls.Add(this.leftIntervallBox);
            this.Controls.Add(this.rightIntervallBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.intervallLabel);
            this.Controls.Add(this.answareLabel);
            this.Controls.Add(this.answareTitleLabel);
            this.Controls.Add(this.userGuessLabel);
            this.Controls.Add(this.lessThanButton);
            this.Controls.Add(this.greaterThanButton);
            this.Controls.Add(this.equalsToButton);
            this.Controls.Add(this.userGuessBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userGuessBox;
        private System.Windows.Forms.Button equalsToButton;
        private System.Windows.Forms.Button greaterThanButton;
        private System.Windows.Forms.Button lessThanButton;
        private System.Windows.Forms.Label userGuessLabel;
        private System.Windows.Forms.Label answareTitleLabel;
        private System.Windows.Forms.Label answareLabel;
        private System.Windows.Forms.Label intervallLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rightIntervallBox;
        private System.Windows.Forms.TextBox leftIntervallBox;
        private System.Windows.Forms.Label hyphenLabel;
        private System.Windows.Forms.Button startGameButton;
    }
}

