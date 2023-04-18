namespace Dice_Roller
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
            this.Title = new System.Windows.Forms.Label();
            this.Button = new System.Windows.Forms.Button();
            this.Number = new System.Windows.Forms.Label();
            this.MaxRange = new System.Windows.Forms.TextBox();
            this.MinRange = new System.Windows.Forms.TextBox();
            this.MinRangeText = new System.Windows.Forms.Label();
            this.MaxRangeText = new System.Windows.Forms.Label();
            this.ReRoll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(227, 25);
            this.Title.MaximumSize = new System.Drawing.Size(339, 77);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(339, 77);
            this.Title.TabIndex = 0;
            this.Title.Text = "Dice Roller";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Button
            // 
            this.Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button.Location = new System.Drawing.Point(319, 167);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(154, 38);
            this.Button.TabIndex = 1;
            this.Button.Text = "Role A Die";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // Number
            // 
            this.Number.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Number.Location = new System.Drawing.Point(289, 167);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(215, 38);
            this.Number.TabIndex = 2;
            this.Number.Text = "Your Number is :";
            this.Number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MaxRange
            // 
            this.MaxRange.Location = new System.Drawing.Point(466, 124);
            this.MaxRange.Name = "MaxRange";
            this.MaxRange.Size = new System.Drawing.Size(100, 23);
            this.MaxRange.TabIndex = 3;
            this.MaxRange.TextChanged += new System.EventHandler(this.MaxRange_TextChanged);
            // 
            // MinRange
            // 
            this.MinRange.Location = new System.Drawing.Point(227, 124);
            this.MinRange.Name = "MinRange";
            this.MinRange.Size = new System.Drawing.Size(100, 23);
            this.MinRange.TabIndex = 4;
            this.MinRange.TextChanged += new System.EventHandler(this.MinRange_TextChanged);
            // 
            // MinRangeText
            // 
            this.MinRangeText.AutoSize = true;
            this.MinRangeText.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinRangeText.Location = new System.Drawing.Point(245, 102);
            this.MinRangeText.Name = "MinRangeText";
            this.MinRangeText.Size = new System.Drawing.Size(64, 14);
            this.MinRangeText.TabIndex = 5;
            this.MinRangeText.Text = "Min Range";
            // 
            // MaxRangeText
            // 
            this.MaxRangeText.AutoSize = true;
            this.MaxRangeText.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaxRangeText.Location = new System.Drawing.Point(483, 102);
            this.MaxRangeText.Name = "MaxRangeText";
            this.MaxRangeText.Size = new System.Drawing.Size(66, 14);
            this.MaxRangeText.TabIndex = 6;
            this.MaxRangeText.Text = "Max Range";
            // 
            // ReRoll
            // 
            this.ReRoll.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReRoll.Location = new System.Drawing.Point(359, 222);
            this.ReRoll.Name = "ReRoll";
            this.ReRoll.Size = new System.Drawing.Size(75, 23);
            this.ReRoll.TabIndex = 7;
            this.ReRoll.Text = "Re Roll";
            this.ReRoll.UseVisualStyleBackColor = true;
            this.ReRoll.Click += new System.EventHandler(this.ReRoll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 317);
            this.Controls.Add(this.ReRoll);
            this.Controls.Add(this.MaxRangeText);
            this.Controls.Add(this.MinRangeText);
            this.Controls.Add(this.MinRange);
            this.Controls.Add(this.MaxRange);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.Title);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Dice Roller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Title;
        private Button Button;
        private Label Number;
        private TextBox MaxRange;
        private TextBox MinRange;
        private Label MinRangeText;
        private Label MaxRangeText;
        private Button ReRoll;
    }
}