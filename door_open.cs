using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class door_open : MonoBehaviour
{
    
    bool isOpen;
    public Transform doorMove;
    [SerializeField] float doorSecond;
    public Vector3 doorVec;
    public Vector3 doorVec2;
    void Start()
    {
        //zDoor=this.gameObject.transform.rotation.z;
        isOpen=false;
        
        
    }
    void FixedUpdate() 
    {
        Vector3 doorVec = new Vector3(0,0,Mathf.Clamp(0,0,-90));
        Vector3 doorVec2 = new Vector3(0,0,Mathf.Clamp(0,0,90));
    }                           
    
    public void Door_open_and_closed()
    {   
        
        if (isOpen==false)
        {
            
            doorMove.DOLocalRotate(doorVec,doorSecond,RotateMode.LocalAxisAdd);
            
            isOpen=true;
        }

        else if (isOpen==true)
        {
            doorMove.DOLocalRotate(doorVec2,doorSecond,RotateMode.LocalAxisAdd);
            
            isOpen=false;
        }

       
    }

     public IEnumerator DoorWait()
    
    {
        yield return new WaitForSeconds(2f);
    }
}
