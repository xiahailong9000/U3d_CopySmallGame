using System;
using CC_Game;
using CC_Util;
using CopySmallGame.G01.Cfg.CheckPoint;
using CopySmallGame.G01.Module.Role;
using UnityEngine;

namespace CopySmallGame.G01.Module {
    /// <summary>
    /// 机关管理器
    /// </summary>
    public class C_TrapManage {
        public void S_Init() {
            C_ObjBase.S_RegisterPartType(new C_Trap_Data(), new C_Trap());
        }
        public void S_GameReset() {

        }
        int trapIndex;
        float launchTime;
        public void S_GameStart(int checkPointId) {

            trapIndex = 1;
            Cfg_CheckPoint cfg = Cfg_CheckPoint.GetConfig(trapIndex);
            launchTime = Time.time + cfg.RebornTime;
            C_MonoMonitor.GetInstance.S_UpdateEventAdd(0, S_Update);
        }
        public void S_GameEnd() {
            C_MonoMonitor.GetInstance.S_UpdateEventRemove(S_Update);
        }

        void S_Update() {
            if(Time.time> launchTime) {
                trapIndex ++;
                Cfg_CheckPoint cfg = Cfg_CheckPoint.GetConfig(trapIndex);
                if (cfg == null) {
                    
                    return;
                }
                launchTime = Time.time + cfg.RebornTime;
                C_ObjBase trap = C_Trap.S_CreateObj(C_Int4.GetInt4(cfg.onlyAssetPath),trapIndex,cfg.cubeDirection);
                if (trap == null) {
                    Debug.LogErrorFormat("关卡错误_________");
                    return;
                }
            }
        }
        public class C_Parameter {
          //  public static Action d_Daa
        }
    }
}
