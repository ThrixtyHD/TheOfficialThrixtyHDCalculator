namespace customcalculator
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            OutputTextBox = new TextBox();
            FiveButton = new Button();
            FourButton = new Button();
            TwoButton = new Button();
            EightButton = new Button();
            NineButton = new Button();
            SixButton = new Button();
            SevenButton = new Button();
            ThreeButton = new Button();
            SubtractionButton = new Button();
            SlashButton = new Button();
            AdditionButton = new Button();
            PercentageButton = new Button();
            XButton = new Button();
            IDKButton = new Button();
            ZeroButton = new Button();
            EqualsButton = new Button();
            RickRoll = new Button();
            PeriodButton = new Button();
            OneButton = new Button();
            ClearButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(250, 64);
            label1.Name = "label1";
            label1.Size = new Size(123, 27);
            label1.TabIndex = 0;
            label1.Text = "your answer";
            label1.Click += label1_Click;
            // 
            // OutputTextBox
            // 
            OutputTextBox.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold | FontStyle.Italic);
            OutputTextBox.Location = new Point(233, 27);
            OutputTextBox.Name = "OutputTextBox";
            OutputTextBox.Size = new Size(251, 34);
            OutputTextBox.TabIndex = 1;
            // 
            // FiveButton
            // 
            FiveButton.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold | FontStyle.Italic);
            FiveButton.Location = new Point(72, 133);
            FiveButton.Name = "FiveButton";
            FiveButton.Size = new Size(54, 50);
            FiveButton.TabIndex = 10;
            FiveButton.Text = "5";
            FiveButton.UseVisualStyleBackColor = true;
            FiveButton.Click += FiveButton_Click;
            // 
            // FourButton
            // 
            FourButton.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold | FontStyle.Italic);
            FourButton.Location = new Point(12, 132);
            FourButton.Name = "FourButton";
            FourButton.Size = new Size(54, 50);
            FourButton.TabIndex = 11;
            FourButton.Text = "4";
            FourButton.UseVisualStyleBackColor = true;
            FourButton.Click += FourButton_Click;
            // 
            // TwoButton
            // 
            TwoButton.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold | FontStyle.Italic);
            TwoButton.Location = new Point(72, 83);
            TwoButton.Name = "TwoButton";
            TwoButton.Size = new Size(54, 50);
            TwoButton.TabIndex = 12;
            TwoButton.Text = "2";
            TwoButton.UseVisualStyleBackColor = true;
            TwoButton.Click += TwoButton_Click;
            // 
            // EightButton
            // 
            EightButton.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold | FontStyle.Italic);
            EightButton.Location = new Point(72, 189);
            EightButton.Name = "EightButton";
            EightButton.Size = new Size(54, 50);
            EightButton.TabIndex = 16;
            EightButton.Text = "8";
            EightButton.UseVisualStyleBackColor = true;
            EightButton.Click += EightButton_Click;
            // 
            // NineButton
            // 
            NineButton.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold | FontStyle.Italic);
            NineButton.Location = new Point(132, 186);
            NineButton.Name = "NineButton";
            NineButton.Size = new Size(54, 50);
            NineButton.TabIndex = 15;
            NineButton.Text = "9";
            NineButton.UseVisualStyleBackColor = true;
            NineButton.Click += NineButton_Click;
            // 
            // SixButton
            // 
            SixButton.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold | FontStyle.Italic);
            SixButton.Location = new Point(132, 133);
            SixButton.Name = "SixButton";
            SixButton.Size = new Size(54, 50);
            SixButton.TabIndex = 14;
            SixButton.Text = "6";
            SixButton.UseVisualStyleBackColor = true;
            SixButton.Click += SixButton_Click;
            // 
            // SevenButton
            // 
            SevenButton.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold | FontStyle.Italic);
            SevenButton.Location = new Point(12, 189);
            SevenButton.Name = "SevenButton";
            SevenButton.Size = new Size(54, 50);
            SevenButton.TabIndex = 13;
            SevenButton.Text = "7";
            SevenButton.UseVisualStyleBackColor = true;
            SevenButton.Click += SevenButton_Click;
            // 
            // ThreeButton
            // 
            ThreeButton.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold | FontStyle.Italic);
            ThreeButton.Location = new Point(132, 83);
            ThreeButton.Name = "ThreeButton";
            ThreeButton.Size = new Size(54, 50);
            ThreeButton.TabIndex = 17;
            ThreeButton.Text = "3";
            ThreeButton.UseVisualStyleBackColor = true;
            ThreeButton.Click += ThreeButton_Click;
            // 
            // SubtractionButton
            // 
            SubtractionButton.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold | FontStyle.Italic);
            SubtractionButton.Location = new Point(72, 301);
            SubtractionButton.Name = "SubtractionButton";
            SubtractionButton.Size = new Size(54, 50);
            SubtractionButton.TabIndex = 21;
            SubtractionButton.Text = "-";
            SubtractionButton.UseVisualStyleBackColor = true;
            SubtractionButton.Click += SubtractionButton_Click;
            // 
            // SlashButton
            // 
            SlashButton.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold | FontStyle.Italic);
            SlashButton.Location = new Point(132, 298);
            SlashButton.Name = "SlashButton";
            SlashButton.Size = new Size(54, 50);
            SlashButton.TabIndex = 20;
            SlashButton.Text = "/";
            SlashButton.UseVisualStyleBackColor = true;
            SlashButton.Click += SlashButton_Click;
            // 
            // AdditionButton
            // 
            AdditionButton.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold | FontStyle.Italic);
            AdditionButton.Location = new Point(12, 301);
            AdditionButton.Name = "AdditionButton";
            AdditionButton.Size = new Size(54, 50);
            AdditionButton.TabIndex = 19;
            AdditionButton.Text = "+";
            AdditionButton.UseVisualStyleBackColor = true;
            AdditionButton.Click += AdditionButton_Click;
            // 
            // PercentageButton
            // 
            PercentageButton.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold | FontStyle.Italic);
            PercentageButton.Location = new Point(72, 357);
            PercentageButton.Name = "PercentageButton";
            PercentageButton.Size = new Size(54, 50);
            PercentageButton.TabIndex = 24;
            PercentageButton.Text = "%";
            PercentageButton.UseVisualStyleBackColor = true;
            PercentageButton.Click += PercentageButton_Click;
            // 
            // XButton
            // 
            XButton.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold | FontStyle.Italic);
            XButton.Location = new Point(132, 354);
            XButton.Name = "XButton";
            XButton.Size = new Size(54, 50);
            XButton.TabIndex = 23;
            XButton.Text = "x";
            XButton.UseVisualStyleBackColor = true;
            XButton.Click += XButton_Click;
            // 
            // IDKButton
            // 
            IDKButton.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold | FontStyle.Italic);
            IDKButton.Location = new Point(12, 357);
            IDKButton.Name = "IDKButton";
            IDKButton.Size = new Size(54, 50);
            IDKButton.TabIndex = 22;
            IDKButton.Text = "-/+";
            IDKButton.UseVisualStyleBackColor = true;
            IDKButton.Click += IDKButton_Click;
            // 
            // ZeroButton
            // 
            ZeroButton.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold | FontStyle.Italic);
            ZeroButton.Location = new Point(411, 155);
            ZeroButton.Name = "ZeroButton";
            ZeroButton.Size = new Size(54, 50);
            ZeroButton.TabIndex = 25;
            ZeroButton.Text = "0";
            ZeroButton.UseVisualStyleBackColor = true;
            ZeroButton.Click += ZeroButton_Click;
            // 
            // EqualsButton
            // 
            EqualsButton.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold | FontStyle.Italic);
            EqualsButton.Location = new Point(12, 27);
            EqualsButton.Name = "EqualsButton";
            EqualsButton.Size = new Size(174, 50);
            EqualsButton.TabIndex = 26;
            EqualsButton.Text = "=";
            EqualsButton.UseVisualStyleBackColor = true;
            EqualsButton.Click += EqualsButton_Click;
            // 
            // RickRoll
            // 
            RickRoll.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold | FontStyle.Italic);
            RickRoll.Location = new Point(262, 265);
            RickRoll.Name = "RickRoll";
            RickRoll.Size = new Size(174, 50);
            RickRoll.TabIndex = 27;
            RickRoll.Text = "rickroll";
            RickRoll.UseVisualStyleBackColor = true;
            RickRoll.Click += RickRoll_Click;
            // 
            // PeriodButton
            // 
            PeriodButton.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold | FontStyle.Italic);
            PeriodButton.Location = new Point(221, 209);
            PeriodButton.Name = "PeriodButton";
            PeriodButton.Size = new Size(54, 50);
            PeriodButton.TabIndex = 28;
            PeriodButton.Text = ".";
            PeriodButton.UseVisualStyleBackColor = true;
            PeriodButton.Click += PeriodButton_Click;
            // 
            // OneButton
            // 
            OneButton.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold | FontStyle.Italic);
            OneButton.Location = new Point(250, 122);
            OneButton.Name = "OneButton";
            OneButton.Size = new Size(54, 50);
            OneButton.TabIndex = 29;
            OneButton.Text = "1";
            OneButton.UseVisualStyleBackColor = true;
            OneButton.Click += OneButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold | FontStyle.Italic);
            ClearButton.Location = new Point(323, 94);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(174, 50);
            ClearButton.TabIndex = 30;
            ClearButton.Text = "clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(496, 468);
            Controls.Add(ClearButton);
            Controls.Add(OneButton);
            Controls.Add(PeriodButton);
            Controls.Add(RickRoll);
            Controls.Add(EqualsButton);
            Controls.Add(ZeroButton);
            Controls.Add(PercentageButton);
            Controls.Add(XButton);
            Controls.Add(IDKButton);
            Controls.Add(SubtractionButton);
            Controls.Add(SlashButton);
            Controls.Add(AdditionButton);
            Controls.Add(ThreeButton);
            Controls.Add(EightButton);
            Controls.Add(NineButton);
            Controls.Add(SixButton);
            Controls.Add(SevenButton);
            Controls.Add(TwoButton);
            Controls.Add(FourButton);
            Controls.Add(FiveButton);
            Controls.Add(OutputTextBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "A totally normal calculator. microsoft should hire me";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox OutputTextBox;
        private Button FiveButton;
        private Button FourButton;
        private Button TwoButton;
        private Button EightButton;
        private Button NineButton;
        private Button SixButton;
        private Button SevenButton;
        private Button ThreeButton;
        private Button SubtractionButton;
        private Button SlashButton;
        private Button AdditionButton;
        private Button PercentageButton;
        private Button XButton;
        private Button IDKButton;
        private Button ZeroButton;
        private Button EqualsButton;
        private Button RickRoll;
        private Button PeriodButton;
        private Button OneButton;
        private Button ClearButton;
    }
}
