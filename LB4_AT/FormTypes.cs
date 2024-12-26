
using LB4_AT.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace LB4_AT
{
    public partial class FormTypes : Form
    {

        private Models.AppContext db;

        public Models.AppContext Db { get => db; set => db = value; }

        public FormTypes() => InitializeComponent();

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.Db = new Models.AppContext();
            this.Db.AnimeTypes.Load();
            this.dataGridViewTypes.DataSource = this.Db.AnimeTypes.OrderBy(o => o.AnimeOfType).ToList();
            dataGridViewTypes.Columns["Id"].Visible = false;
            dataGridViewTypes.Columns["AnimeTittles"].Visible = false;
            dataGridViewTypes.Columns["AnimeOfType"].HeaderText = "Type";

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this.Db?.Dispose();
            this.Db = null;
        }

        private void ButtonTypeAdd_Click(object sender, EventArgs e)
        {
            FormTypeAdd formTypeAdd = new();
            DialogResult result = formTypeAdd.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            AnimeType animeType = new()
            {
                AnimeOfType = formTypeAdd.textBoxTypeName.Text
            };

            Db.AnimeTypes.Add(animeType);
            Db.SaveChanges();

            MessageBox.Show("Новый объект добавлен");

            this.dataGridViewTypes.DataSource = this.Db.AnimeTypes.Local
                .OrderBy(o => o.AnimeOfType).ToList();
        }

        private void ButtonTypeUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewTypes.SelectedRows.Count == 0)
                return;

            int index = dataGridViewTypes.SelectedRows[0].Index;
            short id = 0;
            bool converted = Int16.TryParse(dataGridViewTypes[0, index].Value.ToString(), out id);
            if (!converted)
                return;

            AnimeType animeType = Db.AnimeTypes.Find(id);

            FormTypeAdd formTypeAdd = new();

            formTypeAdd.textBoxTypeName.Text = animeType.AnimeOfType;

            DialogResult result = formTypeAdd.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            animeType.AnimeOfType = formTypeAdd.textBoxTypeName.Text;

            Db.SaveChanges();
            MessageBox.Show("Объект обновлен");
            this.dataGridViewTypes.DataSource = this.Db.AnimeTypes.Local
                .OrderBy(o => o.AnimeOfType).ToList();
        }
        private void ButtonTypeDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewTypes.SelectedRows.Count == 0)
                return;

            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите удалить объект?",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            int index = dataGridViewTypes.SelectedRows[0].Index;
            short id = 0;
            bool converted = Int16.TryParse(dataGridViewTypes[0, index].Value.ToString(), out id);
            if (!converted)
                return;

            AnimeType animeType = Db.AnimeTypes.Find(id);

            Db.AnimeTypes.Remove(animeType);

            Db.SaveChanges();
            MessageBox.Show("Объект удален");
            this.dataGridViewTypes.DataSource = this.Db.AnimeTypes.Local
                .OrderBy(o => o.AnimeOfType).ToList();
        }

    }
}
