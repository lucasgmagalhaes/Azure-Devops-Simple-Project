using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace DemoUI.Componente.Comum
{
    public static class WhiteUtils
    {
        private static Application app;
        private static UIItemContainer currentForm;

        private static Stack<Window> windows;
        private static Window currentWindow => windows.Pop();


        public static void Iniciar(string caminhoAplicacao)
        {
            app = Application.Launch(caminhoAplicacao);
        }
        public static void Finalizar()
        {
            app?.Close();
        }


        internal static T Encontrar<T>(SearchCriteria sc) where T : UIItem
        {
            return currentForm?.Get<T>(sc);
        }
        internal static T Encontrar<T>(this UIItemContainer container) where T : UIItem
        {
            return container.Get<T>(SearchCriteria.All);
        }
        internal static T Encontrar<T>(this UIItemContainer container, SearchCriteria sc) where T : UIItem
        {
            return container.Get<T>(sc);
        }


        internal static void SetWindowForm(SearchCriteria sc)
        {
            if (windows == null)
            {
                windows = new Stack<Window>();
                windows.Push(app.GetWindow(sc, InitializeOption.NoCache));
            }
            else
                windows.Push(currentWindow.ModalWindow(sc));

            currentForm = currentWindow;
        }
    }
}
