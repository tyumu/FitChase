using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private Animator anim;
    private SphereCollider attackCollider;
    private float attackTime = 0.0f;
    void Start()
    {
        anim = GetComponent<Animator>();
        attackCollider = GetComponent<SphereCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        if(x != 0 || z != 0){
            anim.SetBool("IsRun", true);
            transform.position += new Vector3(x, 0, z) * Time.deltaTime* 5.0f;
        }else{
            anim.SetBool("IsRun", false);
        }

        if(Input.GetKeyDown(KeyCode.Space)){
            anim.SetTrigger("DoAttack");
        }
        var stateInfo = anim.GetCurrentAnimatorStateInfo(0);
        if(stateInfo.IsName("Attack") && stateInfo.normalizedTime >= 0.6){
            attackCollider.enabled = true;
        }
        if(attackCollider.enabled){
            attackTime += Time.deltaTime;
            if(attackTime >= 0.5f){
                attackCollider.enabled = false;
                attackTime = 0.0f;
            }
        }
    }
}