using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Animator myAnim;
    List<Rigidbody> ragdollRigids;

    void Start()
    {
        myAnim = GetComponent<Animator>();
        ragdollRigids = new List<Rigidbody>(transform.GetComponentsInChildren<Rigidbody>());
        ragdollRigids.Remove(GetComponent<Rigidbody>());
        DeactivateRagdoll();


    }

    void Update()
    {

    }

    void ActivateRagdoll()
    {
        myAnim.enabled = false;
        for (int i = 0; i < ragdollRigids.Count; i++)
        {
            ragdollRigids[i].useGravity = true;
            ragdollRigids[i].isKinematic = false;
        }
    }

    void DeactivateRagdoll() //Desativa o Ragdoll para o player não cair
    {
        myAnim.enabled = true;
        for (int i = 0; i < ragdollRigids.Count; i++)
        {
            ragdollRigids[i].useGravity = false;
            ragdollRigids[i].isKinematic = true;
        }
    }

    public void GetKilled()
    {
        ActivateRagdoll();
    }


}
