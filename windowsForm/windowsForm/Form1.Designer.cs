
namespace windowsForm
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
            this.FormUsers = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FormUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // FormUsers
            // 
            this.FormUsers.AllowUserToOrderColumns = true;
            this.FormUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.FormUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FormUsers.Location = new System.Drawing.Point(40, 77);
            this.FormUsers.Name = "FormUsers";
            this.FormUsers.ReadOnly = true;
            this.FormUsers.RowHeadersWidth = 51;
            this.FormUsers.RowTemplate.Height = 29;
            this.FormUsers.Size = new System.Drawing.Size(746, 308);
            this.FormUsers.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(40, 13);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(179, 58);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Carregar funcionários";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 397);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.FormUsers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FormUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView FormUsers;
        private System.Windows.Forms.Button btnLoad;
    }
}

