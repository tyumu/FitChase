using System.Collections.Generic;
using UnityEngine;
public class CarDataManager : MonoBehaviour
{
    public static CarDataManager Instance;

    private Dictionary<string, int> carHpDict = new Dictionary<string, int>();

    void Awake(){
        if(Instance == null){
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
    }

    public void SetHP(string carName, int hp){
        carHpDict[carName] = hp;
    }

    public int GetHP(string carName){
        return carHpDict.ContainsKey(carName) ? carHpDict[carName] : -1;
    }
}
//使い方
//どのシーンのスクリプトからでも下記のように呼び出せる
// int hp = CarDataManager.Instance.GetHP("blueCar");
// Debug.Log("Car1のHPは: " + hp);
//車の名前はblueCar、blackCar、whiteCar、yellowCar
//スペルミスと大文字小文字に注意
//HPの初期値は100