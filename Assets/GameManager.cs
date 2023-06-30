using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance = null;
    public static GameManager Instance{
        get{
            if(instance == null){
                return null;
            }
            return instance;
        }
    }
    public Player player;
    
    private void Awake() {
        if(instance == null) {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }else {
            Destroy(this.gameObject);
        }
    }
}
