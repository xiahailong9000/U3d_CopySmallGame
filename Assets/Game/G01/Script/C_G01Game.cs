using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace CopySmallGame.G01 {
    public class C_G01Game  {

        C_GameManage gameManage = new C_GameManage();
        public void S_Start() {
            gameManage.S_Init();
        }
    }
}