using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class metoroids : MonoBehaviour
{
    Rigidbody2D rigid;
    public float Speed;

    GameObject targetSpawn;
    METSpawning metSpawning;

    Scored scored;
    public int score;

    Animator animator;

    bool go = true;

    // Start is called before the first frame update
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody2D>();
        metSpawning = GameObject.Find("MeteoroidsSpawnpoint").GetComponent<METSpawning>();
        rigid.angularVelocity = Random.Range(-150f, 150f);
        scored = GameObject.Find("ScoreManager").GetComponent<Scored>();
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        /*targetSpawn = metSpawning.chosenSpawn == metSpawning.Spawn00 ? metSpawning.Spawn04
            : metSpawning.chosenSpawn == metSpawning.Spawn01 ? metSpawning.Spawn05
            : metSpawning.chosenSpawn == metSpawning.Spawn02 ? metSpawning.Spawn06
            : metSpawning.chosenSpawn == metSpawning.Spawn03 ? metSpawning.Spawn07
            : metSpawning.chosenSpawn == metSpawning.Spawn04 ? metSpawning.Spawn00
            : metSpawning.chosenSpawn == metSpawning.Spawn05 ? metSpawning.Spawn01
            : metSpawning.chosenSpawn == metSpawning.Spawn06 ? metSpawning.Spawn02
            : metSpawning.Spawn03;*/

        //rigid.AddForce((targetSpawn.transform.position - transform.position) * Speed * Time.deltaTime, ForceMode2D.Impulse);
        if (go)
        {
            transform.position = Vector3.MoveTowards(transform.position, Vector3.zero, Speed * Time.deltaTime);
        }
        
        Object.Destroy(gameObject, 10f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            rigid.angularVelocity = 0;
            //rigid.velocity = Vector3.zero;
            go = false;
            scored.METDestroyed(score);
            animator.SetTrigger("hit");
            collision.gameObject.SetActive(false);
            Object.Destroy(gameObject, 0.4f);
        }
    }
}
