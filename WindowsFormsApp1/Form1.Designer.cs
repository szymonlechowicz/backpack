
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
      this.generateButton = new System.Windows.Forms.Button();
      this.weightsTextBox = new System.Windows.Forms.TextBox();
      this.numberTextBox = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.valuesTextBox = new System.Windows.Forms.TextBox();
      this.capTextBox = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.itemsTextBox = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // generateButton
      // 
      this.generateButton.Location = new System.Drawing.Point(457, 24);
      this.generateButton.Margin = new System.Windows.Forms.Padding(2);
      this.generateButton.Name = "generateButton";
      this.generateButton.Size = new System.Drawing.Size(68, 32);
      this.generateButton.TabIndex = 0;
      this.generateButton.Text = "Generate";
      this.generateButton.UseVisualStyleBackColor = true;
      this.generateButton.Click += new System.EventHandler(this.button1_Click);
      // 
      // weightsTextBox
      // 
      this.weightsTextBox.Location = new System.Drawing.Point(105, 31);
      this.weightsTextBox.Name = "weightsTextBox";
      this.weightsTextBox.Size = new System.Drawing.Size(299, 20);
      this.weightsTextBox.TabIndex = 1;
      // 
      // numberTextBox
      // 
      this.numberTextBox.Location = new System.Drawing.Point(105, 6);
      this.numberTextBox.Name = "numberTextBox";
      this.numberTextBox.Size = new System.Drawing.Size(51, 20);
      this.numberTextBox.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(86, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Number of items:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 34);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(88, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Weights of items:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(13, 59);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(81, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "Values of items:";
      // 
      // valuesTextBox
      // 
      this.valuesTextBox.Location = new System.Drawing.Point(105, 56);
      this.valuesTextBox.Name = "valuesTextBox";
      this.valuesTextBox.Size = new System.Drawing.Size(299, 20);
      this.valuesTextBox.TabIndex = 6;
      // 
      // capTextBox
      // 
      this.capTextBox.Location = new System.Drawing.Point(287, 6);
      this.capTextBox.Name = "capTextBox";
      this.capTextBox.Size = new System.Drawing.Size(71, 20);
      this.capTextBox.TabIndex = 7;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(179, 9);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(102, 13);
      this.label4.TabIndex = 8;
      this.label4.Text = "Backpack capacity:";
      // 
      // itemsTextBox
      // 
      this.itemsTextBox.Location = new System.Drawing.Point(105, 102);
      this.itemsTextBox.Name = "itemsTextBox";
      this.itemsTextBox.Size = new System.Drawing.Size(299, 20);
      this.itemsTextBox.TabIndex = 9;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(15, 105);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(79, 13);
      this.label5.TabIndex = 10;
      this.label5.Text = "Selected items:";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(554, 159);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.itemsTextBox);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.capTextBox);
      this.Controls.Add(this.valuesTextBox);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.numberTextBox);
      this.Controls.Add(this.weightsTextBox);
      this.Controls.Add(this.generateButton);
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateButton;
    private System.Windows.Forms.TextBox weightsTextBox;
    private System.Windows.Forms.TextBox numberTextBox;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox valuesTextBox;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox itemsTextBox;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox capTextBox;
  }
}

