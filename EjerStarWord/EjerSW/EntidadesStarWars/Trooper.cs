using System;
using System.Text; 

namespace EntidadesStarWars
{
    public class Trooper
    {
        private Blaster armament;
        private string description;
        private bool isClon;
        private ETipo type;

        public Trooper(Blaster armament, string description, ETipo type, bool isClon = false)
        {
            if(type is not ETipo.Explorer)
            {
                this.armament = armament;
            }
            else
            {
                this.armament = Blaster.DLT19;
            }

            this.description = description;
            this.type = type;

            if(type is not ETipo.Sand)
            {
                this.isClon = isClon;
            }
            else
            {
                this.isClon = false;
            }
            
        }

        public Blaster Armament { get => armament; }
        public bool IsClon { get => isClon; set => isClon = value; }
        public ETipo Tipo { get => type; set => type = value; }

        public string InfoTrooper()
        {
            return description;
        }

        public string LoadDescription(ETipo type)
        {
            return type switch
            {
                ETipo.Sand => "Soldado de asalto de terrenos desérticos",
                ETipo.Assault => "Comando para misiones de infiltracion",
                ETipo.Explorer => "Soldado de exploracion",
                _ => "Se produjo un error",
            };
        }
    }
}
