using System;
using UI00;
using UnityEngine;
using UnityEngine.UI;
namespace CopySmallGame.G01.UI {
    public class UI_Main : C_UIBase {
        public UI_Main(Transform father = null) : base(father) {
            // Debug.LogErrorFormat("___new UI_Main()___________{0}____",Time.frameCount);
        }
        public static string prefabPath;
        public override string S_GetPrefabPath() {
            if (prefabPath != null) {
                return prefabPath;
            }
            return "Game/G01/Resources/G01/UI/UI_Main/UI_Main.prefab";
        }
        Button startGameButton,selectRoleButton,selectSceneButton;
        RectTransform buttonGroup;
        protected override void S_Init() {

            buttonGroup = GetControl<RectTransform>("buttonGroup");
            startGameButton = GetControl<Button>("startGameButton", buttonGroup);
            selectRoleButton = GetControl<Button>("selectRoleButton", buttonGroup);
            selectSceneButton = GetControl<Button>("selectSceneButton", buttonGroup);
            startGameButton.onClick.AddListener(delegate () {
                C_Parameter.d_GameStart();
            });
        }

        public void S_GameReset() {
            buttonGroup.gameObject.SetActive(true);
        }

        public void S_GameStart() {
            buttonGroup.gameObject.SetActive(false);
        }
        public void S_GameEnd() {

        }
        public class C_Parameter {
            public static Action d_GameStart;
        }
    }
}