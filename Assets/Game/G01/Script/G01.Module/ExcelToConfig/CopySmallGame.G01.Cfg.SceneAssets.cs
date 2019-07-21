
using System;
using System.Collections.Generic;
using M3ExcelToConfig;
/// <summary>
/// ----重要提示---《----当前代码为自动生成代码---请勿修改----》--------------------------------------------
/// </summary>
namespace CopySmallGame.G01.Cfg.SceneAssets {
	/// <summary>
	///怪物属性表    
	///<para></para>
 	/// </summary>
	[Serializable]
	public partial class Cfg_Role:I_CfgBase{


		#region------声明变量------------------------------------------------
		private int _id;//怪物属性表---()---
		private string _constant;//常量---()---
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
		///constant== 常量 
		///<para></para>
		/// </summary>
		public string constant{
			get {
				return _constant;
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
        
        /// <summary>
        /// 普通小怪
        /// </summary>
        public static Cfg_Role 小黄鱼 {
            get {
                return GetDictionary()[1];
            }
        }        
        /// <summary>
        /// 胆小怪兽
        /// </summary>
        public static Cfg_Role 车旗鱼 {
            get {
                return GetDictionary()[2];
            }
        }        
        /// <summary>
        /// 呼吸怪兽
        /// </summary>
        public static Cfg_Role 金枪鱼 {
            get {
                return GetDictionary()[3];
            }
        }        
        /// <summary>
        /// 胆小快速怪兽
        /// </summary>
        public static Cfg_Role 小丑鱼 {
            get {
                return GetDictionary()[4];
            }
        }        
        /// <summary>
        /// 减速怪兽
        /// </summary>
        public static Cfg_Role 帝鲶鱼 {
            get {
                return GetDictionary()[5];
            }
        }        
        /// <summary>
        /// 加血怪兽
        /// </summary>
        public static Cfg_Role 天使鱼 {
            get {
                return GetDictionary()[6];
            }
        }        
        /// <summary>
        /// 五角怪兽
        /// </summary>
        public static Cfg_Role 河豚 {
            get {
                return GetDictionary()[7];
            }
        }        
        /// <summary>
        /// 钢铁怪兽
        /// </summary>
        public static Cfg_Role 海龟 {
            get {
                return GetDictionary()[8];
            }
        }        
        /// <summary>
        /// 分裂钢铁怪兽
        /// </summary>
        public static Cfg_Role 鲂鱼 {
            get {
                return GetDictionary()[9];
            }
        }        
        /// <summary>
        /// 追踪怪兽
        /// </summary>
        public static Cfg_Role 灯笼鱼 {
            get {
                return GetDictionary()[10];
            }
        }        
        /// <summary>
        /// 加速怪兽
        /// </summary>
        public static Cfg_Role 电鳗鱼 {
            get {
                return GetDictionary()[11];
            }
        }        
        /// <summary>
        /// 呼吸怪兽
        /// </summary>
        public static Cfg_Role 狮子鱼 {
            get {
                return GetDictionary()[12];
            }
        }        
        /// <summary>
        /// 牛逼的怪物
        /// </summary>
        public static Cfg_Role 蓝蝙蝠鱼 {
            get {
                return GetDictionary()[13];
            }
        }        
        /// <summary>
        /// 牛逼的怪物
        /// </summary>
        public static Cfg_Role 剑鱼 {
            get {
                return GetDictionary()[14];
            }
        }        
        /// <summary>
        /// 牛逼的怪物
        /// </summary>
        public static Cfg_Role 鲨鱼 {
            get {
                return GetDictionary()[15];
            }
        }        
        /// <summary>
        /// 牛逼的怪物
        /// </summary>
        public static Cfg_Role 金蝙蝠鱼 {
            get {
                return GetDictionary()[16];
            }
        }
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
                    //UnityEngine.Debug.LogFormat(" Cfg_Role_消息长度不在__{0}", sss0[i]);
                    continue;
                }
                try {
                    Cfg_Role nn = new Cfg_Role();
					nn._id = (int)C_Tool.S_GetValue("int",sss[0]);
					nn._constant = (string)C_Tool.S_GetValue("string",sss[1]);
					nn._name = (string)C_Tool.S_GetValue("string",sss[2]);
					nn._onlyAssetPath = (int[])C_Tool.S_GetValue("int[]",sss[3]);
					dataDic[nn._id] = nn;
				} catch (Exception ex) {
					UnityEngine.Debug.LogErrorFormat("Cfg_Role=怪物属性表_读取数据解析出错__目标长度={0}__当前长度 ={1}____{2}\n__{3}\n__{4}", 4, sss.Length-1, sss0[i],ex.Message, ex.StackTrace);
				}
			}
		}
		public Cfg_Role(){}
		public Cfg_Role(int id,string constant,string name,int[] onlyAssetPath) {
			this._id = id;
			this._constant = constant;
			this._name = name;
			this._onlyAssetPath = onlyAssetPath;
			dataDic[id] = this;
		}




		#region------任意字符串字段查询-----------------------------------------------
        static Dictionary<string, List<Cfg_Role>> _constantDic = new Dictionary<string, List<Cfg_Role>>();
        public static List<Cfg_Role> Get_constantList(string key) {
            if (_constantDic.Count == 0) {
                var dic = GetDictionary().GetEnumerator();
                while (dic.MoveNext()) {
                    string[] sss = new string[]{dic.Current.Value._constant};
                    for (int i = 0; i < sss.Length; i++) {
                        string key0 = sss[i].Trim();
                        if (_constantDic.ContainsKey(key0) == false) {
                            _constantDic[key0] = new List<Cfg_Role>();
                        }
                        _constantDic[key0].Add(dic.Current.Value);
                    }
                }
            }
            if (_constantDic.ContainsKey(key)) {
                return _constantDic[key];
            } else {
                return null;
            }
        }

        static Dictionary<string, List<Cfg_Role>> _nameDic = new Dictionary<string, List<Cfg_Role>>();
        public static List<Cfg_Role> Get_nameList(string key) {
            if (_nameDic.Count == 0) {
                var dic = GetDictionary().GetEnumerator();
                while (dic.MoveNext()) {
                    string[] sss = new string[]{dic.Current.Value._name};
                    for (int i = 0; i < sss.Length; i++) {
                        string key0 = sss[i].Trim();
                        if (_nameDic.ContainsKey(key0) == false) {
                            _nameDic[key0] = new List<Cfg_Role>();
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




		static Dictionary<int, Cfg_Role> dataDic = new Dictionary<int, Cfg_Role>();
		public static Dictionary<int, Cfg_Role> GetDictionary() {
            if (dataDic.Count>0) {
                return dataDic;
            } else {
				new Cfg_Role(1,"小黄鱼","小黄鱼",new int[]{5,10,80,0});
				new Cfg_Role(2,"车旗鱼","车旗鱼",new int[]{5,10,80,0});
				new Cfg_Role(3,"金枪鱼","金枪鱼",new int[]{5,10,80,0});
				new Cfg_Role(4,"小丑鱼","小丑鱼",new int[]{5,10,80,0});
				new Cfg_Role(5,"帝鲶鱼","帝鲶鱼",new int[]{5,10,80,0});
				new Cfg_Role(6,"天使鱼","天使鱼",new int[]{5,10,80,0});
				new Cfg_Role(7,"河豚","河豚",new int[]{5,10,80,0});
				new Cfg_Role(8,"海龟","海龟",new int[]{5,10,80,0});
				new Cfg_Role(9,"鲂鱼","鲂鱼",new int[]{5,10,80,0});
				new Cfg_Role(10,"灯笼鱼","灯笼鱼",new int[]{5,10,80,0});
				new Cfg_Role(11,"电鳗鱼","电鳗鱼",new int[]{5,10,80,0});
				new Cfg_Role(12,"狮子鱼","狮子鱼",new int[]{5,10,80,0});
				new Cfg_Role(13,"蓝蝙蝠鱼","蓝蝙蝠鱼",new int[]{5,10,80,0});
				new Cfg_Role(14,"剑鱼","剑鱼",new int[]{5,10,80,0});
				new Cfg_Role(15,"鲨鱼","鲨鱼",new int[]{5,10,80,0});
				new Cfg_Role(16,"金蝙蝠鱼","金蝙蝠鱼",new int[]{5,10,80,0});
				return dataDic;
			}
		}

        public static Cfg_Role GetConfig(int id) {
            if (GetDictionary().ContainsKey(id)) {
               return GetDictionary()[id];
            } else {
                return null;
            }
        }
	}

	/// <summary>
	///buff数据表    
	///<para></para>
 	/// </summary>
	[Serializable]
	public partial class Cfg_Npc:I_CfgBase{


		#region------声明变量------------------------------------------------
		private int _id;//buff数据表---()---
		private int[] _onlyAssetsPath;//唯一资源路径---()---

		#endregion---声明变量----------------------------------------------




		#region------属性--------------------------------------------------
		/// <summary>
		///id== buff数据表 
		///<para></para>
		/// </summary>
		public int id{
			get {
				return _id;
			}
		}
		/// <summary>
		///onlyAssetsPath== 唯一资源路径 
		///<para></para>
		/// </summary>
		public int[] onlyAssetsPath{
			get {
				return _onlyAssetsPath;
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
                    //UnityEngine.Debug.LogFormat(" Cfg_Npc_消息长度不在__{0}", sss0[i]);
                    continue;
                }
                try {
                    Cfg_Npc nn = new Cfg_Npc();
					nn._id = (int)C_Tool.S_GetValue("int",sss[0]);
					nn._onlyAssetsPath = (int[])C_Tool.S_GetValue("int[]",sss[1]);
					dataDic[nn._id] = nn;
				} catch (Exception ex) {
					UnityEngine.Debug.LogErrorFormat("Cfg_Npc=buff数据表_读取数据解析出错__目标长度={0}__当前长度 ={1}____{2}\n__{3}\n__{4}", 2, sss.Length-1, sss0[i],ex.Message, ex.StackTrace);
				}
			}
		}
		public Cfg_Npc(){}
		public Cfg_Npc(int id,int[] onlyAssetsPath) {
			this._id = id;
			this._onlyAssetsPath = onlyAssetsPath;
			dataDic[id] = this;
		}




		#region------任意字符串字段查询-----------------------------------------------
		#endregion----任意字符串字段查询-----------------------------------------------




		static Dictionary<int, Cfg_Npc> dataDic = new Dictionary<int, Cfg_Npc>();
		public static Dictionary<int, Cfg_Npc> GetDictionary() {
            if (dataDic.Count>0) {
                return dataDic;
            } else {
				new Cfg_Npc(0,new int[]{-1,14,121,0});
				new Cfg_Npc(1,new int[]{-1,14,122,0});
				new Cfg_Npc(2,new int[]{-1,14,123,0});
				new Cfg_Npc(3,new int[]{-1,14,124,0});
				new Cfg_Npc(4,new int[]{-1,14,125,0});
				new Cfg_Npc(5,new int[]{-1,14,126,0});
				new Cfg_Npc(6,new int[]{-1,14,127,0});
				new Cfg_Npc(7,new int[]{-1,14,128,0});
				return dataDic;
			}
		}

        public static Cfg_Npc GetConfig(int id) {
            if (GetDictionary().ContainsKey(id)) {
               return GetDictionary()[id];
            } else {
                return null;
            }
        }
	}

	/// <summary>
	///怪物属性表    
	///<para></para>
 	/// </summary>
	[Serializable]
	public partial class Cfg_Scene:I_CfgBase{


		#region------声明变量------------------------------------------------
		private int _id;//怪物属性表---()---
		private string _constant3;//常量---()---
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
		///constant3== 常量 
		///<para></para>
		/// </summary>
		public string constant3{
			get {
				return _constant3;
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
                    //UnityEngine.Debug.LogFormat(" Cfg_Scene_消息长度不在__{0}", sss0[i]);
                    continue;
                }
                try {
                    Cfg_Scene nn = new Cfg_Scene();
					nn._id = (int)C_Tool.S_GetValue("int",sss[0]);
					nn._constant3 = (string)C_Tool.S_GetValue("string",sss[1]);
					nn._name = (string)C_Tool.S_GetValue("string",sss[2]);
					nn._onlyAssetPath = (int[])C_Tool.S_GetValue("int[]",sss[3]);
					dataDic[nn._id] = nn;
				} catch (Exception ex) {
					UnityEngine.Debug.LogErrorFormat("Cfg_Scene=怪物属性表_读取数据解析出错__目标长度={0}__当前长度 ={1}____{2}\n__{3}\n__{4}", 4, sss.Length-1, sss0[i],ex.Message, ex.StackTrace);
				}
			}
		}
		public Cfg_Scene(){}
		public Cfg_Scene(int id,string constant3,string name,int[] onlyAssetPath) {
			this._id = id;
			this._constant3 = constant3;
			this._name = name;
			this._onlyAssetPath = onlyAssetPath;
			dataDic[id] = this;
		}




		#region------任意字符串字段查询-----------------------------------------------
        static Dictionary<string, List<Cfg_Scene>> _constant3Dic = new Dictionary<string, List<Cfg_Scene>>();
        public static List<Cfg_Scene> Get_constant3List(string key) {
            if (_constant3Dic.Count == 0) {
                var dic = GetDictionary().GetEnumerator();
                while (dic.MoveNext()) {
                    string[] sss = new string[]{dic.Current.Value._constant3};
                    for (int i = 0; i < sss.Length; i++) {
                        string key0 = sss[i].Trim();
                        if (_constant3Dic.ContainsKey(key0) == false) {
                            _constant3Dic[key0] = new List<Cfg_Scene>();
                        }
                        _constant3Dic[key0].Add(dic.Current.Value);
                    }
                }
            }
            if (_constant3Dic.ContainsKey(key)) {
                return _constant3Dic[key];
            } else {
                return null;
            }
        }

        static Dictionary<string, List<Cfg_Scene>> _nameDic = new Dictionary<string, List<Cfg_Scene>>();
        public static List<Cfg_Scene> Get_nameList(string key) {
            if (_nameDic.Count == 0) {
                var dic = GetDictionary().GetEnumerator();
                while (dic.MoveNext()) {
                    string[] sss = new string[]{dic.Current.Value._name};
                    for (int i = 0; i < sss.Length; i++) {
                        string key0 = sss[i].Trim();
                        if (_nameDic.ContainsKey(key0) == false) {
                            _nameDic[key0] = new List<Cfg_Scene>();
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




		static Dictionary<int, Cfg_Scene> dataDic = new Dictionary<int, Cfg_Scene>();
		public static Dictionary<int, Cfg_Scene> GetDictionary() {
            if (dataDic.Count>0) {
                return dataDic;
            } else {
				new Cfg_Scene(1,"z月亮星空","月亮星空",new int[]{-1,25,1,0});
				new Cfg_Scene(2,"z月亮星空","月亮星空",new int[]{-1,25,1,0});
				new Cfg_Scene(3,"z月亮星空","月亮星空",new int[]{-1,25,1,0});
				new Cfg_Scene(4,"z月亮星空","月亮星空",new int[]{-1,25,1,0});
				new Cfg_Scene(5,"z月亮星空","月亮星空",new int[]{-1,25,1,0});
				new Cfg_Scene(6,"z月亮星空","月亮星空",new int[]{-1,25,1,0});
				new Cfg_Scene(7,"z月亮星空","月亮星空",new int[]{-1,25,1,0});
				new Cfg_Scene(8,"z月亮星空","月亮星空",new int[]{-1,25,1,0});
				new Cfg_Scene(9,"z月亮星空","月亮星空",new int[]{-1,25,1,0});
				new Cfg_Scene(10,"z月亮星空","月亮星空",new int[]{-1,25,1,0});
				new Cfg_Scene(11,"z月亮星空","月亮星空",new int[]{-1,25,1,0});
				new Cfg_Scene(12,"z月亮星空","月亮星空",new int[]{-1,25,1,0});
				new Cfg_Scene(13,"z月亮星空","月亮星空",new int[]{-1,25,1,0});
				new Cfg_Scene(14,"z月亮星空","月亮星空",new int[]{-1,25,1,0});
				new Cfg_Scene(15,"z月亮星空","月亮星空",new int[]{-1,25,1,0});
				new Cfg_Scene(16,"z月亮星空","月亮星空",new int[]{-1,25,1,0});
				return dataDic;
			}
		}

        public static Cfg_Scene GetConfig(int id) {
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