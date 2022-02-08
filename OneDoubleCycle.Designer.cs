
namespace _23_variant_CSharp_2_5_2
{
    partial class OneDoubleCycle
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
            this.buttonMatrDim = new System.Windows.Forms.Button();
            this.labelMinSum = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelInputEl = new System.Windows.Forms.Label();
            this.textBoxInputEl = new System.Windows.Forms.TextBox();
            this.radioButtonRandom = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMatrDim
            // 
            this.buttonMatrDim.Location = new System.Drawing.Point(397, 15);
            this.buttonMatrDim.Name = "buttonMatrDim";
            this.buttonMatrDim.Size = new System.Drawing.Size(103, 26);
            this.buttonMatrDim.TabIndex = 23;
            this.buttonMatrDim.Text = "Применить";
            this.buttonMatrDim.UseVisualStyleBackColor = true;
            this.buttonMatrDim.Click += new System.EventHandler(this.buttonMatrDim_Click);
            // 
            // labelMinSum
            // 
            this.labelMinSum.AutoSize = true;
            this.labelMinSum.Font = new System.Drawing.Font("Segoe UI", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMinSum.Location = new System.Drawing.Point(13, 418);
            this.labelMinSum.Name = "labelMinSum";
            this.labelMinSum.Size = new System.Drawing.Size(0, 19);
            this.labelMinSum.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 82);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 47;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1030, 519);
            this.dataGridView1.TabIndex = 21;
            // 
            // labelInputEl
            // 
            this.labelInputEl.AutoSize = true;
            this.labelInputEl.Font = new System.Drawing.Font("Segoe UI", 9.163636F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelInputEl.Location = new System.Drawing.Point(-1, 18);
            this.labelInputEl.Name = "labelInputEl";
            this.labelInputEl.Size = new System.Drawing.Size(257, 19);
            this.labelInputEl.TabIndex = 20;
            this.labelInputEl.Text = "Введите размерность матрицы N:";
            // 
            // textBoxInputEl
            // 
            this.textBoxInputEl.Location = new System.Drawing.Point(301, 15);
            this.textBoxInputEl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxInputEl.Name = "textBoxInputEl";
            this.textBoxInputEl.Size = new System.Drawing.Size(75, 26);
            this.textBoxInputEl.TabIndex = 19;
            // 
            // radioButtonRandom
            // 
            this.radioButtonRandom.AutoSize = true;
            this.radioButtonRandom.Checked = true;
            this.radioButtonRandom.Location = new System.Drawing.Point(12, 52);
            this.radioButtonRandom.Name = "radioButtonRandom";
            this.radioButtonRandom.Size = new System.Drawing.Size(315, 23);
            this.radioButtonRandom.TabIndex = 24;
            this.radioButtonRandom.TabStop = true;
            this.radioButtonRandom.Text = "Заполнить матрицу случайными элементами";
            this.radioButtonRandom.UseVisualStyleBackColor = true;
            // 
            // OneDoubleCycle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButtonRandom);
            this.Controls.Add(this.buttonMatrDim);
            this.Controls.Add(this.labelMinSum);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelInputEl);
            this.Controls.Add(this.textBoxInputEl);
            this.Name = "OneDoubleCycle";
            this.Text = "Алгоритм с использованием единственного двухкратного цикла";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMatrDim;
        private System.Windows.Forms.Label labelMinSum;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelInputEl;
        private System.Windows.Forms.TextBox textBoxInputEl;
        private System.Windows.Forms.RadioButton radioButtonRandom;
    }
}

