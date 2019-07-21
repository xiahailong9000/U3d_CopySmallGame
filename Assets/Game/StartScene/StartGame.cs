using G01;
using UnityEngine;

public class StartGame : MonoBehaviour {
    public int gameIndex = 1;
    void Start() {
        //GameObject.DontDestroyOnLoad(gameObject);
        switch (gameIndex) {
            case 1:
                C_G01Game.S_Start();
                break;
            case 16:
          
                break;
        }
    }
}
