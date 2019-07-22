using System;
using System.Collections;
using System.Collections.Generic;
using CC_Util;
using UnityEngine;

namespace CopySmallGame.G01.Module {
    public class C_PlayerInputControl {
        public C_Parameter parameter = new C_Parameter();
        //Transform fristRoleRoot;
        public void S_Init() {
            //fristRoleRoot = C_Parameter.d_GetFirstRoleRootEvent();
            C_MonoMonitor.GetInstance.d_UpdateEvent += S_Update;

        }
        void S_Update() {
            if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Ended) {
                C_Parameter.d_FingerLiftEvent();
            }
            if (Input.GetMouseButtonUp(0)) {
                C_Parameter.d_FingerLiftEvent();
            }
        }
        public class C_Parameter {
            public static Action d_FingerLiftEvent;
        }
    }


}
