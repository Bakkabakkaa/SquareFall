using System;
using UnityEngine;

public class SquareDestructionTrigger : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D collider)
   {
      Destroy(collider.gameObject);
   }
}
