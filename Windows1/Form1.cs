using LibreriaPersonas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows1
{
    public partial class Form1 : Form
    {
        BindingList<Person> binding;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IPersonService service = new PersonService();
            binding = new BindingList<Person>(service.FindAll());
            dataGridView1.DataSource = binding;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            IPersonService servicio = new PersonService();
            servicio.InsertPerson(new Person(textBox1.Text, textBox2.Text, Int32.Parse(textBox3.Text)));
            binding = new BindingList<Person>(servicio.FindAll());
            dataGridView1.DataSource = binding;

        }
    }
}
