
namespace ControlListBox
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
            this.clbExample = new System.Windows.Forms.CheckedListBox();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnSecond = new System.Windows.Forms.Button();
            this.btnIndeterminate = new System.Windows.Forms.Button();
            this.btnAdd4th = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnGetIndex = new System.Windows.Forms.Button();
            this.btnSubtract3 = new System.Windows.Forms.Button();
            this.btnRemove2Half = new System.Windows.Forms.Button();
            this.btnAdd2Half = new System.Windows.Forms.Button();
            this.btnAddRange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clbExample
            // 
            this.clbExample.FormattingEnabled = true;
            this.clbExample.Items.AddRange(new object[] {
            "One",
            "Two",
            "Three"});
            this.clbExample.Location = new System.Drawing.Point(193, 30);
            this.clbExample.Name = "clbExample";
            this.clbExample.Size = new System.Drawing.Size(267, 242);
            this.clbExample.TabIndex = 0;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(133, 324);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 1;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnSecond
            // 
            this.btnSecond.Location = new System.Drawing.Point(250, 324);
            this.btnSecond.Name = "btnSecond";
            this.btnSecond.Size = new System.Drawing.Size(75, 23);
            this.btnSecond.TabIndex = 2;
            this.btnSecond.Text = "Second";
            this.btnSecond.UseVisualStyleBackColor = true;
            this.btnSecond.Click += new System.EventHandler(this.btnSecond_Click);
            // 
            // btnIndeterminate
            // 
            this.btnIndeterminate.Location = new System.Drawing.Point(357, 324);
            this.btnIndeterminate.Name = "btnIndeterminate";
            this.btnIndeterminate.Size = new System.Drawing.Size(165, 23);
            this.btnIndeterminate.TabIndex = 3;
            this.btnIndeterminate.Text = "Indeterminate";
            this.btnIndeterminate.UseVisualStyleBackColor = true;
            this.btnIndeterminate.Click += new System.EventHandler(this.btnIndeterminate_Click);
            // 
            // btnAdd4th
            // 
            this.btnAdd4th.Location = new System.Drawing.Point(602, 30);
            this.btnAdd4th.Name = "btnAdd4th";
            this.btnAdd4th.Size = new System.Drawing.Size(123, 23);
            this.btnAdd4th.TabIndex = 4;
            this.btnAdd4th.Text = "Add Fourth";
            this.btnAdd4th.UseVisualStyleBackColor = true;
            this.btnAdd4th.Click += new System.EventHandler(this.btnAdd4th_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(602, 215);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(123, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnGetIndex
            // 
            this.btnGetIndex.Location = new System.Drawing.Point(602, 186);
            this.btnGetIndex.Name = "btnGetIndex";
            this.btnGetIndex.Size = new System.Drawing.Size(123, 23);
            this.btnGetIndex.TabIndex = 6;
            this.btnGetIndex.Text = "Get Index of 2";
            this.btnGetIndex.UseVisualStyleBackColor = true;
            this.btnGetIndex.Click += new System.EventHandler(this.btnGetIndex_Click);
            // 
            // btnSubtract3
            // 
            this.btnSubtract3.Location = new System.Drawing.Point(602, 157);
            this.btnSubtract3.Name = "btnSubtract3";
            this.btnSubtract3.Size = new System.Drawing.Size(123, 23);
            this.btnSubtract3.TabIndex = 7;
            this.btnSubtract3.Text = "Subtract 3";
            this.btnSubtract3.UseVisualStyleBackColor = true;
            this.btnSubtract3.Click += new System.EventHandler(this.btnSubtract3_Click);
            // 
            // btnRemove2Half
            // 
            this.btnRemove2Half.Location = new System.Drawing.Point(602, 117);
            this.btnRemove2Half.Name = "btnRemove2Half";
            this.btnRemove2Half.Size = new System.Drawing.Size(123, 23);
            this.btnRemove2Half.TabIndex = 8;
            this.btnRemove2Half.Text = "Subtract 2 1/2";
            this.btnRemove2Half.UseVisualStyleBackColor = true;
            this.btnRemove2Half.Click += new System.EventHandler(this.btnRemove2Half_Click);
            // 
            // btnAdd2Half
            // 
            this.btnAdd2Half.Location = new System.Drawing.Point(602, 88);
            this.btnAdd2Half.Name = "btnAdd2Half";
            this.btnAdd2Half.Size = new System.Drawing.Size(123, 23);
            this.btnAdd2Half.TabIndex = 9;
            this.btnAdd2Half.Text = "Add 2 1/2";
            this.btnAdd2Half.UseVisualStyleBackColor = true;
            this.btnAdd2Half.Click += new System.EventHandler(this.btnAdd2Half_Click);
            // 
            // btnAddRange
            // 
            this.btnAddRange.Location = new System.Drawing.Point(602, 59);
            this.btnAddRange.Name = "btnAddRange";
            this.btnAddRange.Size = new System.Drawing.Size(123, 23);
            this.btnAddRange.TabIndex = 10;
            this.btnAddRange.Text = "Add Range";
            this.btnAddRange.UseVisualStyleBackColor = true;
            this.btnAddRange.Click += new System.EventHandler(this.btnAddRange_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddRange);
            this.Controls.Add(this.btnAdd2Half);
            this.Controls.Add(this.btnRemove2Half);
            this.Controls.Add(this.btnSubtract3);
            this.Controls.Add(this.btnGetIndex);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd4th);
            this.Controls.Add(this.btnIndeterminate);
            this.Controls.Add(this.btnSecond);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.clbExample);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbExample;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnSecond;
        private System.Windows.Forms.Button btnIndeterminate;
        private System.Windows.Forms.Button btnAdd4th;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnGetIndex;
        private System.Windows.Forms.Button btnSubtract3;
        private System.Windows.Forms.Button btnRemove2Half;
        private System.Windows.Forms.Button btnAdd2Half;
        private System.Windows.Forms.Button btnAddRange;
    }
}

