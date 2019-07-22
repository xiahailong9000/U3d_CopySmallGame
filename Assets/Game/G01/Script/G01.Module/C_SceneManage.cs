using CC_Farm.Part;
using CC_Game;
using CC_Util;
using CopySmallGame.G01.Cfg.SceneAssets;
using CopySmallGame.G01.Data;
using CopySmallGame.G01.Module.Role;
using UnityEngine;

namespace CopySmallGame.G01.Module {
    public class C_SceneManage {
        public C_DataManage dataManage = new C_DataManage();
        C_fristRole fristRole = new C_fristRole();
        C_PlayerInputControl playerInputControl = new C_PlayerInputControl();
        public void S_Init() {
            fristRole.parameter.currentUseRoleCfgId = dataManage.playerData.currentUseRoleCfgId;
            C_PlayerInputControl.C_Parameter.d_FingerLiftEvent = fristRole.S_Jump;
            fristRole.S_Init();
            playerInputControl.S_Init();
            C_ObjBase.mono.S_Delayed(0.2f).d_EndEvent = delegate () {
                S_GameReset();
            };
        }
        public void S_GameReset() {
            S_LoadScene();
            fristRole.S_GameReset();
        }

        public void S_GameStart() {

        }
        public void S_GameEnd() {

        }


        GameObject scene;
        GameObject roleModel;
        void S_LoadScene() {
            int sceneId = (int)dataManage.playerData.currentUseSceneCfgId.Value;
            Cfg_Scene sceneCfg = Cfg_Scene.GetConfig(sceneId);
            scene = C_128_AssetsCore.GetInstance.S_GetModel(sceneCfg.onlyAssetPath, 1);
            scene.transform.position = Vector3.zero;

       

            C_GameSetupTools.S_SetLight();
            Camera.main.transform.position = new Vector3(0, 5.07f, 5.85f);
            Camera.main.transform.eulerAngles = new Vector3(30, 180, 0);
        }
    }
}