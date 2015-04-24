using System;
using System.Threading.Tasks;
using System.Windows;
using log4net;
using MMS.UI;

namespace MMS.Core
{
    public class Engine
    {
        #region instance
        public static Engine Instance;

        public static Engine GetEngine()
        {
            return Instance ?? (Instance = new Engine());
        }
        #endregion

        private UIControl UiControl;
        private ILog Logger;
        private Engine()
        {
            this.UiControl = new UIControl();
            this.Logger = Logging.Logger.GetLogger();
            this.Logger.Info("Engine initialized!");
        }
        public void Run()
        {
            this.Logger.Info("Engine running!");
            this.UiControl.Run();
        }

        public void Exit()
        {
        }
    }
}