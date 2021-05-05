
namespace amIPositive
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
            this.integerLabel = new System.Windows.Forms.Label();
            this.integerInput = new System.Windows.Forms.TextBox();
            this.enter = new System.Windows.Forms.Button();
            this.signOutput = new System.Windows.Forms.Label();
            this.divideOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // integerLabel
            // 
            this.integerLabel.AutoSize = true;
            this.integerLabel.Location = new System.Drawing.Point(89, 90);
            this.integerLabel.Name = "integerLabel";
            this.integerLabel.Size = new System.Drawing.Size(121, 20);
            this.integerLabel.TabIndex = 0;
            this.integerLabel.Text = "Input an integer";
            // 
            // integerInput
            // 
            this.integerInput.Location = new System.Drawing.Point(273, 90);
            this.integerInput.Name = "integerInput";
            this.integerInput.Size = new System.Drawing.Size(166, 26);
            this.integerInput.TabIndex = 1;
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(298, 164);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(116, 70);
            this.enter.TabIndex = 2;
            this.enter.Text = "Enter";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // signOutput
            // 
            this.signOutput.Location = new System.Drawing.Point(93, 288);
            this.signOutput.Name = "signOutput";
            this.signOutput.Size = new System.Drawing.Size(321, 23);
            this.signOutput.TabIndex = 3;
            // 
            // divideOutput
            // 
            this.divideOutput.Location = new System.Drawing.Point(93, 354);
            this.divideOutput.Name = "divideOutput";
            this.divideOutput.Size = new System.Drawing.Size(321, 23);
            this.divideOutput.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 450);
            this.Controls.Add(this.divideOutput);
            this.Controls.Add(this.signOutput);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.integerInput);
            this.Controls.Add(this.integerLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label integerLabel;
        private System.Windows.Forms.TextBox integerInput;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Label signOutput;
        private System.Windows.Forms.Label divideOutput;
    }
}

