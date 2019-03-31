namespace Educacion.Win
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.listaAlumnosporClaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaAlumnosporClaseDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listaAlumnosporClaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaAlumnosporClaseDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // listaAlumnosporClaseBindingSource
            // 
            this.listaAlumnosporClaseBindingSource.DataSource = typeof(Educacion.BL.ReportedeAlumnosporClase);
            // 
            // listaAlumnosporClaseDataGridView
            // 
            this.listaAlumnosporClaseDataGridView.AutoGenerateColumns = false;
            this.listaAlumnosporClaseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaAlumnosporClaseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.listaAlumnosporClaseDataGridView.DataSource = this.listaAlumnosporClaseBindingSource;
            this.listaAlumnosporClaseDataGridView.Location = new System.Drawing.Point(82, 108);
            this.listaAlumnosporClaseDataGridView.Name = "listaAlumnosporClaseDataGridView";
            this.listaAlumnosporClaseDataGridView.Size = new System.Drawing.Size(300, 220);
            this.listaAlumnosporClaseDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Estudiante";
            this.dataGridViewTextBoxColumn1.HeaderText = "Estudiante";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Materia";
            this.dataGridViewTextBoxColumn2.HeaderText = "Materia";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Refrescar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 348);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listaAlumnosporClaseDataGridView);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.listaAlumnosporClaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaAlumnosporClaseDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource listaAlumnosporClaseBindingSource;
        private System.Windows.Forms.DataGridView listaAlumnosporClaseDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button button1;
    }
}