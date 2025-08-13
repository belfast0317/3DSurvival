using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICondition : MonoBehaviour
{
    public Condition health;
    public Condition stamina;

    // Start is called before the first frame update
    void Start()
    {
      CharacterManager.Instance.Player.condition.uICondition = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
