using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    [SerializeField] int hp;
    [SerializeField] GameObject healthPrefab;
    public Transform healthSpawn;
    public List<GameObject> gb = new List<GameObject>();

    public GameObject gameOverPanel;

    Zombie zombie;

        private void Awake()
    {
        //zombie = GameObject.FindGameObjectWithTag("Zombie").GetComponent<Zombie>();
    }

    // Start is called before the first frame update
    void Start()
    {
        //health.Length = hp;
        for (int i = 0; i < hp; i++)
        {
            gb.Add(Instantiate(healthPrefab, healthSpawn));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Zombie")
        {
            Destroy(other.gameObject);
            hp -= 1;

            Destroy(gb[hp]);
            //gb.RemoveAt(hp);
            
            GameOver();
        }
    }

    void GameOver()
    {
        if(hp <= 0)
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }
    }

}
