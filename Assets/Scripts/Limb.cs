using UnityEngine;

public class Limb : MonoBehaviour
{
    Enemy enemyScript;

    [SerializeField] Limb[] childLimbs;
    [SerializeField] GameObject limbPrefab;
    [SerializeField] GameObject woundHole;
    [SerializeField] GameObject bloodPrefab;

    void Start()
    {
        enemyScript = transform.root.GetComponent<Enemy>();



        if (woundHole != null)
        {
            woundHole.SetActive(false);
        }
    }


    void Update()
    {

    }

    public void Gethit()// Deleta o Membro, Função Core
    {
        if (childLimbs.Length > 0)
        {
            foreach (Limb limb in childLimbs)
            {
                if (limb != null)
                {
                    limb.Gethit();
                }
            }
        }

        if (woundHole != null)
        {
            woundHole.SetActive(true);
            if (bloodPrefab != null)
            {
                Instantiate(bloodPrefab, woundHole.transform.position, woundHole.transform.rotation);
            }
        }
        // Se existir membro, ele é instanciado, ou seja, aparece normalmente na tela.
        if (limbPrefab != null)
        {
            Instantiate(limbPrefab, transform.position, transform.rotation);
        }

        // Reduz o membro a escala 0, desaparecendo e destruindo-o após
        transform.localScale = Vector3.zero;

        enemyScript.GetKilled();

        Destroy(this);
    }





}//-----------------------
