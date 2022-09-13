using System;
using System.Runtime.CompilerServices;
using System.Text; 

namespace EntidadesStarWars
{
    public class Trooper
    {
        private Blaster armament;
        private string description;
        private bool isClon;
        private EType type;

        public Trooper(Blaster armament)
        {
            this.armament = this.Type is not EType.Explorer ? armament : Blaster.DLT19;
            this.description = LoadDescription(this.Type);
            this.isClon = this.Type is not EType.Sand ? false : true;
        }

        public Trooper(Blaster armament, bool isClon):this(armament)
        {
            this.isClon = this.Type is not EType.Sand ? isClon : true;
        }

        public Blaster Armament { get => armament; }
        public bool IsClon { get => isClon; set => isClon = value; }
        public EType Type { get => type; set => type = value; }

        public string InfoTrooper()
        {
            string isClon = this.IsClon ? "SI" : "NO";

            return $"{this.description}, armado con {this.Armament}, {isClon} es clon.";
        }

        public string LoadDescription(EType type)
        {
            return type switch
            {
                EType.Sand => "Soldado de asalto de terrenos desérticos",
                EType.Assault => "Comando para misiones de infiltracion",
                EType.Explorer => "Soldado de exploracion",
                _ => "ERROR. Tipo invalido",
            };
        }

    }
}
