using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private GameObject projectile;
    [SerializeField] private Transform gunTransform;
    public void Fire()
    {
        Instantiate(projectile,gunTransform.position,quaternion.identity);
    }
}
