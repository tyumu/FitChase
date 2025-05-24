using UnityEngine;

public class hpReduce : MonoBehaviour
{
    private int hp = 100;

    void OnTriggerEnter(Collider col){
        if(col.gameObject.tag == "playerAttack"){
            hp -= 10; 
            hp = Mathf.Max(hp, 0); // 0未満にならないように制限
            Debug.Log("プレイヤーの攻撃、10のダメージ。残りHP: " + hp);
            CarDataManager.Instance.SetHP(gameObject.name, hp);
        }
    }

    void Update()
    {
        // 必要に応じてHPが0になったときの処理などを追加
    }
}