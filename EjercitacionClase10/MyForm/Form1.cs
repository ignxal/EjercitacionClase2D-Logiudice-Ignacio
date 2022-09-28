using EjercitacionClase10;

namespace MyForm
{
    public partial class Form1 : Form
    {
        Warrior Pepe;
        Bow bow;
        Sword sword;
        Axe axe;

        public Form1()
        {
            bow = new(100, 2000);
            sword = new(300, 100);
            axe = new(500, 1);
            Pepe = new();
            InitializeComponent();
        }

        private void btnSword_Click(object sender, EventArgs e)
        {
            Pepe.EquipWeapon(sword);
        }

        private void btnAxe_Click(object sender, EventArgs e)
        {
            Pepe.EquipWeapon(axe);
        }

        private void btnBow_Click(object sender, EventArgs e)
        {
            Pepe.EquipWeapon(bow);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblAttack.Text = Pepe.Attack();
        }
    }
}