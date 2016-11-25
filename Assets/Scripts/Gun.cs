using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour 
{
    public Camera camera;
    public GameObject particlePrefab;
    ParticleSystem ps;
	// Use this for initialization
	void Start () 
	{
        ps = particlePrefab.GetComponent<ParticleSystem>();
	}
	
	// Update is called once per frame
	void Update () 
	{
        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
 //           Ray ray = new Ray(camera.transform.position, camera.transform.forward);
            if (Physics.Raycast(ray, out hit)) {
                Transform objectHit = hit.transform;
                Debug.Log("hit name : " + hit.transform.name);
                //GameObject effect = Instantiate(particlePrefab);
                particlePrefab.transform.position = hit.point;

                if (objectHit.transform.tag.Contains("Drone"))
                {
                    Destroy(objectHit.gameObject);
                }
                else
                {
                    ps.Stop();
                    ps.Play();
                }





            }
        }
	}

}
