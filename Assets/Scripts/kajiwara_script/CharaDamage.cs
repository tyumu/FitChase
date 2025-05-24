using UnityEngine;

public class hpReduce : MonoBehaviour
{
    private int hp = 100;

    void OnTriggerEnter(Collider col){
        if(col.gameObject.tag == "playerAttack"){
            hp -= 10; 
            Debug.Log("プレイヤーの攻撃、10のダメージ。残りHP: " + hp);
        }
    }

    void Update()
    {
        // 必要に応じてHPが0になったときの処理などを追加
    }
}