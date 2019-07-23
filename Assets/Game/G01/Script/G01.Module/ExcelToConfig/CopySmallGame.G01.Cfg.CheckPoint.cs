
using System;
using System.Collections.Generic;
using M3ExcelToConfig;
/// <summary>
/// ----重要提示---《----当前代码为自动生成代码---请勿修改----》--------------------------------------------
/// </summary>
namespace CopySmallGame.G01.Cfg.CheckPoint {
	/// <summary>
	///怪物属性表    
	///<para></para>
 	/// </summary>
	[Serializable]
	public partial class Cfg_CheckPoint:I_CfgBase{


		#region------声明变量------------------------------------------------
		private int _id;//怪物属性表---()---
		private int[] _onlyAssetPath;//唯一资源路径---()---
		private int _cubeDirection;//方块方向---()---
		private int _obstacleType;//障碍物类型---(0=普通障碍物 _ 1=火球)---
		private float _RebornTime;//出生时间---()---

		#endregion---声明变量----------------------------------------------




		#region------属性--------------------------------------------------
		/// <summary>
		///id== 怪物属性表 
		///<para></para>
		/// </summary>
		public int id{
			get {
				return _id;
			}
		}
		/// <summary>
		///onlyAssetPath== 唯一资源路径 
		///<para></para>
		/// </summary>
		public int[] onlyAssetPath{
			get {
				return _onlyAssetPath;
			}
		}
		/// <summary>
		///cubeDirection== 方块方向 
		///<para></para>
		/// </summary>
		public int cubeDirection{
			get {
				return _cubeDirection;
			}
		}
		/// <summary>
		///obstacleType== 障碍物类型 
		///<para>0=普通障碍物 _ 1=火球</para>
		/// </summary>
		public int obstacleType{
			get {
				return _obstacleType;
			}
		}
		/// <summary>
		///RebornTime== 出生时间 
		///<para></para>
		/// </summary>
		public float RebornTime{
			get {
				return _RebornTime;
			}
		}

		#endregion----属性--------------------------------------------------




		#region----常量constant----------------------------------------------

		#endregion---常量constant------------------------------------------------


      
		/// <summary>
		///加载CSV数据
		/// </summary>
        public void S_LoadData(string content) {
            S_LoadData0(content);
        }
		/// <summary>
		///加载CSV数据
		/// </summary>
        public static void S_LoadData0(string content) {
            dataDic.Clear();
            string[] sss0 = content.Split('\n');
            for (int i = 0; i < sss0.Length; i++) {
                string[] sss = sss0[i].Split('\t');
                if (sss.Length < 2) {
                    //UnityEngine.Debug.LogFormat(" Cfg_CheckPoint_消息长度不在__{0}", sss0[i]);
                    continue;
                }
                try {
                    Cfg_CheckPoint nn = new Cfg_CheckPoint();
					nn._id = (int)C_Tool.S_GetValue("int",sss[0]);
					nn._onlyAssetPath = (int[])C_Tool.S_GetValue("int[]",sss[1]);
					nn._cubeDirection = (int)C_Tool.S_GetValue("int",sss[2]);
					nn._obstacleType = (int)C_Tool.S_GetValue("int",sss[3]);
					nn._RebornTime = (float)C_Tool.S_GetValue("float",sss[4]);
					dataDic[nn._id] = nn;
				} catch (Exception ex) {
					UnityEngine.Debug.LogErrorFormat("Cfg_CheckPoint=怪物属性表_读取数据解析出错__目标长度={0}__当前长度 ={1}____{2}\n__{3}\n__{4}", 5, sss.Length-1, sss0[i],ex.Message, ex.StackTrace);
				}
			}
		}
		public Cfg_CheckPoint(){}
		public Cfg_CheckPoint(int id,int[] onlyAssetPath,int cubeDirection,int obstacleType,float RebornTime) {
			this._id = id;
			this._onlyAssetPath = onlyAssetPath;
			this._cubeDirection = cubeDirection;
			this._obstacleType = obstacleType;
			this._RebornTime = RebornTime;
			dataDic[id] = this;
		}




		#region------任意字符串字段查询-----------------------------------------------
		#endregion----任意字符串字段查询-----------------------------------------------




		static Dictionary<int, Cfg_CheckPoint> dataDic = new Dictionary<int, Cfg_CheckPoint>();
		public static Dictionary<int, Cfg_CheckPoint> GetDictionary() {
            if (dataDic.Count>0) {
                return dataDic;
            } else {
				new Cfg_CheckPoint(1,new int[]{-1,12,1,0},90,0,2f);
				new Cfg_CheckPoint(2,new int[]{-1,12,1,0},270,0,2f);
				new Cfg_CheckPoint(3,new int[]{-1,12,1,0},90,0,2f);
				new Cfg_CheckPoint(4,new int[]{-1,12,1,0},270,0,2f);
				new Cfg_CheckPoint(5,new int[]{-1,12,1,0},90,0,2f);
				new Cfg_CheckPoint(6,new int[]{-1,12,1,0},270,0,2f);
				new Cfg_CheckPoint(7,new int[]{-1,12,1,0},90,0,2f);
				new Cfg_CheckPoint(8,new int[]{-1,12,1,0},270,0,2f);
				new Cfg_CheckPoint(9,new int[]{-1,12,1,0},90,0,2f);
				new Cfg_CheckPoint(10,new int[]{-1,12,1,0},270,0,2f);
				new Cfg_CheckPoint(11,new int[]{-1,12,1,0},90,0,2f);
				new Cfg_CheckPoint(12,new int[]{-1,12,1,0},270,0,2f);
				new Cfg_CheckPoint(13,new int[]{-1,12,1,0},90,0,2f);
				new Cfg_CheckPoint(14,new int[]{-1,12,1,0},270,0,2f);
				new Cfg_CheckPoint(15,new int[]{-1,12,1,0},90,0,2f);
				new Cfg_CheckPoint(16,new int[]{-1,12,1,0},270,0,2f);
				new Cfg_CheckPoint(17,new int[]{-1,12,1,0},90,0,2f);
				new Cfg_CheckPoint(18,new int[]{-1,12,1,0},270,0,2f);
				new Cfg_CheckPoint(19,new int[]{-1,12,1,0},90,0,2f);
				new Cfg_CheckPoint(20,new int[]{-1,12,1,0},270,0,2f);
				new Cfg_CheckPoint(21,new int[]{-1,12,1,0},90,0,2f);
				new Cfg_CheckPoint(22,new int[]{-1,12,1,0},270,0,2f);
				new Cfg_CheckPoint(23,new int[]{-1,12,1,0},90,0,2f);
				new Cfg_CheckPoint(24,new int[]{-1,12,1,0},270,0,2f);
				new Cfg_CheckPoint(25,new int[]{-1,12,1,0},90,0,2f);
				new Cfg_CheckPoint(26,new int[]{-1,12,1,0},270,0,2f);
				new Cfg_CheckPoint(27,new int[]{-1,12,1,0},90,0,2f);
				new Cfg_CheckPoint(28,new int[]{-1,12,1,0},270,0,2f);
				new Cfg_CheckPoint(29,new int[]{-1,12,1,0},90,0,2f);
				new Cfg_CheckPoint(30,new int[]{-1,12,1,0},270,0,2f);
				return dataDic;
			}
		}

        public static Cfg_CheckPoint GetConfig(int id) {
            if (GetDictionary().ContainsKey(id)) {
               return GetDictionary()[id];
            } else {
                return null;
            }
        }
	}


	#region------解码工具代码-------------------------------------------------

	/// <summary>
	///工具代码
	///<para>当前代码都是自动生成的</para>
	/// </summary>
    static class C_Tool {
	    /// <summary>
	    ///string获取值
	    ///<para>当前代码都是自动生成的</para>
	    /// </summary>
        public static object S_GetValue(string type, string value) {
            if (type.Contains("[][]")) {
                return S_GetArrayArray(type, value);
            } else if (type.Contains("[]")) {
                return S_GetArray(type, value);
            } else {
                return S_GetValue0(type, value);
            }
        }
        static object S_GetArrayArray(string type, string value) {
            string[] sss = value.Split(new string[] { "+", "=" }, StringSplitOptions.RemoveEmptyEntries);//---------
            if (type.Contains("int")) {
                return S_GetArrayData00<int>(type, sss);
            } else if (type.Contains("float")) {
                return S_GetArrayData00<float>(type, sss);
            } else if (type.Contains("long")) {
                return S_GetArrayData00<long>(type, sss);
            } else if (type.Contains("double")) {
                return S_GetArrayData00<double>(type, sss);
            } else if (type.Contains("string")) {
                return S_GetArrayData00<string>(type, sss);
            } else {
                UnityEngine.Debug.LogException(new Exception("数据类型无法识别___" + type + "____请检查单词是否拼写错误"));
                return null;
            }
        }
        static T[][] S_GetArrayData00<T>(string type, string[] sss) {
            List<T[]> iii = new List<T[]>();
            for (int i = 0; i < sss.Length; i++) {
                if (string.IsNullOrEmpty(sss[i])) {
                    continue;
                }
                string[] sss0 = sss[i].Split(new string[] { ",", "，" }, StringSplitOptions.RemoveEmptyEntries);//---------
                T[] obj = S_GetArrayData<T>(type, sss0);
                iii.Add(obj);
            }
            return iii.ToArray();
        }
        static object S_GetArray(string type, string value, int index = 1) {
            string[] sss = value.Split(new string[] { ",", "，" }, StringSplitOptions.RemoveEmptyEntries);//---------
            if (type.Contains("int")) {
                return S_GetArrayData<int>(type, sss);
            } else if (type.Contains("float")) {
                return S_GetArrayData<float>(type, sss);
            } else if (type.Contains("long")) {
                return S_GetArrayData<long>(type, sss);
            } else if (type.Contains("double")) {
                return S_GetArrayData<double>(type, sss);
            } else if (type.Contains("string")) {
                return S_GetArrayData<string>(type, sss);
            } else {
                UnityEngine.Debug.LogException(new Exception("数据类型无法识别___" + type + "____请检查单词是否拼写错误"));
                return null;
            }
        }
        static T[] S_GetArrayData<T>(string type, string[] sss) {
            List<T> iii = new List<T>();
            for (int i = 0; i < sss.Length; i++) {
                if (string.IsNullOrEmpty(sss[i])) {
                    continue;
                }
                object obj = S_GetValue0(type, sss[i]);
                iii.Add((T)obj);
            }
            return iii.ToArray();
        }
        static object S_GetValue0(string type, string value) {
            try {
                if (type.Contains("int")) {
                    return int.Parse(value);
                } else if (type.Contains("float")) {
                    return float.Parse(value);
                } else if (type.Contains("long")) {
                    return long.Parse(value);
                } else if (type.Contains("double")) {
                    return double.Parse(value);
                } else if (type.Contains("string")) {
                    return value;
                } else {
                    return 0;
                }
            } catch {
                return -10000000;
            }
        }
    }

	#endregion-----工具代码-------------------------------------------------


}