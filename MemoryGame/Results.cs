using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Results : Form
    {
        public Results(string name, string tries, string time)
        {
            InitializeComponent();

            // Set values to the textBoxes of the form "Results"
            txtName.Text = name;
            txtMismatch.Text = tries;
            txtTime.Text = time;
        }
    }
}
