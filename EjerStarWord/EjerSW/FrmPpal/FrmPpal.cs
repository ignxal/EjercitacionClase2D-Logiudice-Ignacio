using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesStarWars;
using System.Media; 

namespace FrmPpal
{
    public partial class FrmPpal : Form
    {
        
        public FrmPpal()
        {
            
            InitializeComponent();

            foreach (var type in Enum.GetNames(typeof(EType)))
            {
                cmbTipo.Items.Add(type);
            }

            foreach (var armament in Enum.GetNames(typeof(Blaster)))
            {
                cmbBlaster.Items.Add(armament);
            }

            // ImperialArmy army = new(); ??? private

        }
       
        private void FrmPpal_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedItem is null || cmbBlaster.SelectedItem is null)
            {
                return;
            }

            string tipoValue = cmbTipo.SelectedItem.ToString();
            bool isClonValue = ckbClon.Checked;
            Blaster blasterValue = (Blaster)cmbBlaster.SelectedItem;
            
            Trooper trooper = new(blasterValue, isClonValue);

            //army.AddTrooper(trooper); ??? no context ofc

            RefrescarEjercito();
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedItem is null || cmbBlaster.SelectedItem is null)
            {
                return;
            }

            RefrescarEjercito();
        }
        private void RefrescarEjercito()
        {
            lstEjercito.Items.Clear();

            //List<Trooper> troopers = ImperialArmy.Troopers.ForEach(a){ return a; };

            //string v = Trooper.InfoTrooper();

        }
    }
}
