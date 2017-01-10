using UnityEngine;
using System.Collections;

public class MaterialController : MonoBehaviour {

    [SerializeField]
    private Material _Idle;

    [SerializeField]
    private Material _OnPress;


    // Use this for initialization
    void Start () {
        setMaterial(_Idle);
	}
	
    private void setMaterial(Material m) {
        GetComponent<Renderer>().material = m;
    }

	// Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) {
            setMaterial(_OnPress);
        }
        else if (Input.GetKeyUp(KeyCode.Space)) {
            setMaterial(_Idle);
        }
    }
}
