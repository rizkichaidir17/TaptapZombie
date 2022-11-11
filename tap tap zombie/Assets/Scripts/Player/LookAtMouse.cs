using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtMouse : MonoBehaviour
{
    //[SerializeField] AudioClip mechinGun;

    // Update is called once per frame
    void Update()
    {
        Vector3 targetDir = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = (Mathf.Atan2(targetDir.x, targetDir.y) * Mathf.Rad2Deg) - 90f;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward * -1f);
    }
   /* private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            AudioManager.ins.PlaySFX(mechinGun);
            
        }
    }*/
}
