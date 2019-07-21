using CC_Game;
using CC_Game.Part.Role;
using CC_Util;
using CopySmallGame.G01.Cfg.SceneAssets;
using UnityEngine;

namespace CopySmallGame.G01.Module.Role {
    public class C_fristRole {
        C_ObjBase role = new C_ObjBase();
        public C_Parameter parameter = new C_Parameter();
        public void S_Init() {

        }
        public void S_GameReset() {
            S_ResetRole();
        }
        public C_RoleMotionControl roleMotion = new C_RoleMotionControl();
        void S_ResetRole() {
            int roleId = (int)parameter.currentUseRoleCfgId.Value;
            Cfg_Role roleCfg = Cfg_Role.GetConfig(roleId);
            C_ObjData data = new C_ObjData();
            data.onlyAssetsPath =C_Int4.GetInt4(roleCfg.onlyAssetPath);
            data.originPosi = Vector3.zero;
            role.S_Init(data);

            roleMotion.S_Init(C_ObjBase.mono, role.a2Root.transform, Camera.main);
        }

        public void S_GameStart() {

        }
        public void S_GameEnd() {

        }
        public class C_Parameter {
            public LongData currentUseRoleCfgId;
        }
    }
}
