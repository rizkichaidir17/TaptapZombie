using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zombie : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] int takeDamage;
    int Maxhealth;
    [SerializeField] int health;
    [SerializeField] AudioClip zombieDead;
    [SerializeField] AudioClip mechinGun;
    [SerializeField] Image healthBar;




    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += Vector3.down * speed * Time.deltaTime;
        
    }

    private void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
        {
            health -= takeDamage;
            healthBar.fillAmount -= takeDamage;
            Mati();
            
            AudioManager.ins.PlayGunSFX(mechinGun);

        }
    }

    public void Mati()
    {
        if(health <= 0 )
        {
            AddScore(1);
            AudioManager.ins.PlaySFX(zombieDead);
            Destroy(gameObject);
        }
    }

    public void AddScore(int points)
    {
        UIHandler.Ins.UpdateScore();
    }


}
