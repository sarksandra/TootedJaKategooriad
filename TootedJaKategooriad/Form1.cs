using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace TootedJaKategooriad
{
    public partial class MainForm : Form
    {
        private ProductsContext _productsContext;
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this._productsContext = new ProductsContext();
            this._productsContext.Database.EnsureCreated();
            this._productsContext.Categories.Load();
            this.categoryBindingSource.DataSource = this._productsContext.Categories.Local.ToBindingList();


        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosed(e);
            this._productsContext?.Dispose();
            this._productsContext = null;
        }

        private void dataGridViewCategories_SelectionChanged(object sender, EventArgs e)
        {
            if (this._productsContext is not null)
            {
                var category = (Category)this.dataGridViewCategories.CurrentRow.DataBoundItem;

                if (category is not null)
                {
                    this._productsContext.Entry(category).Collection(e => e.Products).Load();
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this._productsContext!.SaveChanges();
            this.dataGridViewCategories.Refresh();
            this.dataGridViewProducts.Refresh();
        }
    }
}
