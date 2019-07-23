using CC_Util;
namespace CopySmallGame.G01.Data {
    public class C_PlayerData  {
        /// <summary>
        /// 当前使用的场景Id
        /// </summary>
        public LongData currentUseSceneCfgId = new LongData("currentUseSceneCfgId", 1);
        /// <summary>
        /// 当前使用的角色Id
        /// </summary>
        public LongData currentUseRoleCfgId = new LongData("currentUseRoleCfgId", 1);
        /// <summary>
        /// 玩家等级--当前关卡
        /// </summary>
        public LongData playerGrade = new LongData("playerGrade", 1);

        /// <summary>
        /// 金币
        /// </summary>
        public LongData goldCoin = new LongData("goldCoin",100);
        public void S_Init() {

        }
        public void S_GameReset() {

        }

        public void S_GameStart() {

        }
        public void S_GameEnd() {

        }
    }
}