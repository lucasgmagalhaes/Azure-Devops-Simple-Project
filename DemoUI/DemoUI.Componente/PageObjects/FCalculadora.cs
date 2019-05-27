using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;

using DemoUI.Componente.Comum;

namespace DemoUI.Componente.PageObjects
{
    public class FCalculadora
    {
        private Button btnSomar => WhiteUtils.Encontrar<Button>(SearchCriteria.ByAutomationId("btnsomar"));

        private TextBox txtNumero1 => WhiteUtils.Encontrar<TextBox>(SearchCriteria.ByAutomationId("txtn1"));
        private TextBox txtNumero2 => WhiteUtils.Encontrar<TextBox>(SearchCriteria.ByAutomationId("txtn2"));
        private TextBox txtResultado => WhiteUtils.Encontrar<TextBox>(SearchCriteria.ByAutomationId("txtresultado"));

        public FCalculadora()
        {
            WhiteUtils.SetWindowForm(SearchCriteria.ByAutomationId("Form1"));
        }

        public string SomarNumeros(string num1, string num2)
        {
            txtNumero1.SetValue(num1);
            txtNumero2.SetValue(num2);

            btnSomar.Click();

            return txtResultado.Text;
        }
    }
}
