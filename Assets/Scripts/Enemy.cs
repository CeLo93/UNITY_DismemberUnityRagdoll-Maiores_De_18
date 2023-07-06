using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Animator myAnim; // Componente Animator para controlar a animação do inimigo
    List<Rigidbody> ragdollRigids; // Lista de componentes Rigidbody para controlar o ragdoll do inimigo

    void Start()
    {
        myAnim = GetComponent<Animator>(); // Obtém o componente Animator anexado a este objeto
        ragdollRigids = new List<Rigidbody>(transform.GetComponentsInChildren<Rigidbody>()); // Obtém todos os componentes Rigidbody nos objetos filhos deste objeto e cria uma lista com eles
        ragdollRigids.Remove(GetComponent<Rigidbody>()); // Remove o componente Rigidbody deste objeto da lista
        DeactivateRagdoll(); // Desativa o ragdoll do inimigo
    }

    void Update()
    {
        // Nenhuma ação é executada aqui neste momento
    }

    void ActivateRagdoll()
    {
        myAnim.enabled = false; // Desativa o componente Animator para parar a animação controlada por ele
        for (int i = 0; i < ragdollRigids.Count; i++)
        {
            ragdollRigids[i].useGravity = true; // Ativa a gravidade para os componentes Rigidbody da lista
            ragdollRigids[i].isKinematic = false; // Desativa o estado cinemático para os componentes Rigidbody da lista
        }
    }

    void DeactivateRagdoll()
    {
        myAnim.enabled = true; // Ativa novamente o componente Animator para retomar a animação controlada por ele
        for (int i = 0; i < ragdollRigids.Count; i++)
        {
            ragdollRigids[i].useGravity = false; // Desativa a gravidade para os componentes Rigidbody da lista
            ragdollRigids[i].isKinematic = true; // Ativa o estado cinemático para os componentes Rigidbody da lista
        }
    }

    public void GetKilled()
    {
        ActivateRagdoll(); // Ativa o ragdoll do inimigo quando ele é morto
    }
}
