using UnityEngine;
using UnityEngine.TextCore;

public class gunController : MonoBehaviour
{

    public static float damage = 10f;
    public float range = 100f;
    public static float Ammo = 25f;
    public float aimspeed = 10f;


    public Transform ammobar;
    

    public Camera fpsCam;

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButtonDown("Fire1") && Ammo >= 1)
        {
            Shoot();
            ammobar.GetComponent<UnityEngine.UI.Text>().text = Ammo.ToString();
        }if (Ammo == 0) {
            Debug.Log("Out of ammo.");
        }

        
    }
    void Shoot()
    {
        Ammo = Ammo - 1;
        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            enemy enemy = hit.transform.GetComponent<enemy>();
            if(enemy != null)
            {
                enemy.TakeDamage(damage);
            }
        }
    }
}
