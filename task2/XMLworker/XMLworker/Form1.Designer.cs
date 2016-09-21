namespace XMLworker
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bOpenXML = new System.Windows.Forms.Button();
            this.bLoad = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.dgwFS = new System.Windows.Forms.DataGridView();
            this.bGenerate = new System.Windows.Forms.Button();
            this.bindingSource_dgwFS = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dgwDatabase = new System.Windows.Forms.DataGridView();
            this.bindingSource_dgwDatabase = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_dgwFS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_dgwDatabase)).BeginInit();
            this.SuspendLayout();
            // 
            // bOpenXML
            // 
            this.bOpenXML.Location = new System.Drawing.Point(866, 17);
            this.bOpenXML.Name = "bOpenXML";
            this.bOpenXML.Size = new System.Drawing.Size(171, 34);
            this.bOpenXML.TabIndex = 2;
            this.bOpenXML.Text = "Open XML-file";
            this.bOpenXML.UseVisualStyleBackColor = true;
            this.bOpenXML.Click += new System.EventHandler(this.bOpenXML_Click);
            // 
            // bLoad
            // 
            this.bLoad.Location = new System.Drawing.Point(11, 275);
            this.bLoad.Name = "bLoad";
            this.bLoad.Size = new System.Drawing.Size(171, 34);
            this.bLoad.TabIndex = 3;
            this.bLoad.Text = "Load from database";
            this.bLoad.UseVisualStyleBackColor = true;
            this.bLoad.Click += new System.EventHandler(this.bLoad_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(12, 17);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(171, 34);
            this.bSave.TabIndex = 4;
            this.bSave.Text = "Save to database";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // dgwFS
            // 
            this.dgwFS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwFS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwFS.Location = new System.Drawing.Point(11, 57);
            this.dgwFS.Name = "dgwFS";
            this.dgwFS.Size = new System.Drawing.Size(1203, 209);
            this.dgwFS.TabIndex = 5;
            // 
            // bGenerate
            // 
            this.bGenerate.Location = new System.Drawing.Point(1043, 17);
            this.bGenerate.Name = "bGenerate";
            this.bGenerate.Size = new System.Drawing.Size(171, 34);
            this.bGenerate.TabIndex = 6;
            this.bGenerate.Text = "Generate test XML-file";
            this.bGenerate.UseVisualStyleBackColor = true;
            this.bGenerate.Click += new System.EventHandler(this.bGenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Loaded from file system:";
            // 
            // dgwDatabase
            // 
            this.dgwDatabase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDatabase.Location = new System.Drawing.Point(11, 315);
            this.dgwDatabase.Name = "dgwDatabase";
            this.dgwDatabase.Size = new System.Drawing.Size(1203, 209);
            this.dgwDatabase.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Loaded from database:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 550);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgwDatabase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bGenerate);
            this.Controls.Add(this.dgwFS);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bLoad);
            this.Controls.Add(this.bOpenXML);
            this.Name = "Form1";
            this.Text = "XMLworker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwFS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_dgwFS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_dgwDatabase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bOpenXML;
        private System.Windows.Forms.Button bLoad;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.DataGridView dgwFS;
        private System.Windows.Forms.Button bGenerate;
        private System.Windows.Forms.BindingSource bindingSource_dgwFS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwDatabase;
        private System.Windows.Forms.BindingSource bindingSource_dgwDatabase;
        private System.Windows.Forms.Label label2;
    }
}

