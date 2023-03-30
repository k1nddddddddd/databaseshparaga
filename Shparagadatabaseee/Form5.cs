using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shparagadatabaseee
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database21DataSet.Ногтевой_сервис". При необходимости она может быть перемещена или удалена.
            this.ногтевой_сервисTableAdapter.Fill(this.database21DataSet.Ногтевой_сервис);

        }
    }
}
