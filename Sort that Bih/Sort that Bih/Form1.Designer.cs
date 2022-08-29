namespace Sort_that_Bih
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.showUnsorted = new System.Windows.Forms.Button();
            this.flushArray = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.selectionSort = new System.Windows.Forms.Button();
            this.insertionSort = new System.Windows.Forms.Button();
            this.bubbleSort = new System.Windows.Forms.Button();
            this.mergeSort = new System.Windows.Forms.Button();
            this.quickSort = new System.Windows.Forms.Button();
            this.bogoSort = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(504, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generate Array";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // showUnsorted
            // 
            this.showUnsorted.Location = new System.Drawing.Point(161, 39);
            this.showUnsorted.Name = "showUnsorted";
            this.showUnsorted.Size = new System.Drawing.Size(142, 40);
            this.showUnsorted.TabIndex = 2;
            this.showUnsorted.Text = "Show unsorted Array";
            this.showUnsorted.UseVisualStyleBackColor = true;
            this.showUnsorted.Click += new System.EventHandler(this.showUnsorted_Click);
            // 
            // flushArray
            // 
            this.flushArray.Location = new System.Drawing.Point(309, 40);
            this.flushArray.Name = "flushArray";
            this.flushArray.Size = new System.Drawing.Size(297, 40);
            this.flushArray.TabIndex = 3;
            this.flushArray.Text = "Flush Array";
            this.flushArray.UseVisualStyleBackColor = true;
            this.flushArray.Click += new System.EventHandler(this.flushArray_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBox2.Location = new System.Drawing.Point(13, 86);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(290, 352);
            this.textBox2.TabIndex = 4;
            // 
            // selectionSort
            // 
            this.selectionSort.Location = new System.Drawing.Point(309, 84);
            this.selectionSort.Name = "selectionSort";
            this.selectionSort.Size = new System.Drawing.Size(297, 55);
            this.selectionSort.TabIndex = 5;
            this.selectionSort.Text = "Selectionsort";
            this.selectionSort.UseVisualStyleBackColor = true;
            this.selectionSort.Click += new System.EventHandler(this.selectionSort_Click);
            // 
            // insertionSort
            // 
            this.insertionSort.Location = new System.Drawing.Point(309, 145);
            this.insertionSort.Name = "insertionSort";
            this.insertionSort.Size = new System.Drawing.Size(297, 55);
            this.insertionSort.TabIndex = 6;
            this.insertionSort.Text = "Insertionsort";
            this.insertionSort.UseVisualStyleBackColor = true;
            this.insertionSort.Click += new System.EventHandler(this.insertionSort_Click);
            // 
            // bubbleSort
            // 
            this.bubbleSort.Location = new System.Drawing.Point(309, 206);
            this.bubbleSort.Name = "bubbleSort";
            this.bubbleSort.Size = new System.Drawing.Size(297, 55);
            this.bubbleSort.TabIndex = 7;
            this.bubbleSort.Text = "Bubblesort";
            this.bubbleSort.UseVisualStyleBackColor = true;
            this.bubbleSort.Click += new System.EventHandler(this.bubbleSort_Click);
            // 
            // mergeSort
            // 
            this.mergeSort.Location = new System.Drawing.Point(309, 267);
            this.mergeSort.Name = "mergeSort";
            this.mergeSort.Size = new System.Drawing.Size(297, 55);
            this.mergeSort.TabIndex = 8;
            this.mergeSort.Text = "Mergsort";
            this.mergeSort.UseVisualStyleBackColor = true;
            this.mergeSort.Click += new System.EventHandler(this.mergeSort_Click);
            // 
            // quickSort
            // 
            this.quickSort.Location = new System.Drawing.Point(309, 328);
            this.quickSort.Name = "quickSort";
            this.quickSort.Size = new System.Drawing.Size(297, 55);
            this.quickSort.TabIndex = 9;
            this.quickSort.Text = "Quicksort";
            this.quickSort.UseVisualStyleBackColor = true;
            this.quickSort.Click += new System.EventHandler(this.quickSort_Click);
            // 
            // bogoSort
            // 
            this.bogoSort.Location = new System.Drawing.Point(309, 414);
            this.bogoSort.Name = "bogoSort";
            this.bogoSort.Size = new System.Drawing.Size(297, 24);
            this.bogoSort.TabIndex = 10;
            this.bogoSort.Text = "Bogosort";
            this.bogoSort.UseVisualStyleBackColor = true;
            this.bogoSort.Click += new System.EventHandler(this.bogoSort_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(523, 12);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(83, 20);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(618, 450);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.bogoSort);
            this.Controls.Add(this.quickSort);
            this.Controls.Add(this.mergeSort);
            this.Controls.Add(this.bubbleSort);
            this.Controls.Add(this.insertionSort);
            this.Controls.Add(this.selectionSort);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.flushArray);
            this.Controls.Add(this.showUnsorted);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button showUnsorted;
        private System.Windows.Forms.Button flushArray;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button selectionSort;
        private System.Windows.Forms.Button insertionSort;
        private System.Windows.Forms.Button bubbleSort;
        private System.Windows.Forms.Button mergeSort;
        private System.Windows.Forms.Button quickSort;
        private System.Windows.Forms.Button bogoSort;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Timer timer1;
    }
}

