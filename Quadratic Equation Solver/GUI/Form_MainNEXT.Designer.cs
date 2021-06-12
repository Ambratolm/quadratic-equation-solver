namespace QuadraticEquationSolver
{
    partial class NEXT_Form_Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NEXT_Form_Main));
            this.groupBox_equation = new System.Windows.Forms.GroupBox();
            this.numericUpDown_C = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_B = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_A = new System.Windows.Forms.NumericUpDown();
            this.label_equation = new System.Windows.Forms.Label();
            this.groupBox_discriminant = new System.Windows.Forms.GroupBox();
            this.textBox_descSquareRoot = new System.Windows.Forms.TextBox();
            this.textBox_discriminant = new System.Windows.Forms.TextBox();
            this.groupBox_result = new System.Windows.Forms.GroupBox();
            this.textBox_x2 = new System.Windows.Forms.TextBox();
            this.textBox_x1 = new System.Windows.Forms.TextBox();
            this.errorProvider_main = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox_equation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_C)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_A)).BeginInit();
            this.groupBox_discriminant.SuspendLayout();
            this.groupBox_result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_main)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_equation
            // 
            this.groupBox_equation.Controls.Add(this.numericUpDown_C);
            this.groupBox_equation.Controls.Add(this.numericUpDown_B);
            this.groupBox_equation.Controls.Add(this.numericUpDown_A);
            this.groupBox_equation.Controls.Add(this.label_equation);
            this.groupBox_equation.Location = new System.Drawing.Point(17, 20);
            this.groupBox_equation.Margin = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.groupBox_equation.Name = "groupBox_equation";
            this.groupBox_equation.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.groupBox_equation.Size = new System.Drawing.Size(552, 168);
            this.groupBox_equation.TabIndex = 0;
            this.groupBox_equation.TabStop = false;
            this.groupBox_equation.Text = "Equation";
            // 
            // numericUpDown_C
            // 
            this.numericUpDown_C.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_C.Location = new System.Drawing.Point(388, 105);
            this.numericUpDown_C.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_C.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numericUpDown_C.Name = "numericUpDown_C";
            this.numericUpDown_C.Size = new System.Drawing.Size(120, 38);
            this.numericUpDown_C.TabIndex = 3;
            // 
            // numericUpDown_B
            // 
            this.numericUpDown_B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_B.Location = new System.Drawing.Point(216, 105);
            this.numericUpDown_B.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_B.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numericUpDown_B.Name = "numericUpDown_B";
            this.numericUpDown_B.Size = new System.Drawing.Size(120, 38);
            this.numericUpDown_B.TabIndex = 2;
            // 
            // numericUpDown_A
            // 
            this.numericUpDown_A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_A.Location = new System.Drawing.Point(44, 105);
            this.numericUpDown_A.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_A.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numericUpDown_A.Name = "numericUpDown_A";
            this.numericUpDown_A.Size = new System.Drawing.Size(120, 38);
            this.numericUpDown_A.TabIndex = 1;
            // 
            // label_equation
            // 
            this.label_equation.AutoSize = true;
            this.label_equation.BackColor = System.Drawing.Color.Transparent;
            this.label_equation.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Bold);
            this.label_equation.Location = new System.Drawing.Point(141, 38);
            this.label_equation.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label_equation.Name = "label_equation";
            this.label_equation.Size = new System.Drawing.Size(270, 31);
            this.label_equation.TabIndex = 0;
            this.label_equation.Text = "ax² + bx + c = 0";
            // 
            // groupBox_discriminant
            // 
            this.groupBox_discriminant.Controls.Add(this.textBox_descSquareRoot);
            this.groupBox_discriminant.Controls.Add(this.textBox_discriminant);
            this.groupBox_discriminant.Location = new System.Drawing.Point(19, 208);
            this.groupBox_discriminant.Name = "groupBox_discriminant";
            this.groupBox_discriminant.Size = new System.Drawing.Size(550, 148);
            this.groupBox_discriminant.TabIndex = 1;
            this.groupBox_discriminant.TabStop = false;
            this.groupBox_discriminant.Text = "Discriminant";
            // 
            // textBox_descSquareRoot
            // 
            this.textBox_descSquareRoot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_descSquareRoot.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Bold);
            this.textBox_descSquareRoot.Location = new System.Drawing.Point(21, 86);
            this.textBox_descSquareRoot.Name = "textBox_descSquareRoot";
            this.textBox_descSquareRoot.ReadOnly = true;
            this.textBox_descSquareRoot.Size = new System.Drawing.Size(509, 31);
            this.textBox_descSquareRoot.TabIndex = 1;
            // 
            // textBox_discriminant
            // 
            this.textBox_discriminant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_discriminant.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Bold);
            this.textBox_discriminant.Location = new System.Drawing.Point(21, 34);
            this.textBox_discriminant.Name = "textBox_discriminant";
            this.textBox_discriminant.ReadOnly = true;
            this.textBox_discriminant.Size = new System.Drawing.Size(509, 31);
            this.textBox_discriminant.TabIndex = 0;
            // 
            // groupBox_result
            // 
            this.groupBox_result.Controls.Add(this.textBox_x2);
            this.groupBox_result.Controls.Add(this.textBox_x1);
            this.groupBox_result.Location = new System.Drawing.Point(19, 376);
            this.groupBox_result.Name = "groupBox_result";
            this.groupBox_result.Size = new System.Drawing.Size(550, 144);
            this.groupBox_result.TabIndex = 2;
            this.groupBox_result.TabStop = false;
            this.groupBox_result.Text = "Result";
            // 
            // textBox_x2
            // 
            this.textBox_x2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_x2.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Bold);
            this.textBox_x2.Location = new System.Drawing.Point(21, 88);
            this.textBox_x2.Name = "textBox_x2";
            this.textBox_x2.ReadOnly = true;
            this.textBox_x2.Size = new System.Drawing.Size(509, 31);
            this.textBox_x2.TabIndex = 1;
            // 
            // textBox_x1
            // 
            this.textBox_x1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_x1.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Bold);
            this.textBox_x1.Location = new System.Drawing.Point(21, 42);
            this.textBox_x1.Name = "textBox_x1";
            this.textBox_x1.ReadOnly = true;
            this.textBox_x1.Size = new System.Drawing.Size(509, 31);
            this.textBox_x1.TabIndex = 0;
            // 
            // errorProvider_main
            // 
            this.errorProvider_main.BlinkRate = 0;
            this.errorProvider_main.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider_main.ContainerControl = this;
            // 
            // NEXT_Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 540);
            this.Controls.Add(this.groupBox_result);
            this.Controls.Add(this.groupBox_discriminant);
            this.Controls.Add(this.groupBox_equation);
            this.Font = new System.Drawing.Font("Courier New", 20F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.MaximizeBox = false;
            this.Name = "NEXT_Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quadratic Equation Solver";
            this.groupBox_equation.ResumeLayout(false);
            this.groupBox_equation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_C)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_A)).EndInit();
            this.groupBox_discriminant.ResumeLayout(false);
            this.groupBox_discriminant.PerformLayout();
            this.groupBox_result.ResumeLayout(false);
            this.groupBox_result.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_equation;
        private System.Windows.Forms.NumericUpDown numericUpDown_C;
        private System.Windows.Forms.NumericUpDown numericUpDown_B;
        private System.Windows.Forms.NumericUpDown numericUpDown_A;
        private System.Windows.Forms.Label label_equation;
        private System.Windows.Forms.GroupBox groupBox_discriminant;
        private System.Windows.Forms.TextBox textBox_discriminant;
        private System.Windows.Forms.TextBox textBox_descSquareRoot;
        private System.Windows.Forms.GroupBox groupBox_result;
        private System.Windows.Forms.TextBox textBox_x2;
        private System.Windows.Forms.TextBox textBox_x1;
        private System.Windows.Forms.ErrorProvider errorProvider_main;
    }
}