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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database21DataSet._MAKE_UP__БРОВИ". При необходимости она может быть перемещена или удалена.
            this.mAKE_UP__БРОВИTableAdapter.Fill(this.database21DataSet._MAKE_UP__БРОВИ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database21DataSet.Расписание". При необходимости она может быть перемещена или удалена.
            this.расписаниеTableAdapter.Fill(this.database21DataSet.Расписание);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database21DataSet.Парикмахерские_услуги". При необходимости она может быть перемещена или удалена.
            this.парикмахерские_услугиTableAdapter.Fill(this.database21DataSet.Парикмахерские_услуги);

        }
    }
}
