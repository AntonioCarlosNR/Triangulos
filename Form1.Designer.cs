
namespace Triangulos
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
            this.lado1 = new System.Windows.Forms.Label();
            this.textBoxlado1 = new System.Windows.Forms.TextBox();
            this.textBoxlado2 = new System.Windows.Forms.TextBox();
            this.textBoxlado3 = new System.Windows.Forms.TextBox();
            this.lado2 = new System.Windows.Forms.Label();
            this.lado3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lado1
            // 
            this.lado1.AutoSize = true;
            this.lado1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lado1.Location = new System.Drawing.Point(63, 35);
            this.lado1.Name = "lado1";
            this.lado1.Size = new System.Drawing.Size(66, 28);
            this.lado1.TabIndex = 0;
            this.lado1.Text = "Lado1";
            // 
            // textBoxlado1
            // 
            this.textBoxlado1.Location = new System.Drawing.Point(63, 78);
            this.textBoxlado1.Name = "textBoxlado1";
            this.textBoxlado1.Size = new System.Drawing.Size(188, 27);
            this.textBoxlado1.TabIndex = 1;
            // 
            // textBoxlado2
            // 
            this.textBoxlado2.Location = new System.Drawing.Point(63, 161);
            this.textBoxlado2.Name = "textBoxlado2";
            this.textBoxlado2.Size = new System.Drawing.Size(188, 27);
            this.textBoxlado2.TabIndex = 2;
            // 
            // textBoxlado3
            // 
            this.textBoxlado3.Location = new System.Drawing.Point(63, 228);
            this.textBoxlado3.Name = "textBoxlado3";
            this.textBoxlado3.Size = new System.Drawing.Size(188, 27);
            this.textBoxlado3.TabIndex = 3;
            // 
            // lado2
            // 
            this.lado2.AutoSize = true;
            this.lado2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lado2.Location = new System.Drawing.Point(63, 117);
            this.lado2.Name = "lado2";
            this.lado2.Size = new System.Drawing.Size(71, 28);
            this.lado2.TabIndex = 4;
            this.lado2.Text = "Lado 2";
            // 
            // lado3
            // 
            this.lado3.AutoSize = true;
            this.lado3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lado3.Location = new System.Drawing.Point(63, 197);
            this.lado3.Name = "lado3";
            this.lado3.Size = new System.Drawing.Size(71, 28);
            this.lado3.TabIndex = 5;
            this.lado3.Text = "Lado 3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Verificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.result.Location = new System.Drawing.Point(63, 337);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(124, 35);
            this.result.TabIndex = 7;
            this.result.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lado3);
            this.Controls.Add(this.lado2);
            this.Controls.Add(this.textBoxlado3);
            this.Controls.Add(this.textBoxlado2);
            this.Controls.Add(this.textBoxlado1);
            this.Controls.Add(this.lado1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lado1;
        private System.Windows.Forms.TextBox textBoxlado1;
        private System.Windows.Forms.TextBox textBoxlado2;
        private System.Windows.Forms.TextBox textBoxlado3;
        private System.Windows.Forms.Label lado2;
        private System.Windows.Forms.Label lado3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label result;
    }
}

