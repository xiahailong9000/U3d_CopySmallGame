using CC_Game;
using CC_Util;
using CopySmallGame.G01.Module;
using CopySmallGame.G01.UI;
namespace CopySmallGame.G01 {
    public class C_GameManage {

        C_SceneManage sceneManage = new C_SceneManage();
        C_UiManage uiManage = new C_UiManage();
        public void S_Init() {
            C_GameData.gameState = E_GameState.e00_GameNull;
            UI_Main.C_Parameter.d_GameStart = S_GameStart;


            Game.G01.Assets.CC_Resources.ResourcesPath.S_SetPathToDic();
            Art05_Cartoon.CC_Resources.ResourcesPath.S_SetPathToDic();
            sceneManage.S_Init();
            uiManage.S_Init();
            C_ObjBase.mono.S_Delayed(0.2f).d_EndEvent = delegate () {
                S_GameReset();
            };
        }
        public void S_GameReset() {
            C_GameData.gameState = E_GameState.e01_GameReset;
            sceneManage.S_GameReset();
            uiManage.S_GameReset();
        }

        public void S_GameStart() {
            C_GameData.gameState = E_GameState.e02_GameRuning;
            sceneManage.S_GameStart();
            uiManage.S_GameStart();
        }
        public void S_GameEnd() {
            C_GameData.gameState = E_GameState.e05_GameEnd;
            sceneManage.S_GameEnd();
            uiManage.S_GameEnd();
        }
    }



    public class C_kkk {

        public void S_Init() {

        }
        public void S_GameReset() {

        }

        public void S_GameStart() {

        }
        public void S_GameEnd() {

        }
    }
}