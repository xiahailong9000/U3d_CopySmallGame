using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopySmallGame.G01.UI {
    public class C_UiManage {

        /// <summary>
        /// 主界面
        /// </summary>
        public UI_Main ui_Main {
            get {
                if (_ui_Main == null || _ui_Main.rectTransform == null) {
                    _ui_Main = new UI_Main();
                }
                return _ui_Main;
            }
        }
        public UI_Main _ui_Main;
        public void S_Init() {
            ui_Main.S_Open(null);
        }
        public void S_GameReset() {
            ui_Main.S_GameReset();
        }

        public void S_GameStart() {
            ui_Main.S_GameStart();
        }
        public void S_GameEnd() {
            ui_Main.S_GameEnd();
        }
    }
}
