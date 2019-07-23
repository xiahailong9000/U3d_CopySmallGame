using CC_Game;
using UnityEngine;
using CC_Util;
namespace CopySmallGame.G01.Module.Role {
    /// <summary>
    /// 陷阱
    /// </summary>
    public class C_Trap : Part_Base {

        public static C_ObjBase S_CreateObj(C_Int4 onlyAssetsPath,int highIndex,int direction) {
            C_ObjBase obj = new C_ObjBase();
            C_ObjData data = new C_ObjData();
            data.onlyAssetsPath = onlyAssetsPath;
            data.originAngleY = direction;
            data.originPosi = Quaternion.Euler(0, direction, 0)* -Vector3.forward*5+Vector3.up*highIndex*1.2f;
            data.o_partDataList.Add(new C_Trap_Data());
            obj.S_Init(data);
            
            return obj;
        }

        public override Part_Base S_GetNewObj() {
            return new C_Trap();
        }


        public override void S_Init(C_PartDataBase partData) {
          
        }

        public override void S_Init1() {
            Collider collider = obj.a2Root.transform.GetComponentInChildren<Collider>();
            collider.gameObject.AddComponent<C_Mono>();
           
        }
        public override void S_Update() {
            obj.a2Root.transform.Translate(Vector3.forward * 10 * Time.deltaTime);
        }
    }
    public class C_Trap_Data : C_PartDataBase {
        public override C_PartDataBase S_GetNewObj() {
            return new C_Trap_Data();
        }
    }


    public class C_Mono:MonoBehaviour {
        void OnTriggerEnter(Collider other) {// 当进入触发器
            Debug.LogErrorFormat("进入碰撞____{0}", other.name);
        }
        void OnTriggerExit(Collider other) {// 当退出触发器
        }
        void OnTriggerStay(Collider other) {// 当逗留触发器

        }
    }
}
