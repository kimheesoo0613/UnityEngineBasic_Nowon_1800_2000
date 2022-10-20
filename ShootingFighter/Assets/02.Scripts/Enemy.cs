using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float _hp;
    // 프로퍼티 (Property)
    // C# 에서 필드의 캡슐화를 위한 문법
    // Getter, Setter 접근자를 제공해서 값을 읽거나 쓸 때 한번 래필할 수 있다.
    // 캡슐화 : 캡슐알약처럼 잘못된 값 접근을 막거나 접근시 특변한 연산을 수행하도록 만드는 작업
    public float Hp
    {
        get
        {
            return _hp;
        }
        set
        {
            if (value < 0)
                value = 0;

            _hp = value;

            if (_hp <= 0)
                Destroy(this.gameObject);
        }

    }
    [SerializeField] private float _hpMax = 100.0f;

    //==============================================================================
    // ****************************** public **************************************
    //==============================================================================

    public void Hurt (float damage)
    {
        Hp -= damage;
    }

    // public void SetHp(float value)
    // {
    //     if (value < 0)
    //         value = 0;
    //     Hp = value;
    // }

    private void Awake()
    {
        Hp = _hpMax;
    }
}
