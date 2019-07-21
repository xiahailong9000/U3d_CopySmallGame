
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
	public partial class Cfg_Monster:I_CfgBase{


		#region------声明变量------------------------------------------------
		private int _id;//怪物属性表---()---
		private string _constant22;//常量---()---
		private string _name;//名称---()---
		private int[] _onlyAssetPath;//唯一资源路径---()---

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
		///constant22== 常量 
		///<para></para>
		/// </summary>
		public string constant22{
			get {
				return _constant22;
			}
		}
		/// <summary>
		///name== 名称 
		///<para></para>
		/// </summary>
		public string name{
			get {
				return _name;
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
                    //UnityEngine.Debug.LogFormat(" Cfg_Monster_消息长度不在__{0}", sss0[i]);
                    continue;
                }
                try {
                    Cfg_Monster nn = new Cfg_Monster();
					nn._id = (int)C_Tool.S_GetValue("int",sss[0]);
					nn._constant22 = (string)C_Tool.S_GetValue("string",sss[1]);
					nn._name = (string)C_Tool.S_GetValue("string",sss[2]);
					nn._onlyAssetPath = (int[])C_Tool.S_GetValue("int[]",sss[3]);
					dataDic[nn._id] = nn;
				} catch (Exception ex) {
					UnityEngine.Debug.LogErrorFormat("Cfg_Monster=怪物属性表_读取数据解析出错__目标长度={0}__当前长度 ={1}____{2}\n__{3}\n__{4}", 4, sss.Length-1, sss0[i],ex.Message, ex.StackTrace);
				}
			}
		}
		public Cfg_Monster(){}
		public Cfg_Monster(int id,string constant22,string name,int[] onlyAssetPath) {
			this._id = id;
			this._constant22 = constant22;
			this._name = name;
			this._onlyAssetPath = onlyAssetPath;
			dataDic[id] = this;
		}




		#region------任意字符串字段查询-----------------------------------------------
        static Dictionary<string, List<Cfg_Monster>> _constant22Dic = new Dictionary<string, List<Cfg_Monster>>();
        public static List<Cfg_Monster> Get_constant22List(string key) {
            if (_constant22Dic.Count == 0) {
                var dic = GetDictionary().GetEnumerator();
                while (dic.MoveNext()) {
                    string[] sss = new string[]{dic.Current.Value._constant22};
                    for (int i = 0; i < sss.Length; i++) {
                        string key0 = sss[i].Trim();
                        if (_constant22Dic.ContainsKey(key0) == false) {
                            _constant22Dic[key0] = new List<Cfg_Monster>();
                        }
                        _constant22Dic[key0].Add(dic.Current.Value);
                    }
                }
            }
            if (_constant22Dic.ContainsKey(key)) {
                return _constant22Dic[key];
            } else {
                return null;
            }
        }

        static Dictionary<string, List<Cfg_Monster>> _nameDic = new Dictionary<string, List<Cfg_Monster>>();
        public static List<Cfg_Monster> Get_nameList(string key) {
            if (_nameDic.Count == 0) {
                var dic = GetDictionary().GetEnumerator();
                while (dic.MoveNext()) {
                    string[] sss = new string[]{dic.Current.Value._name};
                    for (int i = 0; i < sss.Length; i++) {
                        string key0 = sss[i].Trim();
                        if (_nameDic.ContainsKey(key0) == false) {
                            _nameDic[key0] = new List<Cfg_Monster>();
                        }
                        _nameDic[key0].Add(dic.Current.Value);
                    }
                }
            }
            if (_nameDic.ContainsKey(key)) {
                return _nameDic[key];
            } else {
                return null;
            }
        }

		#endregion----任意字符串字段查询-----------------------------------------------




		static Dictionary<int, Cfg_Monster> dataDic = new Dictionary<int, Cfg_Monster>();
		public static Dictionary<int, Cfg_Monster> GetDictionary() {
            if (dataDic.Count>0) {
                return dataDic;
            } else {
				new Cfg_Monster(1,"月亮星空","月亮星空",new int[]{-1,25,1,0});
				new Cfg_Monster(2,"月亮星空","月亮星空",new int[]{-1,25,1,0});
				new Cfg_Monster(3,"月亮星空","月亮星空",new int[]{-1,25,1,0});
				new Cfg_Monster(4,"月亮星空","月亮星空",new int[]{-1,25,1,0});
				new Cfg_Monster(5,"月亮星空","月亮星空",new int[]{-1,25,1,0});
				new Cfg_Monster(6,"月亮星空","月亮星空",new int[]{-1,25,1,0});
				new Cfg_Monster(7,"月亮星空","月亮星空",new int[]{-1,25,1,0});
				new Cfg_Monster(8,"月亮星空","月亮星空",new int[]{-1,25,1,0});
				new Cfg_Monster(9,"月亮星空","月亮星空",new int[]{-1,25,1,0});
				new Cfg_Monster(10,"月亮星空","月亮星空",new int[]{-1,25,1,0});
				new Cfg_Monster(11,"月亮星空","月亮星空",new int[]{-1,25,1,0});
				new Cfg_Monster(12,"月亮星空","月亮星空",new int[]{-1,25,1,0});
				new Cfg_Monster(13,"月亮星空","月亮星空",new int[]{-1,25,1,0});
				new Cfg_Monster(14,"月亮星空","月亮星空",new int[]{-1,25,1,0});
				new Cfg_Monster(15,"月亮星空","月亮星空",new int[]{-1,25,1,0});
				new Cfg_Monster(16,"月亮星空","月亮星空",new int[]{-1,25,1,0});
				return dataDic;
			}
		}

        public static Cfg_Monster GetConfig(int id) {
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