namespace UI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tbxAuthor = new TextBox();
            tbxName = new TextBox();
            tbxPageCount = new TextBox();
            btnAdd = new Button();
            dgwBooks = new DataGridView();
            btnDelete = new Button();
            tbxSearch = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgwBooks).BeginInit();
            SuspendLayout();
            // 
            // tbxAuthor
            // 
            tbxAuthor.Location = new Point(159, 229);
            tbxAuthor.Name = "tbxAuthor";
            tbxAuthor.Size = new Size(125, 27);
            tbxAuthor.TabIndex = 0;
            // 
            // tbxName
            // 
            tbxName.Location = new Point(28, 229);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(125, 27);
            tbxName.TabIndex = 1;
            // 
            // tbxPageCount
            // 
            tbxPageCount.Location = new Point(290, 229);
            tbxPageCount.Name = "tbxPageCount";
            tbxPageCount.Size = new Size(125, 27);
            tbxPageCount.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(432, 229);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgwBooks
            // 
            dgwBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwBooks.Location = new Point(28, 50);
            dgwBooks.Name = "dgwBooks";
            dgwBooks.RowHeadersWidth = 51;
            dgwBooks.Size = new Size(498, 160);
            dgwBooks.TabIndex = 5;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(540, 229);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // tbxSearch
            // 
            tbxSearch.Location = new Point(100, 15);
            tbxSearch.Name = "tbxSearch";
            tbxSearch.Size = new Size(228, 27);
            tbxSearch.TabIndex = 7;
            tbxSearch.TextChanged += tbxSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 18);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 8;
            label1.Text = "Kitap Ara";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 300);
            Controls.Add(label1);
            Controls.Add(tbxSearch);
            Controls.Add(btnDelete);
            Controls.Add(dgwBooks);
            Controls.Add(btnAdd);
            Controls.Add(tbxPageCount);
            Controls.Add(tbxName);
            Controls.Add(tbxAuthor);
            Name = "Form1";
            Text = "Kütüphane Takip Sistemi";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgwBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxName;
        private TextBox tbxAuthor;
        private TextBox tbxPageCount;
        private Button btnAdd;
        private DataGridView dgwBooks;
        private Button btnDelete;
        private TextBox tbxSearch;
        private Label label1;
    }
}