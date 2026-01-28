using Business;
using Entities;

namespace UI
{
    public partial class Form1 : Form
    {
        // İş mantığı katmanına erişim sağlayan nesnemiz
        BookManager _bookManager = new BookManager();

        public Form1()
        {
            InitializeComponent();

            // 1. Form Genel Ayarları
            this.Text = "Kütüphane Yönetim Paneli v1.0";
            this.BackColor = Color.FromArgb(236, 240, 241); // Açık gri/beyaz modern arka plan
            this.Font = new Font("Segoe UI", 10);

            // 2. DataGridView (Tablo) Modernizasyonu
            dgwBooks.BorderStyle = BorderStyle.None;
            dgwBooks.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgwBooks.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgwBooks.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219); // Mavi seçim
            dgwBooks.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgwBooks.BackgroundColor = Color.White;
            dgwBooks.EnableHeadersVisualStyles = false;
            dgwBooks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgwBooks.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 128, 185); // Koyu mavi header
            dgwBooks.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgwBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Sütunları yay

            // 3. Butonları Güzelleştirme (Ekle Butonu)
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.BackColor = Color.FromArgb(46, 204, 113); // Yeşil
            btnAdd.ForeColor = Color.White;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Text = "➕ Kitap Ekle";

            // 4. Butonları Güzelleştirme (Sil Butonu)
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.BackColor = Color.FromArgb(231, 76, 60); // Kırmızı
            btnDelete.ForeColor = Color.White;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Text = "🗑️ Seçileni Sil";

            // 5. Metin Kutuları (TextBox) İpucu Yazıları
            tbxName.PlaceholderText = "Kitap Adı...";
            tbxAuthor.PlaceholderText = "Yazar...";
            tbxPageCount.PlaceholderText = "Sayfa...";
            tbxSearch.PlaceholderText = "🔍 Listede ara...";
        }


        // Form açıldığında verileri getir
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }

        // Kitap Ekleme Butonu
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _bookManager.Add(new Book
                {
                    BookName = tbxName.Text,
                    Author = tbxAuthor.Text,
                    PageCount = Convert.ToInt32(tbxPageCount.Text),
                    IsAvailable = true
                });
                MessageBox.Show("Kitap kütüphaneye başarıyla kaydedildi!", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBooks(); // Tabloyu tazele
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir sorun oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Kitap Silme Butonu
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgwBooks.CurrentRow != null)
                {
                    // Seçili satırın ilk hücresindeki (BookID) değerini al
                    int id = Convert.ToInt32(dgwBooks.CurrentRow.Cells[0].Value);
                    _bookManager.Delete(id);
                    MessageBox.Show("Kitap kaydı sistemden kalıcı olarak silindi.", "Kayıt Silindi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadBooks(); // Tabloyu tazele
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen silinecek bir kitap seçin! Hata: " + ex.Message);
            }
        }

        // Arama Kutusu (Her harf yazıldığında çalışır)
        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            dgwBooks.DataSource = _bookManager.GetBySearch(tbxSearch.Text);
        }

        // Tabloyu veritabanından güncelleyen ana metodumuz
        private void LoadBooks()
        {
            dgwBooks.DataSource = _bookManager.GetAll();
        }
    }
}