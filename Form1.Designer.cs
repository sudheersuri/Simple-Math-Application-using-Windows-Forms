namespace sudheer_week4
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
            this.OperationsGroupBox = new System.Windows.Forms.GroupBox();
            this.MultiplyRadio = new System.Windows.Forms.RadioButton();
            this.SelectLabel = new System.Windows.Forms.Label();
            this.AddRadio = new System.Windows.Forms.RadioButton();
            this.SubtractRadio = new System.Windows.Forms.RadioButton();
            this.DivideRadio = new System.Windows.Forms.RadioButton();
            this.NumsGroupBox = new System.Windows.Forms.GroupBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.EqualLabel = new System.Windows.Forms.Label();
            this.NumLabel2 = new System.Windows.Forms.Label();
            this.OpLabel = new System.Windows.Forms.Label();
            this.NumLabel1 = new System.Windows.Forms.Label();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.ButonsGroupBox = new System.Windows.Forms.GroupBox();
            this.AmIRightButton = new System.Windows.Forms.Button();
            this.ImDoneButton = new System.Windows.Forms.Button();
            this.NxtQButton = new System.Windows.Forms.Button();
            this.ResultGroupBox = new System.Windows.Forms.GroupBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.OperationsGroupBox.SuspendLayout();
            this.NumsGroupBox.SuspendLayout();
            this.ButonsGroupBox.SuspendLayout();
            this.ResultGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OperationsGroupBox
            // 
            this.OperationsGroupBox.Controls.Add(this.MultiplyRadio);
            this.OperationsGroupBox.Controls.Add(this.SelectLabel);
            this.OperationsGroupBox.Controls.Add(this.AddRadio);
            this.OperationsGroupBox.Controls.Add(this.SubtractRadio);
            this.OperationsGroupBox.Controls.Add(this.DivideRadio);
            this.OperationsGroupBox.Location = new System.Drawing.Point(12, 20);
            this.OperationsGroupBox.Name = "OperationsGroupBox";
            this.OperationsGroupBox.Size = new System.Drawing.Size(758, 132);
            this.OperationsGroupBox.TabIndex = 0;
            this.OperationsGroupBox.TabStop = false;
            // 
            // MultiplyRadio
            // 
            this.MultiplyRadio.AutoSize = true;
            this.MultiplyRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplyRadio.Location = new System.Drawing.Point(535, 62);
            this.MultiplyRadio.Name = "MultiplyRadio";
            this.MultiplyRadio.Size = new System.Drawing.Size(91, 28);
            this.MultiplyRadio.TabIndex = 6;
            this.MultiplyRadio.TabStop = true;
            this.MultiplyRadio.Text = "Multiply";
            this.MultiplyRadio.UseVisualStyleBackColor = true;
            this.MultiplyRadio.CheckedChanged += new System.EventHandler(this.MultiplyRadio_CheckedChanged);
            // 
            // SelectLabel
            // 
            this.SelectLabel.AutoSize = true;
            this.SelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectLabel.Location = new System.Drawing.Point(19, 16);
            this.SelectLabel.Name = "SelectLabel";
            this.SelectLabel.Size = new System.Drawing.Size(206, 24);
            this.SelectLabel.TabIndex = 0;
            this.SelectLabel.Text = "Select an equation type";
            this.SelectLabel.Click += new System.EventHandler(this.SelectLabel_Click);
            // 
            // AddRadio
            // 
            this.AddRadio.AutoSize = true;
            this.AddRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRadio.Location = new System.Drawing.Point(86, 62);
            this.AddRadio.Name = "AddRadio";
            this.AddRadio.Size = new System.Drawing.Size(63, 28);
            this.AddRadio.TabIndex = 3;
            this.AddRadio.TabStop = true;
            this.AddRadio.Text = "Add";
            this.AddRadio.UseVisualStyleBackColor = true;
            this.AddRadio.CheckedChanged += new System.EventHandler(this.AddRadio_CheckedChanged);
            // 
            // SubtractRadio
            // 
            this.SubtractRadio.AutoSize = true;
            this.SubtractRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtractRadio.Location = new System.Drawing.Point(212, 62);
            this.SubtractRadio.Name = "SubtractRadio";
            this.SubtractRadio.Size = new System.Drawing.Size(96, 28);
            this.SubtractRadio.TabIndex = 4;
            this.SubtractRadio.TabStop = true;
            this.SubtractRadio.Text = "Subtract";
            this.SubtractRadio.UseVisualStyleBackColor = true;
            this.SubtractRadio.CheckedChanged += new System.EventHandler(this.SubtractRadio_CheckedChanged);
            // 
            // DivideRadio
            // 
            this.DivideRadio.AutoSize = true;
            this.DivideRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivideRadio.Location = new System.Drawing.Point(367, 62);
            this.DivideRadio.Name = "DivideRadio";
            this.DivideRadio.Size = new System.Drawing.Size(80, 28);
            this.DivideRadio.TabIndex = 5;
            this.DivideRadio.TabStop = true;
            this.DivideRadio.Text = "Divide";
            this.DivideRadio.UseVisualStyleBackColor = true;
            this.DivideRadio.CheckedChanged += new System.EventHandler(this.DivideRadio_CheckedChanged);
            // 
            // NumsGroupBox
            // 
            this.NumsGroupBox.Controls.Add(this.ResultTextBox);
            this.NumsGroupBox.Controls.Add(this.EqualLabel);
            this.NumsGroupBox.Controls.Add(this.NumLabel2);
            this.NumsGroupBox.Controls.Add(this.OpLabel);
            this.NumsGroupBox.Controls.Add(this.NumLabel1);
            this.NumsGroupBox.Controls.Add(this.QuestionLabel);
            this.NumsGroupBox.Location = new System.Drawing.Point(12, 158);
            this.NumsGroupBox.Name = "NumsGroupBox";
            this.NumsGroupBox.Size = new System.Drawing.Size(758, 130);
            this.NumsGroupBox.TabIndex = 0;
            this.NumsGroupBox.TabStop = false;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultTextBox.Location = new System.Drawing.Point(564, 66);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(53, 29);
            this.ResultTextBox.TabIndex = 6;
            this.ResultTextBox.TextChanged += new System.EventHandler(this.ResultTextBox_TextChanged);
            // 
            // EqualLabel
            // 
            this.EqualLabel.AutoSize = true;
            this.EqualLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualLabel.Location = new System.Drawing.Point(479, 71);
            this.EqualLabel.Name = "EqualLabel";
            this.EqualLabel.Size = new System.Drawing.Size(21, 24);
            this.EqualLabel.TabIndex = 5;
            this.EqualLabel.Text = "=";
            // 
            // NumLabel2
            // 
            this.NumLabel2.AutoSize = true;
            this.NumLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumLabel2.Location = new System.Drawing.Point(349, 71);
            this.NumLabel2.Name = "NumLabel2";
            this.NumLabel2.Size = new System.Drawing.Size(58, 24);
            this.NumLabel2.TabIndex = 4;
            this.NumLabel2.Text = "num2";
            this.NumLabel2.Click += new System.EventHandler(this.label3_Click);
            // 
            // OpLabel
            // 
            this.OpLabel.AutoSize = true;
            this.OpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpLabel.Location = new System.Drawing.Point(246, 71);
            this.OpLabel.Name = "OpLabel";
            this.OpLabel.Size = new System.Drawing.Size(21, 24);
            this.OpLabel.TabIndex = 3;
            this.OpLabel.Text = "+";
            // 
            // NumLabel1
            // 
            this.NumLabel1.AutoSize = true;
            this.NumLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumLabel1.Location = new System.Drawing.Point(91, 71);
            this.NumLabel1.Name = "NumLabel1";
            this.NumLabel1.Size = new System.Drawing.Size(58, 24);
            this.NumLabel1.TabIndex = 2;
            this.NumLabel1.Text = "num1";
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionLabel.Location = new System.Drawing.Point(19, 27);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(266, 24);
            this.QuestionLabel.TabIndex = 1;
            this.QuestionLabel.Text = "Can you answer this question?";
            this.QuestionLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // ButonsGroupBox
            // 
            this.ButonsGroupBox.Controls.Add(this.AmIRightButton);
            this.ButonsGroupBox.Controls.Add(this.ImDoneButton);
            this.ButonsGroupBox.Controls.Add(this.NxtQButton);
            this.ButonsGroupBox.Location = new System.Drawing.Point(12, 303);
            this.ButonsGroupBox.Name = "ButonsGroupBox";
            this.ButonsGroupBox.Size = new System.Drawing.Size(758, 68);
            this.ButonsGroupBox.TabIndex = 0;
            this.ButonsGroupBox.TabStop = false;
            // 
            // AmIRightButton
            // 
            this.AmIRightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmIRightButton.Location = new System.Drawing.Point(250, 19);
            this.AmIRightButton.Name = "AmIRightButton";
            this.AmIRightButton.Size = new System.Drawing.Size(234, 35);
            this.AmIRightButton.TabIndex = 2;
            this.AmIRightButton.Text = "Am I right?";
            this.AmIRightButton.UseVisualStyleBackColor = true;
            this.AmIRightButton.Click += new System.EventHandler(this.AmIRightButton_Click);
            // 
            // ImDoneButton
            // 
            this.ImDoneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImDoneButton.Location = new System.Drawing.Point(493, 19);
            this.ImDoneButton.Name = "ImDoneButton";
            this.ImDoneButton.Size = new System.Drawing.Size(230, 35);
            this.ImDoneButton.TabIndex = 1;
            this.ImDoneButton.Text = "I\'m done";
            this.ImDoneButton.UseVisualStyleBackColor = true;
            this.ImDoneButton.Click += new System.EventHandler(this.ImDoneButton_Click);
            // 
            // NxtQButton
            // 
            this.NxtQButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NxtQButton.Location = new System.Drawing.Point(23, 19);
            this.NxtQButton.Name = "NxtQButton";
            this.NxtQButton.Size = new System.Drawing.Size(209, 35);
            this.NxtQButton.TabIndex = 0;
            this.NxtQButton.Text = "Next Question";
            this.NxtQButton.UseVisualStyleBackColor = true;
            this.NxtQButton.Click += new System.EventHandler(this.NxtQButton_Click);
            // 
            // ResultGroupBox
            // 
            this.ResultGroupBox.Controls.Add(this.ResultLabel);
            this.ResultGroupBox.Location = new System.Drawing.Point(12, 377);
            this.ResultGroupBox.Name = "ResultGroupBox";
            this.ResultGroupBox.Size = new System.Drawing.Size(758, 61);
            this.ResultGroupBox.TabIndex = 0;
            this.ResultGroupBox.TabStop = false;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.Location = new System.Drawing.Point(349, 16);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(60, 24);
            this.ResultLabel.TabIndex = 2;
            this.ResultLabel.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NumsGroupBox);
            this.Controls.Add(this.ButonsGroupBox);
            this.Controls.Add(this.ResultGroupBox);
            this.Controls.Add(this.OperationsGroupBox);
            this.Name = "Form1";
            this.Text = "Math Practice";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.OperationsGroupBox.ResumeLayout(false);
            this.OperationsGroupBox.PerformLayout();
            this.NumsGroupBox.ResumeLayout(false);
            this.NumsGroupBox.PerformLayout();
            this.ButonsGroupBox.ResumeLayout(false);
            this.ResultGroupBox.ResumeLayout(false);
            this.ResultGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox OperationsGroupBox;
        private System.Windows.Forms.GroupBox NumsGroupBox;
        private System.Windows.Forms.GroupBox ButonsGroupBox;
        private System.Windows.Forms.GroupBox ResultGroupBox;
        private System.Windows.Forms.Label SelectLabel;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.RadioButton MultiplyRadio;
        private System.Windows.Forms.RadioButton AddRadio;
        private System.Windows.Forms.RadioButton SubtractRadio;
        private System.Windows.Forms.RadioButton DivideRadio;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Label EqualLabel;
        private System.Windows.Forms.Label NumLabel2;
        private System.Windows.Forms.Label OpLabel;
        private System.Windows.Forms.Label NumLabel1;
        private System.Windows.Forms.Button AmIRightButton;
        private System.Windows.Forms.Button ImDoneButton;
        private System.Windows.Forms.Button NxtQButton;
    }
}

