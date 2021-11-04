using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CouldrenInteraction : MonoBehaviour
{
    public bool includeChildren = true;

    public ParticleSystem particle;
    public GameObject Potion_Health;
    public GameObject Grenade_Sulfur;
    public GameObject Poison_Potion;
    public GameObject Mana_Potion;
    private Vector3 position;
 
    private int health = 0;
    private int grenade = 0;
    private int poison = 0;
    private int mana = 0;
    private int bottle = 0;
    


    void OnCollisionEnter(Collision otherObj)
    {
        position = this.transform.position + new Vector3 (0f,1f,0f);

        if (otherObj.gameObject.name.Contains("Redpowder"))
        {
            particle.Play(includeChildren);
            Destroy(otherObj.gameObject);
            health += 1;
        }

        if (otherObj.gameObject.name.Contains("Yellowpowder"))
        {
            particle.Play(includeChildren);
            Destroy(otherObj.gameObject,.5f);
            grenade += 1;
        }

        if (otherObj.gameObject.name.Contains("Greenpowder"))
        {
            particle.Play(includeChildren);
            Destroy(otherObj.gameObject,.5f);
            poison += 1;

        }

        if (otherObj.gameObject.name.Contains("Bluepowder"))
        {
            particle.Play(includeChildren);
            Destroy(otherObj.gameObject,.5f);
            mana += 1;
        }

        if (otherObj.gameObject.name.Contains("EmptyBottle"))
        {
            particle.Play(includeChildren);
            Destroy(otherObj.gameObject,.5f);
            bottle += 1;
        }


    }

    void Update()
    {
        if (bottle > 0)
        {
            if (health > 0)
            {
                Potion_Health.transform.position = position;
                Instantiate(Potion_Health);
                bottle -= 1;
                health -= 1;
                return;
            }

            if (grenade > 0)
            {
                Grenade_Sulfur.transform.position = position;
                Instantiate(Grenade_Sulfur);
                bottle -= 1;
                grenade -= 1;
                return;
            }

            if (poison > 0)
            {
                Poison_Potion.transform.position = position;
                Instantiate(Poison_Potion);
                bottle -= 1;
                poison -= 1;
                return;
            }

            if (mana > 0)
            {
                Mana_Potion.transform.position = position;
                Instantiate(Mana_Potion);
                bottle -= 1;
                mana -= 1;
                return;
            }
        }
    }
    
}
