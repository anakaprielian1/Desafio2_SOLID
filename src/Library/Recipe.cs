//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        // se crea el metodo GetRecipePrint() en esta clase para cumplir con
        // el principio de experto, porque esta clase tiene la informacion 
        // necesaria para imprimir la receta.
     
        public string GetRecipePrint()
        {
            string result = this.FinalProduct.Description + "\n";
            foreach (Step step in this.steps)
            {
                result = result + $"{step.Quantity} de {step.Input.Description} " +
                    $"usando '{step.Equipment.Description}' durante {step.Time} \n";
            }
            return result;
        }

    }
}